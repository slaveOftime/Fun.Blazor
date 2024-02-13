[<AutoOpen>]
module Fun.Blazor.CustomElementsDsl

open System
open Microsoft.AspNetCore.Components
open Fun.Blazor.CustomElements


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
    static member customElement
        (
            componentType: Type,
            tagName: string option,
            attrs: AttrRenderFragment option,
            preRender: bool,
            preRenderNode: NodeRenderFragment option,
            preRenderContainerAttrs: AttrRenderFragment option,
            preRenderContainerTagName: string option,
            renderAfter: RenderAfter option
        )
        =
        let id' = Random.Shared.Next()

        let tagName =
            tagName
            |> Option.defaultWith (fun _ -> Utils.GetTagNameForType(componentType, failIfWithoutFunBlazorCustomElementAttribute = false))

        if tagName.Contains "-" |> not then
            failwith $"Blazor custom element's tag name must be snake name with at least two words, like xxx-xxx. Current tag name is {tagName} for type {componentType.FullName}."

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
                    defaultArg
                        preRenderNode
                        (NodeRenderFragment(fun comp builder index ->
                            builder.OpenComponent(index, componentType)
                            let nextIndex = ceAttrs.Invoke(comp, builder, index + 1)
                            builder.CloseComponent()
                            nextIndex
                        ))
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
                | RenderAfter.Delay delay -> js $"""window.initBlazorCustomElementInDelay("{tagName}", {id'}, {delay})"""
                | RenderAfter.Clicked -> js $"""window.initBlazorCustomElementWhenPreNodeClicked("{tagName}", {id'})"""
                | RenderAfter.ClickedOrDelay delay ->
                    js $"""window.initBlazorCustomElementInDelay("{tagName}", {id'}, {delay})"""
                    js $"""window.initBlazorCustomElementWhenPreNodeClicked("{tagName}", {id'}, {delay})"""
                | RenderAfter.InViewport -> js $"""window.initBlazorCustomElementWhenInViewport("{tagName}", {id'})"""
                | RenderAfter.InViewportOrDelay delay ->
                    js $"""window.initBlazorCustomElementInDelay("{tagName}", {id'}, {delay})"""
                    js $"""window.initBlazorCustomElementWhenInViewport("{tagName}", {id'})"""
                | RenderAfter.InViewportAndDelay delay -> js $"""window.initBlazorCustomElementWhenInViewport("{tagName}", {id'}, {delay})"""
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
    static member customElement
        (
            componentType: Type,
            ?tagName,
            ?attrs,
            ?preRender,
            ?preRenderNode: NodeRenderFragment,
            ?preRenderContainerAttrs,
            ?preRenderContainerTagName,
            ?renderAfter: RenderAfter
        )
        =
        html.customElement (
            componentType,
            tagName,
            attrs,
            defaultArg preRender false,
            preRenderNode,
            preRenderContainerAttrs,
            preRenderContainerTagName,
            renderAfter
        )


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
    static member customElement<'T when 'T :> IComponent>
        (
            ?tagName: string,
            ?attrs: AttrRenderFragment,
            ?preRender: bool,
            ?preRenderNode: NodeRenderFragment,
            ?preRenderContainerAttrs: AttrRenderFragment,
            ?preRenderContainerTagName: string,
            ?delayMs: int,
            ?renderAfter: RenderAfter
        )
        =
        let renderAfter =
            match renderAfter, delayMs with
            | Some x, _ -> Some x
            | None, Some x -> Some(RenderAfter.Delay x)
            | None, None -> None

        html.customElement (
            typeof<'T>,
            tagName,
            attrs,
            defaultArg preRender false,
            preRenderNode,
            preRenderContainerAttrs,
            preRenderContainerTagName,
            renderAfter
        )

    /// <summary>
    /// To use this for a component you will need to call services.AddServerSideBlazor(fun options -> options.RootComponents.RegisterCustomElementForFunBlazor(Assembly.GetExecutingAssembly())) at the start of your program.
    /// It is recommend to add CutomElement.lazyBlazorJs() at the html header.
    /// </summary>
    /// <param name="componentAttrBuilder"></param>
    /// <param name="tagName">By default it try to use the class name itself</param>
    /// <param name="preRender">Enable prerender, will prerender the custom element itself</param>
    /// <param name="preRenderNode">When this is specified, preRender is not necessary and the this node will be used as the prerender stuff instead of using the custome element itself</param>
    /// <param name="preRenderContainerAttrs">Set attributes for prerender container node</param>
    /// <param name="preRenderContainerTagName">Set attributes for prerender container's tag name, default is div</param>
    /// <param name="renderAfter">Start render after some condition, this has higher priority than delayMs</param>
    static member customElement<'T when 'T :> IComponent>
        (
            componentAttrBuilder: ComponentAttrBuilder<'T>,
            ?tagName: string,
            ?preRender: bool,
            ?preRenderNode: NodeRenderFragment,
            ?preRenderContainerAttrs: AttrRenderFragment,
            ?preRenderContainerTagName: string,
            ?renderAfter: RenderAfter
        )
        =
        html.customElement (
            typeof<'T>,
            tagName,
            Some(componentAttrBuilder.Build()),
            defaultArg preRender false,
            preRenderNode,
            preRenderContainerAttrs,
            preRenderContainerTagName,
            renderAfter
        )
