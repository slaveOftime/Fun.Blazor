namespace Fun.Blazor

open FSharp.Compiler.PortaCode.CodeModel
open FSharp.Compiler.PortaCode.Interpreter
open Microsoft.AspNetCore.Components
open Fun.Blazor


type private UpdateResponse = { Quacked: string }


/// Program module - functions to manipulate program instances
module private Extensions =

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
    let reload renderEntryName (codeData: string) (updateRenderFn: NodeRenderFragment -> unit) =
        let interp = EvalContext(System.Reflection.Assembly.GetEntryAssembly().GetName())

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
                                        if membDef.Parameters.Length > 0 then
                                            printfn "*** LiveUpdate failure:"
                                            printfn "***   [x] got code package"
                                            printfn "***   [x] found declaration called 'programLiveUpdate' or 'program'"
                                            printfn "***   FAIL: the declaration has parameters, it must be a single top-level value"
                                            Some
                                                {
                                                    Quacked =
                                                        "couldn't quack! Found declaration called 'program' or 'programLiveUpdate' but the declaration has parameters!"
                                                }

                                        else

                                            printfn $"LiveUpdate: evaluating '{renderEntryName}'...."
                                            let entity = interp.ResolveEntity(membDef.EnclosingEntity)
                                            let (_, programObj) = interp.GetExprDeclResult(entity, membDef.Name)
                                            match getVal programObj with

                                            | :? NodeRenderFragment as render ->
                                                updateRenderFn render
                                                Some { Quacked = "LiveUpdate successful" }

                                            | p ->
                                                printfn "*** LiveUpdate failure:"
                                                printfn "***   [x] got code package"
                                                printfn "***   [x] found declaration called 'programLiveUpdate' or 'program'"
                                                printfn "***   [x] it had no parameters (good!)"
                                                printfn
                                                    "***   FAIL: the declaration had the wrong type '%A', expected 'Program<Arg, Model, Msg>'"
                                                    (p.GetType())
                                                Some { Quacked = "LiveUpdate couldn't quack! types mismatch!" }
                                )
                            match result with
                            | None ->
                                printfn "*** LiveUpdate failure:"
                                printfn "***   [x] got code package"
                                printfn "***   FAIL: couldn't find declaration called 'program' or 'programLiveUpdate'"
                                {
                                    Quacked = "couldn't quack! No declaration called 'program' or 'programLiveUpdate'!"
                                }
                            | Some res -> res
                )

        let options = Newtonsoft.Json.JsonSerializerSettings()
        options.MaxDepth <- 1000
        let req =
            Newtonsoft.Json.JsonConvert.DeserializeObject<(string * DFile) []>(codeData, options)
        switchD req


/// This should be used for root component of your application.
/// Currently it is only usable for server side mode blazor in debug mode.
/// renderEntryName: should be the full name of the initRender. ("Demo.App.app", app).
/// I use IGlobalStore to create a store "--fun-blazor-hot-reload-store" to receive the code changes, so you should not create any store named like that.
/// You should use it together with Fun.Blazor.Cli.
type HotReloadComponent(renderEntryName, initRender) as this =
    inherit FunBlazorComponent()

    let mutable render = initRender

    let setRender r =
        render <- r
        this.ForceRerender()

    static member HotReloadStoreName = "--fun-blazor-hot-reload-store"

    [<Inject>]
    member val GlobalStore = Unchecked.defaultof<IGlobalStore> with get, set

    override _.Render() = render

    override _.OnAfterRender(first) =
#if DEBUG
        if first then
            this
                .GlobalStore
                .Create(HotReloadComponent.HotReloadStoreName, "[]")
                .Observable.Add(fun codeData -> Extensions.reload renderEntryName codeData setRender |> ignore)
#endif
        ()
