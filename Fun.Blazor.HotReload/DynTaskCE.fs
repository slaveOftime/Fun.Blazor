// Copyright 2018 Fabulous contributors. See LICENSE.md.
// Dynamic interpreter for the F# "task" computation expression.
//
// The compiled FSharp.Core task builder methods cannot always be invoked dynamically:
// for several awaiter shapes (for example the non-generic Task / TaskAwaiter bind used
// by "do! Task.Delay ...") they throw "Dynamic invocation of GetAwaiter is not supported".
// The hot reload interpreter replaces calls to those builder methods with the dynamic
// representation below, and drives them to completion with its own await machinery.
module FSharp.Compiler.PortaCode.DynTaskCE

open System
open System.Reflection
open System.Threading.Tasks
open Microsoft.FSharp.Reflection

type DynCode =
    | Done of obj
    | Bind of awaitable: obj * cont: obj
    | Defer of thunk: obj
    | Zero
    | Combine of first: DynCode * second: DynCode
    | TryWith of body: DynCode * handler: obj
    | TryFinally of body: DynCode * compensation: obj
    | Using of resource: obj * bodyFn: obj
    | WhileLoop of guard: obj * body: DynCode
    | ForLoop of source: obj * bodyFn: obj

type IdCont() =
    member _.Invoke(v: obj) : obj = DynCode.Done v

type UnitCont() =
    member _.Invoke(_v: obj) : obj = DynCode.Done null

let bindAll =
    BindingFlags.Public ||| BindingFlags.NonPublic ||| BindingFlags.Instance

let bindAllStatic =
    BindingFlags.Public ||| BindingFlags.NonPublic ||| BindingFlags.Static

/// Apply an interpreted (or compiled) one argument function value to an argument.
let apply1 (f: obj) (arg: obj) : obj =
    let t = f.GetType()
    let m =
        t.GetMethods(bindAll)
        |> Array.tryFind (fun m -> m.Name = "Invoke" && m.GetParameters().Length = 1)

    match m with
    | None -> failwithf "DynTaskCE: failed to find Invoke on function value of type %A" t
    | Some m -> m.Invoke(f, [| arg |])

/// Await an arbitrary task-like value and return its result (null for unit / non-generic results).
let rec awaitObj (o: obj) : Async<obj> =
    async {
        match o with
        | null -> return null
        | :? Task as t -> return! awaitTask t
        | v when v.GetType().IsGenericType && v.GetType().GetGenericTypeDefinition().FullName = "Microsoft.FSharp.Control.FSharpAsync`1" ->
            // let! / do! on an F# async workflow inside a task CE.
            // Call Async.StartAsTask<'T> via reflection to get a Task<'T> with the right 'T.
            let asyncTy = v.GetType()
            let resTy = asyncTy.GetGenericArguments().[0]
            let startAsTaskM =
                typeof<Async>.GetMethods(bindAllStatic)
                |> Array.find (fun m -> m.Name = "StartAsTask" && m.IsGenericMethodDefinition)
            let parameters = startAsTaskM.GetParameters()
            let invokeArgs =
                parameters |> Array.mapi (fun i p -> if i = 0 then v elif p.HasDefaultValue then p.DefaultValue else null)
            let t = startAsTaskM.MakeGenericMethod(resTy).Invoke(null, invokeArgs) :?> Task
            return! awaitTask t
        | v when
            v.GetType().FullName = "System.Runtime.CompilerServices.ValueTask"
            || v.GetType().FullName = "System.Runtime.CompilerServices.ValueTask`1"
            ->
            let asTaskM = v.GetType().GetMethod("AsTask", Type.EmptyTypes)
            let t = asTaskM.Invoke(v, [||]) :?> Task
            return! awaitTask t
        | a ->
            // General awaitable pattern: GetAwaiter / IsCompleted / OnCompleted / GetResult
            let ty = a.GetType()
            let getAwaiterM = ty.GetMethod("GetAwaiter", Type.EmptyTypes)

            if isNull getAwaiterM then
                return failwithf "DynTaskCE: value of type %A is not awaitable" ty
            else
                let awaiter = getAwaiterM.Invoke(a, [||])
                let awaiterTy = awaiter.GetType()
                let isCompletedProp = awaiterTy.GetProperty("IsCompleted")

                if isCompletedProp.GetValue(awaiter) :?> bool then
                    let getResultM = awaiterTy.GetMethod("GetResult", Type.EmptyTypes)
                    return getResultM.Invoke(awaiter, [||])
                else
                    let onCompletedM =
                        awaiterTy.GetMethod("UnsafeOnCompleted", [| typeof<Action> |])
                        |> function
                            | null -> awaiterTy.GetMethod("OnCompleted", [| typeof<Action> |])
                            | m -> m

                    if isNull onCompletedM then
                        return failwithf "DynTaskCE: awaiter of type %A does not implement OnCompleted" awaiterTy
                    else
                        let getResultM = awaiterTy.GetMethod("GetResult", Type.EmptyTypes)
                        return!
                            Async.FromContinuations(fun (cont, econt, _ccont) ->
                                let action =
                                    Action(fun () ->
                                        try
                                            cont (getResultM.Invoke(awaiter, [||]))
                                        with e ->
                                            econt e
                                    )

                                try
                                    onCompletedM.Invoke(awaiter, [| action |]) |> ignore
                                with e ->
                                    econt e
                            )
        }

