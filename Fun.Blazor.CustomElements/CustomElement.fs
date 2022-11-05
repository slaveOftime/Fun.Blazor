[<AutoOpen>]
module Fun.Blazor.DslCustomElement

open System
open System.Collections.Concurrent
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Web
open Fun.Blazor.Operators


let private rootComponstKeys = ConcurrentDictionary<string, bool>()

let private customElementFragemnts = ConcurrentDictionary<int, NodeRenderFragment>()

let mutable internal jsComponentConfig =
    Unchecked.defaultof<IJSComponentConfiguration>


type CustomElement() =

    /// Normally blazorJsSrc should be something like: _framework/blazor.server.js.
    /// You should before you use custom elements.
    /// If your application is running in blazor, you can follow Microsoft.AspNetCore.Components.CustomElements related docs. And this call will not be necessary.
    static member lazyBlazorJs blazorJsSrc =
        js
            $"""
                window.initBlazor = () => {{
                    if (!window.Blazor) {{
                        const CustomElementScript = document.createElement("script")
                        CustomElementScript.src = "_content/Microsoft.AspNetCore.Components.CustomElements/BlazorCustomElements.js"
                        document.body.appendChild(CustomElementScript)

                        const blazorScript = document.createElement("script")
                        blazorScript.src = "{blazorJsSrc}"
                        document.body.appendChild(blazorScript)
                    }}
                }}
            """

    /// This will try to call initBlazor.
    static member internal initBlazorJs = js "if (window.initBlazor) { window.initBlazor() }"


/// This is used to register blazor component as web custom element
type CustomElementBuilder<'T when 'T :> IComponent>(name) =
    inherit EltBuilder(name)

    do
        let key = typeof<'T>.FullName + "-" + name

        rootComponstKeys.GetOrAdd(
            key,
            fun _ ->
                if jsComponentConfig = null then
                    failwithf "%s is null, you may need to call RegisterForFunBlazor when register services." (nameof jsComponentConfig)
                else
                    jsComponentConfig.RegisterAsCustomElement<'T>(name)
                true
        )
        |> ignore


    member _.Run(render: AttrRenderFragment) = html.fragment [ base.Run(render); CustomElement.initBlazorJs ]

    member _.Run(render: NodeRenderFragment) = html.fragment [ base.Run(render); CustomElement.initBlazorJs ]



type CustomElementFragment() as this =
    inherit FunBlazorComponent()

    [<Parameter>]
    member val NodeRenderFragmentKey = 0 with get, set

    override _.Render() =
        match customElementFragemnts.TryGetValue this.NodeRenderFragmentKey with
        | true, x -> x
        | _ -> failwithf "NodeRenderFragment is not found for key %d" this.NodeRenderFragmentKey

    interface IDisposable with
        member _.Dispose() = customElementFragemnts.TryRemove(this.NodeRenderFragmentKey) |> ignore


type CustomElementFragmentBuilder(node: NodeRenderFragment) =
    inherit CustomElementBuilder<CustomElementFragment>("fun-node-custom-element")

    member _.Run(render: AttrRenderFragment) =
        let nodeKey = node.GetHashCode()
        customElementFragemnts.TryAdd(nodeKey, node) |> ignore
        base.Run(render ==> ("node-render-fragment-key" => nodeKey))
