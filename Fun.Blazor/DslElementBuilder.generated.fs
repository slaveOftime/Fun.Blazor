namespace Fun.Blazor

[<AutoOpen>]
module DslElementsBuilder_global =

    open Fun.Blazor
    open Operators

    type EltWithChildBuilder with
                                     
        /// Keyboard shortcut to activate or add focus to the element.
        [<CustomOperation("accesskey")>]
        member inline _.accesskey([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("accesskey" => v)

        /// Sets whether input is automatically capitalized when entered by user
        [<CustomOperation("autocapitalize")>]
        member inline _.autocapitalize([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("autocapitalize" =>>> v)

        /// Sets whether input is automatically capitalized when entered by user
        [<CustomOperation("autocapitalize")>]
        member inline this.autocapitalize([<InlineIfLambda>] render: AttrRenderFragment) = this.autocapitalize(render, true)

        /// Indicates whether the element's content is editable.
        [<CustomOperation("contenteditable")>]
        member inline _.contenteditable([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("contenteditable" =>>> v)

        /// Indicates whether the element's content is editable.
        [<CustomOperation("contenteditable")>]
        member inline this.contenteditable([<InlineIfLambda>] render: AttrRenderFragment) = this.contenteditable(render, true)

        /// Lets you attach custom attributes to an HTML element.
        [<CustomOperation("data")>]
        member inline _.data([<InlineIfLambda>] render: AttrRenderFragment, k, v) = render ==> ("data-" + k => v)

        /// Lets you attach custom attributes to an HTML element.
        [<CustomOperation("data")>]
        member inline _.data([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("data" => v)

        /// Defines the text direction. Allowed values are ltr (Left-To-Right) or rtl (Right-To-Left)
        [<CustomOperation("dir")>]
        member inline _.dir([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("dir" => v)

        /// Defines whether the element can be dragged.
        [<CustomOperation("draggable")>]
        member inline _.draggable([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("draggable" =>>> v)

        /// Defines whether the element can be dragged.
        [<CustomOperation("draggable")>]
        member inline this.draggable([<InlineIfLambda>] render: AttrRenderFragment) = this.draggable(render, true)

        /// Prevents rendering of given element, while keeping child elements, e.g. script elements, active.
        [<CustomOperation("hidden")>]
        member inline _.hidden([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("hidden" => v)

        /// Often used with CSS to style a specific element. The value of this attribute must be unique.
        [<CustomOperation("id")>]
        member inline _.id([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("id" => v)

        
        [<CustomOperation("itemprop")>]
        member inline _.itemprop([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("itemprop" => v)

        /// Defines the language used in the element.
        [<CustomOperation("lang")>]
        member inline _.lang([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("lang" => v)

        /// Defines an explicit role for an element for use by assistive technologies.
        [<CustomOperation("role")>]
        member inline _.role([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("role" => v)

        /// Assigns a slot in a shadow DOM shadow tree to an element.
        [<CustomOperation("slot")>]
        member inline _.slot([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("slot" => v)

        /// Indicates whether spell checking is allowed for the element.
        [<CustomOperation("spellcheck")>]
        member inline _.spellcheck([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("spellcheck" =>>> v)

        /// Indicates whether spell checking is allowed for the element.
        [<CustomOperation("spellcheck")>]
        member inline this.spellcheck([<InlineIfLambda>] render: AttrRenderFragment) = this.spellcheck(render, true)

        /// Overrides the browser's default tab order and follows the one specified instead.
        [<CustomOperation("tabindex")>]
        member inline _.tabindex([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("tabindex" => v)

        /// Text to be displayed in a tooltip when hovering over the element.
        [<CustomOperation("title'")>]
        member inline _.title'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("title" => v)

        /// Specify whether an element's attribute values and the values of its Text node children are to be translated when the page is localized, or whether to leave them unchanged.
        [<CustomOperation("translate")>]
        member inline _.translate([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("translate" =>>> v)

        /// Specify whether an element's attribute values and the values of its Text node children are to be translated when the page is localized, or whether to leave them unchanged.
        [<CustomOperation("translate")>]
        member inline this.translate([<InlineIfLambda>] render: AttrRenderFragment) = this.translate(render, true)

    type EltBuilder_script with

        /// Executes the script asynchronously.
        [<CustomOperation("async")>]
        member inline _.async([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("async" => v)

        /// How the element handles cross-origin requests
        [<CustomOperation("crossorigin")>]
        member inline _.crossorigin([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("crossorigin" => v)

        /// Indicates that the script should be executed after the page has been parsed.
        [<CustomOperation("defer")>]
        member inline _.defer([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("defer" =>>> v)

        /// Indicates that the script should be executed after the page has been parsed.
        [<CustomOperation("defer")>]
        member inline this.defer([<InlineIfLambda>] render: AttrRenderFragment) = this.defer(render, true)

        /// Specifies a Subresource Integrity value that allows browsers to verify what they fetch.
        [<CustomOperation("integrity")>]
        member inline _.integrity([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("integrity" => v)

        /// Specifies which referrer is sent when fetching the resource.
        [<CustomOperation("referrerpolicy")>]
        member inline _.referrerpolicy([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("referrerpolicy" => v)

        /// The URL of the embeddable content.
        [<CustomOperation("src")>]
        member inline _.src([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("src" => v)

        /// Defines the type of the element.
        [<CustomOperation("type'")>]
        member inline _.type'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("type" => v)


module DslElementBuilder_generated =

    open Fun.Blazor
    open Operators

    type EltBuilder_a() =
        inherit EltWithChildBuilder("a")

        /// Indicates that the hyperlink is to be used for downloading a resource.
        [<CustomOperation("download")>]
        member inline _.download([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("download" =>>> v)

        /// Indicates that the hyperlink is to be used for downloading a resource.
        [<CustomOperation("download")>]
        member inline this.download([<InlineIfLambda>] render: AttrRenderFragment) = this.download(render, true)

        /// The URL of a linked resource.
        [<CustomOperation("href")>]
        member inline _.href([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("href" => v)

        /// Specifies the language of the linked resource.
        [<CustomOperation("hreflang")>]
        member inline _.hreflang([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("hreflang" => v)

        /// Specifies a hint of the media for which the linked resource was designed.
        [<CustomOperation("media")>]
        member inline _.media([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("media" => v)

        /// The ping attribute specifies a space-separated list of URLs to be notified if a user follows the hyperlink.
        [<CustomOperation("ping")>]
        member inline _.ping([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("ping" => v)

        /// Specifies which referrer is sent when fetching the resource.
        [<CustomOperation("referrerpolicy")>]
        member inline _.referrerpolicy([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("referrerpolicy" => v)

        /// Specifies the relationship of the target object to the link object.
        [<CustomOperation("rel")>]
        member inline _.rel([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("rel" => v)

        
        [<CustomOperation("shape")>]
        member inline _.shape([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("shape" => v)

        /// Specifies where to open the linked document (in the case of an <a> element) or where to display the response received (in the case of a <form> element)
        [<CustomOperation("target")>]
        member inline _.target([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("target" => v)

    type EltBuilder_area() =
        inherit EltWithChildBuilder("area")

        /// Alternative text in case an image can't be displayed.
        [<CustomOperation("alt")>]
        member inline _.alt([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("alt" => v)

        /// A set of values specifying the coordinates of the hot-spot region.
        [<CustomOperation("coords")>]
        member inline _.coords([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("coords" => v)

        /// Indicates that the hyperlink is to be used for downloading a resource.
        [<CustomOperation("download")>]
        member inline _.download([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("download" =>>> v)

        /// Indicates that the hyperlink is to be used for downloading a resource.
        [<CustomOperation("download")>]
        member inline this.download([<InlineIfLambda>] render: AttrRenderFragment) = this.download(render, true)

        /// The URL of a linked resource.
        [<CustomOperation("href")>]
        member inline _.href([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("href" => v)

        /// Specifies a hint of the media for which the linked resource was designed.
        [<CustomOperation("media")>]
        member inline _.media([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("media" => v)

        /// The ping attribute specifies a space-separated list of URLs to be notified if a user follows the hyperlink.
        [<CustomOperation("ping")>]
        member inline _.ping([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("ping" => v)

        /// Specifies which referrer is sent when fetching the resource.
        [<CustomOperation("referrerpolicy")>]
        member inline _.referrerpolicy([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("referrerpolicy" => v)

        /// Specifies the relationship of the target object to the link object.
        [<CustomOperation("rel")>]
        member inline _.rel([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("rel" => v)

        
        [<CustomOperation("shape")>]
        member inline _.shape([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("shape" => v)

        /// Specifies where to open the linked document (in the case of an <a> element) or where to display the response received (in the case of a <form> element)
        [<CustomOperation("target")>]
        member inline _.target([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("target" => v)

    type EltBuilder_audio() =
        inherit EltWithChildBuilder("audio")

        /// The audio or video should play as soon as possible.
        [<CustomOperation("autoplay")>]
        member inline _.autoplay([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("autoplay" =>>> v)

        /// The audio or video should play as soon as possible.
        [<CustomOperation("autoplay")>]
        member inline this.autoplay([<InlineIfLambda>] render: AttrRenderFragment) = this.autoplay(render, true)

        /// Contains the time range of already buffered media.
        [<CustomOperation("buffered")>]
        member inline _.buffered([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("buffered" => v)

        /// Indicates whether the browser should show playback controls to the user.
        [<CustomOperation("controls")>]
        member inline _.controls([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("controls" =>>> v)

        /// Indicates whether the browser should show playback controls to the user.
        [<CustomOperation("controls")>]
        member inline this.controls([<InlineIfLambda>] render: AttrRenderFragment) = this.controls(render, true)

        /// How the element handles cross-origin requests
        [<CustomOperation("crossorigin")>]
        member inline _.crossorigin([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("crossorigin" => v)

        /// Indicates whether the media should start playing from the start when it's finished.
        [<CustomOperation("loop")>]
        member inline _.loop([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("loop" =>>> v)

        /// Indicates whether the media should start playing from the start when it's finished.
        [<CustomOperation("loop")>]
        member inline this.loop([<InlineIfLambda>] render: AttrRenderFragment) = this.loop(render, true)

        /// Indicates whether the audio will be initially silenced on page load.
        [<CustomOperation("muted")>]
        member inline _.muted([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("muted" =>>> v)

        /// Indicates whether the audio will be initially silenced on page load.
        [<CustomOperation("muted")>]
        member inline this.muted([<InlineIfLambda>] render: AttrRenderFragment) = this.muted(render, true)

        /// Indicates whether the whole resource, parts of it or nothing should be preloaded.
        [<CustomOperation("preload")>]
        member inline _.preload([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("preload" =>>> v)

        /// Indicates whether the whole resource, parts of it or nothing should be preloaded.
        [<CustomOperation("preload")>]
        member inline this.preload([<InlineIfLambda>] render: AttrRenderFragment) = this.preload(render, true)

        /// The URL of the embeddable content.
        [<CustomOperation("src")>]
        member inline _.src([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("src" => v)

    type EltBuilder_base() =
        inherit EltWithChildBuilder("base")

        /// The URL of a linked resource.
        [<CustomOperation("href")>]
        member inline _.href([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("href" => v)

        /// Specifies where to open the linked document (in the case of an <a> element) or where to display the response received (in the case of a <form> element)
        [<CustomOperation("target")>]
        member inline _.target([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("target" => v)

    type EltBuilder_blockquote() =
        inherit EltWithChildBuilder("blockquote")

        /// Contains a URI which points to the source of the quote or change.
        [<CustomOperation("cite")>]
        member inline _.cite([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("cite" => v)

    type EltBuilder_body() =
        inherit EltWithChildBuilder("body")

        /// Specifies the URL of an image file. Note: Although browsers and email clients may still support this attribute, it is obsolete. Use CSS background-image instead.
        [<CustomOperation("background")>]
        member inline _.background([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("background" => v)

        /// Background color of the element.Note: This is a legacy attribute. Please use the CSS background-color property instead.
        [<CustomOperation("bgcolor")>]
        member inline _.bgcolor([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("bgcolor" => v)

    type EltBuilder_button() =
        inherit EltWithChildBuilder("button")

        /// Indicates whether the user can interact with the element.
        [<CustomOperation("disabled")>]
        member inline _.disabled([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("disabled" =>>> v)

        /// Indicates whether the user can interact with the element.
        [<CustomOperation("disabled")>]
        member inline this.disabled([<InlineIfLambda>] render: AttrRenderFragment) = this.disabled(render, true)

        /// Indicates the form that is the owner of the element.
        [<CustomOperation("form")>]
        member inline _.form([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("form" =>>> v)

        /// Indicates the form that is the owner of the element.
        [<CustomOperation("form")>]
        member inline this.form([<InlineIfLambda>] render: AttrRenderFragment) = this.form(render, true)

        /// Indicates the action of the element, overriding the action defined in the <form>.
        [<CustomOperation("formaction")>]
        member inline _.formaction([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("formaction" => v)

        /// Indicates the action of the element, overriding the action defined in the <form>.
        [<CustomOperation("formaction")>]
        member inline this.formaction([<InlineIfLambda>] render: AttrRenderFragment) = this.formaction(render, true)

        /// If the button/input is a submit button (e.g. type="submit"), this attribute sets the encoding type to use during form submission. If this attribute is specified, it overrides the enctype attribute of the button's form owner.
        [<CustomOperation("formenctype")>]
        member inline _.formenctype([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("formenctype" => v)

        /// If the button/input is a submit button (e.g. type="submit"), this attribute sets the submission method to use during form submission (GET, POST, etc.). If this attribute is specified, it overrides the method attribute of the button's form owner.
        [<CustomOperation("formmethod")>]
        member inline _.formmethod([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("formmethod" => v)

        /// If the button/input is a submit button (e.g. type="submit"), this boolean attribute specifies that the form is not to be validated when it is submitted. If this attribute is specified, it overrides the novalidate attribute of the button's form owner.
        [<CustomOperation("formnovalidate")>]
        member inline _.formnovalidate([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("formnovalidate" => v)

        /// If the button/input is a submit button (e.g. type="submit"), this attribute specifies the browsing context (for example, tab, window, or inline frame) in which to display the response that is received after submitting the form. If this attribute is specified, it overrides the target attribute of the button's form owner.
        [<CustomOperation("formtarget")>]
        member inline _.formtarget([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("formtarget" => v)

        /// Name of the element. For example used by the server to identify the fields in form submits.
        [<CustomOperation("name")>]
        member inline _.name([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("name" => v)

        /// Defines the type of the element.
        [<CustomOperation("type'")>]
        member inline _.type'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("type" => v)

    type EltBuilder_canvas() =
        inherit EltWithChildBuilder("canvas")

        /// Specifies the height of elements listed here. For all other elements, use the CSS height property. Note: In some instances, such as <div>, this is a legacy attribute, in which case the CSS height property should be used instead.
        [<CustomOperation("height")>]
        member inline _.height([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("height" => v)

        /// For the elements listed here, this establishes the element's width.Note: For all other instances, such as <div>, this is a legacy attribute, in which case the CSS width property should be used instead.
        [<CustomOperation("width")>]
        member inline _.width([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("width" => v)

    type EltBuilder_caption() =
        inherit EltWithChildBuilder("caption")

    type EltBuilder_col() =
        inherit EltWithChildBuilder("col")

        /// Background color of the element.Note: This is a legacy attribute. Please use the CSS background-color property instead.
        [<CustomOperation("bgcolor")>]
        member inline _.bgcolor([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("bgcolor" => v)

        
        [<CustomOperation("span")>]
        member inline _.span([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("span" => v)

    type EltBuilder_colgroup() =
        inherit EltWithChildBuilder("colgroup")

        /// Background color of the element.Note: This is a legacy attribute. Please use the CSS background-color property instead.
        [<CustomOperation("bgcolor")>]
        member inline _.bgcolor([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("bgcolor" => v)

        
        [<CustomOperation("span")>]
        member inline _.span([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("span" => v)

    type EltBuilder_contenteditable() =
        inherit EltWithChildBuilder("contenteditable")

        /// The enterkeyhint specifies what action label (or icon) to present for the enter key on virtual keyboards. The attribute can be used with form controls (such as the value of textarea elements), or in elements in an editing host (e.g., using contenteditable attribute).
        [<CustomOperation("enterkeyhintExperimental")>]
        member inline _.enterkeyhintExperimental([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("enterkeyhintExperimental" => v)

        /// Provides a hint as to the type of data that might be entered by the user while editing the element or its contents. The attribute can be used with form controls (such as the value of textarea elements), or in elements in an editing host (e.g., using contenteditable attribute).
        [<CustomOperation("inputmode")>]
        member inline _.inputmode([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("inputmode" => v)

    type EltBuilder_data() =
        inherit EltWithChildBuilder("data")

    type EltBuilder_del() =
        inherit EltWithChildBuilder("del")

        /// Contains a URI which points to the source of the quote or change.
        [<CustomOperation("cite")>]
        member inline _.cite([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("cite" => v)

        /// Indicates the date and time associated with the element.
        [<CustomOperation("datetime")>]
        member inline _.datetime([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("datetime" =>>> v)

        /// Indicates the date and time associated with the element.
        [<CustomOperation("datetime")>]
        member inline this.datetime([<InlineIfLambda>] render: AttrRenderFragment) = this.datetime(render, true)

    type EltBuilder_details() =
        inherit EltWithChildBuilder("details")

        /// Indicates whether the contents are currently visible (in the case of a <details> element) or whether the dialog is active and can be interacted with (in the case of a <dialog> element).
        [<CustomOperation("open'")>]
        member inline _.open'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("open" =>>> v)

        /// Indicates whether the contents are currently visible (in the case of a <details> element) or whether the dialog is active and can be interacted with (in the case of a <dialog> element).
        [<CustomOperation("open'")>]
        member inline this.open'([<InlineIfLambda>] render: AttrRenderFragment) = this.open'(render, true)

    type EltBuilder_dialog() =
        inherit EltWithChildBuilder("dialog")

        /// Indicates whether the contents are currently visible (in the case of a <details> element) or whether the dialog is active and can be interacted with (in the case of a <dialog> element).
        [<CustomOperation("open'")>]
        member inline _.open'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("open" =>>> v)

        /// Indicates whether the contents are currently visible (in the case of a <details> element) or whether the dialog is active and can be interacted with (in the case of a <dialog> element).
        [<CustomOperation("open'")>]
        member inline this.open'([<InlineIfLambda>] render: AttrRenderFragment) = this.open'(render, true)

    type EltBuilder_embed() =
        inherit EltWithChildBuilder("embed")

        /// Specifies the height of elements listed here. For all other elements, use the CSS height property. Note: In some instances, such as <div>, this is a legacy attribute, in which case the CSS height property should be used instead.
        [<CustomOperation("height")>]
        member inline _.height([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("height" => v)

        /// The URL of the embeddable content.
        [<CustomOperation("src")>]
        member inline _.src([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("src" => v)

        /// Defines the type of the element.
        [<CustomOperation("type'")>]
        member inline _.type'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("type" => v)

        /// For the elements listed here, this establishes the element's width.Note: For all other instances, such as <div>, this is a legacy attribute, in which case the CSS width property should be used instead.
        [<CustomOperation("width")>]
        member inline _.width([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("width" => v)

    type EltBuilder_fieldset() =
        inherit EltWithChildBuilder("fieldset")

        /// Indicates whether the user can interact with the element.
        [<CustomOperation("disabled")>]
        member inline _.disabled([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("disabled" =>>> v)

        /// Indicates whether the user can interact with the element.
        [<CustomOperation("disabled")>]
        member inline this.disabled([<InlineIfLambda>] render: AttrRenderFragment) = this.disabled(render, true)

        /// Indicates the form that is the owner of the element.
        [<CustomOperation("form")>]
        member inline _.form([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("form" =>>> v)

        /// Indicates the form that is the owner of the element.
        [<CustomOperation("form")>]
        member inline this.form([<InlineIfLambda>] render: AttrRenderFragment) = this.form(render, true)

        /// Name of the element. For example used by the server to identify the fields in form submits.
        [<CustomOperation("name")>]
        member inline _.name([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("name" => v)

    type EltBuilder_font() =
        inherit EltWithChildBuilder("font")

        /// This attribute sets the text color using either a named color or a color specified in the hexadecimal #RRGGBB format. Note: This is a legacy attribute. Please use the CSS color property instead.
        [<CustomOperation("color")>]
        member inline _.color([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("color" => v)

    type EltBuilder_form() =
        inherit EltWithChildBuilder("form")

        /// List of types the server accepts, typically a file type.
        [<CustomOperation("accept")>]
        member inline _.accept([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("accept" => v)

        /// List of supported charsets.
        [<CustomOperation("acceptCharset")>]
        member inline _.acceptCharset([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("accept-charset" => v)

        /// The URI of a program that processes the information submitted via the form.
        [<CustomOperation("action")>]
        member inline _.action([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("action" => v)

        /// Indicates whether controls in this form can by default have their values automatically completed by the browser.
        [<CustomOperation("autocomplete")>]
        member inline _.autocomplete([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("autocomplete" =>> (if v then "on" else "off"))

        /// Indicates whether controls in this form can by default have their values automatically completed by the browser.
        [<CustomOperation("autocomplete")>]
        member inline this.autocomplete([<InlineIfLambda>] render: AttrRenderFragment) = this.autocomplete(render, true)

        /// Defines the content type of the form data when the method is POST.
        [<CustomOperation("enctype")>]
        member inline _.enctype([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("enctype" => v)

        /// Defines which HTTP method to use when submitting the form. Can be GET (default) or POST.
        [<CustomOperation("method")>]
        member inline _.method([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("method" => v)

        /// Name of the element. For example used by the server to identify the fields in form submits.
        [<CustomOperation("name")>]
        member inline _.name([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("name" => v)

        /// This attribute indicates that the form shouldn't be validated when submitted.
        [<CustomOperation("novalidate")>]
        member inline _.novalidate([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("novalidate" =>>> v)

        /// This attribute indicates that the form shouldn't be validated when submitted.
        [<CustomOperation("novalidate")>]
        member inline this.novalidate([<InlineIfLambda>] render: AttrRenderFragment) = this.novalidate(render, true)

        /// Specifies where to open the linked document (in the case of an <a> element) or where to display the response received (in the case of a <form> element)
        [<CustomOperation("target")>]
        member inline _.target([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("target" => v)

    type EltBuilder_hr() =
        inherit EltWithChildBuilder("hr")

        /// This attribute sets the text color using either a named color or a color specified in the hexadecimal #RRGGBB format. Note: This is a legacy attribute. Please use the CSS color property instead.
        [<CustomOperation("color")>]
        member inline _.color([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("color" => v)

    type EltBuilder_html() =
        inherit EltWithChildBuilder("html")

    type EltBuilder_iframe() =
        inherit EltWithChildBuilder("iframe")

        /// Specifies a feature-policy for the iframe.
        [<CustomOperation("allow")>]
        member inline _.allow([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("allow" => v)

        /// Specifies the Content Security Policy that an embedded document must agree to enforce upon itself.
        [<CustomOperation("cspExperimental")>]
        member inline _.cspExperimental([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("cspExperimental" => v)

        /// Specifies the height of elements listed here. For all other elements, use the CSS height property. Note: In some instances, such as <div>, this is a legacy attribute, in which case the CSS height property should be used instead.
        [<CustomOperation("height")>]
        member inline _.height([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("height" => v)

        /// Indicates if the element should be loaded lazily (loading="lazy") or loaded immediately (loading="eager").
        [<CustomOperation("loadingExperimental")>]
        member inline _.loadingExperimental([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("loadingExperimental" =>>> v)

        /// Indicates if the element should be loaded lazily (loading="lazy") or loaded immediately (loading="eager").
        [<CustomOperation("loadingExperimental")>]
        member inline this.loadingExperimental([<InlineIfLambda>] render: AttrRenderFragment) = this.loadingExperimental(render, true)

        /// Name of the element. For example used by the server to identify the fields in form submits.
        [<CustomOperation("name")>]
        member inline _.name([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("name" => v)

        /// Specifies which referrer is sent when fetching the resource.
        [<CustomOperation("referrerpolicy")>]
        member inline _.referrerpolicy([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("referrerpolicy" => v)

        /// Stops a document loaded in an iframe from using certain features (such as submitting forms or opening new windows).
        [<CustomOperation("sandbox")>]
        member inline _.sandbox([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("sandbox" => v)

        /// The URL of the embeddable content.
        [<CustomOperation("src")>]
        member inline _.src([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("src" => v)

        
        [<CustomOperation("srcdoc")>]
        member inline _.srcdoc([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("srcdoc" => v)

        /// For the elements listed here, this establishes the element's width.Note: For all other instances, such as <div>, this is a legacy attribute, in which case the CSS width property should be used instead.
        [<CustomOperation("width")>]
        member inline _.width([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("width" => v)

    type EltBuilder_img() =
        inherit EltWithChildBuilder("img")

        /// Alternative text in case an image can't be displayed.
        [<CustomOperation("alt")>]
        member inline _.alt([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("alt" => v)

        /// The border width.Note: This is a legacy attribute. Please use the CSS border property instead.
        [<CustomOperation("border")>]
        member inline _.border([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("border" => v)

        /// How the element handles cross-origin requests
        [<CustomOperation("crossorigin")>]
        member inline _.crossorigin([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("crossorigin" => v)

        /// Indicates the preferred method to decode the image.
        [<CustomOperation("decoding")>]
        member inline _.decoding([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("decoding" =>>> v)

        /// Indicates the preferred method to decode the image.
        [<CustomOperation("decoding")>]
        member inline this.decoding([<InlineIfLambda>] render: AttrRenderFragment) = this.decoding(render, true)

        /// Specifies the height of elements listed here. For all other elements, use the CSS height property. Note: In some instances, such as <div>, this is a legacy attribute, in which case the CSS height property should be used instead.
        [<CustomOperation("height")>]
        member inline _.height([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("height" => v)

        /// Indicates that the image is part of a server-side image map.
        [<CustomOperation("ismap")>]
        member inline _.ismap([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("ismap" =>>> v)

        /// Indicates that the image is part of a server-side image map.
        [<CustomOperation("ismap")>]
        member inline this.ismap([<InlineIfLambda>] render: AttrRenderFragment) = this.ismap(render, true)

        /// Indicates if the element should be loaded lazily (loading="lazy") or loaded immediately (loading="eager").
        [<CustomOperation("loadingExperimental")>]
        member inline _.loadingExperimental([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("loadingExperimental" =>>> v)

        /// Indicates if the element should be loaded lazily (loading="lazy") or loaded immediately (loading="eager").
        [<CustomOperation("loadingExperimental")>]
        member inline this.loadingExperimental([<InlineIfLambda>] render: AttrRenderFragment) = this.loadingExperimental(render, true)

        /// Specifies which referrer is sent when fetching the resource.
        [<CustomOperation("referrerpolicy")>]
        member inline _.referrerpolicy([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("referrerpolicy" => v)

        
        [<CustomOperation("sizes")>]
        member inline _.sizes([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("sizes" => v)

        /// The URL of the embeddable content.
        [<CustomOperation("src")>]
        member inline _.src([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("src" => v)

        /// One or more responsive image candidates.
        [<CustomOperation("srcset")>]
        member inline _.srcset([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("srcset" => v)

        
        [<CustomOperation("usemap")>]
        member inline _.usemap([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("usemap" => v)

        /// For the elements listed here, this establishes the element's width.Note: For all other instances, such as <div>, this is a legacy attribute, in which case the CSS width property should be used instead.
        [<CustomOperation("width")>]
        member inline _.width([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("width" => v)

    type EltBuilder_input() =
        inherit EltWithChildBuilder("input")

        /// List of types the server accepts, typically a file type.
        [<CustomOperation("accept")>]
        member inline _.accept([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("accept" => v)

        /// Alternative text in case an image can't be displayed.
        [<CustomOperation("alt")>]
        member inline _.alt([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("alt" => v)

        /// Indicates whether controls in this form can by default have their values automatically completed by the browser.
        [<CustomOperation("autocomplete")>]
        member inline _.autocomplete([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("autocomplete" =>> (if v then "on" else "off"))

        /// Indicates whether controls in this form can by default have their values automatically completed by the browser.
        [<CustomOperation("autocomplete")>]
        member inline this.autocomplete([<InlineIfLambda>] render: AttrRenderFragment) = this.autocomplete(render, true)

        /// From the Media Capture specification, specifies a new file can be captured.
        [<CustomOperation("capture")>]
        member inline _.capture([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("capture" => v)

        /// Indicates whether the element should be checked on page load.
        [<CustomOperation("checked'")>]
        member inline _.checked'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("checked" =>>> v)

        /// Indicates whether the element should be checked on page load.
        [<CustomOperation("checked'")>]
        member inline this.checked'([<InlineIfLambda>] render: AttrRenderFragment) = this.checked'(render, true)

        
        [<CustomOperation("dirname")>]
        member inline _.dirname([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("dirname" => v)

        /// Indicates whether the user can interact with the element.
        [<CustomOperation("disabled")>]
        member inline _.disabled([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("disabled" =>>> v)

        /// Indicates whether the user can interact with the element.
        [<CustomOperation("disabled")>]
        member inline this.disabled([<InlineIfLambda>] render: AttrRenderFragment) = this.disabled(render, true)

        /// Indicates the form that is the owner of the element.
        [<CustomOperation("form")>]
        member inline _.form([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("form" =>>> v)

        /// Indicates the form that is the owner of the element.
        [<CustomOperation("form")>]
        member inline this.form([<InlineIfLambda>] render: AttrRenderFragment) = this.form(render, true)

        /// Indicates the action of the element, overriding the action defined in the <form>.
        [<CustomOperation("formaction")>]
        member inline _.formaction([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("formaction" => v)

        /// Indicates the action of the element, overriding the action defined in the <form>.
        [<CustomOperation("formaction")>]
        member inline this.formaction([<InlineIfLambda>] render: AttrRenderFragment) = this.formaction(render, true)

        /// If the button/input is a submit button (e.g. type="submit"), this attribute sets the encoding type to use during form submission. If this attribute is specified, it overrides the enctype attribute of the button's form owner.
        [<CustomOperation("formenctype")>]
        member inline _.formenctype([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("formenctype" => v)

        /// If the button/input is a submit button (e.g. type="submit"), this attribute sets the submission method to use during form submission (GET, POST, etc.). If this attribute is specified, it overrides the method attribute of the button's form owner.
        [<CustomOperation("formmethod")>]
        member inline _.formmethod([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("formmethod" => v)

        /// If the button/input is a submit button (e.g. type="submit"), this boolean attribute specifies that the form is not to be validated when it is submitted. If this attribute is specified, it overrides the novalidate attribute of the button's form owner.
        [<CustomOperation("formnovalidate")>]
        member inline _.formnovalidate([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("formnovalidate" => v)

        /// If the button/input is a submit button (e.g. type="submit"), this attribute specifies the browsing context (for example, tab, window, or inline frame) in which to display the response that is received after submitting the form. If this attribute is specified, it overrides the target attribute of the button's form owner.
        [<CustomOperation("formtarget")>]
        member inline _.formtarget([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("formtarget" => v)

        /// Specifies the height of elements listed here. For all other elements, use the CSS height property. Note: In some instances, such as <div>, this is a legacy attribute, in which case the CSS height property should be used instead.
        [<CustomOperation("height")>]
        member inline _.height([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("height" => v)

        /// Identifies a list of pre-defined options to suggest to the user.
        [<CustomOperation("list")>]
        member inline _.list([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("list" => v)

        /// Indicates the maximum value allowed.
        [<CustomOperation("max")>]
        member inline _.max([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("max" => v)

        /// Indicates the maximum value allowed.
        [<CustomOperation("max")>]
        member inline this.max([<InlineIfLambda>] render: AttrRenderFragment) = this.max(render, true)

        /// Defines the maximum number of characters allowed in the element.
        [<CustomOperation("maxlength")>]
        member inline _.maxlength([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("maxlength" => v)

        /// Indicates the minimum value allowed.
        [<CustomOperation("min")>]
        member inline _.min([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("min" => v)

        /// Indicates the minimum value allowed.
        [<CustomOperation("min")>]
        member inline this.min([<InlineIfLambda>] render: AttrRenderFragment) = this.min(render, true)

        /// Defines the minimum number of characters allowed in the element.
        [<CustomOperation("minlength")>]
        member inline _.minlength([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("minlength" => v)

        /// Indicates whether multiple values can be entered in an input of the type email or file.
        [<CustomOperation("multiple")>]
        member inline _.multiple([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("multiple" =>>> v)

        /// Indicates whether multiple values can be entered in an input of the type email or file.
        [<CustomOperation("multiple")>]
        member inline this.multiple([<InlineIfLambda>] render: AttrRenderFragment) = this.multiple(render, true)

        /// Name of the element. For example used by the server to identify the fields in form submits.
        [<CustomOperation("name")>]
        member inline _.name([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("name" => v)

        /// Defines a regular expression which the element's value will be validated against.
        [<CustomOperation("pattern")>]
        member inline _.pattern([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("pattern" => v)

        /// Provides a hint to the user of what can be entered in the field.
        [<CustomOperation("placeholder")>]
        member inline _.placeholder([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("placeholder" => v)

        /// Indicates whether the element can be edited.
        [<CustomOperation("readonly")>]
        member inline _.readonly([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("readonly" =>>> v)

        /// Indicates whether the element can be edited.
        [<CustomOperation("readonly")>]
        member inline this.readonly([<InlineIfLambda>] render: AttrRenderFragment) = this.readonly(render, true)

        /// Indicates whether this element is required to fill out or not.
        [<CustomOperation("required")>]
        member inline _.required([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("required" =>>> v)

        /// Indicates whether this element is required to fill out or not.
        [<CustomOperation("required")>]
        member inline this.required([<InlineIfLambda>] render: AttrRenderFragment) = this.required(render, true)

        /// Defines the width of the element (in pixels). If the element's type attribute is text or password then it's the number of characters.
        [<CustomOperation("size")>]
        member inline _.size([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("size" => v)

        /// The URL of the embeddable content.
        [<CustomOperation("src")>]
        member inline _.src([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("src" => v)

        
        [<CustomOperation("step")>]
        member inline _.step([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("step" => v)

        /// Defines the type of the element.
        [<CustomOperation("type'")>]
        member inline _.type'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("type" => v)

        
        [<CustomOperation("usemap")>]
        member inline _.usemap([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("usemap" => v)

        /// For the elements listed here, this establishes the element's width.Note: For all other instances, such as <div>, this is a legacy attribute, in which case the CSS width property should be used instead.
        [<CustomOperation("width")>]
        member inline _.width([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("width" => v)

        [<CustomOperation("autocomplete")>]
        member inline _.autocomplete([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("autocomplete" =>> v)

    type EltBuilder_ins() =
        inherit EltWithChildBuilder("ins")

        /// Contains a URI which points to the source of the quote or change.
        [<CustomOperation("cite")>]
        member inline _.cite([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("cite" => v)

        /// Indicates the date and time associated with the element.
        [<CustomOperation("datetime")>]
        member inline _.datetime([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("datetime" =>>> v)

        /// Indicates the date and time associated with the element.
        [<CustomOperation("datetime")>]
        member inline this.datetime([<InlineIfLambda>] render: AttrRenderFragment) = this.datetime(render, true)

    type EltBuilder_label() =
        inherit EltWithChildBuilder("label")

        /// Describes elements which belongs to this one.
        [<CustomOperation("for'")>]
        member inline _.for'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("for" => v)

        /// Indicates the form that is the owner of the element.
        [<CustomOperation("form")>]
        member inline _.form([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("form" =>>> v)

        /// Indicates the form that is the owner of the element.
        [<CustomOperation("form")>]
        member inline this.form([<InlineIfLambda>] render: AttrRenderFragment) = this.form(render, true)

    type EltBuilder_li() =
        inherit EltWithChildBuilder("li")

    type EltBuilder_link() =
        inherit EltWithChildBuilder("link")

        /// How the element handles cross-origin requests
        [<CustomOperation("crossorigin")>]
        member inline _.crossorigin([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("crossorigin" => v)

        /// The URL of a linked resource.
        [<CustomOperation("href")>]
        member inline _.href([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("href" => v)

        /// Specifies the language of the linked resource.
        [<CustomOperation("hreflang")>]
        member inline _.hreflang([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("hreflang" => v)

        /// Specifies a Subresource Integrity value that allows browsers to verify what they fetch.
        [<CustomOperation("integrity")>]
        member inline _.integrity([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("integrity" => v)

        /// Specifies a hint of the media for which the linked resource was designed.
        [<CustomOperation("media")>]
        member inline _.media([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("media" => v)

        /// Specifies which referrer is sent when fetching the resource.
        [<CustomOperation("referrerpolicy")>]
        member inline _.referrerpolicy([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("referrerpolicy" => v)

        /// Specifies the relationship of the target object to the link object.
        [<CustomOperation("rel")>]
        member inline _.rel([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("rel" => v)

        
        [<CustomOperation("sizes")>]
        member inline _.sizes([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("sizes" => v)

        /// Defines the type of the element.
        [<CustomOperation("type'")>]
        member inline _.type'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("type" => v)

    type EltBuilder_map() =
        inherit EltWithChildBuilder("map")

        /// Name of the element. For example used by the server to identify the fields in form submits.
        [<CustomOperation("name")>]
        member inline _.name([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("name" => v)

    type EltBuilder_marquee() =
        inherit EltWithChildBuilder("marquee")

        /// Background color of the element.Note: This is a legacy attribute. Please use the CSS background-color property instead.
        [<CustomOperation("bgcolor")>]
        member inline _.bgcolor([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("bgcolor" => v)

        /// Indicates whether the media should start playing from the start when it's finished.
        [<CustomOperation("loop")>]
        member inline _.loop([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("loop" =>>> v)

        /// Indicates whether the media should start playing from the start when it's finished.
        [<CustomOperation("loop")>]
        member inline this.loop([<InlineIfLambda>] render: AttrRenderFragment) = this.loop(render, true)

    type EltBuilder_menu() =
        inherit EltWithChildBuilder("menu")

        /// Defines the type of the element.
        [<CustomOperation("type'")>]
        member inline _.type'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("type" => v)

    type EltBuilder_meta() =
        inherit EltWithChildBuilder("meta")

        /// Declares the character encoding of the page or script.
        [<CustomOperation("charset")>]
        member inline _.charset([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("charset" => v)

        /// A value associated with http-equiv or name depending on the context.
        [<CustomOperation("content")>]
        member inline _.content([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("content" => v)

        /// Defines a pragma directive.
        [<CustomOperation("httpEquiv")>]
        member inline _.httpEquiv([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("http-equiv" => v)

        /// Name of the element. For example used by the server to identify the fields in form submits.
        [<CustomOperation("name")>]
        member inline _.name([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("name" => v)

    type EltBuilder_meter() =
        inherit EltWithChildBuilder("meter")

        /// Indicates the form that is the owner of the element.
        [<CustomOperation("form")>]
        member inline _.form([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("form" =>>> v)

        /// Indicates the form that is the owner of the element.
        [<CustomOperation("form")>]
        member inline this.form([<InlineIfLambda>] render: AttrRenderFragment) = this.form(render, true)

        /// Indicates the lower bound of the upper range.
        [<CustomOperation("high")>]
        member inline _.high([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("high" =>>> v)

        /// Indicates the lower bound of the upper range.
        [<CustomOperation("high")>]
        member inline this.high([<InlineIfLambda>] render: AttrRenderFragment) = this.high(render, true)

        /// Indicates the upper bound of the lower range.
        [<CustomOperation("low")>]
        member inline _.low([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("low" =>>> v)

        /// Indicates the upper bound of the lower range.
        [<CustomOperation("low")>]
        member inline this.low([<InlineIfLambda>] render: AttrRenderFragment) = this.low(render, true)

        /// Indicates the maximum value allowed.
        [<CustomOperation("max")>]
        member inline _.max([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("max" => v)

        /// Indicates the maximum value allowed.
        [<CustomOperation("max")>]
        member inline this.max([<InlineIfLambda>] render: AttrRenderFragment) = this.max(render, true)

        /// Indicates the minimum value allowed.
        [<CustomOperation("min")>]
        member inline _.min([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("min" => v)

        /// Indicates the minimum value allowed.
        [<CustomOperation("min")>]
        member inline this.min([<InlineIfLambda>] render: AttrRenderFragment) = this.min(render, true)

        /// Indicates the optimal numeric value.
        [<CustomOperation("optimum")>]
        member inline _.optimum([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("optimum" =>>> v)

        /// Indicates the optimal numeric value.
        [<CustomOperation("optimum")>]
        member inline this.optimum([<InlineIfLambda>] render: AttrRenderFragment) = this.optimum(render, true)

    type EltBuilder_object() =
        inherit EltWithChildBuilder("object")

        /// The border width.Note: This is a legacy attribute. Please use the CSS border property instead.
        [<CustomOperation("border")>]
        member inline _.border([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("border" => v)

        /// Specifies the URL of the resource.
        [<CustomOperation("data")>]
        member inline _.data([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("data" => v)

        /// Indicates the form that is the owner of the element.
        [<CustomOperation("form")>]
        member inline _.form([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("form" =>>> v)

        /// Indicates the form that is the owner of the element.
        [<CustomOperation("form")>]
        member inline this.form([<InlineIfLambda>] render: AttrRenderFragment) = this.form(render, true)

        /// Specifies the height of elements listed here. For all other elements, use the CSS height property. Note: In some instances, such as <div>, this is a legacy attribute, in which case the CSS height property should be used instead.
        [<CustomOperation("height")>]
        member inline _.height([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("height" => v)

        /// Name of the element. For example used by the server to identify the fields in form submits.
        [<CustomOperation("name")>]
        member inline _.name([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("name" => v)

        /// Defines the type of the element.
        [<CustomOperation("type'")>]
        member inline _.type'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("type" => v)

        
        [<CustomOperation("usemap")>]
        member inline _.usemap([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("usemap" => v)

        /// For the elements listed here, this establishes the element's width.Note: For all other instances, such as <div>, this is a legacy attribute, in which case the CSS width property should be used instead.
        [<CustomOperation("width")>]
        member inline _.width([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("width" => v)

    type EltBuilder_ol() =
        inherit EltWithChildBuilder("ol")

        /// Indicates whether the list should be displayed in a descending order instead of an ascending order.
        [<CustomOperation("reversed")>]
        member inline _.reversed([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("reversed" =>>> v)

        /// Indicates whether the list should be displayed in a descending order instead of an ascending order.
        [<CustomOperation("reversed")>]
        member inline this.reversed([<InlineIfLambda>] render: AttrRenderFragment) = this.reversed(render, true)

        /// Defines the first number if other than 1.
        [<CustomOperation("start")>]
        member inline _.start([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("start" => v)

        /// Defines the type of the element.
        [<CustomOperation("type'")>]
        member inline _.type'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("type" => v)

    type EltBuilder_optgroup() =
        inherit EltWithChildBuilder("optgroup")

        /// Indicates whether the user can interact with the element.
        [<CustomOperation("disabled")>]
        member inline _.disabled([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("disabled" =>>> v)

        /// Indicates whether the user can interact with the element.
        [<CustomOperation("disabled")>]
        member inline this.disabled([<InlineIfLambda>] render: AttrRenderFragment) = this.disabled(render, true)

        /// Specifies a user-readable title of the element.
        [<CustomOperation("label")>]
        member inline _.label([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("label" => v)

    type EltBuilder_option() =
        inherit EltWithChildBuilder("option")

        /// Indicates whether the user can interact with the element.
        [<CustomOperation("disabled")>]
        member inline _.disabled([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("disabled" =>>> v)

        /// Indicates whether the user can interact with the element.
        [<CustomOperation("disabled")>]
        member inline this.disabled([<InlineIfLambda>] render: AttrRenderFragment) = this.disabled(render, true)

        /// Specifies a user-readable title of the element.
        [<CustomOperation("label")>]
        member inline _.label([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("label" => v)

        /// Defines a value which will be selected on page load.
        [<CustomOperation("selected")>]
        member inline _.selected([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("selected" => v)

    type EltBuilder_output() =
        inherit EltWithChildBuilder("output")

        /// Describes elements which belongs to this one.
        [<CustomOperation("for'")>]
        member inline _.for'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("for" => v)

        /// Indicates the form that is the owner of the element.
        [<CustomOperation("form")>]
        member inline _.form([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("form" =>>> v)

        /// Indicates the form that is the owner of the element.
        [<CustomOperation("form")>]
        member inline this.form([<InlineIfLambda>] render: AttrRenderFragment) = this.form(render, true)

        /// Name of the element. For example used by the server to identify the fields in form submits.
        [<CustomOperation("name")>]
        member inline _.name([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("name" => v)

    type EltBuilder_param() =
        inherit EltWithChildBuilder("param")

        /// Name of the element. For example used by the server to identify the fields in form submits.
        [<CustomOperation("name")>]
        member inline _.name([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("name" => v)

    type EltBuilder_progress() =
        inherit EltWithChildBuilder("progress")

        /// Indicates the form that is the owner of the element.
        [<CustomOperation("form")>]
        member inline _.form([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("form" =>>> v)

        /// Indicates the form that is the owner of the element.
        [<CustomOperation("form")>]
        member inline this.form([<InlineIfLambda>] render: AttrRenderFragment) = this.form(render, true)

        /// Indicates the maximum value allowed.
        [<CustomOperation("max")>]
        member inline _.max([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("max" => v)

        /// Indicates the maximum value allowed.
        [<CustomOperation("max")>]
        member inline this.max([<InlineIfLambda>] render: AttrRenderFragment) = this.max(render, true)

    type EltBuilder_q() =
        inherit EltWithChildBuilder("q")

        /// Contains a URI which points to the source of the quote or change.
        [<CustomOperation("cite")>]
        member inline _.cite([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("cite" => v)

    type EltBuilder_select() =
        inherit EltWithChildBuilder("select")

        /// Indicates whether controls in this form can by default have their values automatically completed by the browser.
        [<CustomOperation("autocomplete")>]
        member inline _.autocomplete([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("autocomplete" =>> (if v then "on" else "off"))

        /// Indicates whether controls in this form can by default have their values automatically completed by the browser.
        [<CustomOperation("autocomplete")>]
        member inline this.autocomplete([<InlineIfLambda>] render: AttrRenderFragment) = this.autocomplete(render, true)

        /// Indicates whether the user can interact with the element.
        [<CustomOperation("disabled")>]
        member inline _.disabled([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("disabled" =>>> v)

        /// Indicates whether the user can interact with the element.
        [<CustomOperation("disabled")>]
        member inline this.disabled([<InlineIfLambda>] render: AttrRenderFragment) = this.disabled(render, true)

        /// Indicates the form that is the owner of the element.
        [<CustomOperation("form")>]
        member inline _.form([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("form" =>>> v)

        /// Indicates the form that is the owner of the element.
        [<CustomOperation("form")>]
        member inline this.form([<InlineIfLambda>] render: AttrRenderFragment) = this.form(render, true)

        /// Indicates whether multiple values can be entered in an input of the type email or file.
        [<CustomOperation("multiple")>]
        member inline _.multiple([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("multiple" =>>> v)

        /// Indicates whether multiple values can be entered in an input of the type email or file.
        [<CustomOperation("multiple")>]
        member inline this.multiple([<InlineIfLambda>] render: AttrRenderFragment) = this.multiple(render, true)

        /// Name of the element. For example used by the server to identify the fields in form submits.
        [<CustomOperation("name")>]
        member inline _.name([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("name" => v)

        /// Indicates whether this element is required to fill out or not.
        [<CustomOperation("required")>]
        member inline _.required([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("required" =>>> v)

        /// Indicates whether this element is required to fill out or not.
        [<CustomOperation("required")>]
        member inline this.required([<InlineIfLambda>] render: AttrRenderFragment) = this.required(render, true)

        /// Defines the width of the element (in pixels). If the element's type attribute is text or password then it's the number of characters.
        [<CustomOperation("size")>]
        member inline _.size([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("size" => v)

    type EltBuilder_source() =
        inherit EltWithChildBuilder("source")

        /// Specifies a hint of the media for which the linked resource was designed.
        [<CustomOperation("media")>]
        member inline _.media([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("media" => v)

        
        [<CustomOperation("sizes")>]
        member inline _.sizes([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("sizes" => v)

        /// The URL of the embeddable content.
        [<CustomOperation("src")>]
        member inline _.src([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("src" => v)

        /// One or more responsive image candidates.
        [<CustomOperation("srcset")>]
        member inline _.srcset([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("srcset" => v)

        /// Defines the type of the element.
        [<CustomOperation("type'")>]
        member inline _.type'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("type" => v)

    type EltBuilder_style() =
        inherit EltWithChildBuilder("style")

        /// Specifies a hint of the media for which the linked resource was designed.
        [<CustomOperation("media")>]
        member inline _.media([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("media" => v)

        /// Defines the type of the element.
        [<CustomOperation("type'")>]
        member inline _.type'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("type" => v)

    type EltBuilder_table() =
        inherit EltWithChildBuilder("table")

        /// Specifies the URL of an image file. Note: Although browsers and email clients may still support this attribute, it is obsolete. Use CSS background-image instead.
        [<CustomOperation("background")>]
        member inline _.background([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("background" => v)

        /// Background color of the element.Note: This is a legacy attribute. Please use the CSS background-color property instead.
        [<CustomOperation("bgcolor")>]
        member inline _.bgcolor([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("bgcolor" => v)

        /// The border width.Note: This is a legacy attribute. Please use the CSS border property instead.
        [<CustomOperation("border")>]
        member inline _.border([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("border" => v)

    type EltBuilder_tbody() =
        inherit EltWithChildBuilder("tbody")

        /// Background color of the element.Note: This is a legacy attribute. Please use the CSS background-color property instead.
        [<CustomOperation("bgcolor")>]
        member inline _.bgcolor([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("bgcolor" => v)

    type EltBuilder_td() =
        inherit EltWithChildBuilder("td")

        /// Specifies the URL of an image file. Note: Although browsers and email clients may still support this attribute, it is obsolete. Use CSS background-image instead.
        [<CustomOperation("background")>]
        member inline _.background([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("background" => v)

        /// Background color of the element.Note: This is a legacy attribute. Please use the CSS background-color property instead.
        [<CustomOperation("bgcolor")>]
        member inline _.bgcolor([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("bgcolor" => v)

        /// The colspan attribute defines the number of columns a cell should span.
        [<CustomOperation("colspan")>]
        member inline _.colspan([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("colspan" => v)

        /// IDs of the <th> elements which applies to this element.
        [<CustomOperation("headers")>]
        member inline _.headers([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("headers" => v)

        /// Defines the number of rows a table cell should span over.
        [<CustomOperation("rowspan")>]
        member inline _.rowspan([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("rowspan" => v)

    type EltBuilder_textarea() =
        inherit EltWithChildBuilder("textarea")

        /// Indicates whether controls in this form can by default have their values automatically completed by the browser.
        [<CustomOperation("autocomplete")>]
        member inline _.autocomplete([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("autocomplete" =>> (if v then "on" else "off"))

        /// Indicates whether controls in this form can by default have their values automatically completed by the browser.
        [<CustomOperation("autocomplete")>]
        member inline this.autocomplete([<InlineIfLambda>] render: AttrRenderFragment) = this.autocomplete(render, true)

        /// Defines the number of columns in a textarea.
        [<CustomOperation("cols")>]
        member inline _.cols([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("cols" => v)

        
        [<CustomOperation("dirname")>]
        member inline _.dirname([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("dirname" => v)

        /// Indicates whether the user can interact with the element.
        [<CustomOperation("disabled")>]
        member inline _.disabled([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("disabled" =>>> v)

        /// Indicates whether the user can interact with the element.
        [<CustomOperation("disabled")>]
        member inline this.disabled([<InlineIfLambda>] render: AttrRenderFragment) = this.disabled(render, true)

        /// The enterkeyhint specifies what action label (or icon) to present for the enter key on virtual keyboards. The attribute can be used with form controls (such as the value of textarea elements), or in elements in an editing host (e.g., using contenteditable attribute).
        [<CustomOperation("enterkeyhintExperimental")>]
        member inline _.enterkeyhintExperimental([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("enterkeyhintExperimental" => v)

        /// Indicates the form that is the owner of the element.
        [<CustomOperation("form")>]
        member inline _.form([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("form" =>>> v)

        /// Indicates the form that is the owner of the element.
        [<CustomOperation("form")>]
        member inline this.form([<InlineIfLambda>] render: AttrRenderFragment) = this.form(render, true)

        /// Provides a hint as to the type of data that might be entered by the user while editing the element or its contents. The attribute can be used with form controls (such as the value of textarea elements), or in elements in an editing host (e.g., using contenteditable attribute).
        [<CustomOperation("inputmode")>]
        member inline _.inputmode([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("inputmode" => v)

        /// Defines the maximum number of characters allowed in the element.
        [<CustomOperation("maxlength")>]
        member inline _.maxlength([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("maxlength" => v)

        /// Defines the minimum number of characters allowed in the element.
        [<CustomOperation("minlength")>]
        member inline _.minlength([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("minlength" => v)

        /// Name of the element. For example used by the server to identify the fields in form submits.
        [<CustomOperation("name")>]
        member inline _.name([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("name" => v)

        /// Provides a hint to the user of what can be entered in the field.
        [<CustomOperation("placeholder")>]
        member inline _.placeholder([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("placeholder" => v)

        /// Indicates whether the element can be edited.
        [<CustomOperation("readonly")>]
        member inline _.readonly([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("readonly" =>>> v)

        /// Indicates whether the element can be edited.
        [<CustomOperation("readonly")>]
        member inline this.readonly([<InlineIfLambda>] render: AttrRenderFragment) = this.readonly(render, true)

        /// Indicates whether this element is required to fill out or not.
        [<CustomOperation("required")>]
        member inline _.required([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("required" =>>> v)

        /// Indicates whether this element is required to fill out or not.
        [<CustomOperation("required")>]
        member inline this.required([<InlineIfLambda>] render: AttrRenderFragment) = this.required(render, true)

        /// Defines the number of rows in a text area.
        [<CustomOperation("rows")>]
        member inline _.rows([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("rows" => v)

        /// Indicates whether the text should be wrapped.
        [<CustomOperation("wrap")>]
        member inline _.wrap([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("wrap" =>>> v)

        /// Indicates whether the text should be wrapped.
        [<CustomOperation("wrap")>]
        member inline this.wrap([<InlineIfLambda>] render: AttrRenderFragment) = this.wrap(render, true)

    type EltBuilder_tfoot() =
        inherit EltWithChildBuilder("tfoot")

        /// Background color of the element.Note: This is a legacy attribute. Please use the CSS background-color property instead.
        [<CustomOperation("bgcolor")>]
        member inline _.bgcolor([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("bgcolor" => v)

    type EltBuilder_th() =
        inherit EltWithChildBuilder("th")

        /// Specifies the URL of an image file. Note: Although browsers and email clients may still support this attribute, it is obsolete. Use CSS background-image instead.
        [<CustomOperation("background")>]
        member inline _.background([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("background" => v)

        /// Background color of the element.Note: This is a legacy attribute. Please use the CSS background-color property instead.
        [<CustomOperation("bgcolor")>]
        member inline _.bgcolor([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("bgcolor" => v)

        /// The colspan attribute defines the number of columns a cell should span.
        [<CustomOperation("colspan")>]
        member inline _.colspan([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("colspan" => v)

        /// IDs of the <th> elements which applies to this element.
        [<CustomOperation("headers")>]
        member inline _.headers([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("headers" => v)

        /// Defines the number of rows a table cell should span over.
        [<CustomOperation("rowspan")>]
        member inline _.rowspan([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("rowspan" => v)

        /// Defines the cells that the header test (defined in the th element) relates to.
        [<CustomOperation("scope")>]
        member inline _.scope([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("scope" => v)

    type EltBuilder_thead() =
        inherit EltWithChildBuilder("thead")

    type EltBuilder_time() =
        inherit EltWithChildBuilder("time")

        /// Indicates the date and time associated with the element.
        [<CustomOperation("datetime")>]
        member inline _.datetime([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("datetime" =>>> v)

        /// Indicates the date and time associated with the element.
        [<CustomOperation("datetime")>]
        member inline this.datetime([<InlineIfLambda>] render: AttrRenderFragment) = this.datetime(render, true)

    type EltBuilder_tr() =
        inherit EltWithChildBuilder("tr")

        /// Background color of the element.Note: This is a legacy attribute. Please use the CSS background-color property instead.
        [<CustomOperation("bgcolor")>]
        member inline _.bgcolor([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("bgcolor" => v)

    type EltBuilder_track() =
        inherit EltWithChildBuilder("track")

        /// Indicates that the track should be enabled unless the user's preferences indicate something different.
        [<CustomOperation("default'")>]
        member inline _.default'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("default" =>>> v)

        /// Indicates that the track should be enabled unless the user's preferences indicate something different.
        [<CustomOperation("default'")>]
        member inline this.default'([<InlineIfLambda>] render: AttrRenderFragment) = this.default'(render, true)

        /// Specifies the kind of text track.
        [<CustomOperation("kind")>]
        member inline _.kind([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("kind" => v)

        /// Specifies a user-readable title of the element.
        [<CustomOperation("label")>]
        member inline _.label([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("label" => v)

        /// The URL of the embeddable content.
        [<CustomOperation("src")>]
        member inline _.src([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("src" => v)

        
        [<CustomOperation("srclang")>]
        member inline _.srclang([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("srclang" => v)

    type EltBuilder_video() =
        inherit EltWithChildBuilder("video")

        /// The audio or video should play as soon as possible.
        [<CustomOperation("autoplay")>]
        member inline _.autoplay([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("autoplay" =>>> v)

        /// The audio or video should play as soon as possible.
        [<CustomOperation("autoplay")>]
        member inline this.autoplay([<InlineIfLambda>] render: AttrRenderFragment) = this.autoplay(render, true)

        /// Contains the time range of already buffered media.
        [<CustomOperation("buffered")>]
        member inline _.buffered([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("buffered" => v)

        /// Indicates whether the browser should show playback controls to the user.
        [<CustomOperation("controls")>]
        member inline _.controls([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("controls" =>>> v)

        /// Indicates whether the browser should show playback controls to the user.
        [<CustomOperation("controls")>]
        member inline this.controls([<InlineIfLambda>] render: AttrRenderFragment) = this.controls(render, true)

        /// How the element handles cross-origin requests
        [<CustomOperation("crossorigin")>]
        member inline _.crossorigin([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("crossorigin" => v)

        /// Specifies the height of elements listed here. For all other elements, use the CSS height property. Note: In some instances, such as <div>, this is a legacy attribute, in which case the CSS height property should be used instead.
        [<CustomOperation("height")>]
        member inline _.height([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("height" => v)

        /// Indicates whether the media should start playing from the start when it's finished.
        [<CustomOperation("loop")>]
        member inline _.loop([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("loop" =>>> v)

        /// Indicates whether the media should start playing from the start when it's finished.
        [<CustomOperation("loop")>]
        member inline this.loop([<InlineIfLambda>] render: AttrRenderFragment) = this.loop(render, true)

        /// Indicates whether the audio will be initially silenced on page load.
        [<CustomOperation("muted")>]
        member inline _.muted([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("muted" =>>> v)

        /// Indicates whether the audio will be initially silenced on page load.
        [<CustomOperation("muted")>]
        member inline this.muted([<InlineIfLambda>] render: AttrRenderFragment) = this.muted(render, true)

        /// A Boolean attribute indicating that the video is to be played "inline"; that is, within the element's playback area. Note that the absence of this attribute does not imply that the video will always be played in fullscreen.
        [<CustomOperation("playsinline")>]
        member inline _.playsinline([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("playsinline" => v)

        /// A URL indicating a poster frame to show until the user plays or seeks.
        [<CustomOperation("poster")>]
        member inline _.poster([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("poster" => v)

        /// Indicates whether the whole resource, parts of it or nothing should be preloaded.
        [<CustomOperation("preload")>]
        member inline _.preload([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("preload" =>>> v)

        /// Indicates whether the whole resource, parts of it or nothing should be preloaded.
        [<CustomOperation("preload")>]
        member inline this.preload([<InlineIfLambda>] render: AttrRenderFragment) = this.preload(render, true)

        /// The URL of the embeddable content.
        [<CustomOperation("src")>]
        member inline _.src([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("src" => v)

        /// For the elements listed here, this establishes the element's width.Note: For all other instances, such as <div>, this is a legacy attribute, in which case the CSS width property should be used instead.
        [<CustomOperation("width")>]
        member inline _.width([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("width" => v)


[<AutoOpen>]
module DslElements_generated =

    open DslElementBuilder_generated

    /// Together with its href attribute, creates a hyperlink to web pages, files, email addresses, locations within the current page, or anything else a URL can address.
    let a = EltBuilder_a()

    /// Represents an abbreviation or acronym.
    let abbr = EltWithChildBuilder("abbr")

    /// Indicates that the enclosed HTML provides contact information for a person or people, or for an organization.
    let address = EltWithChildBuilder("address")

    /// Defines an area inside an image map that has predefined clickable areas. An image map allows geometric areas on an image to be associated with hyperlink.
    let area = EltBuilder_area()

    /// Represents a self-contained composition in a document, page, application, or site, which is intended to be independently distributable or reusable (e.g., in syndication). Examples include a forum post, a magazine or newspaper article, a blog entry, a product card, a user-submitted comment, an interactive widget or gadget, or any other independent item of content.
    let article = EltWithChildBuilder("article")

    /// Represents a portion of a document whose content is only indirectly related to the document's main content. Asides are frequently presented as sidebars or call-out boxes.
    let aside = EltWithChildBuilder("aside")

    /// Used to embed sound content in documents. It may contain one or more audio sources, represented using the src attribute or the source element: the browser will choose the most suitable one. It can also be the destination for streamed media, using a MediaStream.
    let audio = EltBuilder_audio()

    /// Used to draw the reader's attention to the element's contents, which are not otherwise granted special importance. This was formerly known as the Boldface element, and most browsers still draw the text in boldface. However, you should not use <b> for styling text or granting importance. If you wish to create boldface text, you should use the CSS font-weight property. If you wish to indicate an element is of special importance, you should use the strong element.
    let b = EltWithChildBuilder("b")

    /// Specifies the base URL to use for all relative URLs in a document. There can be only one such element in a document.
    let base' = EltBuilder_base()

    /// Tells the browser's bidirectional algorithm to treat the text it contains in isolation from its surrounding text. It's particularly useful when a website dynamically inserts some text and doesn't know the directionality of the text being inserted.
    let bdi = EltWithChildBuilder("bdi")

    /// Overrides the current directionality of text, so that the text within is rendered in a different direction.
    let bdo = EltWithChildBuilder("bdo")

    /// Indicates that the enclosed text is an extended quotation. Usually, this is rendered visually by indentation. A URL for the source of the quotation may be given using the cite attribute, while a text representation of the source can be given using the <cite> element.
    let blockquote = EltBuilder_blockquote()

    /// represents the content of an HTML document. There can be only one such element in a document.
    let body = EltBuilder_body()

    /// Produces a line break in text (carriage-return). It is useful for writing a poem or an address, where the division of lines is significant.
    let br = EltWithChildBuilder("br")

    /// An interactive element activated by a user with a mouse, keyboard, finger, voice command, or other assistive technology. Once activated, it performs an action, such as submitting a form or opening a dialog.
    let button = EltBuilder_button()

    /// Container element to use with either the canvas scripting API or the WebGL API to draw graphics and animations.
    let canvas = EltBuilder_canvas()

    /// Specifies the caption (or title) of a table.
    let caption = EltBuilder_caption()

    /// Used to mark up the title of a cited creative work. The reference may be in an abbreviated form according to context-appropriate conventions related to citation metadata.
    let cite = EltWithChildBuilder("cite")

    /// Displays its contents styled in a fashion intended to indicate that the text is a short fragment of computer code. By default, the content text is displayed using the user agent's default monospace font.
    let code = EltWithChildBuilder("code")

    /// Defines a column within a table and is used for defining common semantics on all common cells. It is generally found within a <colgroup> element.
    let col = EltBuilder_col()

    /// Defines a group of columns within a table.
    let colgroup = EltBuilder_colgroup()

    /// Links a given piece of content with a machine-readable translation. If the content is time- or date-related, the<time> element must be used.
    let data = EltBuilder_data()

    /// Contains a set of <option> elements that represent the permissible or recommended options available to choose from within other controls.
    let datalist = EltWithChildBuilder("datalist")

    /// Provides the description, definition, or value for the preceding term (<dt>) in a description list (<dl>).
    let dd = EltWithChildBuilder("dd")

    /// Represents a range of text that has been deleted from a document. This can be used when rendering "track changes" or source code diff information, for example. The <ins> element can be used for the opposite purpose: to indicate text that has been added to the document.
    let del = EltBuilder_del()

    /// Creates a disclosure widget in which information is visible only when the widget is toggled into an "open" state. A summary or label must be provided using the <summary> element.
    let details = EltBuilder_details()

    /// Used to indicate the term being defined within the context of a definition phrase or sentence. The ancestor <p> element, the <dt>/<dd> pairing, or the nearest section ancestor of the <dfn> element, is considered to be the definition of the term.
    let dfn = EltWithChildBuilder("dfn")

    /// Represents a dialog box or other interactive component, such as a dismissible alert, inspector, or subwindow.
    let dialog = EltBuilder_dialog()

    /// The generic container for flow content. It has no effect on the content or layout until styled in some way using CSS (e.g., styling is directly applied to it, or some kind of layout model like flexbox is applied to its parent element).
    let div = EltWithChildBuilder("div")

    /// Represents a description list. The element encloses a list of groups of terms (specified using the <dt> element) and descriptions (provided by <dd> elements). Common uses for this element are to implement a glossary or to display metadata (a list of key-value pairs).
    let dl = EltWithChildBuilder("dl")

    /// Specifies a term in a description or definition list, and as such must be used inside a <dl> element. It is usually followed by a <dd> element; however, multiple <dt> elements in a row indicate several terms that are all defined by the immediate next <dd> element.
    let dt = EltWithChildBuilder("dt")

    /// Marks text that has stress emphasis. The <em> element can be nested, with each nesting level indicating a greater degree of emphasis.
    let em = EltWithChildBuilder("em")

    /// Embeds external content at the specified point in the document. This content is provided by an external application or other source of interactive content such as a browser plug-in.
    let embed = EltBuilder_embed()

    /// Used to group several controls as well as labels (<label>) within a web form.
    let fieldset = EltBuilder_fieldset()

    /// Represents a caption or legend describing the rest of the contents of its parent <figure> element.
    let figcaption = EltWithChildBuilder("figcaption")

    /// Represents self-contained content, potentially with an optional caption, which is specified using the <figcaption> element. The figure, its caption, and its contents are referenced as a single unit.
    let figure = EltWithChildBuilder("figure")

    /// Represents a footer for its nearest ancestor sectioning content or sectioning root element. A <footer> typically contains information about the author of the section, copyright data, or links to related documents.
    let footer = EltWithChildBuilder("footer")

    /// Represents a document section containing interactive controls for submitting information.
    let form = EltBuilder_form()

    /// Represent six levels of section headings. <h1> is the highest section level and <h6> is the lowest.
    let h1 = EltWithChildBuilder("h1")

    /// Represent six levels of section headings. <h1> is the highest section level and <h6> is the lowest.
    let h2 = EltWithChildBuilder("h2")

    /// Represent six levels of section headings. <h1> is the highest section level and <h6> is the lowest.
    let h3 = EltWithChildBuilder("h3")

    /// Represent six levels of section headings. <h1> is the highest section level and <h6> is the lowest.
    let h4 = EltWithChildBuilder("h4")

    /// Represent six levels of section headings. <h1> is the highest section level and <h6> is the lowest.
    let h5 = EltWithChildBuilder("h5")

    /// Represent six levels of section headings. <h1> is the highest section level and <h6> is the lowest.
    let h6 = EltWithChildBuilder("h6")

    /// Contains machine-readable information (metadata) about the document, like its title, scripts, and style sheets.
    let head = EltWithChildBuilder("head")

    /// Represents introductory content, typically a group of introductory or navigational aids. It may contain some heading elements but also a logo, a search form, an author name, and other elements.
    let header = EltWithChildBuilder("header")

    /// Represents a heading grouped with any secondary content, such as subheadings, an alternative title, or a tagline.
    let hgroup = EltWithChildBuilder("hgroup")

    /// Represents a thematic break between paragraph-level elements: for example, a change of scene in a story, or a shift of topic within a section.
    let hr = EltBuilder_hr()

    /// Represents the root (top-level element) of an HTML document, so it is also referred to as the root element. All other elements must be descendants of this element.
    let html' = EltBuilder_html()

    /// Represents a range of text that is set off from the normal text for some reason, such as idiomatic text, technical terms, and taxonomical designations, among others. Historically, these have been presented using italicized type, which is the original source of the <i> naming of this element.
    let i = EltWithChildBuilder("i")

    /// Represents a nested browsing context, embedding another HTML page into the current one.
    let iframe = EltBuilder_iframe()

    /// Embeds an image into the document.
    let img = EltBuilder_img()

    /// Used to create interactive controls for web-based forms to accept data from the user; a wide variety of types of input data and control widgets are available, depending on the device and user agent. The <input> element is one of the most powerful and complex in all of HTML due to the sheer number of combinations of input types and attributes.
    let input = EltBuilder_input()

    /// Represents a range of text that has been added to a document. You can use the <del> element to similarly represent a range of text that has been deleted from the document.
    let ins = EltBuilder_ins()

    /// Represents a span of inline text denoting textual user input from a keyboard, voice input, or any other text entry device. By convention, the user agent defaults to rendering the contents of a <kbd> element using its default monospace font, although this is not mandated by the HTML standard.
    let kbd = EltWithChildBuilder("kbd")

    /// Represents a caption for an item in a user interface.
    let label = EltBuilder_label()

    /// Represents a caption for the content of its parent <fieldset>.
    let legend = EltWithChildBuilder("legend")

    /// Represents an item in a list. It must be contained in a parent element: an ordered list (<ol>), an unordered list (<ul>), or a menu (<menu>). In menus and unordered lists, list items are usually displayed using bullet points. In ordered lists, they are usually displayed with an ascending counter on the left, such as a number or letter.
    let li = EltBuilder_li()

    /// Specifies relationships between the current document and an external resource. This element is most commonly used to link to CSS but is also used to establish site icons (both "favicon" style icons and icons for the home screen and apps on mobile devices) among other things.
    let link = EltBuilder_link()

    /// Represents the dominant content of the body of a document. The main content area consists of content that is directly related to or expands upon the central topic of a document, or the central functionality of an application.
    let main = EltWithChildBuilder("main")

    /// Used with <area> elements to define an image map (a clickable link area).
    let map = EltBuilder_map()

    /// Represents text which is marked or highlighted for reference or notation purposes due to the marked passage's relevance in the enclosing context.
    let mark = EltWithChildBuilder("mark")

    /// A semantic alternative to <ul>, but treated by browsers (and exposed through the accessibility tree) as no different than <ul>. It represents an unordered list of items (which are represented by <li> elements).
    let menu = EltBuilder_menu()

    /// Represents metadata that cannot be represented by other HTML meta-related elements, like <base>, <link>, <script>, <style> and <title>.
    let meta = EltBuilder_meta()

    /// Represents either a scalar value within a known range or a fractional value.
    let meter = EltBuilder_meter()

    /// Represents a section of a page whose purpose is to provide navigation links, either within the current document or to other documents. Common examples of navigation sections are menus, tables of contents, and indexes.
    let nav = EltWithChildBuilder("nav")

    /// Defines a section of HTML to be inserted if a script type on the page is unsupported or if scripting is currently turned off in the browser.
    let noscript = EltWithChildBuilder("noscript")

    /// Represents an external resource, which can be treated as an image, a nested browsing context, or a resource to be handled by a plugin.
    let object = EltBuilder_object()

    /// Represents an ordered list of items â typically rendered as a numbered list.
    let ol = EltBuilder_ol()

    /// Creates a grouping of options within a <select> element.
    let optgroup = EltBuilder_optgroup()

    /// Used to define an item contained in a select, an <optgroup>, or a <datalist> element. As such, <option> can represent menu items in popups and other lists of items in an HTML document.
    let option = EltBuilder_option()

    /// Container element into which a site or app can inject the results of a calculation or the outcome of a user action.
    let output = EltBuilder_output()

    /// Represents a paragraph. Paragraphs are usually represented in visual media as blocks of text separated from adjacent blocks by blank lines and/or first-line indentation, but HTML paragraphs can be any structural grouping of related content, such as images or form fields.
    let p = EltWithChildBuilder("p")

    /// Contains zero or more <source> elements and one <img> element to offer alternative versions of an image for different display/device scenarios.
    let picture = EltWithChildBuilder("picture")

    /// Enables the embedding of another HTML page into the current one to enable smoother navigation into new pages.
    let portal = EltWithChildBuilder("portal")

    /// Represents preformatted text which is to be presented exactly as written in the HTML file. The text is typically rendered using a non-proportional, or monospaced, font. Whitespace inside this element is displayed as written.
    let pre = EltWithChildBuilder("pre")

    /// Displays an indicator showing the completion progress of a task, typically displayed as a progress bar.
    let progress = EltBuilder_progress()

    /// Indicates that the enclosed text is a short inline quotation. Most modern browsers implement this by surrounding the text in quotation marks. This element is intended for short quotations that don't require paragraph breaks; for long quotations use the <blockquote> element.
    let q = EltBuilder_q()

    /// Used to provide fall-back parentheses for browsers that do not support the display of ruby annotations using the <ruby> element. One <rp> element should enclose each of the opening and closing parentheses that wrap the <rt> element that contains the annotation's text.
    let rp = EltWithChildBuilder("rp")

    /// Specifies the ruby text component of a ruby annotation, which is used to provide pronunciation, translation, or transliteration information for East Asian typography. The <rt> element must always be contained within a <ruby> element.
    let rt = EltWithChildBuilder("rt")

    /// Represents small annotations that are rendered above, below, or next to base text, usually used for showing the pronunciation of East Asian characters. It can also be used for annotating other kinds of text, but this usage is less common.
    let ruby = EltWithChildBuilder("ruby")

    /// Renders text with a strikethrough, or a line through it. Use the <s> element to represent things that are no longer relevant or no longer accurate. However, <s> is not appropriate when indicating document edits; for that, use the del and ins elements, as appropriate.
    let s = EltWithChildBuilder("s")

    /// Used to enclose inline text which represents sample (or quoted) output from a computer program. Its contents are typically rendered using the browser's default monospaced font (such as Courier or Lucida Console).
    let samp = EltWithChildBuilder("samp")

    /// Used to embed executable code or data; this is typically used to embed or refer to JavaScript code. The <script> element can also be used with other languages, such as WebGL's GLSL shader programming language and JSON.
    let script = EltBuilder_script()

    /// Represents a part that contains a set of form controls or other content related to performing a search or filtering operation.
    let search = EltWithChildBuilder("search")

    /// Represents a generic standalone section of a document, which doesn't have a more specific semantic element to represent it. Sections should always have a heading, with very few exceptions.
    let section = EltWithChildBuilder("section")

    /// Represents a control that provides a menu of options.
    let select = EltBuilder_select()

    /// Part of the Web Components technology suite, this element is a placeholder inside a web component that you can fill with your own markup, which lets you create separate DOM trees and present them together.
    let slot = EltWithChildBuilder("slot")

    /// Represents side-comments and small print, like copyright and legal text, independent of its styled presentation. By default, it renders text within it one font size smaller, such as from small to x-small.
    let small = EltWithChildBuilder("small")

    /// Specifies multiple media resources for the picture, the audio element, or the video element. It is a void element, meaning that it has no content and does not have a closing tag. It is commonly used to offer the same media content in multiple file formats in order to provide compatibility with a broad range of browsers given their differing support for image file formats and media file formats.
    let source = EltBuilder_source()

    /// A generic inline container for phrasing content, which does not inherently represent anything. It can be used to group elements for styling purposes (using the class or id attributes), or because they share attribute values, such as lang. It should be used only when no other semantic element is appropriate. <span> is very much like a div element, but div is a block-level element whereas a <span> is an inline-level element.
    let span = EltWithChildBuilder("span")

    /// Indicates that its contents have strong importance, seriousness, or urgency. Browsers typically render the contents in bold type.
    let strong = EltWithChildBuilder("strong")

    /// Specifies inline text which should be displayed as subscript for solely typographical reasons. Subscripts are typically rendered with a lowered baseline using smaller text.
    let sub = EltWithChildBuilder("sub")

    /// Specifies a summary, caption, or legend for a details element's disclosure box. Clicking the <summary> element toggles the state of the parent <details> element open and closed.
    let summary = EltWithChildBuilder("summary")

    /// Specifies inline text which is to be displayed as superscript for solely typographical reasons. Superscripts are usually rendered with a raised baseline using smaller text.
    let sup = EltWithChildBuilder("sup")

    /// Represents tabular data â that is, information presented in a two-dimensional table comprised of rows and columns of cells containing data.
    let table = EltBuilder_table()

    /// Encapsulates a set of table rows (<tr> elements), indicating that they comprise the body of the table (<table>).
    let tbody = EltBuilder_tbody()

    /// Defines a cell of a table that contains data. It participates in the table model.
    let td = EltBuilder_td()

    /// A mechanism for holding HTML that is not to be rendered immediately when a page is loaded but may be instantiated subsequently during runtime using JavaScript.
    let template = EltWithChildBuilder("template")

    /// Represents a multi-line plain-text editing control, useful when you want to allow users to enter a sizeable amount of free-form text, for example, a comment on a review or feedback form.
    let textarea = EltBuilder_textarea()

    /// Defines a set of rows summarizing the columns of the table.
    let tfoot = EltBuilder_tfoot()

    /// Defines a cell as a header of a group of table cells. The exact nature of this group is defined by the scope and headers attributes.
    let th = EltBuilder_th()

    /// Defines a set of rows defining the head of the columns of the table.
    let thead = EltBuilder_thead()

    /// Represents a specific period in time. It may include the datetime attribute to translate dates into machine-readable format, allowing for better search engine results or custom features such as reminders.
    let time = EltBuilder_time()

    /// Defines the document's title that is shown in a browser's title bar or a page's tab. It only contains text; tags within the element are ignored.
    let title = EltWithChildBuilder("title")

    /// Defines a row of cells in a table. The row's cells can then be established using a mix of <td> (data cell) and <th> (header cell) elements.
    let tr = EltBuilder_tr()

    /// Used as a child of the media elements, audio and video. It lets you specify timed text tracks (or time-based data), for example to automatically handle subtitles. The tracks are formatted in WebVTT format (.vtt files)âWeb Video Text Tracks.
    let track = EltBuilder_track()

    /// Represents a span of inline text which should be rendered in a way that indicates that it has a non-textual annotation. This is rendered by default as a simple solid underline but may be altered using CSS.
    let u = EltWithChildBuilder("u")

    /// Represents an unordered list of items, typically rendered as a bulleted list.
    let ul = EltWithChildBuilder("ul")

    /// Represents the name of a variable in a mathematical expression or a programming context. It's typically presented using an italicized version of the current typeface, although that behavior is browser-dependent.
    let var = EltWithChildBuilder("var")

    /// Embeds a media player which supports video playback into the document. You can also use <video> for audio content, but the audio element may provide a more appropriate user experience.
    let video = EltBuilder_video()

    /// Represents a word break opportunityâa position within text where the browser may optionally break a line, though its line-breaking rules would not otherwise create a break at that location.
    let wbr = EltWithChildBuilder("wbr")

