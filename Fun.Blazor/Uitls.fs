[<AutoOpen>]
module Fun.Blazor.Uitls


let inline (!!) (node: FunBlazorNode) = GenericFelizNode.create node

let inline felizNode node = GenericFelizNode.create node
