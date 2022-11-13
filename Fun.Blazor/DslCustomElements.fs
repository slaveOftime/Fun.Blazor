namespace Fun.Blazor

open System
open System.Collections.Concurrent
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Web
open Fun.Blazor.Operators


[<AutoOpen>]
module DslCustomElements =
    let private rootComponstKeys = ConcurrentDictionary<string, bool>()

    let private customElementFragemnts = ConcurrentDictionary<int, NodeRenderFragment>()

    let mutable internal jsComponentConfig =
        Unchecked.defaultof<IJSComponentConfiguration>


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
                        jsComponentConfig.RegisterCustomElement<'T>(name)
                    true
            )
            |> ignore


        member _.Run(render: AttrRenderFragment) = base.Run(render)

        member _.Run(render: NodeRenderFragment) = base.Run(render)


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


    type CustomElementFragmentBuilder(node: NodeRenderFragment, prerenderNode) =
        inherit CustomElementBuilder<CustomElementFragment>("fun-node-custom-element")

        member _.Run(render: AttrRenderFragment) =
            let nodeKey = node.GetHashCode()
            customElementFragemnts.TryAdd(nodeKey, node) |> ignore

            match prerenderNode with
            | Some node -> base.Run(render ==> ("node-render-fragment-key" => nodeKey) >>> node)
            | _ -> base.Run(render ==> ("node-render-fragment-key" => nodeKey))


[<AutoOpen>]
module CustomElementExtensions =

    type CustomElement =

        /// Wrap a NodeRenderFragment into a web custom element.
        /// You will need to call RegisterForFunBlazor.
        /// For example for blazor server: services.AddServerSideBlazor(fun options -> options.RootComponents.RegisterForFunBlazor()).
        /// prerenderNode will put as ChildContent of the current custom element, so when run prerendering it will be used (eg: blazor server).
        static member inline create(node, ?prerenderNode) = CustomElementFragmentBuilder(node, prerenderNode) { empty }

        /// Wrap a NodeRenderFragment into a web custom element.
        /// 'Services is a tuple of registered services in DI container.
        /// You will need to call RegisterForFunBlazor.
        /// For example for blazor server: services.AddServerSideBlazor(fun options -> options.RootComponents.RegisterForFunBlazor()).
        /// prerenderNode will put as ChildContent of the current custom element, so when run prerendering it will be used (eg: blazor server).
        static member inline create(fn: 'Services -> NodeRenderFragment, ?prerenderNode) =
            CustomElementFragmentBuilder(html.inject fn, prerenderNode) { empty }


namespace Microsoft.Extensions.DependencyInjection

open System.Runtime.CompilerServices
open Microsoft.AspNetCore.Components.Web
open Fun.Blazor

[<Extension>]
type FunBlazorCustomElementsExtensions =

    /// For example for blazor server: services.AddServerSideBlazor(fun options -> options.RootComponents.RegisterForFunBlazor()).
    /// When you use this you should use CustomElement.lazyBlazorJs and CustomElement.initBlazorJs accordinly.
    [<Extension>]
    static member RegisterForFunBlazor(this: IJSComponentConfiguration) = jsComponentConfig <- this
