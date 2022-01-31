[<AutoOpen>]
module Fun.Blazor.DslElmish

open FSharp.Data.Adaptive
open Elmish


type html with

    static member elmish
        (
            initState: unit -> 'Model * Cmd<'Msg>,
            updateState: 'Msg -> 'Model -> 'Model * Cmd<'Msg>,
            render: 'Model -> Dispatch<'Msg> -> NodeRenderFragment
        )
        =
        html.inject (fun (hook: IComponentHook) ->
            let initState, initCmd = initState ()
            let store = cval (initState)

            let rec loopCmd (state: 'Model, cmd: Cmd<'Msg>) =
                for sub in cmd do
                    sub (fun msg ->
                        let newState, newCmd = updateState msg state
                        store.Publish newState
                        loopCmd (newState, newCmd)
                    )

            hook.OnFirstAfterRender.Add(fun () -> loopCmd (initState, initCmd))


            adaptiview () {
                let! state = store

                let dispatch (msg: 'Msg) = loopCmd (updateState msg state)

                render state dispatch
            }
        )
