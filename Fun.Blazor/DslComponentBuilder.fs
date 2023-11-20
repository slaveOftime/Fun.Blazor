namespace Fun.Blazor

open System
open System.Threading.Tasks
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Web
open Operators
open Internal


type ComponentBuilder<'T when 'T :> Microsoft.AspNetCore.Components.IComponent>() =

    interface IComponentBuilder<'T>


    member inline _.Run([<InlineIfLambda>] render: AttrRenderFragment) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent<'T>(index)
            let nextIndex = render.Invoke(comp, builder, index + 1)
            builder.CloseComponent()
            nextIndex
        )
    

    member inline _.Run((render1, render2): struct (AttrRenderFragment * PostRenderFragment)) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent<'T>(index)
            let nextIndex = (render1 ===> render2).Invoke(comp, builder, index + 1)
            builder.CloseComponent()
            nextIndex
        )


    member inline _.Run(AttrRenderFragmentWrapper x) = x


    member inline _.Yield(_: unit) = emptyAttr ()

    member inline _.Yield([<InlineIfLambda>] x: AttrRenderFragment) = x


    member inline _.Yield((key, value): string * string) =
        AttrRenderFragment(fun _ builder index ->
            builder.AddAttribute(index, key, value)
            index + 1
        )

    member inline _.Yield((key, value): string * int) =
        AttrRenderFragment(fun _ builder index ->
            builder.AddAttribute(index, key, value)
            index + 1
        )

    member inline _.Yield((key, value): string * float) =
        AttrRenderFragment(fun _ builder index ->
            builder.AddAttribute(index, key, value)
            index + 1
        )

    member inline _.Yield((key, value): string * bool) =
        AttrRenderFragment(fun _ builder index ->
            builder.AddAttribute(index, key, value)
            index + 1
        )


    member inline _.Yield((key, fn): string * (unit -> unit)) = html.callback (key, fn)
    member inline _.Yield((key, fn): string * ('T -> unit)) = html.callback (key, fn)
    member inline _.Yield((key, fn): string * (unit -> Task<unit>)) = html.callbackTask (key, fn)
    member inline _.Yield((key, fn): string * ('T -> Task<unit>)) = html.callbackTask (key, fn)


    member inline _.Delay([<InlineIfLambda>] fn: unit -> AttrRenderFragment) = AttrRenderFragment(fun c b i -> fn().Invoke(c, b, i))
    member inline _.Delay([<InlineIfLambda>] fn: unit -> AttrRenderFragmentWrapper) = fn ()
    member inline _.Delay([<InlineIfLambda>] fn: unit -> struct (AttrRenderFragment * PostRenderFragment)) = fn ()

    member inline _.Combine([<InlineIfLambda>] render1: AttrRenderFragment, [<InlineIfLambda>] render2: AttrRenderFragment) = render1 ==> render2

    member inline _.For([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> AttrRenderFragment) = render ==> (fn ())

    //member inline _.For(renders: 'T seq, [<InlineIfLambda>] fn: 'T -> AttrRenderFragment) =
    //    renders |> Seq.map fn |> Seq.fold (==>) (emptyAttr ())

    member inline _.YieldFrom(renders: AttrRenderFragment seq) = renders |> Seq.fold (==>) (emptyAttr ())


    member inline _.Zero() = emptyAttr ()


    /// key for blazor
    [<CustomOperation("key")>]
    member inline _.key([<InlineIfLambda>] render: AttrRenderFragment, k) = render ==> html.key k

    [<CustomOperation("ref")>]
    member inline _.ref([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> unit) =
        struct (render, PostRenderFragment(fun _ builder index ->
            builder.AddComponentReferenceCapture(index, (fun x -> fn (unbox<'T> x)))
            index + 1
        ))

    [<CustomOperation("ref")>]
    member inline _.ref((render1, render2): struct (AttrRenderFragment * PostRenderFragment), [<InlineIfLambda>] fn: 'T -> unit) =
        struct (render1, PostRenderFragment(fun comp builder index ->
            let nextIndex = render2.Invoke(comp, builder, index)
            builder.AddComponentReferenceCapture(nextIndex, (fun x -> fn (unbox<'T> x)))
            nextIndex + 1
        ))


#if !NET6_0
    [<CustomOperation("renderMode")>]
    member inline _.renderMode([<InlineIfLambda>] render: AttrRenderFragment, mode: IComponentRenderMode) =
        struct (render, PostRenderFragment(fun _ builder index ->
            builder.AddComponentRenderMode(mode)
            index
        ))

    [<CustomOperation("interactiveAuto")>]
    member inline this.interactiveAuto([<InlineIfLambda>] render: AttrRenderFragment) = this.renderMode (render, RenderMode.InteractiveAuto)

    [<CustomOperation("interactiveServer")>]
    member inline this.interactiveServer([<InlineIfLambda>] render: AttrRenderFragment) = this.renderMode (render, RenderMode.InteractiveServer)

    [<CustomOperation("interactiveWebAssembly")>]
    member inline this.interactiveWebAssembly([<InlineIfLambda>] render: AttrRenderFragment) = this.renderMode (render, RenderMode.InteractiveWebAssembly)


    [<CustomOperation("renderMode")>]
    member inline _.renderMode((render1, render2): struct (AttrRenderFragment * PostRenderFragment), mode: IComponentRenderMode) =
        struct (render1, PostRenderFragment(fun comp builder index ->
            let nextIndex = render2.Invoke(comp, builder, index)
            builder.AddComponentRenderMode(mode)
            nextIndex
        ))

    [<CustomOperation("interactiveAuto")>]
    member inline this.interactiveAuto(renders: struct (AttrRenderFragment * PostRenderFragment)) = this.renderMode (renders, RenderMode.InteractiveAuto)

    [<CustomOperation("interactiveServer")>]
    member inline this.interactiveServer(renders: struct (AttrRenderFragment * PostRenderFragment)) = this.renderMode (renders, RenderMode.InteractiveServer)

    [<CustomOperation("interactiveWebAssembly")>]
    member inline this.interactiveWebAssembly(renders: struct (AttrRenderFragment * PostRenderFragment)) = this.renderMode (renders, RenderMode.InteractiveWebAssembly)


    /// Enhanced navigation is enabled by default, but it can be controlled hierarchically and on a per-link basis using the data-enhance-nav HTML attribute.
    [<CustomOperation("dataEnhanceNav")>]
    member inline _.dataEnhanceNav([<InlineIfLambda>] render: AttrRenderFragment, value: bool) =
        render ==> ("data-enhance-nav" => (if value then "true" else "false"))

    /// Enhanced navigation is enabled by default, but it can be controlled hierarchically and on a per-link basis using the data-enhance-nav HTML attribute.
    [<CustomOperation("dataEnhanceNav")>]
    member inline this.dataEnhanceNav([<InlineIfLambda>] render: AttrRenderFragment) = this.dataEnhanceNav(render, true)

    /// Blazor's enhanced navigation and form handing may undo dynamic changes to the DOM if the updated content isn't part of the server rendering. To preserve the content of an element, use the data-permanent attribute.
    [<CustomOperation("dataPermanent")>]
    member inline _.dataPermanent([<InlineIfLambda>] render: AttrRenderFragment, value: bool) =
        render ==> ("permanent" => (if value then "true" else "false"))

    /// Blazor's enhanced navigation and form handing may undo dynamic changes to the DOM if the updated content isn't part of the server rendering. To preserve the content of an element, use the data-permanent attribute.
    [<CustomOperation("dataPermanent")>]
    member inline this.dataPermanent([<InlineIfLambda>] render: AttrRenderFragment) = this.dataPermanent(render, true)
#endif


    [<CustomOperation("callback")>]
    member inline _.callback([<InlineIfLambda>] render: AttrRenderFragment, eventName, [<InlineIfLambda>] callback: 'T -> unit) =
        render
        ==> AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(index, eventName, EventCallback.Factory.Create(comp, Action<'T> callback))
            index + 1
        )

    [<CustomOperation("callback")>]
    member inline _.callback([<InlineIfLambda>] render: AttrRenderFragment, eventName, [<InlineIfLambda>] callback: 'T -> Task) =
        render
        ==> AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(index, eventName, EventCallback.Factory.Create(comp, Func<'T, Task> callback))
            index + 1
        )

    [<CustomOperation("preventDefault")>]
    member inline _.preventDefault([<InlineIfLambda>] render: AttrRenderFragment, eventName, value) =
        render
        ==> AttrRenderFragment(fun _ builder index ->
            builder.AddEventPreventDefaultAttribute(index, eventName, value)
            index + 1
        )

    [<CustomOperation("stopPropagation")>]
    member inline _.stopPropagation([<InlineIfLambda>] render: AttrRenderFragment, eventName, value) =
        render
        ==> AttrRenderFragment(fun _ builder index ->
            builder.AddEventPreventDefaultAttribute(index, eventName, value)
            index + 1
        )

    [<CustomOperation("asAttrRenderFragment")>]
    member inline _.asAttrRenderFragment(x: AttrRenderFragment) = AttrRenderFragmentWrapper x


    static member inline create() =
        NodeRenderFragment(fun _ builder index ->
            builder.OpenComponent<'T>(index)
            builder.CloseComponent()
            index + 1
        )


type ComponentWithChildBuilder<'T when 'T :> IComponent>() =
    inherit ComponentBuilder<'T>()


    member inline _.Run([<InlineIfLambda>] render: NodeRenderFragment) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent<'T>(index)
            builder.AddAttribute(index + 1, "ChildContent", RenderFragment(fun tb -> render.Invoke(comp, tb, 0) |> ignore))
            builder.CloseComponent()
            index + 2
        )

    /// We should handle this because in Blazor, component need an Attribute called ChildContent for its child elements or components.
    /// So we cannot merge AttrRenderFragment and NodeRenderFragment directly.
    /// Instead, we should first invoke AttrRenderFragment then add ChildContent RenderFragment as attribute and switch builder context.
    /// Other method like Delay, For, Combine should also have appropriate implementation to seperate Attr and Node so we can Invoke them standalone.
    member inline _.Run((render1, render2): struct (AttrRenderFragment * NodeRenderFragment)) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent<'T>(index)
            let nextIndex = render1.Invoke(comp, builder, index + 1)
            builder.AddAttribute(nextIndex, "ChildContent", RenderFragment(fun tb -> render2.Invoke(comp, tb, 0) |> ignore))
            builder.CloseComponent()
            nextIndex + 1
        )

    member inline _.Run((render1, render2, render3): struct (AttrRenderFragment * PostRenderFragment * NodeRenderFragment)) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent<'T>(index)
            let nextIndex = index + 1
            let nextIndex = render1.Invoke(comp, builder, nextIndex)
            builder.AddAttribute(nextIndex, "ChildContent", RenderFragment(fun tb -> render3.Invoke(comp, tb, 0) |> ignore))
            let nextIndex = nextIndex + 1
            let nextIndex = render2.Invoke(comp, builder, nextIndex)
            builder.CloseComponent()
            nextIndex
        )


    member inline _.Yield(x: int) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, x)
            index + 1
        )

    member inline _.Yield(x: string) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, x)
            index + 1
        )

    member inline _.Yield(x: float) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, x)
            index + 1
        )

    member inline _.Yield<'Elt when 'Elt :> IElementBuilder>(x: 'Elt) =
        NodeRenderFragment(fun _ builder index ->
            builder.OpenElement(index, x.Name)
            builder.CloseElement()
            index + 1
        )

    member inline _.Yield<'Comp, 'T1 when 'Comp :> IComponentBuilder<'T1>>(_: 'Comp) =
        NodeRenderFragment(fun _ builder index ->
            builder.OpenComponent<'T1>(index)
            builder.CloseComponent()
            index + 1
        )

    member inline _.Yield(x: RenderFragment) = html.renderFragment x
    
    member inline _.Yield([<InlineIfLambda>] x: NodeRenderFragment) = x

    member inline _.Delay([<InlineIfLambda>] fn: unit -> NodeRenderFragment) = NodeRenderFragment(fun c b i -> fn().Invoke(c, b, i))
    member inline _.Delay([<InlineIfLambda>] fn: unit -> struct (AttrRenderFragment * NodeRenderFragment)) = fn ()
    member inline _.Delay([<InlineIfLambda>] fn: unit -> struct (AttrRenderFragment * PostRenderFragment * NodeRenderFragment)) = fn ()

    /// We should only allow merge AttrRenderFragment with NodeRenderFragment.
    /// Instead of merge NodeRenderFragment with AttrRenderFragment because blazor only allow add attribute then child.
    /// Also it is clear for the DSL
    member inline _.Combine([<InlineIfLambda>] render1: AttrRenderFragment, [<InlineIfLambda>] render2: NodeRenderFragment) = struct (render1, render2)

    member inline _.Combine([<InlineIfLambda>] render1: NodeRenderFragment, [<InlineIfLambda>] render2: NodeRenderFragment) = render1 >=> render2

    member inline _.For([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> NodeRenderFragment) = struct (render, fn ())

    member inline _.For([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> struct (AttrRenderFragment * NodeRenderFragment)) =
        let struct (attr, node) = fn ()
        struct (attr ==> render, node)

    member inline _.For((render1, render2): struct (AttrRenderFragment * PostRenderFragment), [<InlineIfLambda>] fn: unit -> NodeRenderFragment) = struct (render1, render2, fn())

    member inline _.For(renders: 'Data seq, [<InlineIfLambda>] fn: 'Data -> NodeRenderFragment) = renders |> Seq.map fn |> Seq.fold (>=>) (emptyNode ()) |> html.region

    member inline _.YieldFrom(renders: NodeRenderFragment seq) = renders |> Seq.fold (>=>) (emptyNode ()) |> html.region

    member inline _.Zero() = emptyNode ()


    [<CustomOperation("childContent")>]
    member inline _.childContent([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] renderChild: NodeRenderFragment) =
        render ==> html.renderFragment ("ChildContent", renderChild)

    [<CustomOperation("childContent")>]
    [<Obsolete "This is not recommend, please use fragment or remove childContent and yield your content directly.">]
    member inline _.childContent([<InlineIfLambda>] render: AttrRenderFragment, renders: NodeRenderFragment seq) =
        render ==> html.renderFragment ("ChildContent", html.region renders)

    [<CustomOperation("childContent")>]
    member inline _.childContent([<InlineIfLambda>] render: AttrRenderFragment, v: string) =
        render ==> html.renderFragment ("ChildContent", html.text v)

    [<CustomOperation("childContent")>]
    member inline _.childContent([<InlineIfLambda>] render: AttrRenderFragment, v: int) =
        render ==> html.renderFragment ("ChildContent", html.text v)

    [<CustomOperation("childContent")>]
    member inline _.childContent([<InlineIfLambda>] render: AttrRenderFragment, v: float) =
        render ==> html.renderFragment ("ChildContent", html.text v)


    [<CustomOperation("childContent")>]
    member inline _.childContent((render1, render2): struct (AttrRenderFragment * PostRenderFragment), [<InlineIfLambda>] renderChild: NodeRenderFragment) =
        struct (render1, render2, renderChild)

    [<CustomOperation("childContent")>]
    member inline _.childContent((render1, render2): struct (AttrRenderFragment * PostRenderFragment), renders: NodeRenderFragment seq) =
        struct (render1, render2, html.region renders)

    [<CustomOperation("childContent")>]
    member inline _.childContent((render1, render2): struct (AttrRenderFragment * PostRenderFragment), v: string) =
        struct (render1, render2, html.text v)

    [<CustomOperation("childContent")>]
    member inline _.childContent((render1, render2): struct (AttrRenderFragment * PostRenderFragment), v: int) =
        struct (render1, render2, html.text v)

    [<CustomOperation("childContent")>]
    member inline _.childContent((render1, render2): struct (AttrRenderFragment * PostRenderFragment), v: float) =
        struct (render1, render2, html.text v)


    static member inline create(x: int) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent<'T>(index)
            let nextIndex =
                html.renderFragment("ChildContent", html.text x).Invoke(comp, builder, index + 1)
            builder.CloseComponent()
            nextIndex
        )

    static member inline create(x: string) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent<'T>(index)
            let nextIndex =
                html.renderFragment("ChildContent", html.text x).Invoke(comp, builder, index + 1)
            builder.CloseComponent()
            nextIndex
        )

    static member inline create(x: float) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent<'T>(index)
            let nextIndex =
                html.renderFragment("ChildContent", html.text x).Invoke(comp, builder, index + 1)
            builder.CloseComponent()
            nextIndex
        )

    static member inline create(x: NodeRenderFragment) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent<'T>(index)
            let nextIndex =
                html.renderFragment("ChildContent", x).Invoke(comp, builder, index + 1)
            builder.CloseComponent()
            nextIndex
        )

    static member inline create(x: NodeRenderFragment seq) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent<'T>(index)
            let nextIndex =
                html.renderFragment("ChildContent", html.fragment x).Invoke(comp, builder, index + 1)
            builder.CloseComponent()
            nextIndex
        )


type ComponentWithDomAttrBuilder<'T when 'T :> IComponent>() =
    inherit DomAttrBuilder()

    interface IComponentBuilder<'T>


    member inline _.Run([<InlineIfLambda>] render: AttrRenderFragment) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent<'T>(index)
            let nextIndex = render.Invoke(comp, builder, index + 1)
            builder.CloseComponent()
            nextIndex
        )
    
    member inline _.Run((render1, render2): struct (AttrRenderFragment * PostRenderFragment)) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent<'T>(index)
            let nextIndex = (render1 ===> render2).Invoke(comp, builder, index + 1)
            builder.CloseComponent()
            nextIndex
        )


    [<CustomOperation("ref")>]
    member inline _.ref([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> unit) =
        struct (render, PostRenderFragment(fun _ builder index ->
            builder.AddComponentReferenceCapture(index, (fun x -> fn (unbox<'T> x)))
            index + 1
        ))

    [<CustomOperation("ref")>]
    member inline _.ref((render1, render2): struct (AttrRenderFragment * PostRenderFragment), [<InlineIfLambda>] fn: 'T -> unit) =
        struct (render1, PostRenderFragment(fun comp builder index ->
            let nextIndex = render2.Invoke(comp, builder, index)
            builder.AddComponentReferenceCapture(nextIndex, (fun x -> fn (unbox<'T> x)))
            nextIndex + 1
        ))


#if !NET6_0
    [<CustomOperation("renderMode")>]
    member inline _.renderMode([<InlineIfLambda>] render: AttrRenderFragment, mode: IComponentRenderMode) =
        struct (render, PostRenderFragment(fun _ builder index ->
            builder.AddComponentRenderMode(mode)
            index
        ))

    [<CustomOperation("interactiveAuto")>]
    member inline this.interactiveAuto([<InlineIfLambda>] render: AttrRenderFragment) = this.renderMode (render, RenderMode.InteractiveAuto)

    [<CustomOperation("interactiveServer")>]
    member inline this.interactiveServer([<InlineIfLambda>] render: AttrRenderFragment) = this.renderMode (render, RenderMode.InteractiveServer)

    [<CustomOperation("interactiveWebAssembly")>]
    member inline this.interactiveWebAssembly([<InlineIfLambda>] render: AttrRenderFragment) = this.renderMode (render, RenderMode.InteractiveWebAssembly)


    [<CustomOperation("renderMode")>]
    member inline _.renderMode((render1, render2): struct (AttrRenderFragment * PostRenderFragment), mode: IComponentRenderMode) =
        struct (render1, PostRenderFragment(fun comp builder index ->
            let nextIndex = render2.Invoke(comp, builder, index)
            builder.AddComponentRenderMode(mode)
            nextIndex
        ))

    [<CustomOperation("interactiveAuto")>]
    member inline this.interactiveAuto(renders: struct (AttrRenderFragment * PostRenderFragment)) = this.renderMode (renders, RenderMode.InteractiveAuto)

    [<CustomOperation("interactiveServer")>]
    member inline this.interactiveServer(renders: struct (AttrRenderFragment * PostRenderFragment)) = this.renderMode (renders, RenderMode.InteractiveServer)

    [<CustomOperation("interactiveWebAssembly")>]
    member inline this.interactiveWebAssembly(renders: struct (AttrRenderFragment * PostRenderFragment)) = this.renderMode (renders, RenderMode.InteractiveWebAssembly)
#endif


    member inline _.Delay([<InlineIfLambda>] fn: unit -> struct (AttrRenderFragment * PostRenderFragment)) = fn ()


    static member inline create() =
        NodeRenderFragment(fun _ builder index ->
            builder.OpenComponent<'T>(index)
            builder.CloseComponent()
            index + 1
        )


type ComponentWithDomAndChildAttrBuilder<'T when 'T :> IComponent>() =
    inherit ComponentWithDomAttrBuilder<'T>()

    member inline _.Run([<InlineIfLambda>] render: NodeRenderFragment) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent<'T>(index)
            builder.AddAttribute(index + 1, "ChildContent", RenderFragment(fun tb -> render.Invoke(comp, tb, 0) |> ignore))
            builder.CloseComponent()
            index + 2
        )

    /// We should handle this because in Blazor, component need an Attribute called ChildContent for its child elements or components.
    /// So we cannot merge AttrRenderFragment and NodeRenderFragment directly.
    /// Instead, we should first invoke AttrRenderFragment then add ChildContent RenderFragment as attribute and switch builder context.
    /// Other method like Delay, For, Combine should also have appropriate implementation to seperate Attr and Node so we can Invoke them standalone.
    member inline _.Run((render1, render2): struct (AttrRenderFragment * NodeRenderFragment)) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent<'T>(index)
            let nextIndex = render1.Invoke(comp, builder, index + 1)
            builder.AddAttribute(nextIndex, "ChildContent", RenderFragment(fun tb -> render2.Invoke(comp, tb, 0) |> ignore))
            builder.CloseComponent()
            nextIndex + 1
        )

    member inline _.Run((render1, render2, render3): struct (AttrRenderFragment * PostRenderFragment * NodeRenderFragment)) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent<'T>(index)
            let nextIndex = index + 1
            let nextIndex = render1.Invoke(comp, builder, nextIndex)
            builder.AddAttribute(nextIndex, "ChildContent", RenderFragment(fun tb -> render3.Invoke(comp, tb, 0) |> ignore))
            let nextIndex = nextIndex + 1
            let nextIndex = render2.Invoke(comp, builder, nextIndex)
            builder.CloseComponent()
            nextIndex
        )


    member inline _.Yield(x: int) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, x)
            index + 1
        )

    member inline _.Yield(x: string) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, x)
            index + 1
        )

    member inline _.Yield(x: float) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, x)
            index + 1
        )

    member inline _.Yield<'Elt when 'Elt :> IElementBuilder>(x: 'Elt) =
        NodeRenderFragment(fun _ builder index ->
            builder.OpenElement(index, x.Name)
            builder.CloseElement()
            index + 1
        )

    member inline _.Yield<'Comp, 'T1 when 'Comp :> IComponentBuilder<'T1>>(_: 'Comp) =
        NodeRenderFragment(fun _ builder index ->
            builder.OpenComponent<'T1>(index)
            builder.CloseComponent()
            index + 1
        )

    member inline _.Yield([<InlineIfLambda>] x: NodeRenderFragment) = x

    member inline _.Delay([<InlineIfLambda>] fn: unit -> NodeRenderFragment) = NodeRenderFragment(fun c b i -> fn().Invoke(c, b, i))
    member inline _.Delay([<InlineIfLambda>] fn: unit -> struct (AttrRenderFragment * NodeRenderFragment)) = fn ()
    member inline _.Delay([<InlineIfLambda>] fn: unit -> struct (AttrRenderFragment * PostRenderFragment * NodeRenderFragment)) = fn ()

    /// We should only allow merge AttrRenderFragment with NodeRenderFragment.
    /// Instead of merge NodeRenderFragment with AttrRenderFragment because blazor only allow add attribute then child.
    /// Also it is clear for the DSL
    member inline _.Combine([<InlineIfLambda>] render1: AttrRenderFragment, [<InlineIfLambda>] render2: NodeRenderFragment) = struct (render1, render2)

    member inline _.Combine([<InlineIfLambda>] render1: NodeRenderFragment, [<InlineIfLambda>] render2: NodeRenderFragment) = render1 >=> render2

    member inline _.For([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> NodeRenderFragment) = struct (render, fn ())

    member inline _.For([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> struct (AttrRenderFragment * NodeRenderFragment)) =
        let struct (attr, node) = fn ()
        struct (attr ==> render, node)

    member inline _.For((render1, render2): struct (AttrRenderFragment * PostRenderFragment), [<InlineIfLambda>] fn: unit -> NodeRenderFragment) = struct (render1, render2, fn())

    member inline _.For(renders: 'Data seq, [<InlineIfLambda>] fn: 'Data -> NodeRenderFragment) = renders |> Seq.map fn |> Seq.fold (>=>) (emptyNode ()) |> html.region

    member inline _.YieldFrom(renders: NodeRenderFragment seq) = renders |> Seq.fold (>=>) (emptyNode ()) |> html.region

    member inline _.Zero() = emptyNode ()


    [<CustomOperation("childContent")>]
    member inline _.childContent([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] renderChild: NodeRenderFragment) =
        render ==> html.renderFragment ("ChildContent", renderChild)

    [<CustomOperation("childContent")>]
    member inline _.childContent([<InlineIfLambda>] render: AttrRenderFragment, renders: NodeRenderFragment seq) =
        render ==> html.renderFragment ("ChildContent", html.region renders)

    [<CustomOperation("childContent")>]
    member inline _.childContent([<InlineIfLambda>] render: AttrRenderFragment, v: string) =
        render ==> html.renderFragment ("ChildContent", html.text v)

    [<CustomOperation("childContent")>]
    member inline _.childContent([<InlineIfLambda>] render: AttrRenderFragment, v: int) =
        render ==> html.renderFragment ("ChildContent", html.text v)

    [<CustomOperation("childContent")>]
    member inline _.childContent([<InlineIfLambda>] render: AttrRenderFragment, v: float) =
        render ==> html.renderFragment ("ChildContent", html.text v)


    [<CustomOperation("childContent")>]
    member inline _.childContent((render1, render2): struct (AttrRenderFragment * PostRenderFragment), [<InlineIfLambda>] renderChild: NodeRenderFragment) =
        struct (render1, render2, renderChild)

    [<CustomOperation("childContent")>]
    member inline _.childContent((render1, render2): struct (AttrRenderFragment * PostRenderFragment), renders: NodeRenderFragment seq) =
        struct (render1, render2, html.region renders)

    [<CustomOperation("childContent")>]
    member inline _.childContent((render1, render2): struct (AttrRenderFragment * PostRenderFragment), v: string) =
        struct (render1, render2, html.text v)

    [<CustomOperation("childContent")>]
    member inline _.childContent((render1, render2): struct (AttrRenderFragment * PostRenderFragment), v: int) =
        struct (render1, render2, html.text v)

    [<CustomOperation("childContent")>]
    member inline _.childContent((render1, render2): struct (AttrRenderFragment * PostRenderFragment), v: float) =
        struct (render1, render2, html.text v)


    static member inline create(x: int) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent<'T>(index)
            let nextIndex =
                html.renderFragment("ChildContent", html.text x).Invoke(comp, builder, index + 1)
            builder.CloseComponent()
            nextIndex
        )

    static member inline create(x: string) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent<'T>(index)
            let nextIndex =
                html.renderFragment("ChildContent", html.text x).Invoke(comp, builder, index + 1)
            builder.CloseComponent()
            nextIndex
        )

    static member inline create(x: float) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent<'T>(index)
            let nextIndex =
                html.renderFragment("ChildContent", html.text x).Invoke(comp, builder, index + 1)
            builder.CloseComponent()
            nextIndex
        )

    static member inline create(x: NodeRenderFragment) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent<'T>(index)
            let nextIndex =
                html.renderFragment("ChildContent", x).Invoke(comp, builder, index + 1)
            builder.CloseComponent()
            nextIndex
        )

    static member inline create(x: NodeRenderFragment seq) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent<'T>(index)
            let nextIndex =
                html.renderFragment("ChildContent", html.fragment x).Invoke(comp, builder, index + 1)
            builder.CloseComponent()
            nextIndex
        )
