[<AutoOpen>]
module Fun.Blazor.DslCustomElement

open System
open System.Collections.Concurrent
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Web
open Fun.Blazor.Operators


let private rootComponstKeys = System.Collections.Generic.HashSet<string>()
let mutable jsComponentConfig = Unchecked.defaultof<IJSComponentConfiguration>


type IJSComponentConfiguration with

    /// For example for blazor server: services.AddServerSideBlazor(fun options -> options.RootComponents.RegisterForFunBlazor()).
    /// When you use this you should use CustomElt.lazyBlazorJs and CustomElt.initBlazorJs accordinly.
    member this.RegisterForFunBlazor() = jsComponentConfig <- this


type CustomElt =

    /// Normally blazorJsSrc should something like: _framework/blazor.server.js.
    /// You should add this at the head of your html.
    /// If your application is running in blazor, you should add _content/Microsoft.AspNetCore.Components.CustomElements/BlazorCustomElements.js
    /// before _framework/blazor.server.js which you use normnally.
    static member lazyBlazorJs blazorJsSrc =
        js
            $"""
                window.initBlazor = () => {{
                    if (!window.Blazor) {{
                        const customEltScript = document.createElement("script")
                        customEltScript.src = "_content/Microsoft.AspNetCore.Components.CustomElements/BlazorCustomElements.js"
                        document.body.appendChild(customEltScript)

                        const blazorScript = document.createElement("script")
                        blazorScript.src = "{blazorJsSrc}"
                        document.body.appendChild(blazorScript)
                    }}
                }}
            """

    /// This will try to call init blazor js.
    static member internal initBlazorJs = js "if (window.initBlazor) { window.initBlazor() }"


/// This is used to register blazor component as web custom element
type CustomElementBuilder<'T when 'T :> IComponent>(name) =
    inherit EltBuilder(name)

    do
        let key = typeof<'T>.FullName + "-" + name
        if rootComponstKeys.Contains key |> not then
            rootComponstKeys.Add key |> ignore
            jsComponentConfig.RegisterAsCustomElement<'T>(name)

    member _.Run(render: AttrRenderFragment) = html.fragment [ base.Run(render); CustomElt.initBlazorJs ]

    member _.Run(render: NodeRenderFragment) = html.fragment [ base.Run(render); CustomElt.initBlazorJs ]


let private customComponentFragemnts =
    ConcurrentDictionary<string, NodeRenderFragment>()

type FunBlazorCustomComponent() as this =
    inherit FunBlazorComponent()

    [<Parameter>]
    member val NodeRenderFragmentKey = "" with get, set

    override _.Render() =
        if customComponentFragemnts.ContainsKey this.NodeRenderFragmentKey then
            customComponentFragemnts[this.NodeRenderFragmentKey]
        else
            failwithf "NodeRenderFragment is not found for key %s" this.NodeRenderFragmentKey

    interface IDisposable with
        member _.Dispose() = customComponentFragemnts.TryRemove(this.NodeRenderFragmentKey) |> ignore


type NodeCustomElementBuilder(node: NodeRenderFragment) =
    inherit CustomElementBuilder<FunBlazorCustomComponent>("fun-node-custom-element")

    member _.Run(render: AttrRenderFragment) =
        let nodeKey = node.GetHashCode().ToString()
        customComponentFragemnts.TryAdd(nodeKey, node) |> ignore
        base.Run(render ==> ("node-render-fragment-key" => nodeKey))


type CustomElt with

    /// Wrap a NodeRenderFragment into a web custom element.
    /// This is powered by Microsoft.AspNetCore.Components.CustomElements. It will automatically register it.
    /// You will need to call RegisterForFunBlazor.
    /// For example for blazor server: services.AddServerSideBlazor(fun options -> options.RootComponents.RegisterForFunBlazor()).
    static member inline customElt node = NodeCustomElementBuilder(node) { "funblazor", "true" }

    /// Wrap a NodeRenderFragment into a web custom element.
    /// 'Services is a tuple of registered services in DI container.
    /// This is powered by Microsoft.AspNetCore.Components.CustomElements. It will automatically register it.
    /// You will need to call RegisterForFunBlazor.
    /// For example for blazor server: services.AddServerSideBlazor(fun options -> options.RootComponents.RegisterForFunBlazor()).
    static member inline customElt(fn: 'Services -> NodeRenderFragment) = NodeCustomElementBuilder(html.inject fn) { "funblazor", "true" }
