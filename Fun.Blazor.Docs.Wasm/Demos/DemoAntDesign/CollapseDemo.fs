[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.DemoAntDesign.CollapseDemo

open AntDesign

let collapseDemo =
    Collapse'() {
        Bordered false
        DefaultActiveKey [| "1" |]
        ExpandIconTemplate (fun expanded ->
            Icon'() {
                Type "caret-right"
                Rotate (if expanded then 90 else 0)
            })
        childContent [
            for i in [1..3] do
                Panel'() {
                    Header $"Panel {i}"
                    Key (string i)
                    childContent $"Panel {i} content"
                }
        ]
    }
