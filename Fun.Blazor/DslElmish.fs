[<AutoOpen>]
module Fun.Blazor.DslElmish

open Bolero
open Bolero.Html
open Elmish


type FunBlazorHtmlEngine with
    member html.elmish 
        (initState: unit -> 'Model * Cmd<'Msg>
        ,updateState: 'Msg -> 'Model -> 'Model * Cmd<'Msg>
        ,render: 'Model -> Dispatch<'Msg> -> Node
        ,?mapProgram: Bolero.Program<'Model, 'Msg> -> Bolero.Program<'Model, 'Msg>)
        =
        Bolero.Node.BlazorComponent<ElmComponent<'Model, 'Msg>>
            ([
                "Init" => initState
                "Update" => updateState
                "Render" => render
                "MapProgram" => Option.defaultValue id mapProgram
            ]
            ,[])

    member html.elmish (init, update, render, router) =
        html.elmish(init, update, render, Bolero.Program.withRouter router)

    member html.elmish (init, update, render) =
        html.elmish
            (fun () -> init(), Cmd.none
            ,fun msg model -> update msg model, Cmd.none
            ,render)