/// Await a Task or Task<'T> and return its result (null for a non-generic Task).
and awaitTask (t: Task) : Async<obj> =
    async {
        if not t.IsCompleted then do! Async.AwaitTask t
        let ty = t.GetType()

        if ty.IsGenericType && ty.GetGenericTypeDefinition() = typedefof<Task<_>> then
            let resultProp = ty.GetProperty("Result")
            return resultProp.GetValue(t)
        else
            return null
    }

/// Drive a dynamic task computation to completion.
let rec run (code: DynCode) : Async<obj> =
    async {
        match code with
        | Done v -> return v
        | Zero -> return null
        | Defer thunk ->
            let res = apply1 thunk null
            match res with
            | :? DynCode as code -> return! run code
            | _ -> return failwithf "DynTaskCE: Defer thunk returned %A (expected DynCode)" (if isNull res then "<null>" else res.GetType().FullName)
        | Bind (awaitable, cont) ->
            let! v = awaitObj awaitable
            return! run (apply1 cont v :?> DynCode)
        | Combine (first, second) ->
            let! _ = run first
            return! run second
        | TryWith (body, handler) ->
            try
                return! run body
            with e ->
                return! run (apply1 handler e :?> DynCode)
        | TryFinally (body, compensation) ->
            try
                return! run body
            finally
                apply1 compensation null |> ignore
        | Using (resource, bodyFn) ->
            try
                return! run (apply1 bodyFn resource :?> DynCode)
            finally
                match resource with
                | :? IDisposable as d -> d.Dispose()
                | _ -> ()
        | WhileLoop (guard, body) ->
            let rec loop () =
                async {
                    if apply1 guard null :?> bool then
                        let! _ = run body
                        return! loop ()
                    else
                        return null
                }

            return! loop ()
        | ForLoop (source, bodyFn) ->
            let enum = (source :?> System.Collections.IEnumerable).GetEnumerator()
            let rec loop () =
                async {
                    if enum.MoveNext() then
                        let! _ = run (apply1 bodyFn enum.Current :?> DynCode)
                        return! loop ()
                    else
                        return null
                }

            try
                return! loop ()
            finally
                (enum :?> IDisposable).Dispose()
    }

/// Run a dynamic task computation as a typed Task<'T>.
let runAsTypedTask (code: DynCode) (resultTy: Type) : obj =
    let inner = Async.StartAsTask (run code)

    let tcsTy = typedefof<TaskCompletionSource<obj>>.MakeGenericType(resultTy)
    let tcs = Activator.CreateInstance(tcsTy)
    let setResultM = tcsTy.GetMethod("SetResult", [| resultTy |])
    let setExceptionM = tcsTy.GetMethod("SetException", [| typeof<Exception> |])
    let setCanceledM = tcsTy.GetMethod("SetCanceled", Type.EmptyTypes)
    let taskProp = tcsTy.GetProperty("Task")

    inner.ContinueWith(
        fun (prev: Task<obj>) ->
            if prev.IsFaulted then
                setExceptionM.Invoke(tcs, [| prev.Exception :> Exception |]) |> ignore
            elif prev.IsCanceled then
                setCanceledM.Invoke(tcs, [||]) |> ignore
            else
                let v = prev.Result
                setResultM.Invoke(tcs, [| v |]) |> ignore
    )
    |> ignore

    taskProp.GetValue(tcs)

/// Run two task-like values concurrently and produce a typed Task of their result tuple.
let runMergeSources (t1: obj) (t2: obj) (tupleTy: Type) : obj =
    let computation =
        async {
            let! a1 = Async.StartChildAsTask (awaitObj t1)
            let! a2 = Async.StartChildAsTask (awaitObj t2)
            let! v1 = Async.AwaitTask a1
            let! v2 = Async.AwaitTask a2
            return FSharpValue.MakeTuple([| v1; v2 |], tupleTy)
        }

    let inner = Async.StartAsTask computation

    let tcsTy = typedefof<TaskCompletionSource<obj>>.MakeGenericType(tupleTy)
    let tcs = Activator.CreateInstance(tcsTy)
    let setResultM = tcsTy.GetMethod("SetResult", [| tupleTy |])
    let setExceptionM = tcsTy.GetMethod("SetException", [| typeof<Exception> |])
    let setCanceledM = tcsTy.GetMethod("SetCanceled", Type.EmptyTypes)
    let taskProp = tcsTy.GetProperty("Task")

    inner.ContinueWith(
        fun (prev: Task<obj>) ->
            if prev.IsFaulted then
                setExceptionM.Invoke(tcs, [| prev.Exception :> Exception |]) |> ignore
            elif prev.IsCanceled then
                setCanceledM.Invoke(tcs, [||]) |> ignore
            else
                setResultM.Invoke(tcs, [| prev.Result |]) |> ignore
    )
    |> ignore

    taskProp.GetValue(tcs)

