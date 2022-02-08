namespace Fun.Blazor

open Microsoft.AspNetCore.Components
open Elmish


type ElmComponent<'State, 'Msg when 'State: equality>() as this =
    inherit FunBlazorComponent()

    let mutable state = ValueNone
    let mutable program = ValueNone
    let mutable dispatch: 'Msg -> unit = fun _ -> ()


    [<Parameter>]
    member val Init = Unchecked.defaultof<unit -> 'State * Cmd<'Msg>> with get, set

    [<Parameter>]
    member val Update = Unchecked.defaultof<'Msg -> 'State -> 'State * Cmd<'Msg>> with get, set

    [<Parameter>]
    member val View = Unchecked.defaultof<'State -> Dispatch<'Msg> -> NodeRenderFragment> with get, set


    override _.Render() =
        match program, state with
        | ValueSome p, ValueSome s -> Program.view p s dispatch
        | _ -> emptyNode()


    override _.OnInitialized() =
        let initState, initCmd = this.Init()

        state <- ValueSome initState
        program <-
            Program.mkProgram (fun () -> initState, initCmd) this.Update this.View
            |> Program.withSetState (fun model disp ->
                let newState = ValueSome model
                let shouldRerender = newState <> state
                state <- newState
                dispatch <- disp
                if shouldRerender then this.ForceRerender()
            )
            |> ValueSome


    override _.OnAfterRender(firstRender) =
        match program, firstRender with
        | ValueSome p, true -> Program.run p

        | _ -> ()
