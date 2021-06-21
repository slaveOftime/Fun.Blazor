[<AutoOpen>]
module Fun.Blazor.Demo.Wasm.DemoAntDesign.Demo

open Fun.Blazor
open Fun.Blazor.Demo.Wasm.Components


let private rootDir = "Demos/DemoAntDesign"


let demoAntDesign = html.inject (fun (localStore: ILocalStore, shareStore: IShareStore) ->
    let isDarkMode = shareStore.Create ("isDarkMode", false)

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
            ]
        html.script "_content/AntDesign/js/ant-design-blazor.js"
        html.stylesheet "_content/AntDesign/css/ant-design-blazor.css"
    ])
