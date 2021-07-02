[<AutoOpen>]
module Fun.Blazor.Uitls


let inline (!!) (node: IFunBlazorNode) = GenericFunBlazorNode.create node

let inline genericFunBlazor node = GenericFunBlazorNode.create node
