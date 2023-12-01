namespace Fun.Blazor

open System
open System.Threading.Tasks
open FSharp.Data.Adaptive
open Microsoft.AspNetCore.Components
open Operators
open Internal


type html() =

    /// Helper method to create an empty node
    static member inline none = emptyNode ()

    /// Helper method to create an empty attribute
    static member inline emptyAttr = emptyAttr ()

    static member mergeAttrs attrs = attrs |> Seq.fold (==>) (emptyAttr ())
    static member mergeNodes nodes = nodes |> Seq.fold (>=>) (emptyNode ())

    /// Helper method to make put multiple nodes into a fragment node
    static member inline fragment(nodes: NodeRenderFragment seq) = html.region nodes


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
    ///     html.region [
    ///         if errors |> List.isEmpty |> not then
    ///             MudText'() {
    ///                 Color Color.Error
    ///                 Typo Typo.caption
    ///                 simplifyErrors errors
    ///             }
    ///     ]
    /// ```
    static member region(nodes: NodeRenderFragment seq) =
        NodeRenderFragment(fun comp builder sequence ->
            builder.OpenRegion(sequence)

            nodes |> Seq.fold (fun i node -> node.Invoke(comp, builder, i)) 0 |> ignore

            builder.CloseRegion()
            sequence + 1
        )


    /// <summary>
    /// Make a blazor component to a render fragment with a render for attributes
    /// You can open Fun.Blazor.Operators to build attribute very easily:
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// html.blazor<DemoComp> (domAttr {
    ///     "attrName1", attrValue1
    ///     "attrName2", attrValue2
    ///     "attrName3", attrValue3
    /// })
    /// </code>
    /// </example>
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

    /// <summary>
    /// Make a blazor component to a render fragment with a render for attributes
    /// You can open Fun.Blazor.Operators to build attribute very easily:
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// html.blazor<DemoComp> (domAttr {
    ///     "attrName1", attrValue1
    ///     "attrName2", attrValue2
    ///     "attrName3", attrValue3
    /// })
    /// </code>
    /// </example>
    static member inline blazor<'T when 'T :> IComponent>(?render: AttrRenderFragment) =
        html.blazor(typeof<'T>, attr = defaultArg render (emptyAttr()))

    /// <summary>
    /// Make a blazor component to a render fragment with a render for attributes
    /// You can open Fun.Blazor.Operators to build attribute very easily:
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// html.blazor (ComponentAttrBuilder<DemoComp>()
    ///     .Add((fun x -> x.Prop1), value1)
    ///     .Add((fun x -> x.Prop2), value2)
    /// )
    /// </code>
    /// </example>
    static member inline blazor<'T when 'T :> IComponent>(attrBuilder: ComponentAttrBuilder<'T>) =
        html.blazor(typeof<'T>, attr = attrBuilder.Build())


#if !NET6_0
    /// <summary>
    /// Make a blazor component to a render fragment with a render for attributes
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// html.blazor<DemoComp> (RenderModeServer, domAttr {
    ///     "attrName1", attrValue1
    ///     "attrName2", attrValue2
    /// })
    /// </code>
    /// </example>
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

    /// <summary>
    /// Make a blazor component to a render fragment with a render for attributes
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// html.blazor<DemoComp> (RenderModeServer, domAttr {
    ///     "attrName1", attrValue1
    ///     "attrName2", attrValue2
    /// })
    /// </code>
    /// </example>
    static member inline blazor<'T when 'T :> IComponent>(renderMode: IComponentRenderMode, ?attr: AttrRenderFragment) =
        html.blazor(typeof<'T>, renderMode, attr = defaultArg attr (emptyAttr()))

    /// <summary>
    /// Make a blazor component to a render fragment with a render for attributes
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// html.blazor (RenderModeServer, ComponentAttrBuilder<DemoComp>()
    ///     .Add((fun x -> x.Prop1), value1)
    ///     .Add((fun x -> x.Prop2), value2)
    /// )
    /// </code>
    /// </example>
    static member inline blazor<'T when 'T :> IComponent>(renderMode: IComponentRenderMode, attrBuilder: ComponentAttrBuilder<'T>) =
        html.blazor(typeof<'T>, renderMode, attr = attrBuilder.Build())


    /// This has to be used together with _framework/blazor.web.js. 
    /// For more information please go to https://learn.microsoft.com/en-us/aspnet/core/blazor/components/rendering?view=aspnetcore-8.0#streaming-rendering
    static member inline streaming (node: NodeRenderFragment) =
        html.blazor<FunStreamingComponent>(nameof Unchecked.defaultof<FunStreamingComponent>.Content => node)
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


    /// Helper method for create attribute for convert NodeRenderFragment to Microsoft.AspNetCore.Components.RenderFragment
    static member inline renderFragment<'TItem>(name: string, [<InlineIfLambda>] render: 'TItem -> NodeRenderFragment) =
        AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(
                index,
                name,
                box (
                    Microsoft.AspNetCore.Components.RenderFragment<'TItem>(fun x ->
                        Microsoft.AspNetCore.Components.RenderFragment(fun tb -> render(x).Invoke(comp, tb, 0) |> ignore)
                    )
                )
            )
            index + 1
        )

    /// Helper method for create attribute for convert NodeRenderFragment to Microsoft.AspNetCore.Components.RenderFragment
    static member inline renderFragment(name: string, fragment: NodeRenderFragment) =
        AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(index, name, box (Microsoft.AspNetCore.Components.RenderFragment(fun tb -> fragment.Invoke(comp, tb, 0) |> ignore)))
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
    static member inline ref(fn) =
        PostRenderFragment(fun _ builder index ->
            builder.AddElementReferenceCapture(index, Action<ElementReference> fn)
            index + 1
        )


    /// This is a helper method for create attributes for blazor bindable attribute which normally has two attributes, xxx and xxxChanged by convention. 
    /// Be careful, the store change will not trigger the attribute to be re-render. This is used to update the store when the attribute is changed.
    /// This is normally used as a helper method for generated DSL.
    static member bind<'T>(name: string, store: cval<'T>) =
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
    static member bind<'T>(name: string, (value: 'T, fn: 'T -> unit)) =
        AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(index, name, value)
            builder.AddAttribute(index + 1, name + "Changed", EventCallback.Factory.Create(comp, Action<'T> fn))
            index + 2
        )


    /// Helper method for create callback attribute
    static member inline callback<'T>(eventName, fn: 'T -> unit) =
        AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(index, eventName, EventCallback.Factory.Create(comp, Action<'T> fn))
            index + 1
        )

    /// Helper method for create callback attribute
    static member inline callback(eventName, fn: unit -> unit) =
        AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(index, eventName, EventCallback.Factory.Create(comp, Action fn))
            index + 1
        )

    /// Helper method for create callback attribute
    static member inline callbackTask<'T>(eventName, fn: 'T -> Task<unit>) =
        AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(index, eventName, EventCallback.Factory.Create(comp, Func<'T, Task>(fun x -> fn x :> Task)))
            index + 1
        )

    /// Helper method for create callback attribute
    static member inline callbackTask(eventName, fn: unit -> Task<unit>) =
        AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(index, eventName, EventCallback.Factory.Create(comp, Func<Task>(fun () -> fn () :> Task)))
            index + 1
        )


    static member inline raw x =
        NodeRenderFragment(fun _ builder index ->
            builder.AddMarkupContent(index, x)
            index + 1
        )


    static member inline text(x: int) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, box x)
            index + 1
        )

    static member inline text(x: float) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, box x)
            index + 1
        )

    static member inline text(x: Guid) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, string x)
            index + 1
        )

    static member inline text(x: string) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, x)
            index + 1
        )


    static member inline style(x: string) = "style" =>> x
    static member inline styles(x) = "style" =>> makeStyles x
    static member inline class'(x: string) = "class" =>> x
    static member inline classes(x: string seq) = "class" =>> (String.concat " " x)


type Static =

    /// This is for pure static html markup
    static member html(x: string) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddMarkupContent(index, x)
            index + 1
        )