let private taskBuilderTypeNames =
    Set.ofList [
        "Microsoft.FSharp.Control.TaskBuilder"
        "Microsoft.FSharp.Control.TaskBuilderBase"
        "Microsoft.FSharp.Control.BackgroundTaskBuilder"
    ]

let private taskBuilderExtensionNames =
    Set.ofList [
        "Microsoft.FSharp.Control.TaskBuilderExtensions.LowPriority"
        "Microsoft.FSharp.Control.TaskBuilderExtensions.MediumPriority"
        "Microsoft.FSharp.Control.TaskBuilderExtensions.HighPriority"
        "Microsoft.FSharp.Control.TaskBuilderExtensions.LowPlusPriority"
    ]

/// Check if a resolved method is one of the FSharp.Core task CE builder methods
/// that cannot be invoked dynamically and needs to be replaced by our dynamic implementation.
let isTaskBuilderMethod (minfo: MethodInfo) : bool =
    let declaringTy = minfo.DeclaringType

    if isNull declaringTy then
        false
    else
        let fullName = declaringTy.FullName

        if taskBuilderTypeNames.Contains fullName then
            not minfo.IsStatic
        elif taskBuilderExtensionNames.Contains fullName then
            minfo.IsStatic
        else
            false

/// Try to run a resolved task builder method dynamically.
/// Returns None when the method is not a task CE builder method.
/// objOptV is the instance for instance calls, argsV are the evaluated arguments
/// (which for extension members include the builder as the first argument).
let tryInterceptTaskBuilderMethod (minfo: MethodInfo) (objOptV: obj) (argsV: obj []) : obj option =
    if not (isTaskBuilderMethod minfo) then
        None
    else
        let name = minfo.Name
        // FSharp.Core compiles task CE extension members with dotted names like "TaskBuilderBase.Bind"
        let name = if name.Contains "." then name.Substring(name.IndexOf '.' + 1) else name

        // For instance builder methods the builder is the instance, for extension
        // methods (static) it is the first argument.
        let isExtension = minfo.IsStatic
        let args = if isExtension then argsV else Array.append [| objOptV |] argsV

        let dynCodeOfArg (v: obj) =
            match v with
            | :? DynCode as code -> code
            | _ -> failwithf "DynTaskCE: expected a dynamic task computation but got %A" (v.GetType())

        match name, isExtension, args with
        // TaskBuilder.Run (instance, on TaskBuilder / BackgroundTaskBuilder)
        | "Run", false, [| _builder; code |] ->
            let code = dynCodeOfArg code
            let taskTy = minfo.ReturnType
            let resultTy = taskTy.GetGenericArguments().[0]
            Some(runAsTypedTask code resultTy)

        // TaskBuilderBase.Delay (instance)
        | "Delay", false, [| _builder; thunk |] -> Some(box (Defer thunk))

        // TaskBuilderBase.Zero (instance)
        | "Zero", false, [| _builder |] -> Some(box Zero)

        // TaskBuilderBase.Return (instance)
        | "Return", false, [| _builder; value |] -> Some(box (Done value))

        // TaskBuilderBase.Combine (instance)
        | "Combine", false, [| _builder; first; second |] ->
            Some(box (Combine(dynCodeOfArg first, dynCodeOfArg second)))

        // TaskBuilderBase.While (instance)
        | "While", false, [| _builder; guard; body |] -> Some(box (WhileLoop(guard, dynCodeOfArg body)))

        // TaskBuilderBase.For (instance)
        | "For", false, [| _builder; source; bodyFn |] -> Some(box (ForLoop(source, bodyFn)))

        // TaskBuilderBase.TryWith (instance)
        | "TryWith", false, [| _builder; body; handler |] -> Some(box (TryWith(dynCodeOfArg body, handler)))

        // TaskBuilderBase.TryFinally (instance)
        | "TryFinally", false, [| _builder; body; compensation |] ->
            Some(box (TryFinally(dynCodeOfArg body, compensation)))

        // Extensions (static, builder as args.[0])
        | "Bind", true, [| _builder; awaitable; cont |] -> Some(box (Bind(awaitable, cont)))

        | "ReturnFrom", true, [| _builder; task |] -> Some(box (Bind(task, IdCont())))

        | "Using", true, [| _builder; resource; bodyFn |] -> Some(box (Using(resource, bodyFn)))

        | "MergeSources", true, [| _builder; t1; t2 |] ->
            let tupleTy = minfo.ReturnType
            Some(runMergeSources t1 t2 tupleTy)

        | _ -> None
