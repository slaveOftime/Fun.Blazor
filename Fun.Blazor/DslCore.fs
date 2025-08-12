namespace Fun.Blazor

open System
open System.Threading.Tasks
open FSharp.Data.Adaptive
open Microsoft.AspNetCore.Components
open Operators
open Internal

#if !NET6_0
open Microsoft.Extensions.Logging
open Microsoft.Extensions.DependencyInjection
open Microsoft.AspNetCore.Components.Web
#endif


type html() =

    /// Helper method to create an empty node
    static member inline none = emptyNode ()

    /// Helper method to create an empty attribute
    static member inline emptyAttr = emptyAttr ()

    /// Helper method to create an empty css node
    static member inline emptyCss = Fun.Css.Internal.CombineKeyValue(fun x -> x)


    static member inline mergeAttrs(attrs: AttrRenderFragment seq) =
        AttrRenderFragment(fun comp builder i ->
            let mutable i = i
            for attr in attrs do
                i <- attr.Invoke(comp, builder, i)
            i
        )

    static member inline mergeNodes(nodes: NodeRenderFragment seq) =
        NodeRenderFragment(fun comp builder i ->
            let mutable i = i
            for node in nodes do
                i <- node.Invoke(comp, builder, i)
            i
        )

    /// Helper method to make put multiple nodes into a fragment node
    static member inline fragment(nodes: NodeRenderFragment seq) = makeRegion nodes


    /// You can also use fragment/html.fragment.
    /// If the input node is dynamic in structure, for example the number of nodes/attributes will change based on some conditions,
    /// Then use this we can reset the sequence number for the input node, so it will not make the sequence number dynamic/changed at runtime for its caller.
    ///
    /// Please check the detail here: https://learn.microsoft.com/en-us/aspnet/core/blazor/advanced-scenarios?view=aspnetcore-7.0#sequence-numbers-relate-to-code-line-numbers-and-not-execution-order
    ///
    /// For example, you have an errorView which will display dynamic structure of the childcontent then you can:
    ///
    /// ```fsharp
    /// let private errorView errors =
    ///     html.region (
    ///         if errors |> List.isEmpty |> not then
    ///             MudText'() {
    ///                 Color Color.Error
    ///                 Typo Typo.caption
    ///                 simplifyErrors errors
    ///             }
    ///         else
    ///             html.none
    ///     )
    /// ```
    static member inline region([<InlineIfLambda>] node: NodeRenderFragment) =
        NodeRenderFragment(fun comp builder sequence ->
            builder.OpenRegion(sequence)

            node.Invoke(comp, builder, 0) |> ignore

            builder.CloseRegion()
            sequence + 1
        )

    /// You can also use fragment/html.fragment.
    /// If the input node is dynamic in structure, for example the number of nodes/attributes will change based on some conditions,
    /// Then use this we can reset the sequence number for the input node, so it will not make the sequence number dynamic/changed at runtime for its caller.
    ///
    /// Please check the detail here: https://learn.microsoft.com/en-us/aspnet/core/blazor/advanced-scenarios?view=aspnetcore-7.0#sequence-numbers-relate-to-code-line-numbers-and-not-execution-order
    ///
    /// For example, you have an errorView which will display dynamic structure of the childcontent then you can:
    ///
    /// ```fsharp
    /// let private errorView errors =
    ///     html.region [|
    ///         if errors |> List.isEmpty |> not then
    ///             MudText'() {
    ///                 Color Color.Error
    ///                 Typo Typo.caption
    ///                 simplifyErrors errors
    ///             }
    ///     |]
    /// ```
    static member inline region(nodes: NodeRenderFragment seq) = makeRegion nodes


    /// Make a blazor component to a render fragment with a render for attributes
    /// You can open Fun.Blazor.Operators to build attribute very easily:
    /// ```fsharp
    /// html.blazor<DemoComp> (domAttr {
    ///     "attrName1", attrValue1
    ///     "attrName2", attrValue2
    ///     "attrName3", attrValue3
    /// })
    /// ```
    static member inline blazor(componentType: Type, ?attr: AttrRenderFragment) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent(index, componentType)

            let nextIndex =
                match attr with
                | None -> index + 1
                | Some r -> r.Invoke(comp, builder, index + 1)

            builder.CloseComponent()
            nextIndex
        )

    /// Make a blazor component to a render fragment with a render for attributes
    /// You can open Fun.Blazor.Operators to build attribute very easily:
    /// ```fsharp
    /// html.blazor<DemoComp> (domAttr {
    ///     "attrName1", attrValue1
    ///     "attrName2", attrValue2
    ///     "attrName3", attrValue3
    /// })
    /// ```
    static member inline blazor<'T when 'T :> IComponent>(?attr: AttrRenderFragment) = html.blazor (typeof<'T>, ?attr = attr)

    /// Make a blazor component to a render fragment with a render for attributes
    /// You can open Fun.Blazor.Operators to build attribute very easily:
    /// ```fsharp
    /// html.blazor (ComponentAttrBuilder<DemoComp>()
    ///     .Add((fun x -> x.Prop1), value1)
    ///     .Add((fun x -> x.Prop2), value2)
    /// )
    /// ```
    static member inline blazor<'T when 'T :> IComponent>(attrBuilder: ComponentAttrBuilder<'T>) =
        html.blazor (typeof<'T>, attr = attrBuilder.Build())


#if !NET6_0
    /// Make a blazor component to a render fragment with a render for attributes
    /// ```fsharp
    /// html.blazor<DemoComp> (RenderModeServer, domAttr {
    ///     "attrName1", attrValue1
    ///     "attrName2", attrValue2
    /// })
    /// ```
    static member inline blazor(componentType: Type, renderMode: IComponentRenderMode, ?attr: AttrRenderFragment) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent(index, componentType)

            let nextIndex =
                match attr with
                | Some attr -> attr.Invoke(comp, builder, index + 1)
                | None -> index + 1

            builder.AddComponentRenderMode(renderMode)
            builder.CloseComponent()
            nextIndex
        )

    /// Make a blazor component to a render fragment with a render for attributes
    /// ```fsharp
    /// html.blazor<DemoComp> (RenderModeServer, domAttr {
    ///     "attrName1", attrValue1
    ///     "attrName2", attrValue2
    /// })
    /// ```
    static member inline blazor<'T when 'T :> IComponent>(renderMode: IComponentRenderMode, ?attr: AttrRenderFragment) =
        html.blazor (typeof<'T>, renderMode, ?attr = attr)

    /// Make a blazor component to a render fragment with a render for attributes
    /// ```fsharp
    /// html.blazor (RenderModeServer, ComponentAttrBuilder<DemoComp>()
    ///     .Add((fun x -> x.Prop1), value1)
    ///     .Add((fun x -> x.Prop2), value2)
    /// )
    /// ```
    static member inline blazor<'T when 'T :> IComponent>(renderMode: IComponentRenderMode, attrBuilder: ComponentAttrBuilder<'T>) =
        html.blazor (typeof<'T>, renderMode, attr = attrBuilder.Build())


    /// This has to be used together with _framework/blazor.web.js.
    /// For more information please go to https://learn.microsoft.com/en-us/aspnet/core/blazor/components/rendering?view=aspnetcore-8.0#streaming-rendering
    static member inline streaming(node: NodeRenderFragment) =
        html.blazor<FunStreamingComponent> (nameof Unchecked.defaultof<FunStreamingComponent>.Content => node)
#endif


    /// Helper method to use 'Comp type to create an empty node for component
    static member inline fromBuilder<'Comp, 'T when 'Comp :> IComponentBuilder<'T>>(_: 'Comp) =
        NodeRenderFragment(fun _ builder index ->
            builder.OpenComponent<'T>(index)
            builder.CloseComponent()
            index + 1
        )

    /// Helper method to use elt's name to create an empty node for element
    static member inline fromBuilder<'Elt when 'Elt :> IElementBuilder>(elt: 'Elt) =
        NodeRenderFragment(fun _ builder index ->
            builder.OpenElement(index, elt.Name)
            builder.CloseElement()
            index + 1
        )


    /// Helper method to create blazor RednerFragment
    static member inline renderFragment([<InlineIfLambda>] render: NodeRenderFragment, ?comp: IComponent) =
        RenderFragment(fun tb -> render.Invoke(defaultArg comp null, tb, 0) |> ignore)

    /// Helper method to create blazor RednerFragment<'Item>
    static member inline renderFragment<'TItem>([<InlineIfLambda>] render: 'TItem -> NodeRenderFragment, ?comp: IComponent) =
        RenderFragment<'TItem>(fun x -> html.renderFragment (render x, comp = defaultArg comp null))


    /// Helper method for create attribute for convert NodeRenderFragment to Microsoft.AspNetCore.Components.RenderFragment
    static member inline renderFragment<'TItem>(name: string, [<InlineIfLambda>] render: 'TItem -> NodeRenderFragment) =
        AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(index, name, box (html.renderFragment (render, comp)))
            index + 1
        )

    /// Helper method for create attribute for convert NodeRenderFragment to Microsoft.AspNetCore.Components.RenderFragment
    static member inline renderFragment(name: string, fragment: NodeRenderFragment) =
        AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(index, name, box (html.renderFragment (fragment, comp)))
            index + 1
        )


    /// This will convert normal blazor RenderFragment to Fun Blazor node
    static member inline renderFragment(fragment: RenderFragment) =
        NodeRenderFragment(fun _ builder index ->
            builder.OpenRegion(index)
            fragment.Invoke(builder)
            builder.CloseRegion()
            index + 1
        )


    /// Helper method for create key attribute
    static member inline key k =
        AttrRenderFragment(fun _ builder index ->
            builder.SetKey k
#if DEBUG
            builder.AddAttribute(index, "FunBlazorDebugKey", box k)
            index + 1
#else
            index
#endif
        )

    /// Helper method for create ref attribute
    static member inline ref([<InlineIfLambda>] fn) =
        PostRenderFragment(fun _ builder index ->
            builder.AddElementReferenceCapture(index, Action<ElementReference> fn)
            index + 1
        )


    /// This is a helper method for create attributes for blazor bindable attribute which normally has two attributes, xxx and xxxChanged by convention.
    /// Be careful, the store change will not trigger the attribute to be re-render. This is used to update the store when the attribute is changed.
    /// This is normally used as a helper method for generated DSL.
    static member inline bind<'T>(name: string, store: cval<'T>) =
        AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(index, name, store.Value)
            builder.AddAttribute(
                index + 1,
                name + "Changed",
                EventCallback.Factory.Create(comp, Action<'T>(fun x -> transact (fun () -> store.Value <- x)))
            )
            index + 2
        )

    /// This is a helper method for create attributes for blazor bindable attribute which normally has two attributes, xxx and xxxChanged by convention.
    /// This is normally used as a helper method for generated DSL.
    static member inline bind<'T>(name: string, (value: 'T, fn: 'T -> unit)) =
        AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(index, name, value)
            builder.AddAttribute(index + 1, name + "Changed", EventCallback.Factory.Create(comp, Action<'T> fn))
            index + 2
        )


    /// Helper method for create callback attribute
    static member inline callback<'T>(eventName, [<InlineIfLambda>] fn: 'T -> unit) =
        AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(index, eventName, EventCallback.Factory.Create(comp, Action<'T> fn))
            index + 1
        )

    /// Helper method for create callback attribute
    static member inline callback(eventName, [<InlineIfLambda>] fn: unit -> unit) =
        AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(index, eventName, EventCallback.Factory.Create(comp, Action fn))
            index + 1
        )

    /// Helper method for create callback attribute
    static member inline callbackTask<'T>(eventName, [<InlineIfLambda>] fn: 'T -> Task) =
        AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(index, eventName, EventCallback.Factory.Create(comp, Func<'T, Task>(fun x -> fn x)))
            index + 1
        )

    /// Helper method for create callback attribute
    static member inline callbackTask<'T>(eventName, [<InlineIfLambda>] fn: 'T -> Task<unit>) =
        AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(index, eventName, EventCallback.Factory.Create(comp, Func<'T, Task>(fun x -> fn x :> Task)))
            index + 1
        )

    /// Helper method for create callback attribute
    static member inline callbackTask(eventName, [<InlineIfLambda>] fn: unit -> Task<unit>) =
        AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(index, eventName, EventCallback.Factory.Create(comp, Func<Task>(fun () -> fn () :> Task)))
            index + 1
        )


    /// This is for pure static html markup
    static member inline raw(x: string) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddMarkupContent(index, x)
            index + 1
        )


    static member inline text(x: obj) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, x)
            index + 1
        )


#if !NET6_0
    /// Render a node as string, logging must be registered in the service collection
    static member renderAsString (serviceProvider: IServiceProvider) (node: NodeRenderFragment) = task {
        let loggerFactory = serviceProvider.GetRequiredService<ILoggerFactory>()
        use htmlRenderer = new HtmlRenderer(serviceProvider, loggerFactory)
        return!
            htmlRenderer.Dispatcher.InvokeAsync<string>(fun () -> task {
                let dict = Internal.dictionaryPool.Get()
                try
                    dict["Fragment"] <- node
                    let parameters = ParameterView.FromDictionary(dict)
                    let! output = htmlRenderer.RenderComponentAsync<FunFragmentComponent>(parameters)
                    return output.ToHtmlString()
                finally
                    Internal.dictionaryPool.Return dict
            })
    }
#endif


type Static =

    /// This is for pure static html markup
    static member inline html(x: string) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddMarkupContent(index, x)
            index + 1
        )
