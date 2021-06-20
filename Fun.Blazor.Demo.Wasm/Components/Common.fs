[<AutoOpen>]
module Fun.Blazor.Demo.Wasm.Components.Common

open Fun.Blazor


let private spaceV (x: int) = 
    html.div [ 
        attr.styles [ style.height x ]
    ]

let spaceV1 = spaceV 2
let spaceV2 = spaceV 6
let spaceV3 = spaceV 10
let spaceV4 = spaceV 16
