[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.DemoAntDesign.Demo

open Fun.Blazor
open Fun.Blazor.Docs.Wasm.Components


let private rootDir = "Demos/DemoAntDesign"


let demoAntDesign =
    div {
        simplePage
            "https://antblazor.com/"
            "Ant Design"
            "For Blazor"
            "Following the Ant Design specification, we developed a Blazor Components library ant-design-blazor that contains a set of high quality components and demos for building rich, interactive user interfaces."
            (fragment {
                demoContainer "Modal" $"{rootDir}/ModalDemo" modalDemo
                demoDivider
                demoContainer "Dropdown" $"{rootDir}/DropDownDemo" dropDownDemo
                demoDivider
                demoContainer "Collapse" $"{rootDir}/CollapseDemo" collapseDemo
                demoDivider
                demoContainer "Chart" $"{rootDir}/ChartDemo" chartDemo
            })
        stylesheet "_content/AntDesign/css/ant-design-blazor.css"
    }
