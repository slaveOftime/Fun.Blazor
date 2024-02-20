namespace Fun.Blazor

open System
open System.Threading.Tasks
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Web
open Operators
open Internal


type DomAttrBuilder() =
    interface IFunBlazorBuilder

    member inline _.Run([<InlineIfLambda>] x: AttrRenderFragment) = AttrRenderFragment(fun c b i -> x.Invoke(c, b, i))
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

    member inline _.Combine([<InlineIfLambda>] render1: AttrRenderFragment, [<InlineIfLambda>] render2: AttrRenderFragment) = render1 ==> render2

    member inline _.For([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> AttrRenderFragment) = render ==> (fn ())

    //member inline _.For(renders: 'T seq, [<InlineIfLambda>] fn: 'T -> AttrRenderFragment) =
    //    renders |> Seq.map fn |> Seq.fold (==>) (emptyAttr ())

    member inline _.YieldFrom(renders: AttrRenderFragment seq) =
        AttrRenderFragment(fun comp builder sequence ->
            builder.OpenRegion(sequence)

            let mutable i = 0
            for attr in renders do
                i <- attr.Invoke(comp, builder, i)

            builder.CloseRegion()
            sequence + 1
        )

    member inline _.Zero() = emptyAttr ()


    /// key for blazor
    [<CustomOperation("key")>]
    member inline _.key([<InlineIfLambda>] render: AttrRenderFragment, k) = render ==> html.key k

    /// A helper to make CE work without set any real attributes.
    [<CustomOperation("empty")>]
    member inline _.empty([<InlineIfLambda>] render: AttrRenderFragment) = render

    [<CustomOperation("asAttrRenderFragment")>]
    member inline _.asAttrRenderFragment(render: AttrRenderFragment) = AttrRenderFragmentWrapper render


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

    [<CustomOperation("callback")>]
    member inline _.callback([<InlineIfLambda>] render: AttrRenderFragment, eventName, [<InlineIfLambda>] callback: 'T -> Task<unit>) =
        render ==> html.callbackTask (eventName, callback)


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
            builder.AddEventStopPropagationAttribute(index, eventName, value)
            index + 1
        )

#if !NET6_0
    /// Enhanced navigation is enabled by default, but it can be controlled hierarchically and on a per-link basis using the data-enhance-nav HTML attribute.
    [<CustomOperation("dataEnhanceNav")>]
    member inline _.dataEnhanceNav([<InlineIfLambda>] render: AttrRenderFragment, value: bool) =
        render ==> ("data-enhance-nav" => (if value then "true" else "false"))

    /// Enhanced navigation is enabled by default, but it can be controlled hierarchically and on a per-link basis using the data-enhance-nav HTML attribute.
    [<CustomOperation("dataEnhanceNav")>]
    member inline this.dataEnhanceNav([<InlineIfLambda>] render: AttrRenderFragment) = this.dataEnhanceNav (render, true)

    /// Blazor's enhanced navigation and form handing may undo dynamic changes to the DOM if the updated content isn't part of the server rendering. To preserve the content of an element, use the data-permanent attribute.
    [<CustomOperation("dataPermanent")>]
    member inline _.dataPermanent([<InlineIfLambda>] render: AttrRenderFragment, value: bool) =
        render ==> ("permanent" => (if value then "true" else "false"))

    /// Blazor's enhanced navigation and form handing may undo dynamic changes to the DOM if the updated content isn't part of the server rendering. To preserve the content of an element, use the data-permanent attribute.
    [<CustomOperation("dataPermanent")>]
    member inline this.dataPermanent([<InlineIfLambda>] render: AttrRenderFragment) = this.dataPermanent (render, true)
#endif

    /// <summary>
    /// A list of strings to be applied as classes
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// div {
    ///   classes [ "flex"; "flex-row"; "space-betwen" ]
    /// }
    /// </code>
    /// </example>
    [<CustomOperation("classes")>]
    member inline _.classes([<InlineIfLambda>] render: AttrRenderFragment, v: string list) = render ==> ("class" =>> (String.concat " " v))

    [<CustomOperation("class'")>]
    member inline _.class'([<InlineIfLambda>] render: AttrRenderFragment, v: string) = render ==> ("class" =>> v)

    [<CustomOperation("style'")>]
    member inline _.style([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("style" =>> x)

    [<CustomOperation("styles")>]
    member _.styles(render: AttrRenderFragment, v: (string * string) seq) = render ==> ("style" =>> (makeStyles v))

    [<CustomOperation("key'")>]
    member inline _.key'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("key" => v)

    [<CustomOperation("value")>]
    member inline _.value<'T>([<InlineIfLambda>] render: AttrRenderFragment, v: 'T) =
        render ==> ("value" => (if typeof<'T> = typeof<bool> then box (string v) else box v))

    /// Indicating that an element should be focused on page load, or when the <dialog> that it is part of is displayed.
    [<CustomOperation("autofocus")>]
    member inline _.autofocus([<InlineIfLambda>] render: AttrRenderFragment, ?v) = render ==> ("autofocus" =>>> defaultArg v true)
    