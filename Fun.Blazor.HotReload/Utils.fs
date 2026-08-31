// Client-side "apply a hot-reload code package" logic. Receives the serialized
// PortaCode changes from the watcher hub, evaluates them via the interpreter, and
// swaps in the new render function for each registered entry.
module Fun.Blazor.HotReload.Utils

open FSharp.Compiler.PortaCode.CodeModel
open FSharp.Compiler.PortaCode.Interpreter
open Fun.Blazor


type internal UpdateResponse = { Quacked: string }


let rec internal tryFindEntityByName name (decls: DDecl []) =
    decls
    |> Array.tryPick (
        function
        | DDeclEntity (entityDef, subDecls) ->
            if entityDef.Name = name then
                Some(entityDef, subDecls)
            else
                tryFindEntityByName name subDecls
        | _ -> None
    )


let rec internal tryFindMemberByName fullName (decls: DDecl []) =
    decls
    |> Array.tryPick (
        function
        | DDeclEntity (_, ds) -> tryFindMemberByName fullName ds
        | DDeclMember (membDef, body, _range) ->
            let (DEntityRef entityName) = membDef.Ref.Entity
            if entityName + "." + membDef.Name = fullName then Some(membDef, body) else None
        | _ -> None
    )


/// Cache one EvalContext per render entry so successive saves only add the
/// changed declarations (AddDecls is incremental) instead of re-emitting all
/// shell types and re-initializing the interpreter on every edit.
let internal evalContexts = System.Collections.Concurrent.ConcurrentDictionary<string, EvalContext>()

let internal getEvalContext (renderEntryName: string) =
    evalContexts.GetOrAdd(renderEntryName, fun _ ->
        EvalContext(System.Reflection.Assembly.GetEntryAssembly().GetName()))


/// Starts the HttpServer listening for changes
let internal reload<'T> renderEntryName (codeData: (string * DFile) []) (updateRenderFn: ('T -> NodeRenderFragment) -> unit) =
    let interp = getEvalContext renderEntryName

    let unsupport () =
        printfn "*** LiveUpdate failure:"
        printfn "***   [x] got code package"
        printfn "***   [x] found declaration called '%s'" renderEntryName
        printfn "***   [x] it had no parameters (good!)"
        printfn "***   FAIL: the declaration had the wrong type '%A'. it must be a single top-level value in a module." (p.GetType())
        Some { Quacked = "LiveUpdate couldn't quack! types mismatch!" }

    let success () = Some { Quacked = "LiveUpdate successful" }

    let reportDiagnostics (diags: DDiagnostic []) =
        if diags.Length > 0 then
            printfn "*** LiveUpdate: %d declaration(s) could not be interpreted and were skipped." diags.Length
            printfn "***   The last good render is kept. Move the reported code into a non hot-reload file."
            for d in diags do
                printfn "%O" d

    let switchD (files: (string * DFile) []) =
        lock
            interp
            (fun () ->
                let res =
                    try
                        for (_, file) in files do
                            printfn "LiveUpdate: adding declarations...."
                            interp.AddDecls file.Code

                        // Evaluate declarations optimistically: a member that cannot be
                        // interpreted (Limitation #1) is skipped and reported with its
                        // location instead of failing the whole update.
                        let diags =
                            [|
                                for (_, file) in files do
                                    printfn "LiveUpdate: evaluating decls in code package for side effects...."
                                    yield! interp.TryEvalDecls(envEmpty, file.Code)
                            |]
                        Result.Ok diags
                    with
                    | exn -> Result.Error exn

                match res with
                | Result.Error exn ->
                    // Registration itself failed (e.g. an entity could not be resolved). Keep the
                    // last good render and report the failure with whatever location info we have.
                    printfn "*** LiveUpdate failure:"
                    printfn "***   [x] got code package"
                    printfn "***   FAIL: the declarations could not be registered: %s" exn.Message
                    printfn "%O" (DiagnosticFromException exn)
                    {
                        Quacked = sprintf "couldn't quack! the declarations could not be registered: %s" exn.Message
                    }

                | Result.Ok diags ->
                    reportDiagnostics diags
                    match files.Length with
                    | 0 -> { Quacked = "couldn't quack! Files were empty!" }
                    | _ ->
                        let result =
                            files
                            |> Array.tryPick (fun (_, file) ->
                                let renderEntry = tryFindMemberByName renderEntryName file.Code

                                match renderEntry with
                                | None -> None
                                | Some (membDef, body) ->
                                    printfn $"LiveUpdate: evaluating '{renderEntryName}'...."

                                    if membDef.Parameters.Length > 0 then
                                        match interp.ResolveMethod membDef.Ref membDef.Range with
                                        | ResolvedMember.UMethod (_, method) ->
                                            match method.Value with
                                            | :? MethodLambdaValue as (MethodLambdaValue fn) ->
                                                try
                                                    updateRenderFn (fun x -> unbox (fn ([||], [| x |])))
                                                    success ()
                                                with
                                                | _ -> unsupport ()
                                            | _ -> unsupport ()
                                        | _ -> unsupport ()

                                    else
                                        // Evaluate the entry expression here so a failure is caught and
                                        // reported with its location instead of crashing the update.
                                        match interp.TryEvalExpr(envEmpty, body, membDef.Range) with
                                        | Result.Error err ->
                                            printfn "*** LiveUpdate failure evaluating '%s':" renderEntryName
                                            printfn "%O" (DiagnosticFromException err)
                                            Some { Quacked = $"couldn't quack! evaluating '{renderEntryName}' failed: {err.Message}" }
                                        | Result.Ok programObj ->
                                            match getVal programObj with
                                            | :? NodeRenderFragment as render ->
                                                updateRenderFn (fun _ -> render)
                                                success ()
                                            | :? MethodLambdaValue as (MethodLambdaValue fn) ->
                                                try
                                                    updateRenderFn (fun _ -> unbox (fn ([||], [||])))
                                                    success ()
                                                with
                                                | _ -> unsupport ()
                                            | p -> unsupport ()
                            )

                        match result with
                        | Some res -> res
                        | None ->
                            // The CLI sends the affected dependent path through the entry.
                            // Reaching here means the entry genuinely isn't defined in a
                            // hot-reload-enabled file.
                            printfn "*** LiveUpdate failure:"
                            printfn "***   [x] got code package"
                            printfn "***   FAIL: couldn't find declaration called '%s' in any hot-reload file." renderEntryName
                            printfn "***         Make sure the file that defines it has '// hot-reload' at the top."
                            {
                                Quacked = $"couldn't quack! No declaration called '{renderEntryName}'!"
                            }
            )

    let sw = System.Diagnostics.Stopwatch.StartNew()
    switchD codeData |> ignore
    printfn "Code applied %A ms" sw.ElapsedMilliseconds
