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

    member inline _.YieldFrom(renders: AttrRenderFragment seq) = renders |> Seq.fold (==>) (emptyAttr ())


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
    member inline _.classes([<InlineIfLambda>] render: AttrRenderFragment, v: string list) = render ==> (html.class' (String.concat " " v))

    [<CustomOperation("class'")>]
    member inline _.class'([<InlineIfLambda>] render: AttrRenderFragment, v: string) = render ==> (html.class' v)

    [<CustomOperation("style'")>]
    member inline _.style([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.style x

    [<CustomOperation("styles")>]
    member _.styles(render: AttrRenderFragment, v: (string * string) seq) = render ==> html.style (makeStyles v)

    [<CustomOperation("key'")>]
    member inline _.key'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("key" => v)

    [<CustomOperation("value")>]
    member inline _.value<'T>([<InlineIfLambda>] render: AttrRenderFragment, v: 'T) =
        render ==> ("value" => (if typeof<'T> = typeof<bool> then box (string v) else box v))


    /// Indicating that an element should be focused on page load, or when the <dialog> that it is part of is displayed.
    [<CustomOperation("autofocus")>]
    member inline _.autofocus([<InlineIfLambda>] render: AttrRenderFragment, ?v) = render ==> ("autofocus" =>>> defaultArg v true)
    /// Lets you attach custom attributes to an HTML element.
    [<CustomOperation("data")>]
    member inline _.data([<InlineIfLambda>] render: AttrRenderFragment, k, v) = render ==> ("data-" + k => v)

    /// Lets you attach custom attributes to an HTML element.
    [<CustomOperation("data")>]
    member inline _.data([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("data" => v)

    /// Defines whether the element can be dragged.
    [<CustomOperation("draggable")>]
    member inline _.draggable([<InlineIfLambda>] render: AttrRenderFragment, ?v) = render ==> ("draggable" =>>> defaultArg v true)

    /// Prevents rendering of given element, while keeping child elements, e.g. script elements, active.
    [<CustomOperation("hidden")>]
    member inline _.hidden([<InlineIfLambda>] render: AttrRenderFragment, ?v) = render ==> ("hidden" =>>> defaultArg v true)

    /// Often used with CSS to style a specific element. The value of this attribute must be unique.
    [<CustomOperation("id")>]
    member inline _.id([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("id" => v)

    /// Defines the language used in the element.
    [<CustomOperation("lang")>]
    member inline _.lang([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("lang" => v)

    /// Defines an explicit role for an element for use by assistive technologies.
    [<CustomOperation("role")>]
    member inline _.role([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("role" => v)

    /// Overrides the browser's default tab order and follows the one specified instead.
    [<CustomOperation("tabindex")>]
    member inline _.tabindex([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("tabindex" => v)

    /// Text to be displayed in a tooltip when hovering over the element.
    [<CustomOperation("title'")>]
    member inline _.title'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("title" => v)


    /// Keyboard shortcut to activate or add focus to the element.
    [<CustomOperation("accesskey")>]
    member inline _.accesskey([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("accesskey" => v)

    /// Sets whether input is automatically capitalized when entered by user
    [<CustomOperation("autocapitalize")>]
    member inline _.autocapitalize([<InlineIfLambda>] render: AttrRenderFragment, ?v) = render ==> ("autocapitalize" =>>> defaultArg v true)

    /// Indicates whether the element's content is editable.
    [<CustomOperation("contenteditable")>]
    member inline _.contenteditable([<InlineIfLambda>] render: AttrRenderFragment, ?v) = render ==> ("contenteditable" =>>> defaultArg v true)

    /// Defines the text direction. Allowed values are ltr (Left-To-Right) or rtl (Right-To-Left)
    [<CustomOperation("dir_ltr")>]
    member inline _.dir_ltr([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("dir" => "ltr")

    /// Defines the text direction. Allowed values are ltr (Left-To-Right) or rtl (Right-To-Left)
    [<CustomOperation("dir_rtl")>]
    member inline _.dir_rtl([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("dir" => "rtl")


    /// Defining what action label (or icon) to present for the enter key on virtual keyboards.
    [<CustomOperation("enterkeyhint")>]
    member inline _.enterkeyhint([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("enterkeyhint" => v)

    /// Allows you to select and style elements existing in nested shadow trees, by exporting their part names.
    [<CustomOperation("exportparts")>]
    member inline _.exportparts([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("exportparts" => v)

    /// Indicating that the browser will ignore the element. With the inert attribute, all of the element's flat tree descendants (such as modal <dialog>s) that don't otherwise escape inertness are ignored. The inert attribute also makes the browser ignore input events sent by the user, including focus-related events and events from assistive technologies.
    [<CustomOperation("inert")>]
    member inline _.inert([<InlineIfLambda>] render: AttrRenderFragment, ?v) = render ==> ("inert" =>>> defaultArg v true)

    /// Hints at the type of data that might be entered by the user while editing the element or its contents. This allows a browser to display an appropriate virtual keyboard.
    [<CustomOperation("inputmode")>]
    member inline _.inputmode([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("inputmode" => v)

    /// Specify that a standard HTML element should behave like a defined custom built-in element (see Using custom elements for more details).
    [<CustomOperation("is")>]
    member inline _.is([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("is" =>> v)


    /// Provides microdata in the form of a unique, global identifier of an item
    [<CustomOperation("itemid")>]
    member inline _.itemid([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("itemid" => v)

    /// Used to add properties to an item. Every HTML element can have an itemprop attribute specified, and an itemprop consists of a name-value pair. Each name-value pair is called a property, and a group of one or more properties forms an item. Property values are either a string or a URL and can be associated with a very wide range of elements including <audio>, <embed>, <iframe>, <img>, <link>, <object>, <source>, <track>, and <video>.
    [<CustomOperation("itemprop")>]
    member inline _.itemprop([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("itemprop" => v)

    /// Provides a list of element IDs (not itemids) elsewhere in the document, with additional properties
    [<CustomOperation("itemref")>]
    member inline _.itemref([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("itemref" => v)

    /// Defines the scope of associated metadata. Specifying the itemscope attribute for an element creates a new item, which results in a number of name-value pairs that are associated with the element.
    [<CustomOperation("itemscope")>]
    member inline _.itemscope([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("itemscope" => v)

    /// Used to set the scope of where in the data structure the vocabulary set by itemtype will be active.
    [<CustomOperation("itemtype")>]
    member inline _.itemtype([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("itemtype" => v)


    /// Contains a space-separated list of the part names of the element. Part names allows CSS to select and style specific elements in a shadow tree via the ::part pseudo-element.
    [<CustomOperation("part")>]
    member inline _.part([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("part" => v)

    /// Assigns a slot in a shadow DOM shadow tree to an element.
    [<CustomOperation("slot")>]
    member inline _.slot([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("slot" => v)

    /// Indicates whether spell checking is allowed for the element.
    [<CustomOperation("spellcheck")>]
    member inline _.spellcheck([<InlineIfLambda>] render: AttrRenderFragment, ?v) = render ==> ("spellcheck" =>>> defaultArg v true)

    /// Specify whether an element's attribute values and the values of its Text node children are to be translated when the page is localized, or whether to leave them unchanged.
    [<CustomOperation("translate")>]
    member inline _.translate([<InlineIfLambda>] render: AttrRenderFragment, ?v) = render ==> ("translate" =>>> defaultArg v true)

    /// Defining a cryptographic nonce ("number used once") which can be used by Content Security Policy to determine whether or not a given fetch will be allowed to proceed for a given element.
    [<CustomOperation("nonce")>]
    member inline _.nonce([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("nonce" => v)

    /// Used to designate an element as a popover element
    [<CustomOperation("popover")>]
    member inline _.popover([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("popover" => v)
