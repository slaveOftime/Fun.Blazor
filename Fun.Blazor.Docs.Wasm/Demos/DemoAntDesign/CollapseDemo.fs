[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.DemoAntDesign.CollapseDemo

open AntDesign

let collapseDemo =
    collapse() {
        bordered false
        defaultActiveKey [| "1" |]
        expandIconTemplate (fun expanded ->
            icon() {
                type' "caret-right"
                rotate (if expanded then 90 else 0)
                CAST
            })
        childContent [
            for i in [1..3] do
                panel() {
                    header $"Panel {i}"
                    key (string i)
                    childContentStr $"Panel {i} content"
                }
        ]
    }
