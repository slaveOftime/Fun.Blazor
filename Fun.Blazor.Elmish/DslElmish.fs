﻿[<AutoOpen>]
module Fun.Blazor.DslElmish

open FSharp.Data.Adaptive
open Elmish
open Operators


type html with

    /// init will be called OnInitialized, but the cmd generated by init will not be exec to avoid server mode blazor prerender loop issue
    /// After first render, elmish loop will exec cmd created by init. And continue with its state.
    static member inline elmish
        (
            [<InlineIfLambda>] init: unit -> 'State * Cmd<'Msg>,
            [<InlineIfLambda>] update: 'Msg -> 'State -> 'State * Cmd<'Msg>,
            [<InlineIfLambda>] view: 'State -> Dispatch<'Msg> -> NodeRenderFragment
        )
        =
        ComponentWithChildBuilder<ElmComponent<'State, 'Msg>>() {
            "Init" => init
            "Update" => update
            "View" => view
        }


    static member inline elmish
        (
            [<InlineIfLambda>] initState: unit -> 'State,
            [<InlineIfLambda>] updateState: 'Msg -> 'State -> 'State,
            [<InlineIfLambda>] render: 'State -> Dispatch<'Msg> -> NodeRenderFragment
        )
        =
        html.elmish ((fun () -> initState (), Cmd.none), (fun msg state -> updateState msg state, Cmd.none), render)


type IComponentHook with

    /// Make a simple elmish model with adaptive data
    member hook.UseElmish<'Model, 'Msg>
        (
            state: cval<'Model>,
            update: 'Msg -> 'Model -> 'Model * Cmd<'Msg>,
            ?initCmd: Cmd<'Msg>,
            ?execInitCmdAfterRender: bool
        )
        =
        let execInitCmdAfterRender = defaultArg execInitCmdAfterRender true

        let rec dispatch msg =
            let newState, newCmd = update msg state.Value
            state.Publish newState
            newCmd |> List.iter (fun sub -> sub dispatch)

        let execCmd = List.iter (fun sub -> sub dispatch)

        match initCmd with
        | None -> ()
        | Some initCmd when execInitCmdAfterRender -> hook.OnFirstAfterRender.Add(fun () -> execCmd initCmd)
        | Some initCmd -> execCmd initCmd

        dispatch


    member inline hook.UseElmish<'Model, 'Msg>([<InlineIfLambda>] init, [<InlineIfLambda>] update, ?execInitCmdAfterRender) =
        let initState, initCmd = init ()
        let state = cval initState
        let dispatch =
            hook.UseElmish<'Model, 'Msg>(state, update, initCmd = initCmd, execInitCmdAfterRender = defaultArg execInitCmdAfterRender true)
        state :> aval<_>, dispatch
