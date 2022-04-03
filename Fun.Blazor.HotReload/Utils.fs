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


/// Starts the HttpServer listening for changes
let internal reload<'T> renderEntryName (codeData: (string * DFile) []) (updateRenderFn: ('T -> NodeRenderFragment) -> unit) =
    let interp = EvalContext(System.Reflection.Assembly.GetEntryAssembly().GetName())

    let unsupport () =
        printfn "*** LiveUpdate failure:"
        printfn "***   [x] got code package"
        printfn "***   [x] found declaration called '%s'" renderEntryName
        printfn "***   [x] it had no parameters (good!)"
        printfn "***   FAIL: the declaration had the wrong type '%A'. it must be a single top-level value in a module." (p.GetType())
        Some { Quacked = "LiveUpdate couldn't quack! types mismatch!" }

    let success () = Some { Quacked = "LiveUpdate successful" }

    let switchD (files: (string * DFile) []) =
        lock
            interp
            (fun () ->
                let res =
                    try
                        for (_, file) in files do
                            printfn "LiveUpdate: adding declarations...."
                            interp.AddDecls file.Code

                        for (_, file) in files do
                            printfn "LiveUpdate: evaluating decls in code package for side effects...."
                            interp.EvalDecls(envEmpty, file.Code)
                        Result.Ok()
                    with
                    | exn -> Result.Error exn

                match res with
                | Result.Error exn ->
                    printfn "*** LiveUpdate failure:"
                    printfn "***   [x] got code package"
                    printfn "***   FAIL: the evaluation of the declarations in the code package failed: %A" exn
                    {
                        Quacked = sprintf "couldn't quack! the evaluation of the declarations in the code package failed: %A" exn
                    }

                | Result.Ok () ->
                    match files.Length with
                    | 0 -> { Quacked = "couldn't quack! Files were empty!" }
                    | _ ->
                        let result =
                            files
                            |> Array.tryPick (fun (_, file) ->
                                let renderEntry = tryFindMemberByName renderEntryName file.Code

                                match renderEntry with
                                | None -> None
                                | Some (membDef, _) ->
                                    printfn $"LiveUpdate: evaluating '{renderEntryName}'...."

                                    if membDef.Parameters.Length > 0 then
                                        printfn $"LiveUpdate: evaluating '{renderEntryName}'...."
                                        let method = interp.ResolveMethod membDef.Ref membDef.Range
                                        match method with
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
                                        let entity = interp.ResolveEntity(membDef.EnclosingEntity)
                                        let _, programObj = interp.GetExprDeclResult(entity, membDef.Name)
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
                        | None ->
                            printfn "*** LiveUpdate failure:"
                            printfn "***   [x] got code package"
                            printfn "***   FAIL: couldn't find declaration called '%s'" renderEntryName
                            {
                                Quacked = $"couldn't quack! No declaration called '{renderEntryName}'!"
                            }
                        | Some res -> res
            )

    let sw = System.Diagnostics.Stopwatch.StartNew()
    switchD codeData |> ignore
    printfn "Code applied %A ms" sw.ElapsedMilliseconds
