[<AutoOpen>]
module Fun.Blazor.Tests.Utils

open System.Runtime.CompilerServices
open Bunit
open Fun.Blazor


[<Extension>]
type FunBlazorTestExtensions =

    [<Extension>]
    static member RenderNode(ctx: TestContext, node: NodeRenderFragment) =
        ctx.RenderComponent(fun (parameters: ComponentParameterCollectionBuilder<FunFragmentComponent>) ->
            parameters.Add((fun p -> p.Fragment), node) |> ignore
        )
