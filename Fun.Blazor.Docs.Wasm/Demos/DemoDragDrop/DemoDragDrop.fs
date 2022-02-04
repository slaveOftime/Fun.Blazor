[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.DemoDragDrop.Demo

open Fun.Blazor
open Fun.Blazor.Docs.Wasm.Components


let private rootDir = "Demos/DemoDragDrop"


let demoDragDrop =
    div {
        simplePage
            "https://github.com/Postlagerkarte/blazor-dragdrop"
            "blazor-dragdrop"
            "Drag and Drop Library for Blazor"
            ""
            (demoContainer "Skeleton" $"{rootDir}/ListDragDropDemo" listDragDropDemo)
        script {
            src "https://unpkg.com/@fluentui/web-components"
            type' "module"
        }
    }
