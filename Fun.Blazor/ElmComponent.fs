namespace Fun.Blazor

open System
open Microsoft.AspNetCore.Components
open Bolero
open Elmish


type ElmComponent<'Model, 'Msg> () =
    inherit ProgramComponent<'Model, 'Msg>()
    
    [<Parameter>]
    member val Init = Unchecked.defaultof<unit -> 'Model * Cmd<'Msg>> with get, set
    
    [<Parameter>]
    member val Update = Unchecked.defaultof<'Msg -> 'Model -> 'Model * Cmd<'Msg>> with get, set

    [<Parameter>]
    member val Render = Unchecked.defaultof<'Model -> Dispatch<'Msg> -> FunBlazorNode> with get, set
    
    [<Parameter>]
    member val MapProgram = Unchecked.defaultof<Program<'Model, 'Msg> -> Program<'Model, 'Msg>> with get, set
    
    [<Inject>]
    member val Services = Unchecked.defaultof<IServiceProvider> with get, set

    override this.Program =
        Program.mkProgram
            (fun _ -> this.Init())
            (fun msg model -> this.Update msg model)
            (fun model dispatch -> this.Render model dispatch |> FunBlazorNode.ToBoleroNode)
        |> this.MapProgram
