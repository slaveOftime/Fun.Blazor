[<AutoOpen>]
module Fun.Blazor.DslElmish

open FSharp.Data.Adaptive
open Elmish


type html with

    static member elmish
        (
            initState: unit -> 'State * Cmd<'Msg>,
            updateState: 'Msg -> 'State -> 'State * Cmd<'Msg>,
            render: 'State -> Dispatch<'Msg> -> NodeRenderFragment
        )
        =
        html.inject (fun (hook: IComponentHook) ->
            let initState, initCmd = initState ()
            let store = cval (initState)

            // TODO should use elmish common implementation
            let rec loopCmd (state: 'State, cmd: Cmd<'Msg>) =
                for sub in cmd do
                    sub (fun msg ->
                        let newState, newCmd = updateState msg state
                        store.Publish newState
                        loopCmd (newState, newCmd)
                    )

            hook.OnFirstAfterRender.Add(fun () -> loopCmd (initState, initCmd))


            adaptiview () {
                let! state = store

                let dispatch (msg: 'Msg) = loopCmd (state, Cmd.ofMsg msg)

                render state dispatch
            }
        )


    static member elmish
        (
            initState: unit -> 'State,
            updateState: 'Msg -> 'State -> 'State,
            render: 'State -> Dispatch<'Msg> -> NodeRenderFragment
        )
        =
        html.elmish ((fun () -> initState (), Cmd.none), (fun msg state -> updateState msg state, Cmd.none), render)
