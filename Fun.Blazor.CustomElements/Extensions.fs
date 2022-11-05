namespace Microsoft.Extensions.DependencyInjection

open System.Runtime.CompilerServices
open Microsoft.AspNetCore.Components.Web


[<Extension>]
type FunBlazorCustomElementsExtensions =

    /// For example for blazor server: services.AddServerSideBlazor(fun options -> options.RootComponents.RegisterForFunBlazor()).
    /// When you use this you should use CustomElement.lazyBlazorJs and CustomElement.initBlazorJs accordinly.
    [<Extension>]
    static member RegisterForFunBlazor(this: IJSComponentConfiguration) = Fun.Blazor.DslCustomElement.jsComponentConfig <- this


namespace Fun.Blazor

[<AutoOpen>]
module CustomElementExtensions =

    type CustomElement with

        /// Wrap a NodeRenderFragment into a web custom element.
        /// This is powered by Microsoft.AspNetCore.Components.CustomElements. It will automatically register it.
        /// You will need to call RegisterForFunBlazor.
        /// For example for blazor server: services.AddServerSideBlazor(fun options -> options.RootComponents.RegisterForFunBlazor()).
        static member inline create(node) = CustomElementFragmentBuilder(node) { "fun-blazor", "" }

        /// Wrap a NodeRenderFragment into a web custom element.
        /// 'Services is a tuple of registered services in DI container.
        /// This is powered by Microsoft.AspNetCore.Components.CustomElements. It will automatically register it.
        /// You will need to call RegisterForFunBlazor.
        /// For example for blazor server: services.AddServerSideBlazor(fun options -> options.RootComponents.RegisterForFunBlazor()).
        static member inline create(fn: 'Services -> NodeRenderFragment) = CustomElement.create (html.inject fn)
