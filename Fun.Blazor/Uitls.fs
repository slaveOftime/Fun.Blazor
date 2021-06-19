[<AutoOpen>]
module Fun.Blazor.Uitls


let inline (!!) (node: FelizNode) = GenericFelizNode.create node

let inline felizNode node = GenericFelizNode.create node
