namespace Fun.Blazor

open System
open System.Text
open System.Collections.Concurrent
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Web
open Fun.Blazor.Operators


[<AttributeUsage(AttributeTargets.Class)>]
type FunBlazorCustomElementAttribute() =
    inherit Attribute()

    member val TagName = "" with get, set


[<AutoOpen>]
module DslCustomElements =

    [<RequireQualifiedAccess>]
    type RenderAfter =
        /// Render after timeout in ms
        | Delay of int
        /// Render after prerender container received click event
        | Clicked
        /// Render after prerender container received click event or timeout in ms
        | ClickedOrDelay of int
        /// Render after element is in viewport
        | InViewport
        /// Render after element is in viewport or timeout in ms
        | InViewportOrDelay of int
        /// Render after element is in viewport, and delay for some time in ms
        | InViewportAndDelay of int

    let private rootComponstKeys = ConcurrentDictionary<string, bool>()

    let private customElementFragemnts = ConcurrentDictionary<int, NodeRenderFragment>()

    let mutable internal jsComponentConfig =
        Unchecked.defaultof<IJSComponentConfiguration>


    let internal toSnakeCase (text: string) =
        if text = null || text.Length < 2 then
            text
        else
            let sb = StringBuilder()

            sb.Append(Char.ToLowerInvariant(text[0])) |> ignore

            for c in text |> Seq.skip 1 do
                if Char.IsUpper(c) then
                    sb.Append('-').Append(Char.ToLowerInvariant(c)) |> ignore
                else
                    sb.Append(c) |> ignore

            sb.ToString()


    /// This is used to register blazor component as web custom element
    [<Obsolete "Please use html.customElement instead">]
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


        member inline this.Run([<InlineIfLambda>] render: NodeRenderFragment) =
            NodeRenderFragment(fun comp builder index ->
                builder.OpenElement(index, (this :> IElementBuilder).Name)
                let nextIndex = index + 1
                let nextIndex = render.Invoke(comp, builder, nextIndex)
                builder.CloseElement()
                nextIndex
            )


    [<Obsolete "Please use html.customElement instead">]
    type CustomElementFragment() as this =
        inherit FunComponent()

        [<Parameter>]
        member val NodeRenderFragmentKey = 0 with get, set

        override _.Render() =
            match customElementFragemnts.TryGetValue this.NodeRenderFragmentKey with
            | true, x -> x
            | _ -> failwithf "NodeRenderFragment is not found for key %d" this.NodeRenderFragmentKey

        interface IDisposable with
            member _.Dispose() = customElementFragemnts.TryRemove(this.NodeRenderFragmentKey) |> ignore

    [<Obsolete "Please use html.customElement instead">]
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

        /// Normally blazorJsSrc should be something like: _framework/blazor.server.js.
        /// You should add this before you use custom elements.
        static member lazyBlazorJs(?blazorJsSrc, ?hasBlazorJs) =
            let initBlazor =
                if defaultArg hasBlazorJs false then
                    """
                    window.initBlazor = () => {
                        window.isBlazorScriptAdded = true
                    }
                    """
                else
                    $"""
                    window.initBlazor = () => {{
                        if (!window.isBlazorScriptAdded) {{
                            window.isBlazorScriptAdded = true
                            const blazorScript = document.createElement("script")
                            blazorScript.src = "{defaultArg blazorJsSrc "_framework/blazor.server.js"}"
                            document.body.appendChild(blazorScript)
                        }}
                    }}
                    """
            js
                $"""
                {initBlazor}

                window.initBlazorCustomElement = (id) => {{
                    // Ensure the blazor js is executed, so it can monitor the custom element tag
                    if (window.initBlazor) {{
                        window.initBlazor()
                        // Remove related prerender node
                        const e = document.querySelector("#ce-prerender-" + id)
                        if (e) {{
                            const timerId = setInterval(() => {{
                                if (!e.nextElementSibling || e.nextElementSibling.children.length > 0) {{
                                    e.parentElement.removeChild(e)
                                    clearInterval(timerId)
                                }}
                            }}, 50)
                        }}
                    }}
                }}

                window.initBlazorCustomElementLazy = (tagName, id) => {{
                    // find custom element lazy placeholder and create target custom element based on it
                    var wns = document.querySelector(tagName + "-lazy-" + id);
                    if (!!wns) {{
                        var index;
                        var lmn = document.createElement(tagName);

                        // Copy the children
                        while (wns.firstChild) {{
                            lmn.appendChild(wns.firstChild); // *Moves* the child
                        }}

                        // Copy the attributes
                        for (index = wns.attributes.length - 1; index >= 0; --index) {{
                            lmn.attributes.setNamedItem(wns.attributes[index].cloneNode());
                        }}

                        // Replace it
                        wns.parentNode.replaceChild(lmn, wns);
                    }}
                    window.initBlazorCustomElement(id);
                }}

                window.initBlazorCustomElementInDelay = (tagName, id, delay) => {{
                    setTimeout(() => {{
                        window.initBlazorCustomElementLazy(tagName, id);
                    }}, delay)
                }}

                window.initBlazorCustomElementWhenPreNodeClicked = (tagName, id) => {{
                    const elt = document.querySelector("#ce-prerender-" + id);
                    if (elt) {{
                        elt.addEventListener("click", () => {{
                            window.initBlazorCustomElementLazy(tagName, id);
                        }});
                    }}
                }};

                window.initBlazorCustomElementWhenInViewport = (tagName, id, delay) => {{
                    const elt = document.querySelector("#ce-prerender-" + id);
                    if (elt) {{
                        const handler = () => {{
                            const rect = elt.getBoundingClientRect();
                            const isEltVisible =
                                rect.top >= 0 &&
                                rect.left >= 0 &&
                                rect.bottom <= (window.innerHeight || document.documentElement.clientHeight) && /* or $(window).height() */
                                rect.right <= (window.innerWidth || document.documentElement.clientWidth) /* or $(window).width() */
                                ;
                            if (isEltVisible) {{
                                window.removeEventListener('DOMContentLoaded', handler, false);
                                window.removeEventListener('load', handler, false);
                                window.removeEventListener('scroll', handler, false);
                                window.removeEventListener('resize', handler, false);
                                if (!!delay) {{
                                    window.initBlazorCustomElementInDelay(tagName, id, delay);
                                }}
                                else {{
                                    window.initBlazorCustomElementLazy(tagName, id);
                                }}
                            }}
                        }};
                        window.addEventListener('DOMContentLoaded', handler, false);
                        window.addEventListener('load', handler, false);
                        window.addEventListener('scroll', handler, false);
                        window.addEventListener('resize', handler, false);
                        handler();
                    }}
                }};
                """

        /// This can only be used for a long runing single instance, distribution env is not appropriate.
        /// Wrap a NodeRenderFragment into a web custom element.
        /// You will need to call RegisterForFunBlazor.
        /// For example for blazor server: services.AddServerSideBlazor(fun options -> options.RootComponents.RegisterForFunBlazor()).
        /// prerenderNode will put as ChildContent of the current custom element, so when run prerendering it will be used (eg: blazor server).
        /// It is recommend to add CutomElement.lazyBlazorJs() at the html header.
        [<Obsolete("Please use html.customElement instead")>]
        static member inline create(node, ?prerenderNode) = CustomElementFragmentBuilder(node, prerenderNode) { empty }

        /// This can only be used for a long runing single instance, distribution env is not appropriate.
        /// Wrap a NodeRenderFragment into a web custom element.
        /// 'Services is a tuple of registered services in DI container.
        /// You will need to call RegisterForFunBlazor.
        /// For example for blazor server: services.AddServerSideBlazor(fun options -> options.RootComponents.RegisterForFunBlazor()).
        /// prerenderNode will put as ChildContent of the current custom element, so when run prerendering it will be used (eg: blazor server).
        [<Obsolete("Please use html.customElement instead")>]
        static member inline create(fn: 'Services -> NodeRenderFragment, ?prerenderNode) =
            CustomElementFragmentBuilder(html.inject fn, prerenderNode) { empty }


    type html with

        /// <summary>
        /// To use this for a component you will need to call services.AddServerSideBlazor(fun options -> options.RootComponents.RegisterCustomElementForFunBlazor(Assembly.GetExecutingAssembly())) at the start of your program.
        /// It is recommend to add CutomElement.lazyBlazorJs() at the html header.
        /// </summary>
        /// <param name="componentType">Component type</param>
        /// <param name="tagName">By default it try to use the class name itself</param>
        /// <param name="attrs">Specify the attributes for the custom element</param>
        /// <param name="preRender">Enable prerender, will prerender the custom element itself</param>
        /// <param name="preRenderNode">When this is specified, preRender is not necessary and the this node will be used as the prerender stuff instead of using the custome element itself</param>
        /// <param name="preRenderContainerAttrs">Set attributes for prerender container node</param>
        /// <param name="preRenderContainerTagName">Set attributes for prerender container's tag name, default is div</param>
        /// <param name="renderAfter">Start render after some condition, this has higher priority than delayMs</param>
        static member customElement(componentType: Type, tagName: string option, attrs: AttrRenderFragment option, preRender: bool, preRenderNode: NodeRenderFragment option, preRenderContainerAttrs: AttrRenderFragment option, preRenderContainerTagName: string option, renderAfter: RenderAfter option) =
            let id' = Random.Shared.Next()
            let tagName = tagName |> Option.defaultWith (fun _ -> toSnakeCase componentType.Name)
            let lazyTagName = $"{tagName}-lazy-{id'}"

            let preRenderNodeId = $"ce-prerender-{id'}"
            let preRenderContainerTagName = defaultArg preRenderContainerTagName "div"

            let ceAttrs = defaultArg attrs html.emptyAttr

            let preRenderNode =
                if not preRender then
                    html.none
                else
                    EltWithChildBuilder preRenderContainerTagName {
                        id preRenderNodeId
                        defaultArg preRenderContainerAttrs html.emptyAttr
                        defaultArg preRenderNode (
                            NodeRenderFragment(fun comp builder index ->
                                builder.OpenComponent(index, componentType)
                                let nextIndex = ceAttrs.Invoke(comp, builder, index + 1)
                                builder.CloseComponent()
                                nextIndex
                            )
                        )
                    }

            fragment {
                match renderAfter with
                | None ->
                    EltBuilder tagName { ceAttrs }
                    js $"""window.initBlazorCustomElement({id'})"""

                | Some renderAfter ->
                    preRenderNode
                    EltBuilder lazyTagName { ceAttrs }
                    match renderAfter with
                    | RenderAfter.Delay delay ->
                        js $"""window.initBlazorCustomElementInDelay("{tagName}", {id'}, {delay})"""
                    | RenderAfter.Clicked ->
                        js $"""window.initBlazorCustomElementWhenPreNodeClicked("{tagName}", {id'})"""
                    | RenderAfter.ClickedOrDelay delay -> 
                        js $"""window.initBlazorCustomElementInDelay("{tagName}", {id'}, {delay})"""
                        js $"""window.initBlazorCustomElementWhenPreNodeClicked("{tagName}", {id'}, {delay})"""
                    | RenderAfter.InViewport -> js $"""window.initBlazorCustomElementWhenInViewport("{tagName}", {id'})"""
                    | RenderAfter.InViewportOrDelay delay -> 
                        js $"""window.initBlazorCustomElementInDelay("{tagName}", {id'}, {delay})"""
                        js $"""window.initBlazorCustomElementWhenInViewport("{tagName}", {id'})"""
                    | RenderAfter.InViewportAndDelay delay ->
                        js $"""window.initBlazorCustomElementWhenInViewport("{tagName}", {id'}, {delay})"""
            }

        /// <summary>
        /// To use this for a component you will need to call services.AddServerSideBlazor(fun options -> options.RootComponents.RegisterCustomElementForFunBlazor(Assembly.GetExecutingAssembly())) at the start of your program.
        /// It is recommend to add CutomElement.lazyBlazorJs() at the html header.
        /// </summary>
        /// <param name="componentType">Component type</param>
        /// <param name="tagName">By default it try to use the class name itself</param>
        /// <param name="attrs">Specify the attributes for the custom element</param>
        /// <param name="preRender">Enable prerender, will prerender the custom element itself</param>
        /// <param name="preRenderNode">When this is specified, preRender is not necessary and the this node will be used as the prerender stuff instead of using the custome element itself</param>
        /// <param name="preRenderContainerAttrs">Set attributes for prerender container node</param>
        /// <param name="preRenderContainerTagName">Set attributes for prerender container's tag name, default is div</param>
        /// <param name="renderAfter">Start render after some condition, this has higher priority than delayMs</param>
        static member customElement(componentType: Type, ?tagName: string, ?attrs, ?preRender, ?preRenderNode: NodeRenderFragment, ?preRenderContainerAttrs, ?preRenderContainerTagName, ?renderAfter: RenderAfter) =
            html.customElement(componentType, tagName, attrs, defaultArg preRender false, preRenderNode, preRenderContainerAttrs, preRenderContainerTagName, renderAfter)
            
        
        /// <summary>
        /// To use this for a component you will need to call services.AddServerSideBlazor(fun options -> options.RootComponents.RegisterCustomElementForFunBlazor(Assembly.GetExecutingAssembly())) at the start of your program.
        /// It is recommend to add CutomElement.lazyBlazorJs() at the html header.
        /// </summary>
        /// <param name="tagName">By default it try to use the class name itself</param>
        /// <param name="attrs">Specify the attributes for the custom element</param>
        /// <param name="preRender">Enable prerender, will prerender the custom element itself</param>
        /// <param name="preRenderNode">When this is specified, preRender is not necessary and the this node will be used as the prerender stuff instead of using the custome element itself</param>
        /// <param name="preRenderContainerAttrs">Set attributes for prerender container node</param>
        /// <param name="preRenderContainerTagName">Set attributes for prerender container's tag name, default is div</param>
        /// <param name="delayMs">Start render after some delay</param>
        /// <param name="renderAfter">Start render after some condition, this has higher priority than delayMs</param>
        static member customElement<'T when 'T :> IComponent>(?tagName: string, ?attrs, ?preRender, ?preRenderNode: NodeRenderFragment, ?preRenderContainerAttrs, ?preRenderContainerTagName, ?delayMs: int, ?renderAfter: RenderAfter) =
            let renderAfter =
                match renderAfter, delayMs with
                | Some x, _ -> Some x
                | None, Some x -> Some(RenderAfter.Delay x)
                | None, None -> None 

            html.customElement(typeof<'T>, tagName, attrs, defaultArg preRender false, preRenderNode, preRenderContainerAttrs, preRenderContainerTagName, renderAfter)
            

namespace Microsoft.Extensions.DependencyInjection

open System
open System.Runtime.CompilerServices
open Microsoft.AspNetCore.Components.Web
open Fun.Result
open Fun.Blazor
open System.Reflection

[<Extension>]
type FunBlazorCustomElementsExtensions =

    /// This can only be used for a long runing single instance, distribution env is not appropriate.
    /// For example for blazor server: services.AddServerSideBlazor(fun options -> options.RootComponents.RegisterForFunBlazor()).
    /// When you use this you should use CustomElement.lazyBlazorJs and CustomElement.initBlazorJs accordingly.
    [<Extension>]
    [<Obsolete>]
    static member RegisterForFunBlazor(this: IJSComponentConfiguration) = jsComponentConfig <- this

    /// Please make sure the Component name has at least two upper case like DemoComp, or use tagName with snake style like "demo-comp".
    /// For example for blazor server: services.AddServerSideBlazor(fun options -> options.RootComponents.RegisterCustomElementForFunBlazor<YourComponent>()).
    /// When you use this you should use CustomElement.lazyBlazorJs and CustomElement.initBlazorJs accordingly.
    [<Extension>]
    static member RegisterCustomElementForFunBlazor(this: IJSComponentConfiguration, ty: System.Type, ?tagName) =
        let identifier = tagName |> Option.defaultWith (fun _ -> toSnakeCase (ty.Name))
        // https://github.com/dotnet/aspnetcore/blob/main/src/Components/CustomElements/src/JSComponentConfigurationExtensions.cs
        this.RegisterForJavaScript(ty, identifier, "registerBlazorCustomElement")

    /// Please make sure the Component name has at least two upper case like DemoComp, or use tagName with snake style like "demo-comp".
    /// For example for blazor server: services.AddServerSideBlazor(fun options -> options.RootComponents.RegisterCustomElementForFunBlazor<YourComponent>()).
    /// When you use this you should use CustomElement.lazyBlazorJs and CustomElement.initBlazorJs accordingly.
    [<Extension>]
    static member RegisterCustomElementForFunBlazor<'Component when 'Component :> Microsoft.AspNetCore.Components.IComponent>
        (
            this: IJSComponentConfiguration,
            ?tagName
        )
        =
        this.RegisterCustomElement<'Component>(tagName |> Option.defaultWith (fun _ -> toSnakeCase (typeof<'Component>.Name)))

    /// You will need to add FunBlazorCustomElementAttribute to the target components. 
    /// Please make sure the Component name has at least two upper case like DemoComp, or use tagName with snake style like "demo-comp".
    /// For example for blazor server: services.AddServerSideBlazor(fun options -> options.RootComponents.RegisterCustomElementForFunBlazor<YourComponent>()).
    /// When you use this you should use CustomElement.lazyBlazorJs and CustomElement.initBlazorJs accordingly.
    [<Extension>]
    static member RegisterCustomElementForFunBlazor(this: IJSComponentConfiguration, assembly: Assembly) =
        for ty in assembly.GetTypes() do
            let attr = ty.GetCustomAttribute<FunBlazorCustomElementAttribute>()
            if attr |> box |> isNull |> not then
                match attr.TagName with
                | NullOrEmptyString -> this.RegisterCustomElementForFunBlazor(ty)
                | SafeString tagName -> this.RegisterCustomElementForFunBlazor(ty, tagName)
