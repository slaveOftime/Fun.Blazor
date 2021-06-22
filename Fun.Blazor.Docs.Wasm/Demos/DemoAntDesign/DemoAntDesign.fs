[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.DemoAntDesign.Demo

open Fun.Blazor
open Fun.Blazor.Docs.Wasm.Components


let private rootDir = "Demos/DemoAntDesign"


let demoAntDesign =
    html.div [
        simplePage
            "https://antblazor.com/"
            "Ant Design"
            "For Blazor"
            "Following the Ant Design specification, we developed a Blazor Components library ant-design-blazor that contains a set of high quality components and demos for building rich, interactive user interfaces."
            [
                demoContainer "Modal" $"{rootDir}/ModalDemo" modalDemo
                demoDivider
                demoContainer "Dropdown" $"{rootDir}/DropDownDemo" dropDownDemo
                demoDivider
                demoContainer "Collapse" $"{rootDir}/CollapseDemo" collapseDemo
                demoDivider
                demoContainer "Chart" $"{rootDir}/ChartDemo" chartDemo
            ]

        html.script "_content/AntDesign/js/ant-design-blazor.js"
        html.stylesheet "_content/AntDesign/css/ant-design-blazor.css"
        html.script "https://unpkg.com/@antv/g2plot@1.1.28/dist/g2plot.js"
        html.script "_content/AntDesign.Charts/ant-design-charts-blazor.js"
    ]
