[<AutoOpen>]
module Fun.Blazor.Tests.Utils

open System.Runtime.CompilerServices
open Microsoft.AspNetCore.Components
open Bunit
open Bolero
open Fun.Blazor


[<Extension>]
type FunBlazorTestComponent() =
    inherit Component()

    [<Parameter>]
    member val Node = Unchecked.defaultof<Node> with get, set

    override this.Render () = this.Node


    [<Extension>]
    static member RenderNode(ctx: TestContext, node: Node) =
        ctx.RenderComponent(fun (parameters: ComponentParameterCollectionBuilder<FunBlazorTestComponent>) -> 
            parameters.Add((fun p -> p.Node), node) |> ignore)
