[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.DemoAntDesign.CollapseDemo

open AntDesign

let collapseDemo =
    collapse.create [
        collapse.bordered false
        collapse.defaultActiveKey [| "1" |]
        collapse.expandIconTemplate (fun expanded ->
            icon.create [
                icon.type' "caret-right"
                icon.rotate (if expanded then 90 else 0)
            ])
        collapse.childContent [
            for i in [1..3] do
                panel.create [
                    panel.header $"Panel {i}"
                    panel.key (string i)
                    panel.childContent $"Panel {i} content"
                ]
        ]
    ]
