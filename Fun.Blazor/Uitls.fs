[<AutoOpen>]
module Fun.Blazor.Uitls


let inline (!!) (node: FunBlazorNode) = GenericFunBlazorNode.create node

let inline genericFunBlazor node = GenericFunBlazorNode.create node
