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

                    window.initBlazorCustomElement = (tagName, id, delay) => {{
                         const handler = () => {{
                            if (window.initBlazor) {{
                                window.initBlazor()
                                const e = document.querySelector("#ce-" + id)
                                if (e) {{
                                    const timerId = setInterval(() => {{
                                        if (e.nextElementSibling.children.length > 0) {{
                                            e.parentElement.removeChild(e)
                                            clearInterval(timerId)
                                        }}
                                    }}, 50)
                                }}
                            }}
                        }}
                        
                        if (!!delay) {{
                            setTimeout(() => {{
                                var wns = document.querySelector(tagName + "-" + id);
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
                                
                                    // Start try to render
                                    handler();
                                }}
                            }}, delay)
                        }}
                        else {{
                            handler()
                        }}
                    }}
                """

        /// This can only be used for a long runing single instance, distribution env is not appropriate.
        /// Wrap a NodeRenderFragment into a web custom element.
        /// You will need to call RegisterForFunBlazor.
        /// For example for blazor server: services.AddServerSideBlazor(fun options -> options.RootComponents.RegisterForFunBlazor()).
        /// prerenderNode will put as ChildContent of the current custom element, so when run prerendering it will be used (eg: blazor server).
        /// It is recommend to add CutomElement.lazyBlazorJs() at the html header.
        static member inline create(node, ?prerenderNode) = CustomElementFragmentBuilder(node, prerenderNode) { empty }

        /// This can only be used for a long runing single instance, distribution env is not appropriate.
        /// Wrap a NodeRenderFragment into a web custom element.
        /// 'Services is a tuple of registered services in DI container.
        /// You will need to call RegisterForFunBlazor.
        /// For example for blazor server: services.AddServerSideBlazor(fun options -> options.RootComponents.RegisterForFunBlazor()).
        /// prerenderNode will put as ChildContent of the current custom element, so when run prerendering it will be used (eg: blazor server).
        static member inline create(fn: 'Services -> NodeRenderFragment, ?prerenderNode) =
            CustomElementFragmentBuilder(html.inject fn, prerenderNode) { empty }


    type html with

        /// To use this for a component you will need to call RegisterCustomElementForFunBlazor properly at the start of your program.
        /// It is recommend to add CutomElement.lazyBlazorJs() at the html header.
        static member customElement<'T when 'T :> IComponent>(?tagName, ?attrs, ?preRender, ?preRenderNode: NodeRenderFragment, ?preRenderContainerAttrs, ?delayMs: int) =
            let id' = Random.Shared.Next()
            let tagName = tagName |> Option.defaultWith (fun _ -> toSnakeCase typeof<'T>.Name)
            let preRender = defaultArg preRender false

            html.fragment [
                match preRenderNode with
                | None when preRender -> div {
                    id $"ce-{id'}"
                    defaultArg preRenderContainerAttrs html.emptyAttr
                    html.blazor<'T> (defaultArg attrs (AttrRenderFragment(fun _ _ i -> i)))
                  }
                | Some node -> div {
                    id $"ce-{id'}"
                    defaultArg preRenderContainerAttrs html.emptyAttr
                    node
                  }
                | _ -> ()
                match delayMs with
                | None ->
                    EltBuilder tagName { defaultArg attrs html.emptyAttr }
                    js $"""window.initBlazorCustomElement("{tagName}", {id'})"""
                | Some delay ->
                    EltBuilder $"{tagName}-{id'}" { defaultArg attrs html.emptyAttr }
                    js $"""window.initBlazorCustomElement("{tagName}", {id'}, {delay})"""
                    
            ]


namespace Microsoft.Extensions.DependencyInjection

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
