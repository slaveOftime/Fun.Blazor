namespace Fun.Css

open System
open System.Text


module Internal =
    type CombineKeyValue = delegate of StringBuilder -> StringBuilder

    /// Merge two togeter
    let inline (&&&) ([<InlineIfLambda>] comb1: CombineKeyValue) ([<InlineIfLambda>] comb2: CombineKeyValue) =
        CombineKeyValue(fun sb -> comb2.Invoke(comb1.Invoke(sb)))

    /// Append key value pair
    let inline (&>>) ([<InlineIfLambda>] comb: CombineKeyValue) (x: string, value: string) =
        CombineKeyValue(fun sb -> comb.Invoke(sb).Append(x).Append(": ").Append(value).Append("; "))


    type Makers =
        static member inline mkPxWithKV(k: string, v: int) =
            CombineKeyValue(fun x -> x.Append(k).Append(": ").Append(v).Append("px; "))

        static member inline mkPxWithKV(k: string, v: float) =
            CombineKeyValue(fun x -> x.Append(k).Append(": ").Append(v).Append("px; "))

        static member inline mkWithKV(k: string, v: int) =
            CombineKeyValue(fun x -> x.Append(k).Append(": ").Append(v).Append("; "))

        static member inline mkWithKV(k: string, v: float) =
            CombineKeyValue(fun x -> x.Append(k).Append(": ").Append(v).Append("; "))


open Internal
open type Makers


type CssBuilder() =

    member inline _.Yield(_: unit) = CombineKeyValue(fun sb -> sb)
    member inline _.Yield([<InlineIfLambda>] x: CombineKeyValue) = x

    member inline _.Run([<InlineIfLambda>] combine: CombineKeyValue) = combine

    member inline _.For([<InlineIfLambda>] comb: CombineKeyValue, [<InlineIfLambda>] fn: unit -> CombineKeyValue) = comb &&& (fn ())

    member inline _.For(ls: 'T seq, [<InlineIfLambda>] fn: 'T -> CombineKeyValue) =
        ls |> Seq.map fn |> Seq.fold (&&&) (CombineKeyValue(fun x -> x))

    member _.Delay(fn: unit -> CombineKeyValue) = fn ()

    member inline _.Zero() = CombineKeyValue(fun sb -> sb)

    member inline _.Combine([<InlineIfLambda>] render1: CombineKeyValue, [<InlineIfLambda>] render2: CombineKeyValue) = render1 &&& render2


    /// Define a custom property
    [<CustomOperation("custom")>]
    member inline _.custom([<InlineIfLambda>] comb: CombineKeyValue, key: string, value: string) = comb &>> (key, value)


    [<CustomOperation("zoom")>]
    member inline _.zoom([<InlineIfLambda>] comb: CombineKeyValue, x: float) = comb &&& mkWithKV ("zoom", x)

    /// Specifies that all the element's properties should be changed to their initial values.
    [<CustomOperation("allInitial")>]
    member inline _.allInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("all", "initial")
    /// Specifies that all the element's properties should be changed to their inherited values.
    [<CustomOperation("allInherit")>]
    member inline _.allInherit([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("all", "inherit")
    /// Specifies that all the element's properties should be changed to their inherited values if they inherit by default, or to their initial values if not.
    [<CustomOperation("allUnset")>]
    member inline _.allUnset([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("all", "unset")

    /// Specifies behavior that depends on the stylesheet origin to which the declaration belongs:
    ///
    /// User-agent origin
    ///     Equivalent to unset.
    /// User origin
    ///     Rolls back the cascade to the user-agent level, so that the specified values are calculated as if no author-level or user-level rules were specified for the element.
    /// Author origin
    ///     Rolls back the cascade to the user level, so that the specified values are calculated as if no author-level rules were specified for the element. For purposes of revert, the Author origin includes the Override and Animation origins.
    [<CustomOperation("allRevert")>]
    member inline _.allRevert([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("all", "revert")

    [<CustomOperation("boxShadow")>]
    member inline _.boxShadow([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("box-shadow", value)

    [<CustomOperation("boxShadow")>]
    member inline _.boxShadow([<InlineIfLambda>] comb: CombineKeyValue, horizontalOffset: int, verticalOffset: int, color: string) =
        CombineKeyValue(fun x ->
            comb
                .Invoke(x)
                .Append("box-shadow")
                .Append(horizontalOffset)
                .Append("px ")
                .Append(verticalOffset)
                .Append("px ")
                .Append(color)
                .Append(";")
        )

    [<CustomOperation("boxShadow")>]
    member inline _.boxShadow([<InlineIfLambda>] comb: CombineKeyValue, horizontalOffset: int, verticalOffset: int, blur: int, color: string) =
        CombineKeyValue(fun x ->
            comb
                .Invoke(x)
                .Append("box-shadow: ")
                .Append(horizontalOffset)
                .Append("px ")
                .Append(verticalOffset)
                .Append("px ")
                .Append(blur)
                .Append("px ")
                .Append(color)
                .Append(";")
        )

    [<CustomOperation("boxShadow")>]
    member inline _.boxShadow
        (
            [<InlineIfLambda>] comb: CombineKeyValue,
            horizontalOffset: int,
            verticalOffset: int,
            blur: int,
            spread: int,
            color: string
        )
        =
        CombineKeyValue(fun x ->
            comb
                .Invoke(x)
                .Append("box-shadow: ")
                .Append(horizontalOffset)
                .Append("px ")
                .Append(verticalOffset)
                .Append("px ")
                .Append(blur)
                .Append("px ")
                .Append(spread)
                .Append("px ")
                .Append(color)
        )

    [<CustomOperation("boxShadowNone")>]
    member inline _.boxShadowNone([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("box-shadow", "none")
    /// Inherits this property from its parent element.
    [<CustomOperation("boxShadowInheritFromParent")>]
    member inline _.boxShadowInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("box-shadow", "inherit")

    [<CustomOperation("height")>]
    member inline _.height([<InlineIfLambda>] comb: CombineKeyValue, value: int) = comb &&& mkPxWithKV ("height", value)
    [<CustomOperation("height")>]
    member inline _.height([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("height", value)
    /// Inherits this property from its parent element.
    [<CustomOperation("heightInheritFromParent")>]
    member inline _.heightInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("height", "inherit")
    /// Sets this property to its default value.
    [<CustomOperation("heightInitial")>]
    member inline _.heightInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("height", "initial")
    /// The intrinsic preferred height.
    [<CustomOperation("heightMaxContent")>]
    member inline _.heightMaxContent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("height", "max-content")
    /// The intrinsic minimum height.
    [<CustomOperation("heightMinContent")>]
    member inline _.heightMinContent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("height", "min-content")

    [<CustomOperation("maxHeight")>]
    member inline _.maxHeight([<InlineIfLambda>] comb: CombineKeyValue, value: int) = comb &&& mkPxWithKV ("max-height", value)
    [<CustomOperation("maxHeight")>]
    member inline _.maxHeight([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("max-height", value)
    /// Inherits this property from its parent element.
    [<CustomOperation("maxHeightInheritFromParent")>]
    member inline _.maxHeightInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("max-height", "inherit")
    /// Sets this property to its default value.
    [<CustomOperation("maxHeightInitial")>]
    member inline _.maxHeightInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("max-height", "initial")
    /// The intrinsic preferred height.
    [<CustomOperation("maxHeightMaxContent")>]
    member inline _.maxHeightMaxContent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("height", "max-content")
    /// The intrinsic minimum height.
    [<CustomOperation("maxHeightMinContent")>]
    member inline _.maxHeightMinContent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("height", "min-content")

    [<CustomOperation("minHeight")>]
    member inline _.minHeight([<InlineIfLambda>] comb: CombineKeyValue, value: int) = comb &&& mkPxWithKV ("min-height", value)
    [<CustomOperation("minHeight")>]
    member inline _.minHeight([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("min-height", value)
    /// Inherits this property from its parent element.
    [<CustomOperation("minHeightInheritFromParent")>]
    member inline _.minHeightInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("min-height", "inherit")
    /// Sets this property to its default value.
    [<CustomOperation("minHeightInitial")>]
    member inline _.minHeightInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("min-height", "initial")
    /// The intrinsic preferred height.
    [<CustomOperation("minHeightMaxContent")>]
    member inline _.minHeightMaxContent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("height", "max-content")
    /// The intrinsic minimum height.
    [<CustomOperation("minHeightMinContent")>]
    member inline _.minHeightMinContent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("height", "min-content")

    /// The browser determines the justification algorithm
    [<CustomOperation("textJustifyAuto")>]
    member inline _.textJustifyAuto([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-justify", "auto")
    /// Increases/Decreases the space between words
    [<CustomOperation("textJustifyInterWord")>]
    member inline _.textJustifyInterWord([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-justify", "inter-word")
    /// Increases/Decreases the space between characters
    [<CustomOperation("textJustifyInterCharacter")>]
    member inline _.textJustifyInterCharacter([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-justify", "inter-character")
    /// Disables justification methods
    [<CustomOperation("textJustifyNone")>]
    member inline _.textJustifyNone([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-justify", "none")
    [<CustomOperation("textJustifyInitial")>]
    member inline _.textJustifyInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-justify", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("textJustifyInheritFromParent")>]
    member inline _.textJustifyInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-justify", "inherit")

    /// Sequences of whitespace will collapse into a single whitespace. Text will wrap when necessary. This is default.
    [<CustomOperation("whiteSpaceNormal")>]
    member inline _.whiteSpaceNormal([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("white-space", "normal")
    /// Sequences of whitespace will collapse into a single whitespace. Text will never wrap to the next line.
    /// The text continues on the same line until a `<br> ` tag is encountered.
    [<CustomOperation("whiteSpaceNowrap")>]
    member inline _.whiteSpaceNowrap([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("white-space", "nowrap")
    /// Whitespace is preserved by the browser. Text will only wrap on line breaks. Acts like the <pre> tag in HTML.
    [<CustomOperation("whiteSpacePre")>]
    member inline _.whiteSpacePre([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("white-space", "pre")
    /// Sequences of whitespace will collapse into a single whitespace. Text will wrap when necessary, and on line breaks
    [<CustomOperation("whiteSpacePreLine")>]
    member inline _.whiteSpacePreLine([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("white-space", "pre-line")
    /// Whitespace is preserved by the browser. Text will wrap when necessary, and on line breaks
    [<CustomOperation("whiteSpacePreWrap")>]
    member inline _.whiteSpacePreWrap([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("white-space", "pre-wrap")
    /// Sets this property to its default value.
    [<CustomOperation("whiteSpaceInitial")>]
    member inline _.whiteSpaceInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("white-space", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("whiteSpaceInheritFromParent")>]
    member inline _.whiteSpaceInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("white-space", "inherit")

    /// Default value. Uses default line break rules.
    [<CustomOperation("wordbreakNormal")>]
    member inline _.wordbreakNormal([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("word-break", "normal")
    /// To prevent overflow, word may be broken at any character
    [<CustomOperation("wordbreakBreakAll")>]
    member inline _.wordbreakBreakAll([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("word-break", "break-all")
    /// Word breaks should not be used for Chinese/Japanese/Korean (CJK) text. Non-CJK text behavior is the same as value "normal")
    [<CustomOperation("wordbreakKeepAll")>]
    member inline _.wordbreakKeepAll([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("word-break", "keep-all")
    /// To prevent overflow, word may be broken at arbitrary points.
    [<CustomOperation("wordbreakBreakWord")>]
    member inline _.wordbreakBreakWord([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("word-break", "break-word")
    /// Sets this property to its default value.
    [<CustomOperation("wordbreakInitial")>]
    member inline _.wordbreakInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("word-break", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("wordbreakInheritFromParent")>]
    member inline _.wordbreakInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("word-break", "inherit")

    /// Allows a straight jump "scroll effect" between elements within the scrolling box. This is default
    [<CustomOperation("scrollBehaviorAuto")>]
    member inline _.scrollBehaviorAuto([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("scroll-behavior", "auto")
    /// Allows a smooth animated "scroll effect" between elements within the scrolling box.
    [<CustomOperation("scrollBehaviorSmooth")>]
    member inline _.scrollBehaviorSmooth([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("scroll-behavior", "smooth")
    /// Sets this property to its default value.
    [<CustomOperation("scrollBehaviorInitial")>]
    member inline _.scrollBehaviorInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("scroll-behavior", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("scrollBehaviorInheritFromParent")>]
    member inline _.scrollBehaviorInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("scroll-behavior", "inherit")

    /// The content is not clipped, and it may be rendered outside the left and right edges. This is default.
    [<CustomOperation("overflowVisible")>]
    member inline _.overflowVisible([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("overflow", "visibile")
    /// The content is clipped - and no scrolling mechanism is provided.
    [<CustomOperation("overflowHidden")>]
    member inline _.overflowHidden([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("overflow", "hidden")
    /// The content is clipped and a scrolling mechanism is provided.
    [<CustomOperation("overflowScroll")>]
    member inline _.overflowScroll([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("overflow", "scroll")
    /// Should cause a scrolling mechanism to be provided for overflowing boxes
    [<CustomOperation("overflowAuto")>]
    member inline _.overflowAuto([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("overflow", "auto")
    /// Sets this property to its default value.
    [<CustomOperation("overflowInitial")>]
    member inline _.overflowInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("overflow", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("overflowInheritFromParent")>]
    member inline _.overflowInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("overflow", "inherit")

    /// The content is not clipped, and it may be rendered outside the left and right edges. This is default.
    [<CustomOperation("overflowXVisible")>]
    member inline _.overflowXVisible([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("overflow-x", "visibile")
    /// The content is clipped - and no scrolling mechanism is provided.
    [<CustomOperation("overflowXHidden")>]
    member inline _.overflowXHidden([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("overflow-x", "hidden")
    /// The content is clipped and a scrolling mechanism is provided.
    [<CustomOperation("overflowXScroll")>]
    member inline _.overflowXScroll([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("overflow-x", "scroll")
    /// Should cause a scrolling mechanism to be provided for overflowing boxes
    [<CustomOperation("overflowXAuto")>]
    member inline _.overflowXAuto([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("overflow-x", "auto")
    /// Sets this property to its default value.
    [<CustomOperation("overflowXInitial")>]
    member inline _.overflowXInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("overflow-x", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("overflowXInheritFromParent")>]
    member inline _.overflowXInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("overflow-x", "inherit")

    /// The content is not clipped, and it may be rendered outside the left and right edges. This is default.
    [<CustomOperation("overflowYVisible")>]
    member inline _.overflowYVisible([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("overflow-y", "visibile")
    /// The content is clipped - and no scrolling mechanism is provided.
    [<CustomOperation("overflowYHidden")>]
    member inline _.overflowYHidden([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("overflow-y", "hidden")
    /// The content is clipped and a scrolling mechanism is provided.
    [<CustomOperation("overflowYScroll")>]
    member inline _.overflowYScroll([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("overflow-y", "scroll")
    /// Should cause a scrolling mechanism to be provided for overflowing boxes
    [<CustomOperation("overflowYAuto")>]
    member inline _.overflowYAuto([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("overflow-y", "auto")
    /// Sets this property to its default value.
    [<CustomOperation("overflowYInitial")>]
    member inline _.overflowYInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("overflow-y", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("overflowYInheritFromParent")>]
    member inline _.overflowYInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("overflow-y", "inherit")

    /// The element is hidden (but still takes up space).
    [<CustomOperation("visibilityHidden")>]
    member inline _.visibilityHidden([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("visibility", "hidden")
    /// Default value. The element is visible.
    [<CustomOperation("visibilityVisible")>]
    member inline _.visibilityVisible([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("visibility", "visible")
    /// Only for table rows (`<tr> `), row groups (`<tbody> `), columns (`<col> `), column groups
    /// (`<colgroup> `). This value removes a row or column, but it does not affect the table layout.
    /// The space taken up by the row or column will be available for other content.
    ///
    /// If collapse is used on other elements, it renders as "hidden")
    [<CustomOperation("visibilityCollapse")>]
    member inline _.visibilityCollapse([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("visibility", "collapse")
    /// Sets this property to its default value.
    [<CustomOperation("visibilityInitial")>]
    member inline _.visibilityInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("visibility", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("visibilityInheritFromParent")>]
    member inline _.visibilityInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("visibility", "inherit")

    /// Default value. The length is equal to the length of the flexible item. If the item has
    /// no length specified, the length will be according to its content.
    [<CustomOperation("flexBasisAuto")>]
    member inline _.flexBasisAuto([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("flex-basis", "auto")
    /// Sets this property to its default value.
    [<CustomOperation("flexBasisInitial")>]
    member inline _.flexBasisInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("flex-basis", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("flexBasisInheritFromParent")>]
    member inline _.flexBasisInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("flex-basis", "inherit")

    /// Default value. The flexible items are displayed horizontally, as a row
    [<CustomOperation("flexDirectionRow")>]
    member inline _.flexDirectionRow([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("flex-direction", "row")
    /// Same as row, but in reverse order.
    [<CustomOperation("flexDirectionRowReverse")>]
    member inline _.flexDirectionRowReverse([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("flex-direction", "row-reverse")
    /// The flexible items are displayed vertically, as a column
    [<CustomOperation("flexDirectionColumn")>]
    member inline _.flexDirectionColumn([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("flex-direction", "column")
    /// Same as column, but in reverse order
    [<CustomOperation("flexDirectionColumnReverse")>]
    member inline _.flexDirectionColumnReverse([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("flex-direction", "column-reverse")
    /// Sets this property to its default value.
    [<CustomOperation("flexDirectionInitial")>]
    member inline _.flexDirectionInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("flex-basis", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("flexDirectionInheritFromParent")>]
    member inline _.flexDirectionInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("flex-basis", "inherit")

    /// Default value. Specifies that the flexible items will not wrap.
    [<CustomOperation("flexWrapNowrap")>]
    member inline _.flexWrapNowrap([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("flex-wrap", "nowrap")
    /// Specifies that the flexible items will wrap if necessary
    [<CustomOperation("flexWrapWrap")>]
    member inline _.flexWrapWrap([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("flex-wrap", "wrap")
    /// Specifies that the flexible items will wrap, if necessary, in reverse order
    [<CustomOperation("flexWrapWrapReverse")>]
    member inline _.flexWrapWrapReverse([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("flex-wrap", "wrap-reverse")
    /// Sets this property to its default value.
    [<CustomOperation("flexWrapInitial")>]
    member inline _.flexWrapInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("flex-wrap", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("flexWrapInheritFromParent")>]
    member inline _.flexWrapInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("flex-wrap", "inherit")

    /// The element must float on the left side of its containing block.
    [<CustomOperation("floatLeft")>]
    member inline _.floatLeft([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("float", "left")
    /// The element must float on the right side of its containing block.
    [<CustomOperation("floatRight")>]
    member inline _.floatRight([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("float", "right")
    /// The element must not float.
    [<CustomOperation("floatNone")>]
    member inline _.floatNone([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("float", "none")

    /// The font display strategy is defined by the user agent.
    ///
    /// Default value)
    [<CustomOperation("fontDisplayAuto")>]
    member inline _.fontDisplayAuto([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-display", "auto")
    /// Gives the font face a short block period and an infinite swap period.
    [<CustomOperation("fontDisplayBlock")>]
    member inline _.fontDisplayBlock([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-display", "block")
    /// Gives the font face an extremely small block period and an infinite swap period.
    [<CustomOperation("fontDisplaySwap")>]
    member inline _.fontDisplaySwap([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-display", "swap")
    /// Gives the font face an extremely small block period and a short swap period.
    [<CustomOperation("fontDisplayFallback")>]
    member inline _.fontDisplayFallback([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-display", "fallback")
    /// Gives the font face an extremely small block period and no swap period.
    [<CustomOperation("fontDisplayOptional")>]
    member inline _.fontDisplayOptional([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-display", "optional")

    /// Default. The browser determines whether font kerning should be applied or not
    [<CustomOperation("fontKerningAuto")>]
    member inline _.fontKerningAuto([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-kerning", "auto")
    /// Specifies that font kerning is applied
    [<CustomOperation("fontKerningNormal")>]
    member inline _.fontKerningNormal([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-kerning", "normal")
    /// Specifies that font kerning is not applied
    [<CustomOperation("fontKerningNone")>]
    member inline _.fontKerningNone([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-kerning", "none")

    /// Defines from thin to thick characters. 400 is the same as normal, and 700 is the same as bold.
    /// Possible values are [100, 200, 300, 400, 500, 600, 700, 800, 900]
    [<CustomOperation("fontWeight")>]
    member inline _.fontWeight([<InlineIfLambda>] comb: CombineKeyValue, weight: int) = comb &&& mkWithKV ("font-weight", weight)
    /// Defines normal characters. This is default.
    [<CustomOperation("fontWeightNormal")>]
    member inline _.fontWeightNormal([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-weight", "normal")
    /// Defines thick characters.
    [<CustomOperation("fontWeightBold")>]
    member inline _.fontWeightBold([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-weight", "bold")
    /// Defines thicker characters
    [<CustomOperation("fontWeightBolder")>]
    member inline _.fontWeightBolder([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-weight", "bolder")
    /// Defines lighter characters.
    [<CustomOperation("fontWeightLighter")>]
    member inline _.fontWeightLighter([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-weight", "lighter")
    /// Sets this property to its default value.
    [<CustomOperation("fontWeightInitial")>]
    member inline _.fontWeightInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-weight", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("fontWeightInheritFromParent")>]
    member inline _.fontWeightInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-weight", "inherit")

    /// The browser displays a normal font style. This is defaut.
    [<CustomOperation("fontStyleNormal")>]
    member inline _.fontStyleNormal([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-style", "normal")
    /// The browser displays an italic font style.
    [<CustomOperation("fontStyleItalic")>]
    member inline _.fontStyleItalic([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-style", "italic")
    /// The browser displays an oblique font style.
    [<CustomOperation("fontStyleOblique")>]
    member inline _.fontStyleOblique([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-style", "oblique")
    /// Sets this property to its default value.
    [<CustomOperation("fontStyleInitial")>]
    member inline _.fontStyleInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-style", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("fontStyleInheritFromParent")>]
    member inline _.fontStyleInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-style", "inherit")

    /// The browser displays a normal font. This is default
    [<CustomOperation("fontVariantNormal")>]
    member inline _.fontVariantNormal([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-variant", "normal")
    /// The browser displays a small-caps font
    [<CustomOperation("fontVariantSmallCaps")>]
    member inline _.fontVariantSmallCaps([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-variant", "small-caps")
    /// Sets this property to its default value.
    [<CustomOperation("fontVariantInitial")>]
    member inline _.fontVariantInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-variant", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("fontVariantInheritFromParent")>]
    member inline _.fontVariantInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-variant", "inherit")

    /// Break words only at allowed break points
    [<CustomOperation("wordWrapNormal")>]
    member inline _.wordWrapNormal([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("word-wrap", "normal")
    /// Allows unbreakable words to be broken
    [<CustomOperation("wordWrapBreakWord")>]
    member inline _.wordWrapBreakWord([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("word-wrap", "break-word")
    /// Sets this property to its default value.
    [<CustomOperation("wordWrapInitial")>]
    member inline _.wordWrapInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("word-wrap", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("wordWrapInheritFromParent")>]
    member inline _.wordWrapInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("word-wrap", "inherit")

    /// Default. The element inherits its parent container's align-items property, or "stretch" if it has no parent container.
    [<CustomOperation("alignSelfAuto")>]
    member inline _.alignSelfAuto([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("align-self", "auto")
    /// The element is positioned to fit the container
    [<CustomOperation("alignSelfStretch")>]
    member inline _.alignSelfStretch([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("align-self", "stretch")
    /// The element is positioned at the center of the container
    [<CustomOperation("alignSelfCenter")>]
    member inline _.alignSelfCenter([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("align-self", "center")
    /// The element is positioned at the beginning of the container
    [<CustomOperation("alignSelfFlexStart")>]
    member inline _.alignSelfFlexStart([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("align-self", "flex-start")
    /// The element is positioned at the end of the container
    [<CustomOperation("alignSelfFlexEnd")>]
    member inline _.alignSelfFlexEnd([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("align-self", "flex-end")
    /// The element is positioned at the baseline of the container
    [<CustomOperation("alignSelfBaseline")>]
    member inline _.alignSelfBaseline([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("align-self", "baseline")
    /// Sets this property to its default value)
    [<CustomOperation("alignSelfInitial")>]
    member inline _.alignSelfInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("align-self", "initial")
    /// Inherits this property from its parent element
    [<CustomOperation("alignSelfInheritFromParent")>]
    member inline _.alignSelfInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("align-self", "inherit")

    /// Default. Items are stretched to fit the container
    [<CustomOperation("alignItemsStretch")>]
    member inline _.alignItemsStretch([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("align-items", "stretch")
    /// Items are positioned at the center of the container
    [<CustomOperation("alignItemsCenter")>]
    member inline _.alignItemsCenter([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("align-items", "center")
    /// Items are positioned at the beginning of the container
    [<CustomOperation("alignItemsFlexStart")>]
    member inline _.alignItemsFlexStart([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("align-items", "flex-start")
    /// Items are positioned at the end of the container
    [<CustomOperation("alignItemsFlexEnd")>]
    member inline _.alignItemsFlexEnd([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("align-items", "flex-end")
    /// Items are positioned at the baseline of the container
    [<CustomOperation("alignItemsBaseline")>]
    member inline _.alignItemsBaseline([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("align-items", "baseline")
    /// Sets this property to its default value)
    [<CustomOperation("alignItemsInitial")>]
    member inline _.alignItemsInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("align-items", "initial")
    /// Inherits this property from its parent element
    [<CustomOperation("alignItemsInheritFromParent")>]
    member inline _.alignItemsInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("align-items", "inherit")

    /// Default value. Lines stretch to take up the remaining space.
    [<CustomOperation("alignContentStretch")>]
    member inline _.alignContentStretch([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("align-content", "stretch")
    /// Lines are packed toward the center of the flex container.
    [<CustomOperation("alignContentCenter")>]
    member inline _.alignContentCenter([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("align-content", "center")
    /// Lines are packed toward the start of the flex container.
    [<CustomOperation("alignContentFlexStart")>]
    member inline _.alignContentFlexStart([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("align-content", "flex-start")
    /// Lines are packed toward the end of the flex container.
    [<CustomOperation("alignContentFlexEnd")>]
    member inline _.alignContentFlexEnd([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("align-content", "flex-end")
    /// Lines are evenly distributed in the flex container.
    [<CustomOperation("alignContentSpaceBetween")>]
    member inline _.alignContentSpaceBetween([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("align-content", "space-between")
    /// Lines are evenly distributed in the flex container, with half-size spaces on either end.
    [<CustomOperation("alignContentSpaceAround")>]
    member inline _.alignContentSpaceAround([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("align-content", "space-around")
    [<CustomOperation("alignContentInitial")>]
    member inline _.alignContentInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("align-content", "initial")
    [<CustomOperation("alignContentInheritFromParent")>]
    member inline _.alignContentInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("align-content", "inherit")

    /// Default value. Items are positioned at the beginning of the container.
    [<CustomOperation("justifyContentFlexStart")>]
    member inline _.justifyContentFlexStart([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("justify-content", "flex-start")
    /// Items are positioned at the end of the container.
    [<CustomOperation("justifyContentFlexEnd")>]
    member inline _.justifyContentFlexEnd([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("justify-content", "flex-end")
    /// Items are positioned at the center of the container
    [<CustomOperation("justifyContentCenter")>]
    member inline _.justifyContentCenter([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("justify-content", "center")
    /// Items are positioned with space between the lines
    [<CustomOperation("justifyContentSpaceBetween")>]
    member inline _.justifyContentSpaceBetween([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("justify-content", "space-between")
    /// Items are positioned with space before, between, and after the lines.
    [<CustomOperation("justifyContentSpaceAround")>]
    member inline _.justifyContentSpaceAround([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("justify-content", "space-around")
    /// Sets this property to its default value.
    [<CustomOperation("justifyContentInitial")>]
    member inline _.justifyContentInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("justify-content", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("justifyContentInheritFromParent")>]
    member inline _.justifyContentInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("justify-content", "inherit")

    [<CustomOperation("outlineWidth")>]
    member inline _.outlineWidth([<InlineIfLambda>] comb: CombineKeyValue, width: int) = comb &&& mkPxWithKV ("outline-width", width)
    [<CustomOperation("outlineWidth")>]
    member inline _.outlineWidth([<InlineIfLambda>] comb: CombineKeyValue, width: string) = comb &>> ("outline-width", width)
    /// Specifies a medium outline. This is default.
    [<CustomOperation("outlineWidthMedium")>]
    member inline _.outlineWidthMedium([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("outline-width", "medium")
    /// Specifies a thin outline.
    [<CustomOperation("outlineWidthThin")>]
    member inline _.outlineWidthThin([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("outline-width", "thin")
    /// Specifies a thick outline.
    [<CustomOperation("outlineWidthThick")>]
    member inline _.outlineWidthThick([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("outline-width", "thick")
    /// Sets this property to its default value)
    [<CustomOperation("outlineWidthInitial")>]
    member inline _.outlineWidthInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("outline-width", "initial")
    /// Inherits this property from its parent element
    [<CustomOperation("outlineWidthInheritFromParent")>]
    member inline _.outlineWidthInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("outline-width", "inherit")

    /// Default value. The marker is a filled circle
    [<CustomOperation("listStyleTypeDisc")>]
    member inline _.listStyleTypeDisc([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("list-style-type", "disc")
    /// The marker is traditional Armenian numbering
    [<CustomOperation("listStyleTypeArmenian")>]
    member inline _.listStyleTypeArmenian([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("list-style-type", "armenian")
    /// The marker is a circle
    [<CustomOperation("listStyleTypeCircle")>]
    member inline _.listStyleTypeCircle([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("list-style-type", "circle")
    /// The marker is plain ideographic numbers
    [<CustomOperation("listStyleTypeCjkIdeographic")>]
    member inline _.listStyleTypeCjkIdeographic([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("list-style-type", "cjk-ideographic")
    /// The marker is a number
    [<CustomOperation("listStyleTypeDecimal")>]
    member inline _.listStyleTypeDecimal([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("list-style-type", "decimal")
    /// The marker is a number with leading zeros (01, 02, 03, etc.))
    [<CustomOperation("listStyleTypeDecimalLeadingZero")>]
    member inline _.listStyleTypeDecimalLeadingZero([<InlineIfLambda>] comb: CombineKeyValue) =
        comb &>> ("list-style-type", "decimal-leading-zero")
    /// The marker is traditional Georgian numbering
    [<CustomOperation("listStyleTypeGeorgian")>]
    member inline _.listStyleTypeGeorgian([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("list-style-type", "georgian")
    /// The marker is traditional Hebrew numbering
    [<CustomOperation("listStyleTypeHebrew")>]
    member inline _.listStyleTypeHebrew([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("list-style-type", "hebrew")
    /// The marker is traditional Hiragana numbering
    [<CustomOperation("listStyleTypeHiragana")>]
    member inline _.listStyleTypeHiragana([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("list-style-type", "hiragana")
    /// The marker is traditional Hiragana iroha numbering
    [<CustomOperation("listStyleTypeHiraganaIroha")>]
    member inline _.listStyleTypeHiraganaIroha([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("list-style-type", "hiragana-iroha")
    /// The marker is traditional Katakana numbering
    [<CustomOperation("listStyleTypeKatakana")>]
    member inline _.listStyleTypeKatakana([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("list-style-type", "katakana")
    /// The marker is traditional Katakana iroha numbering
    [<CustomOperation("listStyleTypeKatakanaIroha")>]
    member inline _.listStyleTypeKatakanaIroha([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("list-style-type", "katakana-iroha")
    /// The marker is lower-alpha (a, b, c, d, e, etc.))
    [<CustomOperation("listStyleTypeLowerAlpha")>]
    member inline _.listStyleTypeLowerAlpha([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("list-style-type", "lower-alpha")
    /// The marker is lower-greek
    [<CustomOperation("listStyleTypeLowerGreek")>]
    member inline _.listStyleTypeLowerGreek([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("list-style-type", "lower-greek")
    /// The marker is lower-latin (a, b, c, d, e, etc.))
    [<CustomOperation("listStyleTypeLowerLatin")>]
    member inline _.listStyleTypeLowerLatin([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("list-style-type", "lower-latin")
    /// The marker is lower-roman (i, ii, iii, iv, v, etc.))
    [<CustomOperation("listStyleTypeLowerRoman")>]
    member inline _.listStyleTypeLowerRoman([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("list-style-type", "lower-roman")
    /// No marker is shown
    [<CustomOperation("listStyleTypeNone")>]
    member inline _.listStyleTypeNone([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("list-style-type", "none")
    /// The marker is a square
    [<CustomOperation("listStyleTypeSquare")>]
    member inline _.listStyleTypeSquare([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("list-style-type", "square")
    /// The marker is upper-alpha (A, B, C, D, E, etc.))
    [<CustomOperation("listStyleTypeUpperAlpha")>]
    member inline _.listStyleTypeUpperAlpha([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("list-style-type", "upper-alpha")
    /// The marker is upper-greek
    [<CustomOperation("listStyleTypeUpperGreek")>]
    member inline _.listStyleTypeUpperGreek([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("list-style-type", "upper-greek")
    /// The marker is upper-latin (A, B, C, D, E, etc.))
    [<CustomOperation("listStyleTypeUpperLatin")>]
    member inline _.listStyleTypeUpperLatin([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("list-style-type", "upper-latin")
    /// The marker is upper-roman (I, II, III, IV, V, etc.))
    [<CustomOperation("listStyleTypeUpperRoman")>]
    member inline _.listStyleTypeUpperRoman([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("list-style-type", "upper-roman")
    /// Sets this property to its default value.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=initial
    [<CustomOperation("listStyleTypeInitial")>]
    member inline _.listStyleTypeInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("list-style-type", "initial")
    /// Inherits this property from its parent element.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=initial
    [<CustomOperation("listStyleTypeInheritFromParent")>]
    member inline _.listStyleTypeInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("list-style-type", "inherit")

    [<CustomOperation("propertyNone")>]
    member inline _.propertyNone([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("list-style-image", "none")
    /// The path to the image to be used as a list-item marker
    [<CustomOperation("propertyUrl")>]
    member inline _.propertyUrl([<InlineIfLambda>] comb: CombineKeyValue, path: string) =
        comb
        &&& CombineKeyValue(fun x -> x.Append("list-style-image: url(").Append(path).Append("); "))
    /// Sets this property to its default value.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=initial
    [<CustomOperation("propertyInitial")>]
    member inline _.propertyInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("list-style-image", "initial")
    /// Inherits this property from its parent element.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=initial
    [<CustomOperation("propertyInheritFromParent")>]
    member inline _.propertyInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("list-style-image", "inherit")

    /// The bullet points will be inside the list item
    [<CustomOperation("listStylePositionInside")>]
    member inline _.listStylePositionInside([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("list-style-position", "inside")
    /// The bullet points will be outside the list item. This is default
    [<CustomOperation("listStylePositionOutside")>]
    member inline _.listStylePositionOutside([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("list-style-position", "outside")
    /// Sets this property to its default value.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=initial
    [<CustomOperation("listStylePositionInitial")>]
    member inline _.listStylePositionInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("list-style-position", "initial")
    /// Inherits this property from its parent element.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=initial
    [<CustomOperation("listStylePositionInheritFromParent")>]
    member inline _.listStylePositionInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("list-style-position", "inherit")

    [<CustomOperation("textDecorationLine")>]
    member inline _.textDecorationLine([<InlineIfLambda>] comb: CombineKeyValue, line: string) = comb &>> ("text-decoration-line", line)
    [<CustomOperation("textDecorationLineNone")>]
    member inline _.textDecorationLineNone([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-decoration-line", "none")
    [<CustomOperation("textDecorationLineUnderline")>]
    member inline _.textDecorationLineUnderline([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-decoration-line", "underline")
    [<CustomOperation("textDecorationLineOverline")>]
    member inline _.textDecorationLineOverline([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-decoration-line", "overline")
    [<CustomOperation("textDecorationLineLineThrough")>]
    member inline _.textDecorationLineLineThrough([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-decoration-line", "line-through")
    [<CustomOperation("textDecorationLineInitial")>]
    member inline _.textDecorationLineInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-decoration-line", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("textDecorationLineInheritFromParent")>]
    member inline _.textDecorationLineInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-decoration-line", "inherit")

    [<CustomOperation("textDecoration")>]
    member inline _.textDecoration([<InlineIfLambda>] comb: CombineKeyValue, line: string) = comb &>> ("text-decoration", line)

    [<CustomOperation("textDecorationNone")>]
    member inline _.textDecorationNone([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-decoration", "none")
    [<CustomOperation("textDecorationUnderline")>]
    member inline _.textDecorationUnderline([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-decoration", "underline")
    [<CustomOperation("textDecorationOverline")>]
    member inline _.textDecorationOverline([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-decoration", "overline")
    [<CustomOperation("textDecorationLineThrough")>]
    member inline _.textDecorationLineThrough([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-decoration", "line-through")
    [<CustomOperation("textDecorationInitial")>]
    member inline _.textDecorationInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-decoration", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("textDecorationInheritFromParent")>]
    member inline _.textDecorationInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-decoration", "inherit")

    /// Specifies that child elements will NOT preserve its 3D position. This is default.
    [<CustomOperation("transformStyleFlat")>]
    member inline _.transformStyleFlat([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("transform-style", "flat")
    /// Specifies that child elements will preserve its 3D position
    [<CustomOperation("transformStylePreserve3D")>]
    member inline _.transformStylePreserve3D([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("transform-style", "preserve-3d")
    [<CustomOperation("transformStyleInitial")>]
    member inline _.transformStyleInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("transform-style", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("transformStyleInheritFromParent")>]
    member inline _.transformStyleInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("transform-style", "inherit")

    /// No capitalization. The text renders as it is. This is default.
    [<CustomOperation("textTransformNone")>]
    member inline _.textTransformNone([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-transform", "none")
    /// Transforms the first character of each word to uppercase.
    [<CustomOperation("textTransformCapitalize")>]
    member inline _.textTransformCapitalize([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-transform", "capitalize")
    /// Transforms all characters to uppercase.
    [<CustomOperation("textTransformUppercase")>]
    member inline _.textTransformUppercase([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-transform", "uppercase")
    /// Transforms all characters to lowercase.
    [<CustomOperation("textTransformLowercase")>]
    member inline _.textTransformLowercase([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-transform", "lowercase")
    [<CustomOperation("textTransformInitial")>]
    member inline _.textTransformInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-transform", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("textTransformInheritFromParent")>]
    member inline _.textTransformInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-transform", "inherit")

    /// Default value. The text is clipped and not accessible.
    [<CustomOperation("textOverflowClip")>]
    member inline _.textOverflowClip([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-overflow", "clip")
    /// Render an ellipsis ("...") to represent the clipped text.
    [<CustomOperation("textOverflowEllipsis")>]
    member inline _.textOverflowEllipsis([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-overflow", "ellipsis")
    /// Render the given string to represent the clipped text.
    [<CustomOperation("textOverflowInitial")>]
    member inline _.textOverflowInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-overflow", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("textOverflowInheritFromParent")>]
    member inline _.textOverflowInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-overflow", "inherit")

    /// Default value. Specifies no effects.
    [<CustomOperation("filterNone")>]
    member inline _.filterNone([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("filter", "none")
    /// Applies a blur effect to the elemeen. A larger value will create more blur.
    ///
    /// This overload takes an integer that represents a percentage from 0 to 100.
    [<CustomOperation("filterBlur")>]
    member inline _.filterBlur([<InlineIfLambda>] comb: CombineKeyValue, value: int) =
        comb &&& CombineKeyValue(fun x -> x.Append("filter: blur(").Append(value).Append("%); "))
    /// Applies a blur effect to the elemeen. A larger value will create more blur.
    ///
    /// This overload takes a floating number that goes from 0 to 1,
    [<CustomOperation("filterBlur")>]
    member inline _.filterBlur([<InlineIfLambda>] comb: CombineKeyValue, value: double) =
        comb &&& CombineKeyValue(fun x -> x.Append("filter: blur(").Append(value * 100.).Append("%); "))
    /// Adjusts the brightness of the elemeen
    ///
    /// This overload takes an integer that represents a percentage from 0 to 100.
    ///
    /// Values over 100% will provide brighter results.
    [<CustomOperation("filterBrightness")>]
    member inline _.filterBrightness([<InlineIfLambda>] comb: CombineKeyValue, value: int) =
        comb &&& CombineKeyValue(fun x -> x.Append("filter: brightness(").Append(value).Append("%); "))
    /// Adjusts the brightness of the elemeen. A larger value will create more blur.
    ///
    /// This overload takes a floating number that goes from 0 to 1,
    [<CustomOperation("filterBrightness")>]
    member inline _.filterBrightness([<InlineIfLambda>] comb: CombineKeyValue, value: double) =
        comb &&& CombineKeyValue(fun x -> x.Append("filter: brightness(").Append(value * 100.).Append("%); "))
    /// Adjusts the contrast of the element.
    ///
    /// This overload takes an integer that represents a percentage from 0 to 100.
    [<CustomOperation("filterContrast")>]
    member inline _.filterContrast([<InlineIfLambda>] comb: CombineKeyValue, value: int) =
        comb &&& CombineKeyValue(fun x -> x.Append("filter: contrast(").Append(value).Append("%); "))
    /// Adjusts the contrast of the element. A larger value will create more contrast.
    ///
    /// This overload takes a floating number that goes from 0 to 1
    [<CustomOperation("filterContrast")>]
    member inline _.filterContrast([<InlineIfLambda>] comb: CombineKeyValue, value: double) =
        comb &&& CombineKeyValue(fun x -> x.Append("filter: contrast(").Append(value * 100.).Append("%); "))
    /// Applies a drop shadow effect.
    [<CustomOperation("filterDropShadow")>]
    member inline _.filterDropShadow
        (
            [<InlineIfLambda>] comb: CombineKeyValue,
            horizontalOffset: int,
            verticalOffset: int,
            blur: int,
            spread: int,
            color: string
        )
        =
        comb
        &&& CombineKeyValue(fun x ->
            x
                .Append("filter: drop-shadow(")
                .Append(horizontalOffset)
                .Append("px ")
                .Append(verticalOffset)
                .Append("px ")
                .Append(blur)
                .Append("px ")
                .Append(spread)
                .Append("px ")
                .Append(color)
                .Append("); ")
        )
    /// Applies a drop shadow effect.
    [<CustomOperation("filterDropShadow")>]
    member inline _.filterDropShadow([<InlineIfLambda>] comb: CombineKeyValue, horizontalOffset: int, verticalOffset: int, blur: int, color: string) =
        comb
        &&& CombineKeyValue(fun x ->
            x
                .Append("filter: drop-shadow(")
                .Append(horizontalOffset)
                .Append("px ")
                .Append(verticalOffset)
                .Append("px ")
                .Append(blur)
                .Append("px ")
                .Append(color)
                .Append("); ")
        )
    /// Applies a drop shadow effect.
    [<CustomOperation("filterDropShadow")>]
    member inline _.filterDropShadow([<InlineIfLambda>] comb: CombineKeyValue, horizontalOffset: int, verticalOffset: int, color: string) =
        comb
        &&& CombineKeyValue(fun x ->
            x
                .Append("filter: drop-shadow(")
                .Append(horizontalOffset)
                .Append("px ")
                .Append(verticalOffset)
                .Append("px ")
                .Append(color)
                .Append("); ")
        )
    /// Converts the image to grayscale
    ///
    /// This overload takes an integer that represents a percentage from 0 to 100.
    [<CustomOperation("filterGrayscale")>]
    member inline _.filterGrayscale([<InlineIfLambda>] comb: CombineKeyValue, value: int) =
        comb &&& CombineKeyValue(fun x -> x.Append("filter: grayscale(").Append(value).Append("%); "))
    /// Converts the image to grayscale
    ///
    /// This overload takes a floating number that goes from 0 to 1
    [<CustomOperation("filterGrayscale")>]
    member inline _.filterGrayscale([<InlineIfLambda>] comb: CombineKeyValue, value: double) =
        comb &&& CombineKeyValue(fun x -> x.Append("filter: grayscale(").Append(value).Append("%); "))
    /// Applies a hue rotation on the image. The value defines the number of degrees around the color circle the image
    /// samples will be adjusted. 0deg is default, and represents the original image.
    ///
    /// **Note**: Maximum value is 360
    [<CustomOperation("filterHueRotate")>]
    member inline _.filterHueRotate([<InlineIfLambda>] comb: CombineKeyValue, degrees: int) =
        comb &&& CombineKeyValue(fun x -> x.Append("filter: hue-rotate(").Append(degrees).Append("deg); "))
    /// Inverts the element.
    ///
    /// This overload takes an integer that represents a percentage from 0 to 100.
    [<CustomOperation("filterInvert")>]
    member inline _.filterInvert([<InlineIfLambda>] comb: CombineKeyValue, value: int) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("filter: ").Append("invert(").Append(value).Append("%); "))
    /// Inverts the element.
    ///
    /// This overload takes a floating number that goes from 0 to 1
    [<CustomOperation("filterInvert")>]
    member inline _.filterInvert([<InlineIfLambda>] comb: CombineKeyValue, value: double) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("filter: ").Append("invert(").Append(value).Append("%); "))
    /// Sets the opacity of the element.
    ///
    /// This overload takes an integer that represents a percentage from 0 to 100.
    [<CustomOperation("filterOpacity")>]
    member inline _.filterOpacity([<InlineIfLambda>] comb: CombineKeyValue, value: int) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("filter: ").Append("opacity(").Append(value).Append("%); "))
    /// Sets the opacity of the element.
    ///
    /// This overload takes a floating number that goes from 0 to 1
    [<CustomOperation("filterOpacity")>]
    member inline _.filterOpacity([<InlineIfLambda>] comb: CombineKeyValue, value: double) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("filter: ").Append("opacity(").Append(value).Append("%); "))
    /// Sets the saturation of the element.
    ///
    /// This overload takes an integer that represents a percentage from 0 to 100.
    [<CustomOperation("filterSaturate")>]
    member inline _.filterSaturate([<InlineIfLambda>] comb: CombineKeyValue, value: int) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("filter: ").Append("saturate(").Append(value).Append("%); "))
    /// Sets the saturation of the element.
    ///
    /// This overload takes a floating number that goes from 0 to 1
    [<CustomOperation("filterSaturate")>]
    member inline _.filterSaturate([<InlineIfLambda>] comb: CombineKeyValue, value: double) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("filter: ").Append("saturate(").Append(value).Append("%); "))
    /// Applies Sepia filter to the element.
    ///
    /// This overload takes an integer that represents a percentage from 0 to 100.
    [<CustomOperation("filterSepia")>]
    member inline _.filterSepia([<InlineIfLambda>] comb: CombineKeyValue, value: int) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("filter: ").Append("sepia(").Append(value).Append("); "))
    /// Applies Sepia filter to the element.
    ///
    /// This overload takes a floating number that goes from 0 to 1
    [<CustomOperation("filterSepia")>]
    member inline _.filterSepia([<InlineIfLambda>] comb: CombineKeyValue, value: double) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("filter: ").Append("sepia(").Append(value).Append("); "))
    /// The url() function takes the location of an XML file that specifies an SVG filter, and may include an anchor to a specific filter element.
    ///
    /// Example: `filter: url(svg-url#element-id)`
    [<CustomOperation("filterUrl")>]
    member inline _.filterUrl([<InlineIfLambda>] comb: CombineKeyValue, value: string) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("filter: ").Append("url(").Append(value).Append("); "))
    /// Sets this property to its default value.
    [<CustomOperation("filterInitial")>]
    member inline _.filterInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("filter", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("filterInheritFromParent")>]
    member inline _.filterInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("filter", "inherit")

    /// Sets whether table borders should collapse into a single border or be separated as in standard HTML.
    /// Borders are separated; each cell will display its own borders. This is default.
    [<CustomOperation("borderCollapseSeparate")>]
    member inline _.borderCollapseSeparate([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("border-collapse", "separate")
    /// Borders are collapsed into a single border when possible (border-spacing and empty-cells properties have no effect))
    [<CustomOperation("borderCollapseCollapse")>]
    member inline _.borderCollapseCollapse([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("border-collapse", "collapse")
    /// Sets this property to its default value)
    [<CustomOperation("borderCollapseInitial")>]
    member inline _.borderCollapseInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("border-collapse", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("borderCollapseInheritFromParent")>]
    member inline _.borderCollapseInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("border-collapse", "inherit")

    /// Sets the distance between the borders of adjacent <table> cells. Applies only when border-collapse is separate.
    [<CustomOperation("borderSpacing")>]
    member inline _.borderSpacing([<InlineIfLambda>] comb: CombineKeyValue, horizontal: string, ?vertical: string) =
        comb &>> ("border-spacing", horizontal + ", " + string vertical)

    /// Sets this property to its default value)
    [<CustomOperation("borderSpacingInitial")>]
    member inline _.borderSpacingInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("border-spacing", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("borderSpacingInheritFromParent")>]
    member inline _.borderSpacingInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("border-spacing", "inherit")

    /// Sets the size of the element's background image.
    ///
    /// The image can be left to its natural size, stretched, or constrained to fit the available space.
    [<CustomOperation("backgroundSize")>]
    member inline _.backgroundSize([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("background-size", value)
    /// Sets the size of the element's background image.
    ///
    /// The image can be left to its natural size, stretched, or constrained to fit the available space.
    [<CustomOperation("backgroundSize")>]
    member inline _.backgroundSize([<InlineIfLambda>] comb: CombineKeyValue, width: string, height: string) =
        comb &>> ("background-size", width + ", " + string height)
    /// Default value. The background image is displayed in its original size
    ///
    /// See [example here](https://www.w3schools.com/cssref/playit.asp?filename=playcss_background-size&preval=auto))
    [<CustomOperation("backgroundSizeAuto")>]
    member inline _.backgroundSizeAuto([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("background-size", "auto")
    /// Resize the background image to cover the entire container, even if it has to stretch the image or cut a little bit off one of the edges.
    ///
    /// See [example here](https://www.w3schools.com/cssref/playit.asp?filename=playcss_background-size&preval=cover))
    [<CustomOperation("backgroundSizeCover")>]
    member inline _.backgroundSizeCover([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("background-size", "cover")
    /// Resize the background image to make sure the image is fully visible
    ///
    /// See [example here](https://www.w3schools.com/cssref/playit.asp?filename=playcss_background-size&preval=contain))
    [<CustomOperation("backgroundSizeContain")>]
    member inline _.backgroundSizeContain([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("background-size", "contain")
    /// Sets this property to its default value.
    [<CustomOperation("backgroundSizeInitial")>]
    member inline _.backgroundSizeInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("background-size", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("backgroundSizeInheritFromParent")>]
    member inline _.backgroundSizeInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("background-size", "inherit")

    /// Default value. The line will display as a single line.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-decoration-style&preval=solid
    [<CustomOperation("textDecorationStyleSolid")>]
    member inline _.textDecorationStyleSolid([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-decoration-style", "solid")
    /// The line will display as a double line.
    ///
    /// https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-decoration-style&preval=double
    [<CustomOperation("textDecorationStyleDouble")>]
    member inline _.textDecorationStyleDouble([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-decoration-style", "double")
    /// The line will display as a dotted line.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-decoration-style&preval=dotted
    [<CustomOperation("textDecorationStyleDotted")>]
    member inline _.textDecorationStyleDotted([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-decoration-style", "dotted")
    /// The line will display as a dashed line.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-decoration-style&preval=dashed
    [<CustomOperation("textDecorationStyleDashed")>]
    member inline _.textDecorationStyleDashed([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-decoration-style", "dashed")
    /// The line will display as a wavy line.
    ///
    /// https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-decoration-style&preval=wavy
    [<CustomOperation("textDecorationStyleWavy")>]
    member inline _.textDecorationStyleWavy([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-decoration-style", "wavy")
    /// Sets this property to its default value.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-decoration-style&preval=initial
    [<CustomOperation("textDecorationStyleInitial")>]
    member inline _.textDecorationStyleInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-decoration-style", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("textDecorationStyleInheritFromParent")>]
    member inline _.textDecorationStyleInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-decoration-style", "inherit")

    /// Makes the text as narrow as it gets.
    [<CustomOperation("fontStretchUltraCondensed")>]
    member inline _.fontStretchUltraCondensed([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-stretch", "ultra-condensed")
    /// Makes the text narrower than condensed, but not as narrow as ultra-condensed
    [<CustomOperation("fontStretchExtraCondensed")>]
    member inline _.fontStretchExtraCondensed([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-stretch", "extra-condensed")
    /// Makes the text narrower than semi-condensed, but not as narrow as extra-condensed.
    [<CustomOperation("fontStretchCondensed")>]
    member inline _.fontStretchCondensed([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-stretch", "condensed")
    /// Makes the text narrower than normal, but not as narrow as condensed.
    [<CustomOperation("fontStretchSemiCondensed")>]
    member inline _.fontStretchSemiCondensed([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-stretch", "semi-condensed")
    /// Default value. No font stretching
    [<CustomOperation("fontStretchNormal")>]
    member inline _.fontStretchNormal([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-stretch", "normal")
    /// Makes the text wider than normal, but not as wide as expanded
    [<CustomOperation("fontStretchSemiExpanded")>]
    member inline _.fontStretchSemiExpanded([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-stretch", "semi-expanded")
    /// Makes the text wider than semi-expanded, but not as wide as extra-expanded
    [<CustomOperation("fontStretchExpanded")>]
    member inline _.fontStretchExpanded([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-stretch", "expanded")
    /// Makes the text wider than expanded, but not as wide as ultra-expanded
    [<CustomOperation("fontStretchExtraExpanded")>]
    member inline _.fontStretchExtraExpanded([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-stretch", "extra-expanded")
    /// Makes the text as wide as it gets.
    [<CustomOperation("fontStretchUltraExpanded")>]
    member inline _.fontStretchUltraExpanded([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-stretch", "ultra-expanded")
    /// Sets this property to its default value.
    [<CustomOperation("fontStretchInitial")>]
    member inline _.fontStretchInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-stretch", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("fontStretchInheritFromParent")>]
    member inline _.fontStretchInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("font-stretch", "inherit")

    /// The element does not float, (will be displayed just where it occurs in the text). This is default
    [<CustomOperation("floatStyleNone")>]
    member inline _.floatStyleNone([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("float", "none")
    [<CustomOperation("floatStyleLeft")>]
    member inline _.floatStyleLeft([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("float", "left")
    [<CustomOperation("floatStyleRight")>]
    member inline _.floatStyleRight([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("float", "right")
    /// Sets this property to its default value.
    [<CustomOperation("floatStyleInitial")>]
    member inline _.floatStyleInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("float", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("floatStyleInheritFromParent")>]
    member inline _.floatStyleInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("float", "inherit")

    /// The element is aligned with the baseline of the parent. This is default.
    [<CustomOperation("verticalAlignBaseline")>]
    member inline _.verticalAlignBaseline([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("vertical-align", "baseline")
    /// The element is aligned with the subscript baseline of the parent
    [<CustomOperation("verticalAlignSub")>]
    member inline _.verticalAlignSub([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("vertical-align", "sup")
    /// The element is aligned with the superscript baseline of the parent.
    [<CustomOperation("verticalAlignSuper")>]
    member inline _.verticalAlignSuper([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("vertical-align", "super")
    /// The element is aligned with the top of the tallest element on the line.
    [<CustomOperation("verticalAlignTop")>]
    member inline _.verticalAlignTop([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("vertical-align", "top")
    /// The element is aligned with the top of the parent element's font.
    [<CustomOperation("verticalAlignTextTop")>]
    member inline _.verticalAlignTextTop([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("vertical-align", "text-top")
    /// The element is placed in the middle of the parent element.
    [<CustomOperation("verticalAlignMiddle")>]
    member inline _.verticalAlignMiddle([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("vertical-align", "middle")
    /// The element is aligned with the lowest element on the line.
    [<CustomOperation("verticalAlignBottom")>]
    member inline _.verticalAlignBottom([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("vertical-align", "bottom")
    /// The element is aligned with the bottom of the parent element's font
    [<CustomOperation("verticalAlignTextBottom")>]
    member inline _.verticalAlignTextBottom([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("vertical-align", "text-bottom")
    /// Sets this property to its default value.
    [<CustomOperation("verticalAlignInitial")>]
    member inline _.verticalAlignInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("vertical-align", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("verticalAlignInheritFromParent")>]
    member inline _.verticalAlignInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("vertical-align", "inherit")

    /// Let the content flow horizontally from left to right, vertically from top to bottom
    [<CustomOperation("writingModeHorizontalTopBottom")>]
    member inline _.writingModeHorizontalTopBottom([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("writing-mode", "horizontal-tb")
    /// Let the content flow vertically from top to bottom, horizontally from right to left
    [<CustomOperation("writingModeVerticalRightLeft")>]
    member inline _.writingModeVerticalRightLeft([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("writing-mode", "vertical-rl")
    /// Let the content flow vertically from top to bottom, horizontally from left to right
    [<CustomOperation("writingModeVerticalLeftRight")>]
    member inline _.writingModeVerticalLeftRight([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("writing-mode", "vertical-lr")
    /// Sets this property to its default value.
    [<CustomOperation("writingModeInitial")>]
    member inline _.writingModeInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("writing-mode", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("writingModeInheritFromParent")>]
    member inline _.writingModeInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("writing-mode", "inherit")

    /// Default value. Specifies a animation effect with a slow start, then fast, then end slowly (equivalent to cubic-bezier(0.25,0.1,0.25,1)).
    [<CustomOperation("animationTimingFunctionEase")>]
    member inline _.animationTimingFunctionEase([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("animation-timing-function", "ease")
    /// Specifies a animation effect with the same speed from start to end (equivalent to cubic-bezier(0,0,1,1)))
    [<CustomOperation("animationTimingFunctionLinear")>]
    member inline _.animationTimingFunctionLinear([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("animation-timing-function", "linear")
    /// Specifies a animation effect with a slow start (equivalent to cubic-bezier(0.42,0,1,1)).
    [<CustomOperation("animationTimingFunctionEaseIn")>]
    member inline _.animationTimingFunctionEaseIn([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("animation-timing-function", "ease-in")
    /// Specifies a animation effect with a slow end (equivalent to cubic-bezier(0,0,0.58,1)).
    [<CustomOperation("animationTimingFunctionEaseOut")>]
    member inline _.animationTimingFunctionEaseOut([<InlineIfLambda>] comb: CombineKeyValue) =
        comb &>> ("animation-timing-function", "ease-out")
    /// Specifies a animation effect with a slow start and end (equivalent to cubic-bezier(0.42,0,0.58,1)))
    [<CustomOperation("animationTimingFunctionEaseInOut")>]
    member inline _.animationTimingFunctionEaseInOut([<InlineIfLambda>] comb: CombineKeyValue) =
        comb &>> ("animation-timing-function", "ease-in-out")
    /// Define your own values in the cubic-bezier function. Possible values are numeric values from 0 to 1
    [<CustomOperation("animationTimingFunctionCubicBezier")>]
    member inline _.animationTimingFunctionCubicBezier([<InlineIfLambda>] comb: CombineKeyValue, n1: float, n2: float, n3: float, n4: float) =
        CombineKeyValue(fun x ->
            comb
                .Invoke(x)
                .Append("animation-timing-function: ")
                .Append("cubic-bezier(")
                .Append(n1)
                .Append(",")
                .Append(n2)
                .Append(",")
                .Append(n3)
                .Append(",")
                .Append(n4)
                .Append("); ")
        )
    /// Sets this property to its default value)
    [<CustomOperation("animationTimingFunctionInitial")>]
    member inline _.animationTimingFunctionInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("animation-timing-function", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("animationTimingFunctionInheritFromParent")>]
    member inline _.animationTimingFunctionInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) =
        comb &>> ("animation-timing-function", "inherit")

    /// Default value. Specifies a transition effect with a slow start, then fast, then end slowly (equivalent to cubic-bezier(0.25,0.1,0.25,1)).
    [<CustomOperation("transitionTimingFunctionEase")>]
    member inline _.transitionTimingFunctionEase([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("transition-timing-function", "ease")
    /// Specifies a transition effect with the same speed from start to end (equivalent to cubic-bezier(0,0,1,1)))
    [<CustomOperation("transitionTimingFunctionLinear")>]
    member inline _.transitionTimingFunctionLinear([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("transition-timing-function", "linear")
    /// Specifies a transition effect with a slow start (equivalent to cubic-bezier(0.42,0,1,1)).
    [<CustomOperation("transitionTimingFunctionEaseIn")>]
    member inline _.transitionTimingFunctionEaseIn([<InlineIfLambda>] comb: CombineKeyValue) =
        comb &>> ("transition-timing-function", "ease-in")
    /// Specifies a transition effect with a slow end (equivalent to cubic-bezier(0,0,0.58,1)).
    [<CustomOperation("transitionTimingFunctionEaseOut")>]
    member inline _.transitionTimingFunctionEaseOut([<InlineIfLambda>] comb: CombineKeyValue) =
        comb &>> ("transition-timing-function", "ease-out")
    /// Specifies a transition effect with a slow start and end (equivalent to cubic-bezier(0.42,0,0.58,1)))
    [<CustomOperation("transitionTimingFunctionEaseInOut")>]
    member inline _.transitionTimingFunctionEaseInOut([<InlineIfLambda>] comb: CombineKeyValue) =
        comb &>> ("transition-timing-function", "ease-in-out")
    /// Equivalent to steps(1, start))
    [<CustomOperation("transitionTimingFunctionStepStart")>]
    member inline _.transitionTimingFunctionStepStart([<InlineIfLambda>] comb: CombineKeyValue) =
        comb &>> ("transition-timing-function", "step-start")
    /// Equivalent to steps(1, end))
    [<CustomOperation("transitionTimingFunctionStepEnd")>]
    member inline _.transitionTimingFunctionStepEnd([<InlineIfLambda>] comb: CombineKeyValue) =
        comb &>> ("transition-timing-function", "step-end")
    /// Define your own values in the cubic-bezier function. Possible values are numeric values from 0 to 1
    [<CustomOperation("transitionTimingFunctionCubicBezier")>]
    member inline _.transitionTimingFunctionCubicBezier([<InlineIfLambda>] comb: CombineKeyValue, n1: float, n2: float, n3: float, n4: float) =
        CombineKeyValue(fun x ->
            comb
                .Invoke(x)
                .Append("transition-timing-function: ")
                .Append("cubic-bezier(")
                .Append(n1)
                .Append(",")
                .Append(n2)
                .Append(",")
                .Append(n3)
                .Append(",")
                .Append(n4)
                .Append("); ")
        )
    /// Sets this property to its default value)
    [<CustomOperation("transitionTimingFunctionInitial")>]
    member inline _.transitionTimingFunctionInitial([<InlineIfLambda>] comb: CombineKeyValue) =
        comb &>> ("transition-timing-function", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("transitionTimingFunctionInheritFromParent")>]
    member inline _.transitionTimingFunctionInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) =
        comb &>> ("transition-timing-function", "inherit")

    /// Default. Text can be selected if the browser allows it.
    [<CustomOperation("userSelectAuto")>]
    member inline _.userSelectAuto([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("user-select", "auto")
    /// Prevents text selection.
    [<CustomOperation("userSelectNone")>]
    member inline _.userSelectNone([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("user-select", "none")
    /// The text can be selected by the user.
    [<CustomOperation("userSelectText")>]
    member inline _.userSelectText([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("user-select", "text")
    /// Text selection is made with one click instead of a double-click.
    [<CustomOperation("userSelectAll")>]
    member inline _.userSelectAll([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("user-select", "all")
    /// Sets this property to its default value.
    [<CustomOperation("userSelectInitial")>]
    member inline _.userSelectInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("user-select", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("userSelectInheritFromParent")>]
    member inline _.userSelectInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("user-select", "inherit")

    /// Sets the line style for all four sides of an element's border.
    [<CustomOperation("borderStyle")>]
    member inline _.borderStyle([<InlineIfLambda>] comb: CombineKeyValue, style: string) = comb &>> ("border-style", style)

    /// Specifies a dotted border.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
    [<CustomOperation("borderStyleDotted")>]
    member inline _.borderStyleDotted([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("border-style", "dotted")
    /// Specifies a dashed border.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
    [<CustomOperation("borderStyleDashed")>]
    member inline _.borderStyleDashed([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("border-style", "dashed")
    /// Specifies a solid border.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
    [<CustomOperation("borderStyleSolid")>]
    member inline _.borderStyleSolid([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("border-style", "solid")
    /// Specifies a double border.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
    [<CustomOperation("borderStyleDouble")>]
    member inline _.borderStyleDouble([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("border-style", "double")
    /// Specifies a 3D grooved border. The effect depends on the border-color value.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
    [<CustomOperation("borderStyleGroove")>]
    member inline _.borderStyleGroove([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("border-style", "groove")
    /// Specifies a 3D ridged border. The effect depends on the border-color value.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
    [<CustomOperation("borderStyleRidge")>]
    member inline _.borderStyleRidge([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("border-style", "ridge")
    /// Specifies a 3D inset border. The effect depends on the border-color value.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
    [<CustomOperation("borderStyleInset")>]
    member inline _.borderStyleInset([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("border-style", "inset")
    /// Specifies a 3D outset border. The effect depends on the border-color value.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
    [<CustomOperation("borderStyleOutset")>]
    member inline _.borderStyleOutset([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("border-style", "outset")
    /// Default value. Specifies no border.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
    [<CustomOperation("borderStyleNone")>]
    member inline _.borderStyleNone([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("border-style", "none")
    /// The same as "none", except in border conflict resolution for table elements.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=hidden
    [<CustomOperation("borderStyleHidden")>]
    member inline _.borderStyleHidden([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("border-style", "hidden")
    /// Sets this property to its default value.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=hidden
    ///
    /// Read about initial value https://www.w3schools.com/cssref/css_initial.asp
    [<CustomOperation("borderStyleInitial")>]
    member inline _.borderStyleInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("border-style", "initial")
    /// Inherits this property from its parent element.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=hidden
    ///
    /// Read about inherit https://www.w3schools.com/cssref/css_inherit.asp
    [<CustomOperation("borderStyleInheritFromParent")>]
    member inline _.borderStyleInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("border-style", "inherit")

    /// Browsers use an automatic table layout algorithm. The column width is set by the widest unbreakable
    /// content in the cells. The content will dictate the layout
    [<CustomOperation("tableLayoutAuto")>]
    member inline _.tableLayoutAuto([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("table-layout", "auto")
    /// Sets a fixed table layout algorithm. The table and column widths are set by the widths of table and col
    /// or by the width of the first row of cells. Cells in other rows do not affect column widths. If no widths
    /// are present on the first row, the column widths are divided equally across the table, regardless of content
    /// inside the cells
    [<CustomOperation("tableLayoutFixed'")>]
    member inline _.tableLayoutFixed'([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("table-layout", "fixed")
    /// Sets this property to its default value.
    [<CustomOperation("tableLayoutInitial")>]
    member inline _.tableLayoutInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("table-layout", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("tableLayoutInheritFromParent")>]
    member inline _.tableLayoutInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("table-layout", "inherit")

    [<CustomOperation("cursor")>]
    member inline _.cursor([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("cursor", value)
    /// The User Agent will determine the cursor to display based on the current context. E.g., equivalent to text when hovering text.
    [<CustomOperation("cursorAuto")>]
    member inline _.cursorAuto([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "auto")
    /// The cursor indicates an alias of something is to be created
    [<CustomOperation("cursorAlias")>]
    member inline _.cursorAlias([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "alias")
    /// The platform-dependent default cursor. Typically an arrow.
    [<CustomOperation("cursorDefaultCursor")>]
    member inline _.cursorDefaultCursor([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "default")
    /// No cursor is rendered.
    [<CustomOperation("cursorNone")>]
    member inline _.cursorNone([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "none")
    /// A context menu is available.
    [<CustomOperation("cursorContextMenu")>]
    member inline _.cursorContextMenu([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "context-menu")
    /// Help information is available.
    [<CustomOperation("cursorHelp")>]
    member inline _.cursorHelp([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "help")
    /// The cursor is a pointer that indicates a link. Typically an image of a pointing hand.
    [<CustomOperation("cursorPointer")>]
    member inline _.cursorPointer([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "pointer")
    /// The program is busy in the background, but the user can still interact with the interface (in contrast to `wait`).
    [<CustomOperation("cursorProgress")>]
    member inline _.cursorProgress([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "progress")
    /// The program is busy, and the user can't interact with the interface (in contrast to progress). Sometimes an image of an hourglass or a watch.
    [<CustomOperation("cursorWait")>]
    member inline _.cursorWait([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "wait")
    /// The table cell or set of cells can be selected.
    [<CustomOperation("cursorCell")>]
    member inline _.cursorCell([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "cell")
    /// Cross cursor, often used to indicate selection in a bitmap.
    [<CustomOperation("cursorCrosshair")>]
    member inline _.cursorCrosshair([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "crosshair")
    /// The text can be selected. Typically the shape of an I-beam.
    [<CustomOperation("cursorText")>]
    member inline _.cursorText([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "text")
    /// The vertical text can be selected. Typically the shape of a sideways I-beam.
    [<CustomOperation("cursorVerticalText")>]
    member inline _.cursorVerticalText([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "vertical-text")
    /// Something is to be copied.
    [<CustomOperation("cursorCopy")>]
    member inline _.cursorCopy([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "copy")
    /// Something is to be moved.
    [<CustomOperation("cursorMove")>]
    member inline _.cursorMove([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "move")
    /// An item may not be dropped at the current location. On Windows and Mac OS X, `no-drop` is the same as `not-allowed`.
    [<CustomOperation("cursorNoDrop")>]
    member inline _.cursorNoDrop([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "no-drop")
    /// The requested action will not be carried out.
    [<CustomOperation("cursorNotAllowed")>]
    member inline _.cursorNotAllowed([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "not-allowed")
    /// Something can be grabbed (dragged to be moved).
    [<CustomOperation("cursorGrab")>]
    member inline _.cursorGrab([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "grab")
    /// Something is being grabbed (dragged to be moved).
    [<CustomOperation("cursorGrabbing")>]
    member inline _.cursorGrabbing([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "grabbing")
    /// Something can be scrolled in any direction (panned).
    [<CustomOperation("cursorAllScroll")>]
    member inline _.cursorAllScroll([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "all-scroll")
    /// The item/column can be resized horizontally. Often rendered as arrows pointing left and right with a vertical bar separating them.
    [<CustomOperation("cursorColumnResize")>]
    member inline _.cursorColumnResize([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "col-resize")
    /// The item/row can be resized vertically. Often rendered as arrows pointing up and down with a horizontal bar separating them.
    [<CustomOperation("cursorRowResize")>]
    member inline _.cursorRowResize([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "row-resize")
    /// Directional resize arrow
    [<CustomOperation("cursorNorthResize")>]
    member inline _.cursorNorthResize([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "n-resize")
    /// Directional resize arrow
    [<CustomOperation("cursorEastResize")>]
    member inline _.cursorEastResize([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "e-resize")
    /// Directional resize arrow
    [<CustomOperation("cursorSouthResize")>]
    member inline _.cursorSouthResize([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "s-resize")
    /// Directional resize arrow
    [<CustomOperation("cursorWestResize")>]
    member inline _.cursorWestResize([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "w-resize")
    /// Directional resize arrow
    [<CustomOperation("cursorNorthEastResize")>]
    member inline _.cursorNorthEastResize([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "ne-resize")
    /// Directional resize arrow
    [<CustomOperation("cursorNorthWestResize")>]
    member inline _.cursorNorthWestResize([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "nw-resize")
    /// Directional resize arrow
    [<CustomOperation("cursorSouthEastResize")>]
    member inline _.cursorSouthEastResize([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "se-resize")
    /// Directional resize arrow
    [<CustomOperation("cursorSouthWestResize")>]
    member inline _.cursorSouthWestResize([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "sw-resize")
    /// Directional resize arrow
    [<CustomOperation("cursorEastWestResize")>]
    member inline _.cursorEastWestResize([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "ew-resize")
    /// Directional resize arrow
    [<CustomOperation("cursorNorthSouthResize")>]
    member inline _.cursorNorthSouthResize([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "ns-resize")
    /// Directional resize arrow
    [<CustomOperation("cursorNorthEastSouthWestResize")>]
    member inline _.cursorNorthEastSouthWestResize([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "nesw-resize")
    /// Directional resize arrow
    [<CustomOperation("cursorNorthWestSouthEastResize")>]
    member inline _.cursorNorthWestSouthEastResize([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "nwse-resize")
    /// Something can be zoomed (magnified) in
    [<CustomOperation("cursorZoomIn")>]
    member inline _.cursorZoomIn([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "zoom-in")
    /// Something can be zoomed out
    [<CustomOperation("cursorZoomOut")>]
    member inline _.cursorZoomOut([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("cursor", "zoom-out")

    /// Permits the user agent to render a custom outline style.
    [<CustomOperation("outlineStyleAuto")>]
    member inline _.outlineStyleAuto([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("outline-style", "auto")
    /// Specifies no outline. This is default.
    [<CustomOperation("outlineStyleNone")>]
    member inline _.outlineStyleNone([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("outline-style", "none")
    /// Specifies a hidden outline
    [<CustomOperation("outlineStyleHidden")>]
    member inline _.outlineStyleHidden([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("outline-style", "hidden")
    /// Specifies a dotted outline
    [<CustomOperation("outlineStyleDotted")>]
    member inline _.outlineStyleDotted([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("outline-style", "dotted")
    /// Specifies a dashed outline
    [<CustomOperation("outlineStyleDashed")>]
    member inline _.outlineStyleDashed([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("outline-style", "dashed")
    /// Specifies a solid outline
    [<CustomOperation("outlineStyleSolid")>]
    member inline _.outlineStyleSolid([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("outline-style", "solid")
    /// Specifies a double outliner
    [<CustomOperation("outlineStyleDouble")>]
    member inline _.outlineStyleDouble([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("outline-style", "double")
    /// Specifies a 3D grooved outline. The effect depends on the outline-color value)
    [<CustomOperation("outlineStyleGroove")>]
    member inline _.outlineStyleGroove([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("outline-style", "groove")
    /// Specifies a 3D ridged outline. The effect depends on the outline-color value)
    [<CustomOperation("outlineStyleRidge")>]
    member inline _.outlineStyleRidge([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("outline-style", "ridge")
    /// Specifies a 3D inset  outline. The effect depends on the outline-color value)
    [<CustomOperation("outlineStyleInset")>]
    member inline _.outlineStyleInset([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("outline-style", "inset")
    /// Specifies a 3D outset outline. The effect depends on the outline-color value)
    [<CustomOperation("outlineStyleOutset")>]
    member inline _.outlineStyleOutset([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("outline-style", "outset")
    /// Sets this property to its default value)
    [<CustomOperation("outlineStyleInitial")>]
    member inline _.outlineStyleInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("outline-style", "initial")
    /// Inherits this property from its parent element
    [<CustomOperation("outlineStyleInheritFromParent")>]
    member inline _.outlineStyleInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("outline-style", "inherit")

    /// Sets the initial position for each background image.
    ///
    /// The position is relative to the position layer set by background-origin.
    [<CustomOperation("backgroundPosition")>]
    member inline _.backgroundPosition([<InlineIfLambda>] comb: CombineKeyValue, position: string) = comb &>> ("background-position", position)
    /// The background image will scroll with the page. This is default.
    [<CustomOperation("backgroundPositionScroll")>]
    member inline _.backgroundPositionScroll([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("background-position", "scroll")
    /// The background image will not scroll with the page.
    [<CustomOperation("backgroundPositionFixedNoScroll")>]
    member inline _.backgroundPositionFixedNoScroll([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("background-position", "fixed")
    /// The background image will scroll with the element's contents.
    [<CustomOperation("backgroundPositionLocal")>]
    member inline _.backgroundPositionLocal([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("background-position", "local")
    /// Sets this property to its default value.
    [<CustomOperation("backgroundPositionInitial")>]
    member inline _.backgroundPositionInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("background-position", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("backgroundPositionInheritFromParent")>]
    member inline _.backgroundPositionInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("background-position", "inherit")

    /// This is default. Sets the blending mode to normal.
    [<CustomOperation("backgroundBlendModeNormal")>]
    member inline _.backgroundBlendModeNormal([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("background-blend-mode", "normal")
    /// Sets the blending mode to screen
    [<CustomOperation("backgroundBlendModeScreen")>]
    member inline _.backgroundBlendModeScreen([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("background-blend-mode", "screen")
    /// Sets the blending mode to overlay
    [<CustomOperation("backgroundBlendModeOverlay")>]
    member inline _.backgroundBlendModeOverlay([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("background-blend-mode", "overlay")
    /// Sets the blending mode to darken
    [<CustomOperation("backgroundBlendModeDarken")>]
    member inline _.backgroundBlendModeDarken([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("background-blend-mode", "darken")
    /// Sets the blending mode to multiply
    [<CustomOperation("backgroundBlendModeLighten")>]
    member inline _.backgroundBlendModeLighten([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("background-blend-mode", "lighten")
    /// Sets the blending mode to color-dodge
    [<CustomOperation("backgroundBlendModeCollorDodge")>]
    member inline _.backgroundBlendModeCollorDodge([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("background-blend-mode", "color-dodge")
    /// Sets the blending mode to saturation
    [<CustomOperation("backgroundBlendModeSaturation")>]
    member inline _.backgroundBlendModeSaturation([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("background-blend-mode", "saturation")
    /// Sets the blending mode to color
    [<CustomOperation("backgroundBlendModeColor")>]
    member inline _.backgroundBlendModeColor([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("background-blend-mode", "color")
    /// Sets the blending mode to luminosity
    [<CustomOperation("backgroundBlendModeLuminosity")>]
    member inline _.backgroundBlendModeLuminosity([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("background-blend-mode", "luminosity")

    /// Default value. The background extends behind the border.
    [<CustomOperation("backgroundClipBorderBox")>]
    member inline _.backgroundClipBorderBox([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("background-clip", "border-box")
    /// The background extends to the inside edge of the border.
    [<CustomOperation("backgroundClipPaddingBox")>]
    member inline _.backgroundClipPaddingBox([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("background-clip", "padding-box")
    /// The background extends to the edge of the content box.
    [<CustomOperation("backgroundClipContentBox")>]
    member inline _.backgroundClipContentBox([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("background-clip", "content-box")
    /// Sets this property to its default value.
    [<CustomOperation("backgroundClipInitial")>]
    member inline _.backgroundClipInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("background-clip", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("backgroundClipInheritFromParent")>]
    member inline _.backgroundClipInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("background-clip", "inherit")

    [<CustomOperation("transform")>]
    member inline _.transform([<InlineIfLambda>] comb: CombineKeyValue, transformation: string) = comb &>> ("transform", transformation)

    /// Defines that there should be no transformation.
    [<CustomOperation("transformNone")>]
    member inline _.transformNone([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("transform", "none")

    /// Defines a 2D transformation, using a matrix of six values.
    [<CustomOperation("transformMatrix")>]
    member inline _.transformMatrix([<InlineIfLambda>] comb: CombineKeyValue, x1: int, y1: int, z1: int, x2: int, y2: int, z2: int) =
        CombineKeyValue(fun x ->
            comb
                .Invoke(x)
                .Append("transform: ")
                .Append("matrix(")
                .Append(x1)
                .Append(",")
                .Append(y2)
                .Append(",")
                .Append(z1)
                .Append(",")
                .Append(x2)
                .Append(",")
                .Append(y2)
                .Append(",")
                .Append(z2)
                .Append("); ")
        )

    /// Defines a 2D translation.
    [<CustomOperation("transformTranslate")>]
    member inline _.transformTranslate([<InlineIfLambda>] comb: CombineKeyValue, x: int, y: int) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("transform: ").Append("translate(").Append(x).Append("px, ").Append(y).Append("px); "))

    /// Defines a 2D translation.
    [<CustomOperation("transformTranslate")>]
    member inline _.transformTranslate([<InlineIfLambda>] comb: CombineKeyValue, x: string, y: string) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("transform: ").Append("translate(").Append(x).Append(", ").Append(y).Append("); "))
    /// Defines a 3D translation.
    [<CustomOperation("transformTranslate3D")>]
    member inline _.transformTranslate3D([<InlineIfLambda>] comb: CombineKeyValue, x: int, y: int, z: int) =
        CombineKeyValue(fun x ->
            comb
                .Invoke(x)
                .Append("transform: ")
                .Append("translate3d(")
                .Append(x)
                .Append("px, ")
                .Append(y)
                .Append("px, ")
                .Append(z)
                .Append("px); ")
        )

    /// Defines a 3D translation.
    [<CustomOperation("transformTranslate3D")>]
    member inline _.transformTranslate3D([<InlineIfLambda>] comb: CombineKeyValue, x: string, y: string, z: string) =
        CombineKeyValue(fun x ->
            comb
                .Invoke(x)
                .Append("transform: ")
                .Append("translate3d(")
                .Append(x)
                .Append(", ")
                .Append(y)
                .Append(", ")
                .Append(z)
                .Append("); ")
        )

    /// Defines a translation, using only the value for the X-axis.
    [<CustomOperation("transformTranslateX")>]
    member inline _.transformTranslateX([<InlineIfLambda>] comb: CombineKeyValue, x: int) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("transform: ").Append("translateX(").Append(x).Append("px); "))
    /// Defines a translation, using only the value for the X-axis.
    [<CustomOperation("transformTranslateX")>]
    member inline _.transformTranslateX([<InlineIfLambda>] comb: CombineKeyValue, x: string) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("transform: ").Append("translateX(").Append(x).Append("); "))
    /// Defines a translation, using only the value for the Y-axis
    [<CustomOperation("transformTranslateY")>]
    member inline _.transformTranslateY([<InlineIfLambda>] comb: CombineKeyValue, y: int) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("transform: ").Append("translateY(").Append(y).Append("px); "))
    /// Defines a translation, using only the value for the Y-axis
    [<CustomOperation("transformTranslateY")>]
    member inline _.transformTranslateY([<InlineIfLambda>] comb: CombineKeyValue, y: string) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("transform: ").Append("translateY(").Append(y).Append("); "))
    /// Defines a 3D translation, using only the value for the Z-axis
    [<CustomOperation("transformTranslateZ")>]
    member inline _.transformTranslateZ([<InlineIfLambda>] comb: CombineKeyValue, z: int) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("transform: ").Append("translateZ(").Append(z).Append("px); "))
    /// Defines a 3D translation, using only the value for the Z-axis
    [<CustomOperation("transformTranslateZ")>]
    member inline _.transformTranslateZ([<InlineIfLambda>] comb: CombineKeyValue, z: string) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("transform: ").Append("translateZ(").Append(z).Append("); "))
    /// Defines a 2D scale transformation.
    [<CustomOperation("transformScale")>]
    member inline _.transformScale([<InlineIfLambda>] comb: CombineKeyValue, x: int, y: int) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("transform: ").Append("scale(").Append(x).Append(", ").Append(y).Append("); "))
    /// Defines a scale transformation.
    /// Defines a scale transformation.
    [<CustomOperation("transformScale")>]
    member inline _.transformScale([<InlineIfLambda>] comb: CombineKeyValue, n: float) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("transform: ").Append("scale(").Append(n).Append("); "))
    /// Defines a 3D scale transformation
    [<CustomOperation("transformScale3D")>]
    member inline _.transformScale3D([<InlineIfLambda>] comb: CombineKeyValue, x: int, y: int, z: int) =
        CombineKeyValue(fun x ->
            comb
                .Invoke(x)
                .Append("transform: ")
                .Append("scale3d(")
                .Append(x)
                .Append(", ")
                .Append(y)
                .Append(", ")
                .Append(z)
                .Append("); ")
        )
    /// Defines a scale transformation by giving a value for the X-axis.
    [<CustomOperation("transformScaleX")>]
    member inline _.transformScaleX([<InlineIfLambda>] comb: CombineKeyValue, x: int) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("transform: ").Append("scaleX(").Append(x).Append("); "))
    /// Defines a scale transformation by giving a value for the Y-axis.
    [<CustomOperation("transformScaleY")>]
    member inline _.transformScaleY([<InlineIfLambda>] comb: CombineKeyValue, y: int) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("transform: ").Append("scaleY(").Append(x).Append("); "))
    /// Defines a 3D translation, using only the value for the Z-axis
    [<CustomOperation("transformScaleZ")>]
    member inline _.transformScaleZ([<InlineIfLambda>] comb: CombineKeyValue, z: int) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("transform: ").Append("scaleZ(").Append(x).Append("); "))
    /// Defines a 2D rotation, the angle is specified in the parameter.
    [<CustomOperation("transformRotate")>]
    member inline _.transformRotate([<InlineIfLambda>] comb: CombineKeyValue, deg: int) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("transform: ").Append("rotate(").Append(x).Append("deg); "))
    /// Defines a 2D rotation, the angle is specified in the parameter.
    [<CustomOperation("transformRotate")>]
    member inline _.transformRotate([<InlineIfLambda>] comb: CombineKeyValue, deg: float) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("transform: ").Append("rotate(").Append(x).Append("deg); "))
    /// Defines a 3D rotation along the X-axis.
    [<CustomOperation("transformRotateX")>]
    member inline _.transformRotateX([<InlineIfLambda>] comb: CombineKeyValue, deg: float) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("transform: ").Append("rotateX(").Append(x).Append("deg); "))

    /// Defines a 3D rotation along the Y-axis
    [<CustomOperation("transformRotateY")>]
    member inline _.transformRotateY([<InlineIfLambda>] comb: CombineKeyValue, deg: float) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("transform: ").Append("rotateY(").Append(x).Append("deg); "))
    /// Defines a 3D rotation along the Z-axis
    [<CustomOperation("transformRotateZ")>]
    member inline _.transformRotateZ([<InlineIfLambda>] comb: CombineKeyValue, deg: float) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("transform: ").Append("rotateZ(").Append(x).Append("deg); "))
    /// Defines a 2D skew transformation along the X- and the Y-axis.
    [<CustomOperation("transformSkew")>]
    member inline _.transformSkew([<InlineIfLambda>] comb: CombineKeyValue, xAngle: float, yAngle: float) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("transform: ").Append("skew(").Append(xAngle).Append("deg, ").Append(yAngle).Append("deg); "))
    /// Defines a 2D skew transformation along the X-axis
    [<CustomOperation("transformSkewX")>]
    member inline _.transformSkewX([<InlineIfLambda>] comb: CombineKeyValue, xAngle: float) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("transform: ").Append("skewX(").Append(xAngle).Append("deg); "))
    /// Defines a 2D skew transformation along the Y-axis
    [<CustomOperation("transformSkewY")>]
    member inline _.transformSkewY([<InlineIfLambda>] comb: CombineKeyValue, yAngle: float) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("transform: ").Append("skewY(").Append(yAngle).Append("deg); "))
    /// Defines a perspective view for a 3D transformed element
    [<CustomOperation("transformPerspective")>]
    member inline _.transformPerspective([<InlineIfLambda>] comb: CombineKeyValue, n: int) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("transform: ").Append("perspective(").Append(n).Append("); "))
    /// Sets this property to its default value.
    [<CustomOperation("transformInitial")>]
    member inline _.transformInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("transform", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("transformInheritFromParent")>]
    member inline _.transformInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("transform", "inherit")

    /// Text direction goes from right-to-left
    [<CustomOperation("directionRightToLeft")>]
    member inline _.directionRightToLeft([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("direction", "rtl")
    /// Text direction goes from left-to-right. This is default
    [<CustomOperation("directionLeftToRight")>]
    member inline _.directionLeftToRight([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("direction", "ltr")
    /// Sets this property to its default value.
    [<CustomOperation("directionInitial")>]
    member inline _.directionInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("direction", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("directionInheritFromParent")>]
    member inline _.directionInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("direction", "inherit")

    /// Display borders on empty cells. This is default
    [<CustomOperation("emptyCellsShow")>]
    member inline _.emptyCellsShow([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("empty-cells", "show")
    /// Hide borders on empty cells
    [<CustomOperation("emptyCellsHide")>]
    member inline _.emptyCellsHide([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("empty-cells", "hide")
    /// Sets this property to its default value)
    [<CustomOperation("emptyCellsInitial")>]
    member inline _.emptyCellsInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("empty-cells", "initial")
    /// Inherits this property from its parent element
    [<CustomOperation("emptyCellsInheritFromParent")>]
    member inline _.emptyCellsInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("empty-cells", "inherit")

    /// Default value. The animation should be played as normal
    [<CustomOperation("animationDirectionNormal")>]
    member inline _.animationDirectionNormal([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("animation-direction", "normal")
    /// The animation should play in reverse direction
    [<CustomOperation("animationDirectionReverse")>]
    member inline _.animationDirectionReverse([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("animation-direction", "reverse")
    /// The animation will be played as normal every odd time (1, 3, 5, etc..) and in reverse direction every even time (2, 4, 6, etc...).
    [<CustomOperation("animationDirectionAlternate")>]
    member inline _.animationDirectionAlternate([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("animation-direction", "alternate")
    /// The animation will be played in reverse direction every odd time (1, 3, 5, etc..) and in a normal direction every even time (2,4,6,etc...))
    [<CustomOperation("animationDirectionAlternateReverse")>]
    member inline _.animationDirectionAlternateReverse([<InlineIfLambda>] comb: CombineKeyValue) =
        comb &>> ("animation-direction", "alternate-reverse")
    /// Sets this property to its default value)
    [<CustomOperation("animationDirectionInitial")>]
    member inline _.animationDirectionInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("animation-direction", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("animationDirectionInheritFromParent")>]
    member inline _.animationDirectionInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("animation-direction", "inherit")

    /// Default value. Specifies that the animation is running.
    [<CustomOperation("animationPlayStateRunning")>]
    member inline _.animationPlayStateRunning([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("animation-play-state", "running")
    /// Specifies that the animation is paused
    [<CustomOperation("animationPlayStatePaused")>]
    member inline _.animationPlayStatePaused([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("animation-play-state", "paused")
    /// Sets this property to its default value)
    [<CustomOperation("animationPlayStateInitial")>]
    member inline _.animationPlayStateInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("animation-play-state", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("animationPlayStateInheritFromParent")>]
    member inline _.animationPlayStateInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("animation-play-state", "inherit")

    /// Specifies that the animation should be played infinite times (forever))
    [<CustomOperation("animationIterationCountInfinite")>]
    member inline _.animationIterationCountInfinite([<InlineIfLambda>] comb: CombineKeyValue) =
        comb &>> ("animation-iteration-count", "infinite")
    /// Sets this property to its default value)
    [<CustomOperation("animationIterationCountInitial")>]
    member inline _.animationIterationCountInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("animation-iteration-count", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("animationIterationCountInheritFromParent")>]
    member inline _.animationIterationCountInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) =
        comb &>> ("animation-iteration-count", "inherit")

    /// Default value. Animation will not apply any styles to the element before or after it is executing
    [<CustomOperation("animationFillModeNone")>]
    member inline _.animationFillModeNone([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("animation-fill-mode", "none")
    /// The element will retain the style values that is set by the last keyframe (depends on animation-direction and animation-iteration-count).
    [<CustomOperation("animationFillModeForwards")>]
    member inline _.animationFillModeForwards([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("animation-fill-mode", "forwards")
    /// The element will get the style values that is set by the first keyframe (depends on animation-direction), and retain this during the animation-delay period
    [<CustomOperation("animationFillModeBackwards")>]
    member inline _.animationFillModeBackwards([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("animation-fill-mode", "backwards")
    /// The animation will follow the rules for both forwards and backwards, extending the animation properties in both directions
    [<CustomOperation("animationFillModeBoth")>]
    member inline _.animationFillModeBoth([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("animation-fill-mode", "both")
    /// Sets this property to its default value)
    [<CustomOperation("animationFillModeInitial")>]
    member inline _.animationFillModeInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("animation-fill-mode", "initial")
    /// Inherits this property from its parent element
    [<CustomOperation("animationFillModeInheritFromParent")>]
    member inline _.animationFillModeInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("animation-fill-mode", "inherit")

    /// Sets how background images are repeated.
    ///
    /// A background image can be repeated along the horizontal and vertical axes, or not repeated at all.
    [<CustomOperation("backgroundRepeat")>]
    member inline _.backgroundRepeat([<InlineIfLambda>] comb: CombineKeyValue, repeat: string) = comb &>> ("background-repeat", repeat)
    /// The background image is repeated both vertically and horizontally. This is default.
    [<CustomOperation("backgroundRepeatRepeat")>]
    member inline _.backgroundRepeatRepeat([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("background-repeat", "repeat")
    /// The background image is only repeated horizontally.
    [<CustomOperation("backgroundRepeatRepeatX")>]
    member inline _.backgroundRepeatRepeatX([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("background-repeat", "repeat-x")
    /// The background image is only repeated vertically.
    [<CustomOperation("backgroundRepeatRepeatY")>]
    member inline _.backgroundRepeatRepeatY([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("background-repeat", "repeat-y")
    /// The background-image is not repeated.
    [<CustomOperation("backgroundRepeatNoRepeat")>]
    member inline _.backgroundRepeatNoRepeat([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("background-repeat", "no-repeat")
    /// Sets this property to its default value.
    [<CustomOperation("backgroundRepeatInitial")>]
    member inline _.backgroundRepeatInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("background-repeat", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("backgroundRepeatInheritFromParent")>]
    member inline _.backgroundRepeatInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("background-repeat", "inherit")

    /// Default value. Elements render in order, as they appear in the document flow.
    [<CustomOperation("positionDefaultStatic")>]
    member inline _.positionDefaultStatic([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("position", "static")
    /// The element is positioned relative to its first positioned (not static) ancestor element.
    [<CustomOperation("positionAbsolute")>]
    member inline _.positionAbsolute([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("position", "absolute")
    /// The element is positioned relative to the browser window
    [<CustomOperation("positionFixed")>]
    member inline _.positionFixed([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("position", "fixed")
    /// The element is positioned relative to its normal position, so "left:20px" adds 20 pixels to the element's LEFT position.
    [<CustomOperation("positionRelative")>]
    member inline _.positionRelative([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("position", "relative")
    /// The element is positioned based on the user's scroll position
    ///
    /// A sticky element toggles between relative and fixed, depending on the scroll position. It is positioned relative until a given offset position is met in the viewport - then it "sticks" in place (like position:fixed).
    ///
    /// Note: Not supported in IE/Edge 15 or earlier. Supported in Safari from version 6.1 with a -webkit- prefix.
    [<CustomOperation("positionSticky")>]
    member inline _.positionSticky([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("position", "sticky")
    [<CustomOperation("positionInitial")>]
    member inline _.positionInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("position", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("positionInheritFromParent")>]
    member inline _.positionInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("position", "inherit")

    /// Default value. The width and height properties include the content, but does not include the padding, border, or margin.
    [<CustomOperation("boxSizingContentBox")>]
    member inline _.boxSizingContentBox([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("box-sizing", "content-box")
    /// The width and height properties include the content, padding, and border, but do not include the margin. Note that padding and border will be inside of the box.
    [<CustomOperation("boxSizingBorderBox")>]
    member inline _.boxSizingBorderBox([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("box-sizing", "border-box")
    /// Sets this property to its default value.
    [<CustomOperation("boxSizingInitial")>]
    member inline _.boxSizingInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("box-sizing", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("boxSizingInheritFromParent")>]
    member inline _.boxSizingInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("box-sizing", "inherit")

    /// Default value. The element offers no user-controllable method for resizing it.
    [<CustomOperation("resizeNone")>]
    member inline _.resizeNone([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("resize", "none")
    /// The element displays a mechanism for allowing the user to resize it, which may be resized both horizontally and vertically.
    [<CustomOperation("resizeBoth")>]
    member inline _.resizeBoth([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("resize", "both")
    /// The element displays a mechanism for allowing the user to resize it in the horizontal direction.
    [<CustomOperation("resizeHorizontal")>]
    member inline _.resizeHorizontal([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("resize", "horizontal")
    /// The element displays a mechanism for allowing the user to resize it in the vertical direction.
    [<CustomOperation("resizeVertical")>]
    member inline _.resizeVertical([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("resize", "vertical")
    /// The element displays a mechanism for allowing the user to resize it in the block direction (either horizontally or vertically, depending on the writing-mode and direction value).
    [<CustomOperation("resizeBlock")>]
    member inline _.resizeBlock([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("resize", "block")
    /// The element displays a mechanism for allowing the user to resize it in the inline direction (either horizontally or vertically, depending on the writing-mode and direction value).
    [<CustomOperation("resizeInline'")>]
    member inline _.resizeInline'([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("resize", "inline")
    /// Sets this property to its default value.
    [<CustomOperation("resizeInitial")>]
    member inline _.resizeInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("resize", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("resizeInheritFromParent")>]
    member inline _.resizeInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("resize", "inherit")

    /// Aligns the text to the left.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align
    [<CustomOperation("textAlignLeft")>]
    member inline _.textAlignLeft([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-align", "left")
    /// Aligns the text to the right.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=right
    [<CustomOperation("textAlignRight")>]
    member inline _.textAlignRight([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-align", "right")
    /// Centers the text.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=center
    [<CustomOperation("textAlignCenter")>]
    member inline _.textAlignCenter([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-align", "center")
    /// Stretches the lines so that each line has equal width (like in newspapers and magazines).
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=justify
    [<CustomOperation("textAlignJustify")>]
    member inline _.textAlignJustify([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-align", "justify")
    /// Sets this property to its default value.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=initial
    [<CustomOperation("textAlignInitial")>]
    member inline _.textAlignInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-align", "initial")
    /// Inherits this property from its parent element.
    ///
    /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=initial
    [<CustomOperation("textAlignInheritFromParent")>]
    member inline _.textAlignInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("text-align", "inherit")

    /// Displays an element as an inline element (like `<span> `). Any height and width properties will have no effect.
    [<CustomOperation("displayInlineElement")>]
    member inline _.displayInlineElement([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("display", "inline")
    /// Displays an element as a block element (like `<p> `). It starts on a new line, and takes up the whole width.
    [<CustomOperation("displayBlock")>]
    member inline _.displayBlock([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("display", "block")
    /// Makes the container disappear, making the child elements children of the element the next level up in the DOM.
    [<CustomOperation("displayContents")>]
    member inline _.displayContents([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("display", "contents")
    /// Displays an element as a block-level flex container.
    [<CustomOperation("displayFlex")>]
    member inline _.displayFlex([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("display", "flex")
    /// Displays an element as a block container box, and lays out its contents using flow layout.
    ///
    /// It always establishes a new block formatting context for its contents.
    [<CustomOperation("displayFlowRoot")>]
    member inline _.displayFlowRoot([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("display", "flow-root")
    /// Displays an element as a block-level grid container.
    [<CustomOperation("displayGrid")>]
    member inline _.displayGrid([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("display", "grid")
    /// Displays an element as an inline-level block container. The element itself is formatted as an inline element, but you can apply height and width values.
    [<CustomOperation("displayInlineBlock")>]
    member inline _.displayInlineBlock([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("display", "inline-block")
    /// Displays an element as an inline-level flex container.
    [<CustomOperation("displayInlineFlex")>]
    member inline _.displayInlineFlex([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("display", "inline-flex")
    /// Displays an element as an inline-level grid container
    [<CustomOperation("displayInlineGrid")>]
    member inline _.displayInlineGrid([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("display", "inline-grid")
    /// The element is displayed as an inline-level table.
    [<CustomOperation("displayInlineTable")>]
    member inline _.displayInlineTable([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("display", "inline-table")
    /// Let the element behave like a `<li> ` element
    [<CustomOperation("displayListItem")>]
    member inline _.displayListItem([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("display", "list-item")
    /// Displays an element as either block or inline, depending on context.
    [<CustomOperation("displayRunIn")>]
    member inline _.displayRunIn([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("display", "run-in")
    /// Let the element behave like a `<table> ` element.
    [<CustomOperation("displayTable")>]
    member inline _.displayTable([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("display", "table")
    /// Let the element behave like a <caption> element.
    [<CustomOperation("displayTableCaption")>]
    member inline _.displayTableCaption([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("display", "table-caption")
    /// Let the element behave like a <colgroup> element.
    [<CustomOperation("displayTableColumnGroup")>]
    member inline _.displayTableColumnGroup([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("display", "table-column-group")
    /// Let the element behave like a <thead> element.
    [<CustomOperation("displayTableHeaderGroup")>]
    member inline _.displayTableHeaderGroup([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("display", "table-header-group")
    /// Let the element behave like a <tfoot> element.
    [<CustomOperation("displayTableFooterGroup")>]
    member inline _.displayTableFooterGroup([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("display", "table-footer-group")
    /// Let the element behave like a <tbody> element.
    [<CustomOperation("displayTableRowGroup")>]
    member inline _.displayTableRowGroup([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("display", "table-row-group")
    /// Let the element behave like a <td> element.
    [<CustomOperation("displayTableCell")>]
    member inline _.displayTableCell([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("display", "table-cell")
    /// Let the element behave like a <col> element.
    [<CustomOperation("displayTableColumn")>]
    member inline _.displayTableColumn([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("display", "table-column")
    /// Let the element behave like a <tr> element.
    [<CustomOperation("displayTableRow")>]
    member inline _.displayTableRow([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("display", "table-row")
    /// The element is completely removed.
    [<CustomOperation("displayNone")>]
    member inline _.displayNone([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("display", "none")
    /// Sets this property to its default value.
    [<CustomOperation("displayInitial")>]
    member inline _.displayInitial([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("display", "initial")
    /// Inherits this property from its parent element.
    [<CustomOperation("displayInheritFromParent")>]
    member inline _.displayInheritFromParent([<InlineIfLambda>] comb: CombineKeyValue) = comb &>> ("display", "inherit")

    /// The zIndex property sets or returns the stack order of a positioned element.
    ///
    /// An element with greater stack order (1) is always in front of another element with lower stack order (0).
    ///
    /// **Tip**: A positioned element is an element with the position property set to: relative, absolute, or fixed.
    ///
    /// **Tip**: This property is useful if you want to create overlapping elements.
    [<CustomOperation("zIndex")>]
    member inline _.zIndex([<InlineIfLambda>] comb: CombineKeyValue, value: int) = comb &&& mkWithKV ("z-index", value)

    /// Sets the margin area on all four sides of an element. It is a shorthand for margin-top, margin-right,
    /// margin-bottom, and margin-left.
    [<CustomOperation("margin")>]
    member inline _.margin([<InlineIfLambda>] comb: CombineKeyValue, value: int) = comb &&& mkPxWithKV ("margin", value)
    /// Sets the margin area on all four sides of an element. It is a shorthand for margin-top, margin-right,
    /// margin-bottom, and margin-left.
    [<CustomOperation("margin")>]
    member inline _.margin([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("margin", value)

    /// Sets the margin area on the vertical and horizontal axis.
    [<CustomOperation("margin")>]
    member inline _.margin([<InlineIfLambda>] comb: CombineKeyValue, vertical: int, horizonal: int) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("margin: ").Append(vertical).Append("px ").Append(horizonal).Append("px); "))

    /// Sets the margin area on the vertical and horizontal axis.
    [<CustomOperation("margin")>]
    member inline _.margin([<InlineIfLambda>] comb: CombineKeyValue, vertical: string, horizonal: string) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("margin: ").Append(vertical).Append(" ").Append(horizonal).Append("); "))

    /// Sets the margin area on all four sides of an element. It is a shorthand for margin-top, margin-right,
    /// margin-bottom, and margin-left.
    [<CustomOperation("margin")>]
    member inline _.margin([<InlineIfLambda>] comb: CombineKeyValue, top: int, right: int, bottom: int, left: int) =
        CombineKeyValue(fun x ->
            comb
                .Invoke(x)
                .Append("margin: ")
                .Append(top)
                .Append("px ")
                .Append(right)
                .Append("px ")
                .Append(bottom)
                .Append("px ")
                .Append(left)
                .Append("px); ")
        )

    /// Sets the margin area on all four sides of an element. It is a shorthand for margin-top, margin-right,
    /// margin-bottom, and margin-left.
    [<CustomOperation("margin")>]
    member inline _.margin([<InlineIfLambda>] comb: CombineKeyValue, top: string, right: string, bottom: string, left: string) =
        CombineKeyValue(fun x ->
            comb
                .Invoke(x)
                .Append("margin: ")
                .Append(top)
                .Append(" ")
                .Append(right)
                .Append(" ")
                .Append(bottom)
                .Append(" ")
                .Append(left)
                .Append("); ")
        )

    /// Sets the margin area on the left side of an element. A positive value places it farther from its
    /// neighbors, while a negative value places it closer.
    [<CustomOperation("marginLeft")>]
    member inline _.marginLeft([<InlineIfLambda>] comb: CombineKeyValue, value: int) = comb &&& mkPxWithKV ("margin-left", value)
    /// Sets the margin area on the left side of an element. A positive value places it farther from its
    /// neighbors, while a negative value places it closer.
    [<CustomOperation("marginLeft")>]
    member inline _.marginLeft([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("margin-left", value)
    /// sets the margin area on the right side of an element. A positive value places it farther from its
    /// neighbors, while a negative value places it closer.
    [<CustomOperation("marginRight")>]
    member inline _.marginRight([<InlineIfLambda>] comb: CombineKeyValue, value: int) = comb &&& mkPxWithKV ("margin-right", value)
    /// sets the margin area on the right side of an element. A positive value places it farther from its
    /// neighbors, while a negative value places it closer.
    [<CustomOperation("marginRight")>]
    member inline _.marginRight([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("margin-right", value)
    /// Sets the margin area on the top of an element. A positive value places it farther from its
    /// neighbors, while a negative value places it closer.
    [<CustomOperation("marginTop")>]
    member inline _.marginTop([<InlineIfLambda>] comb: CombineKeyValue, value: int) = comb &&& mkPxWithKV ("margin-top", value)
    /// Sets the margin area on the top of an element. A positive value places it farther from its
    /// neighbors, while a negative value places it closer.
    [<CustomOperation("marginTop")>]
    member inline _.marginTop([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("margin-top", value)
    /// Sets the margin area on the bottom of an element. A positive value places it farther from its
    /// neighbors, while a negative value places it closer.
    [<CustomOperation("marginBottom")>]
    member inline _.marginBottom([<InlineIfLambda>] comb: CombineKeyValue, value: int) = comb &&& mkPxWithKV ("margin-bottom", value)
    /// Sets the margin area on the bottom of an element. A positive value places it farther from its
    /// neighbors, while a negative value places it closer.
    [<CustomOperation("marginBottom")>]
    member inline _.marginBottom([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("margin-bottom", value)

    /// Sets the padding area on all four sides of an element. It is a shorthand for padding-top,
    /// padding-right, padding-bottom, and padding-left.
    [<CustomOperation("padding")>]
    member inline _.padding([<InlineIfLambda>] comb: CombineKeyValue, value: int) = comb &&& mkPxWithKV ("padding", value)
    /// Sets the padding area on all four sides of an element. It is a shorthand for padding-top,
    /// padding-right, padding-bottom, and padding-left.
    [<CustomOperation("padding")>]
    member inline _.padding([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("padding", value)
    /// Sets the padding area for vertical and horizontal axis.
    [<CustomOperation("padding")>]
    member inline _.padding([<InlineIfLambda>] comb: CombineKeyValue, vertical: int, horizontal: int) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("padding: ").Append(vertical).Append("px ").Append(horizontal).Append("px); "))
    /// Sets the padding area for vertical and horizontal axis.
    [<CustomOperation("padding")>]
    member inline _.padding([<InlineIfLambda>] comb: CombineKeyValue, vertical: string, horizontal: string) =
        CombineKeyValue(fun x -> comb.Invoke(x).Append("padding: ").Append(vertical).Append(" ").Append(horizontal).Append("); "))
    /// Sets the padding area on all four sides of an element. It is a shorthand for padding-top,
    /// padding-right, padding-bottom, and padding-left.
    [<CustomOperation("padding")>]
    member inline _.padding([<InlineIfLambda>] comb: CombineKeyValue, top: string, right: string, bottom: string, left: string) =
        CombineKeyValue(fun x ->
            comb
                .Invoke(x)
                .Append("padding: ")
                .Append(top)
                .Append(" ")
                .Append(right)
                .Append(" ")
                .Append(bottom)
                .Append(" ")
                .Append(left)
                .Append("); ")
        )
    /// Sets the padding area on all four sides of an element. It is a shorthand for padding-top,
    /// padding-right, padding-bottom, and padding-left.
    [<CustomOperation("padding")>]
    member inline _.padding([<InlineIfLambda>] comb: CombineKeyValue, top: int, right: int, bottom: int, left: int) =
        CombineKeyValue(fun x ->
            comb
                .Invoke(x)
                .Append("padding: ")
                .Append(top)
                .Append("px ")
                .Append(right)
                .Append("px ")
                .Append(bottom)
                .Append("px ")
                .Append(left)
                .Append("px); ")
        )
    /// Sets the height of the padding area on the bottom of an element.
    [<CustomOperation("paddingBottom")>]
    member inline _.paddingBottom([<InlineIfLambda>] comb: CombineKeyValue, value: int) = comb &&& mkPxWithKV ("padding-bottom", value)
    /// Sets the height of the padding area on the bottom of an element.
    [<CustomOperation("paddingBottom")>]
    member inline _.paddingBottom([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("padding-bottom", value)
    /// Sets the width of the padding area to the left of an element.
    [<CustomOperation("paddingLeft")>]
    member inline _.paddingLeft([<InlineIfLambda>] comb: CombineKeyValue, value: int) = comb &&& mkPxWithKV ("padding-left", value)
    /// Sets the width of the padding area to the left of an element.
    [<CustomOperation("paddingLeft")>]
    member inline _.paddingLeft([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("padding-left", value)
    /// Sets the width of the padding area on the right of an element.
    [<CustomOperation("paddingRight")>]
    member inline _.paddingRight([<InlineIfLambda>] comb: CombineKeyValue, value: int) = comb &&& mkPxWithKV ("padding-right", value)
    /// Sets the width of the padding area on the right of an element.
    [<CustomOperation("paddingRight")>]
    member inline _.paddingRight([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("padding-right", value)
    /// Sets the height of the padding area on the top of an element.
    [<CustomOperation("paddingTop")>]
    member inline _.paddingTop([<InlineIfLambda>] comb: CombineKeyValue, value: int) = comb &&& mkPxWithKV ("padding-top", value)
    /// Sets the height of the padding area on the top of an element.
    [<CustomOperation("paddingTop")>]
    member inline _.paddingTop([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("padding-top", value)

    /// Sets the flex shrink factor of a flex item. If the size of all flex items is larger than
    /// the flex container, items shrink to fit according to flex-shrink.
    [<CustomOperation("flexShrink")>]
    member inline _.flexShrink([<InlineIfLambda>] comb: CombineKeyValue, value: int) = comb &&& mkWithKV ("flex-shrink", value)
    /// Sets the initial main size of a flex item. It sets the size of the content box unless
    /// otherwise set with box-sizing.
    [<CustomOperation("flexBasis")>]
    member inline _.flexBasis([<InlineIfLambda>] comb: CombineKeyValue, value: int) = comb &&& mkPxWithKV ("flex-basis", value)
    /// Sets the initial main size of a flex item. It sets the size of the content box unless
    /// otherwise set with box-sizing.
    [<CustomOperation("flexBasis")>]
    member inline _.flexBasis([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("flex-basis", value)
    /// Sets the flex grow factor of a flex item main size. It specifies how much of the remaining
    /// space in the flex container should be assigned to the item (the flex grow factor).
    [<CustomOperation("flexGrow")>]
    member inline _.flexGrow([<InlineIfLambda>] comb: CombineKeyValue, value: int) = comb &&& mkWithKV ("flex-grow", value)
    /// Shorthand of flex-grow, flex-shrink and flex-basis
    [<CustomOperation("flex")>]
    member inline _.flex([<InlineIfLambda>] comb: CombineKeyValue, grow: int, ?shrink: int, ?basis: string) =
        comb &>> ("flex", string grow + ", " + string shrink + ", " + string basis)
    /// Shorthand of flex-grow, flex-shrink and flex-basis
    [<CustomOperation("flex")>]
    member inline _.flex([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("flex", value)

    /// Sets the width of each individual grid column in pixels.
    ///
    /// **CSS**
    /// ```css
    /// grid-template-columns: 100px 200px 100px;
    /// ```
    /// **F#**
    /// ```f#
    /// gridTemplateColumns: [100; 200; 100]
    /// ```
    [<CustomOperation("gridTemplateColumns")>]
    member inline _.gridTemplateColumns([<InlineIfLambda>] comb: CombineKeyValue, value: int seq) =
        CombineKeyValue(fun x ->
            let sb = comb.Invoke(x).Append("grid-template-columns: ")
            for v in value do
                sb.Append(v).Append("px ") |> ignore
            sb.Append("; ")
        )
    /// Sets the width of each individual grid column.
    ///
    /// **CSS**
    /// ```css
    /// grid-template-columns: 1fr 1fr 2fr;
    /// ```
    [<CustomOperation("gridTemplateColumns")>]
    member inline _.gridTemplateColumns([<InlineIfLambda>] comb: CombineKeyValue, value) = comb &>> ("grid-template-columns", value)
    /// Sets the width of a number of grid columns to the defined width, as well as naming the lines between them
    ///
    /// **CSS**
    /// ```css
    /// grid-template-columns: repeat(3, 1fr [col-start]);
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridTemplateColumns (3, "1fr", "col-start"))
    /// ```
    [<CustomOperation("gridTemplateColumns")>]
    member inline _.gridTemplateColumns([<InlineIfLambda>] comb: CombineKeyValue, count: int, size: string, ?areaName: string) =
        let areaName =
            match areaName with
            | Some n -> ", [" + n + "]"
            | None -> ""
        CombineKeyValue(fun x ->
            comb
                .Invoke(x)
                .Append("grid-template-columns: ")
                .Append("repeat(")
                .Append(count)
                .Append(", ")
                .Append(size)
                .Append(areaName)
                .Append("); ")
        )
    /// Sets the width of a number of grid rows to the defined width
    ///
    /// **CSS**
    /// ```css
    /// grid-template-rows: 100px 200px 100px;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridTemplateRows [100, 200, 100]
    /// ```
    [<CustomOperation("gridTemplateRows")>]
    member inline _.gridTemplateRows([<InlineIfLambda>] comb: CombineKeyValue, value: int seq) =
        CombineKeyValue(fun x ->
            let sb = comb.Invoke(x).Append("grid-template-rows: ")
            for v in value do
                sb.Append(v).Append("px ") |> ignore
            sb.Append("; ")
        )
    /// Sets the width of a number of grid rows to the defined width
    ///
    /// **CSS**
    /// ```css
    /// grid-template-rows: 1fr 10% 250px auto;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridTemplateRows ["1fr"]
    /// ```
    [<CustomOperation("gridTemplateRows")>]
    member inline _.gridTemplateRows([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("grid-template-rows", value)
    /// Sets the width of a number of grid rows to the defined width
    ///
    /// **CSS**
    /// ```css
    /// grid-template-rows: repeat(3, 10%);
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridTemplateRows (3, length.percent 10))
    /// ```
    [<CustomOperation("gridTemplateRows")>]
    member inline _.gridTemplateRows([<InlineIfLambda>] comb: CombineKeyValue, count: int, size: string, ?areaName: string) =
        let areaName =
            match areaName with
            | Some n -> " [" + n + "]"
            | None -> ""
        CombineKeyValue(fun x ->
            comb
                .Invoke(x)
                .Append("grid-template-rows: ")
                .Append("repeat(")
                .Append(count)
                .Append(", ")
                .Append(size)
                .Append(areaName)
                .Append("); ")
        )
    /// 2D representation of grid layout as blocks with names
    ///
    /// **CSS**
    /// ```css
    /// grid-template-areas:
    ///     'header header header header'
    ///     'nav nav . sidebar'
    ///     'footer footer footer footer';
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridTemplateAreas [
    ///     "header header header header"
    ///     "nav    nav    .      sidebar"
    ///     "footer footer footer footer"
    /// ]
    /// ```
    [<CustomOperation("gridTemplateAreas")>]
    member inline _.gridTemplateAreas([<InlineIfLambda>] comb: CombineKeyValue, value: string list) =
        CombineKeyValue(fun x ->
            let sb = comb.Invoke(x).Append("grid-template-areas: ")
            for item in value do
                sb.Append("'").Append(item).Append("' ") |> ignore

            sb.Append("; ")
        )
    /// Specifies the size of the grid lines. You can think of it like
    /// setting the width of the gutters between the columns.
    ///
    /// **CSS**
    /// ```css
    /// column-gap: 10px;
    /// ```
    /// **F#**
    /// ```f#
    /// style.columnGap 10
    /// ```
    [<CustomOperation("columnGap")>]
    member inline _.columnGap([<InlineIfLambda>] comb: CombineKeyValue, value: int) = comb &&& mkPxWithKV ("column-gap", value)
    /// Specifies the size of the grid lines. You can think of it like
    /// setting the width of the gutters between the columns.
    ///
    /// **CSS**
    /// ```css
    /// column-gap: 1em;
    /// ```
    /// **F#**
    /// ```f#
    /// style.columnGap (length.em 1))
    /// ```
    [<CustomOperation("columnGap")>]
    member inline _.columnGap([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("column-gap", value)
    /// Specifies the size of the grid lines. You can think of it like
    /// setting the width of the gutters between the rows.
    ///
    /// **CSS**
    /// ```css
    /// row-gap: 10px;
    /// ```
    /// **F#**
    /// ```f#
    /// style.rowGap 10
    /// ```
    [<CustomOperation("rowGap")>]
    member inline _.rowGap([<InlineIfLambda>] comb: CombineKeyValue, value: int) = comb &&& mkPxWithKV ("row-gap", value)
    /// Specifies the size of the grid lines. You can think of it like
    /// setting the width of the gutters between the rows.
    ///
    /// **CSS**
    /// ```css
    /// row-gap: 1em;
    /// ```
    /// **F#**
    /// ```f#
    /// style.rowGap (length.em 1))
    /// ```
    [<CustomOperation("rowGap")>]
    member inline _.rowGap([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("row-gap", value)
    /// Specifies the size of the grid lines. You can think of it like
    /// setting the width of the gutters between the rows/columns.
    ///
    /// _Shorthand for `rowGap` and `columnGap`_
    ///
    /// **CSS**
    /// ```css
    /// gap: 1em 2em;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gap (length.em 1, length.em 2))
    /// ```
    [<CustomOperation("gap")>]
    member inline _.gap([<InlineIfLambda>] comb: CombineKeyValue, rowGap: string, columnGap: string) = comb &>> ("gap", rowGap + ", " + columnGap)
    [<CustomOperation("gap")>]
    member inline _.gap([<InlineIfLambda>] comb: CombineKeyValue, rowColumnGap: string) =
        comb &>> ("gap", rowColumnGap + ", " + rowColumnGap)
    /// Sets where an item in the grid starts
    /// The value can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// When there are multiple named lines with the same name, you can specify which one by count
    ///
    /// **CSS**
    /// ```css
    /// grid-column-start: col 2;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridColumnStart ("col", 2))
    /// ```
    [<CustomOperation("gridColumnStart")>]
    member inline _.gridColumnStart([<InlineIfLambda>] comb: CombineKeyValue, value: string, ?count: int) =
        comb
        &>> ("grid-column-start",
             value
             + match count with
               | Some x -> ", " + string x
               | _ -> "")
    /// Sets where an item in the grid starts
    /// The value can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// **CSS**
    /// ```css
    /// grid-column-start: 2;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridColumnStart 2
    /// ```
    [<CustomOperation("gridColumnStart")>]
    member inline _.gridColumnStart([<InlineIfLambda>] comb: CombineKeyValue, value: int) = comb &&& mkWithKV ("grid-column-start", value)
    /// Sets where an item in the grid starts
    /// The value can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// **CSS**
    /// ```css
    /// grid-column-start: span odd-col;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridColumnStart (gridColumn.span "odd-col"))
    /// ```
    [<CustomOperation("gridColumnStart")>]
    member inline _.gridColumnStart([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("grid-column-start", value)
    /// Sets where an item in the grid ends
    /// The value can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// _When there are multiple named lines with the same name, you can specify which one by count_
    ///
    /// **CSS**
    /// ```css
    /// grid-column-end: odd-col 2;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridColumnEnd ("odd-col", 2))
    /// ```
    [<CustomOperation("gridColumnEnd")>]
    member inline _.gridColumnEnd([<InlineIfLambda>] comb: CombineKeyValue, value: string, ?count: int) =
        comb
        &>> ("grid-column-end",
             value
             + match count with
               | Some x -> ", " + string x
               | _ -> "")
    /// Sets where an item in the grid ends
    /// The value can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// **CSS**
    /// ```css
    /// grid-column-end: 2;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridColumnEnd 2
    /// ```
    [<CustomOperation("gridColumnEnd")>]
    member inline _.gridColumnEnd([<InlineIfLambda>] comb: CombineKeyValue, value: int) = comb &&& mkWithKV ("grid-column-end", value)
    /// Sets where an item in the grid ends
    /// The value can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// **CSS**
    /// ```css
    /// grid-column-end: span 2;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridColumnEnd (gridColumn.span 2))
    /// ```
    [<CustomOperation("gridColumnEnd")>]
    member inline _.gridColumnEnd([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("grid-column-end", value)
    /// Sets where an item in the grid starts
    /// The value can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// **CSS**
    /// ```css
    /// grid-row-start: col 2;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridRowStart ("col", 2))
    /// ```
    [<CustomOperation("gridRowStart")>]
    member inline _.gridRowStart([<InlineIfLambda>] comb: CombineKeyValue, value: string, ?count: int) =
        comb
        &>> ("grid-row-start",
             value
             + match count with
               | Some x -> ", " + string x
               | _ -> "")
    /// Sets where an item in the grid starts
    /// The value can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// **CSS**
    /// ```css
    /// grid-row-start: 2;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridRowStart 2
    /// ```
    [<CustomOperation("gridRowStart")>]
    member inline _.gridRowStart([<InlineIfLambda>] comb: CombineKeyValue, value: int) = comb &&& mkWithKV ("grid-row-start", value)
    /// Sets where an item in the grid starts
    /// The value can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// **CSS**
    /// ```css
    /// grid-row-start: span odd-col;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridRowStart (gridRow.span "odd-col"))
    /// ```
    [<CustomOperation("gridRowStart")>]
    member inline _.gridRowStart([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("grid-row-start", value)
    /// Sets where an item in the grid ends
    /// The value can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// _When there are multiple named lines with the same name, you can specify which one by count_
    ///
    /// **CSS**
    /// ```css
    /// grid-row-end: odd-col 2;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridRowEnd ("odd-col", 2))
    /// ```
    [<CustomOperation("gridRowEnd")>]
    member inline _.gridRowEnd([<InlineIfLambda>] comb: CombineKeyValue, value: string, ?count: int) =
        comb
        &>> ("grid-row-end",
             value
             + match count with
               | Some x -> ", " + string x
               | _ -> "")
    /// Sets where an item in the grid ends
    /// The value can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// **CSS**
    /// ```css
    /// grid-row-end: 2;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridRowEnd 2
    /// ```
    [<CustomOperation("gridRowEnd")>]
    member inline _.gridRowEnd([<InlineIfLambda>] comb: CombineKeyValue, value: int) = comb &&& mkWithKV ("grid-row-end", value)
    /// Sets where an item in the grid ends
    /// The value can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// **CSS**
    /// ```css
    /// grid-row-end: span 2;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridRowEnd (gridRow.span 2))
    /// ```
    [<CustomOperation("gridRowEnd")>]
    member inline _.gridRowEnd([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("grid-row-end", value)
    /// Determines a grid item��s location within the grid by referring to specific grid lines.
    /// start is the line where the item begins, end' is the line where it ends.
    /// They can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// _Shorthand for `gridColumnStart` and `gridColumnEnds`_
    ///
    /// **CSS**
    /// ```css
    /// grid-column: col-2 / col-4;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridColumn ("col-2", "col-4"))
    /// ```
    [<CustomOperation("gridColumn")>]
    member inline _.gridColumn([<InlineIfLambda>] comb: CombineKeyValue, start: string, end': string) = comb &>> ("grid-column", start + " / " + end')
    /// Determines a grid item��s location within the grid by referring to specific grid lines.
    /// start is the line where the item begins, end' is the line where it ends.
    /// They can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// _Shorthand for `gridColumnStart` and `gridColumnEnds`_
    ///
    /// **CSS**
    /// ```css
    /// grid-column: 1 / 3;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridColumn (1, 3))
    /// ```
    [<CustomOperation("gridColumn")>]
    member inline _.gridColumn([<InlineIfLambda>] comb: CombineKeyValue, start: int, end': int) =
        comb &>> ("grid-column", string start + " / " + string end')
    /// Determines a grid item��s location within the grid by referring to specific grid lines.
    /// start is the line where the item begins, end' is the line where it ends.
    /// They can be one of the following options:
    /// - a named line
    /// - a numbered line
    /// - span until a named line was hit
    /// - span over a specified number of lines
    ///
    ///
    /// _Shorthand for `gridRowStart` and `gridRowEnds`_
    ///
    /// **CSS**
    /// ```css
    /// grid-row: row-2 / row-4;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridRow ("row-2", "row-4"))
    /// ```
    [<CustomOperation("gridRow")>]
    member inline _.gridRow([<InlineIfLambda>] comb: CombineKeyValue, start: string, end': string) = comb &>> ("grid-row", start + " / " + end')
    /// Sets the named grid area the item is placed in
    ///
    /// **CSS**
    /// ```css
    /// grid-area: header;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridArea "header")
    /// ```
    [<CustomOperation("gridArea")>]
    member inline _.gridArea([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("grid-area", value)
    /// Shorthand for `grid-template-areas`, `grid-template-columns` and `grid-template-rows`.
    ///
    /// Documentation: https://developer.mozilla.org/en-US/docs/Web/CSS/grid-template
    ///
    /// **CSS**
    /// ```css
    /// grid-template:  [header-top] 'a a a'      [header-bottom]
    ///                   [main-top] 'b b b' 1fr  [main-bottom]
    ///                              / auto 1fr auto;
    /// ```
    /// **F#**
    /// ```f#
    /// style.gridTemplate "[header-top] 'a a a'      [header-bottom] " +
    ///                      "[main-top] 'b b b' 1fr  [main-bottom] " +
    ///                                "/ auto 1fr auto")
    /// ```
    [<CustomOperation("gridTemplate")>]
    member inline _.gridTemplate([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("grid-template", value)
    [<CustomOperation("transition")>]
    member inline _.transition([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("transition", value)
    /// Sets the length of time a transition animation should take to complete. By default, the
    /// value is 0s, meaning that no animation will occur.
    [<CustomOperation("transitionDuration")>]
    member inline _.transitionDuration([<InlineIfLambda>] comb: CombineKeyValue, timespan: TimeSpan) =
        comb &>> ("transition-duration", timespan.TotalMilliseconds.ToString() + "ms")
    /// Sets the length of time a transition animation should take to complete. By default, the
    /// value is 0s, meaning that no animation will occur.
    [<CustomOperation("transitionDurationSeconds")>]
    member inline _.transitionDurationSeconds([<InlineIfLambda>] comb: CombineKeyValue, n: float) = comb &>> ("transition-duration", string n + "s")
    /// Sets the length of time a transition animation should take to complete. By default, the
    /// value is 0s, meaning that no animation will occur.
    [<CustomOperation("transitionDurationMilliseconds")>]
    member inline _.transitionDurationMilliseconds([<InlineIfLambda>] comb: CombineKeyValue, n: float) =
        comb &>> ("transition-duration", string n + "ms")
    /// Sets the length of time a transition animation should take to complete. By default, the
    /// value is 0s, meaning that no animation will occur.
    [<CustomOperation("transitionDurationSeconds")>]
    member inline _.transitionDurationSeconds([<InlineIfLambda>] comb: CombineKeyValue, n: int) = comb &>> ("transition-duration", string n + "s")
    /// Sets the length of time a transition animation should take to complete. By default, the
    /// value is 0s, meaning that no animation will occur.
    [<CustomOperation("transitionDurationMilliseconds")>]
    member inline _.transitionDurationMilliseconds([<InlineIfLambda>] comb: CombineKeyValue, n: int) =
        comb &>> ("transition-duration", string n + "ms")
    /// Specifies the duration to wait before starting a property's transition effect when its value changes.
    [<CustomOperation("transitionDelay")>]
    member inline _.transitionDelay([<InlineIfLambda>] comb: CombineKeyValue, timespan: TimeSpan) =
        comb &>> ("transition-delay", timespan.TotalMilliseconds.ToString() + "ms")
    /// Specifies the duration to wait before starting a property's transition effect when its value changes.
    [<CustomOperation("transitionDelaySeconds")>]
    member inline _.transitionDelaySeconds([<InlineIfLambda>] comb: CombineKeyValue, n: float) = comb &>> ("transition-delay", string n + "s")
    /// Specifies the duration to wait before starting a property's transition effect when its value changes.
    [<CustomOperation("transitionDelayMilliseconds")>]
    member inline _.transitionDelayMilliseconds([<InlineIfLambda>] comb: CombineKeyValue, n: float) = comb &>> ("transition-delay", string n + "ms")
    /// Specifies the duration to wait before starting a property's transition effect when its value changes.
    [<CustomOperation("transitionDelaySeconds")>]
    member inline _.transitionDelaySeconds([<InlineIfLambda>] comb: CombineKeyValue, n: int) = comb &>> ("transition-delay", string n + "s")
    /// Specifies the duration to wait before starting a property's transition effect when its value changes.
    [<CustomOperation("transitionDelayMilliseconds")>]
    member inline _.transitionDelayMilliseconds([<InlineIfLambda>] comb: CombineKeyValue, n: int) = comb &>> ("transition-delay", string n + "ms")
    /// Sets the CSS properties to which a transition effect should be applied.
    [<CustomOperation("transitionProperty")>]
    member inline _.transitionProperty([<InlineIfLambda>] comb: CombineKeyValue, property: string) = comb &>> ("transition-property", property)

    /// Sets the size of the font.
    ///
    /// This property is also used to compute the size of em, ex, and other relative <length> units.
    [<CustomOperation("fontSize")>]
    member inline _.fontSize([<InlineIfLambda>] comb: CombineKeyValue, size: int) = comb &&& mkPxWithKV ("font-size", size)
    /// Sets the size of the font.
    ///
    /// This property is also used to compute the size of em, ex, and other relative <length> units.
    [<CustomOperation("fontSize")>]
    member inline _.fontSize([<InlineIfLambda>] comb: CombineKeyValue, size: string) = comb &>> ("font-size", size)
    /// Specifies the height of a text lines.
    ///
    /// This property is also used to compute the size of em, ex, and other relative <length> units.
    ///
    /// Note: Negative values are not allowed.
    [<CustomOperation("lineHeight")>]
    member inline _.lineHeight([<InlineIfLambda>] comb: CombineKeyValue, size: int) = comb &&& mkPxWithKV ("line-height", size)
    /// Specifies the height of a text lines.
    ///
    /// This property is also used to compute the size of em, ex, and other relative <length> units.
    ///
    /// Note: Negative values are not allowed.
    [<CustomOperation("lineHeight")>]
    member inline _.lineHeight([<InlineIfLambda>] comb: CombineKeyValue, size: string) = comb &>> ("line-height", size)

    /// Sets the background color of an element.
    [<CustomOperation("backgroundColor")>]
    member inline _.backgroundColor([<InlineIfLambda>] comb: CombineKeyValue, color: string) = comb &>> ("background-color", color)
    /// Sets the color of the insertion caret, the visible marker where the next character typed will be inserted.
    ///
    /// This is sometimes referred to as the text input cursor. The caret appears in elements such as <input> or
    /// those with the contenteditable attribute. The caret is typically a thin vertical line that flashes to
    /// help make it more noticeable. By default, it is black, but its color can be altered with this property.
    [<CustomOperation("caretColor")>]
    member inline _.caretColor([<InlineIfLambda>] comb: CombineKeyValue, color: string) = comb &>> ("caret-color", color)
    /// Sets the foreground color value of an element's text and text decorations, and sets the
    /// `currentcolor` value. `currentcolor` may be used as an indirect value on other properties
    /// and is the default for other color properties, such as border-color.
    [<CustomOperation("color")>]
    member inline _.color([<InlineIfLambda>] comb: CombineKeyValue, color: string) = comb &>> ("color", color)
    /// Specifies the vertical position of a positioned element. It has no effect on non-positioned elements.
    [<CustomOperation("top")>]
    member inline _.top([<InlineIfLambda>] comb: CombineKeyValue, value: int) = comb &&& mkPxWithKV ("top", value)
    /// Specifies the vertical position of a positioned element. It has no effect on non-positioned elements.
    [<CustomOperation("top")>]
    member inline _.top([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("top", value)
    /// Specifies the vertical position of a positioned element. It has no effect on non-positioned elements.
    [<CustomOperation("bottom")>]
    member inline _.bottom([<InlineIfLambda>] comb: CombineKeyValue, value: int) = comb &&& mkPxWithKV ("bottom", value)
    /// Specifies the vertical position of a positioned element. It has no effect on non-positioned elements.
    [<CustomOperation("bottom")>]
    member inline _.bottom([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("bottom", value)
    /// Specifies the horizontal position of a positioned element. It has no effect on non-positioned elements.
    [<CustomOperation("left")>]
    member inline _.left([<InlineIfLambda>] comb: CombineKeyValue, value: int) = comb &&& mkPxWithKV ("left", value)
    /// Specifies the horizontal position of a positioned element. It has no effect on non-positioned elements.
    [<CustomOperation("left")>]
    member inline _.left([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("left", value)
    /// Specifies the horizontal position of a positioned element. It has no effect on non-positioned elements.
    [<CustomOperation("right")>]
    member inline _.right([<InlineIfLambda>] comb: CombineKeyValue, value: int) = comb &&& mkPxWithKV ("right", value)
    /// Specifies the horizontal position of a positioned element. It has no effect on non-positioned elements.
    [<CustomOperation("right")>]
    member inline _.right([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("right", value)

    /// The outline-offset property adds space between an outline and the edge or border of an element.
    ///
    /// The space between an element and its outline is transparent.
    ///
    /// Outlines differ from borders in three ways:
    ///
    ///  - An outline is a line drawn around elements, outside the border edge
    ///  - An outline does not take up space
    ///  - An outline may be non-rectangular
    ///
    [<CustomOperation("outlineOffset")>]
    member inline _.outlineOffset([<InlineIfLambda>] comb: CombineKeyValue, offset: int) = comb &&& mkPxWithKV ("outline-width", offset)

    /// The outline-offset property adds space between an outline and the edge or border of an element.
    ///
    /// The space between an element and its outline is transparent.
    ///
    /// Outlines differ from borders in three ways:
    ///
    ///  - An outline is a line drawn around elements, outside the border edge
    ///  - An outline does not take up space
    ///  - An outline may be non-rectangular
    ///
    [<CustomOperation("outlineOffset")>]
    member inline _.outlineOffset([<InlineIfLambda>] comb: CombineKeyValue, offset: string) = comb &>> ("outline-width", offset)

    /// An outline is a line that is drawn around elements (outside the borders) to make the element "stand out".
    ///
    /// The `outline-color` property specifies the color of an outline.

    /// **Note**: Always declare the outline-style property before the outline-color property. An element must have an outline before you change the color of it.
    [<CustomOperation("outlineColor")>]
    member inline _.outlineColor([<InlineIfLambda>] comb: CombineKeyValue, color: string) = comb &>> ("outline-color", color)

    /// Sets the line style of an element's border.
    [<CustomOperation("border")>]
    member inline _.border([<InlineIfLambda>] comb: CombineKeyValue, style: string) = comb &>> ("border", style)

    [<CustomOperation("borderLeft")>]
    member inline _.borderLeft([<InlineIfLambda>] comb: CombineKeyValue, style: string) = comb &>> ("border-left", style)

    [<CustomOperation("borderTop")>]
    member inline _.borderTop([<InlineIfLambda>] comb: CombineKeyValue, style: string) = comb &>> ("border-top", style)

    [<CustomOperation("borderRight")>]
    member inline _.borderRight([<InlineIfLambda>] comb: CombineKeyValue, style: string) = comb &>> ("border-right", style)

    [<CustomOperation("borderBottom")>]
    member inline _.borderBottom([<InlineIfLambda>] comb: CombineKeyValue, style: string) = comb &>> ("border-bottom", style)

    /// Sets the line style of an element's bottom border.
    [<CustomOperation("borderBottomStyle")>]
    member inline _.borderBottomStyle([<InlineIfLambda>] comb: CombineKeyValue, style: string) = comb &>> ("border-bottom-style", style)
    /// Sets the width of the bottom border of an element.
    [<CustomOperation("borderBottomWidth")>]
    member inline _.borderBottomWidth([<InlineIfLambda>] comb: CombineKeyValue, width: int) =
        comb &&& mkPxWithKV ("border-bottom-width", width)
    /// Sets the width of the bottom border of an element.
    [<CustomOperation("borderBottomWidth")>]
    member inline _.borderBottomWidth([<InlineIfLambda>] comb: CombineKeyValue, width: string) = comb &>> ("border-bottom-width", width)
    /// Sets the color of an element's bottom border.
    ///
    /// It can also be set with the shorthand CSS properties border-color or border-bottom.
    [<CustomOperation("borderBottomColor")>]
    member inline _.borderBottomColor([<InlineIfLambda>] comb: CombineKeyValue, color: string) = comb &>> ("border-bottom-color", color)
    /// Sets the line style of an element's top border.
    [<CustomOperation("borderTopStyle")>]
    member inline _.borderTopStyle([<InlineIfLambda>] comb: CombineKeyValue, style: string) = comb &>> ("border-top-style", style)
    /// Sets the width of the top border of an element.
    [<CustomOperation("borderTopWidth")>]
    member inline _.borderTopWidth([<InlineIfLambda>] comb: CombineKeyValue, width: int) = comb &&& mkPxWithKV ("border-top-width", width)
    /// Sets the width of the top border of an element.
    [<CustomOperation("borderTopWidth")>]
    member inline _.borderTopWidth([<InlineIfLambda>] comb: CombineKeyValue, width: string) = comb &>> ("border-top-width", width)
    /// Sets the color of an element's top border.
    ///
    /// It can also be set with the shorthand CSS properties border-color or border-bottom.
    [<CustomOperation("borderTopColor")>]
    member inline _.borderTopColor([<InlineIfLambda>] comb: CombineKeyValue, color: string) = comb &>> ("border-top-color", color)
    /// Sets the line style of an element's right border.
    [<CustomOperation("borderRightStyle")>]
    member inline _.borderRightStyle([<InlineIfLambda>] comb: CombineKeyValue, style: string) = comb &>> ("border-right-style", style)
    /// Sets the width of the right border of an element.
    [<CustomOperation("borderRightWidth")>]
    member inline _.borderRightWidth([<InlineIfLambda>] comb: CombineKeyValue, width: int) = comb &&& mkPxWithKV ("border-right-width", width)
    /// Sets the width of the right border of an element.
    [<CustomOperation("borderRightWidth")>]
    member inline _.borderRightWidth([<InlineIfLambda>] comb: CombineKeyValue, width: string) = comb &>> ("border-right-width", width)
    /// Sets the color of an element's right border.
    ///
    /// It can also be set with the shorthand CSS properties border-color or border-bottom.
    [<CustomOperation("borderRightColor")>]
    member inline _.borderRightColor([<InlineIfLambda>] comb: CombineKeyValue, color: string) = comb &>> ("border-right-color", color)
    /// Sets the line style of an element's left border.
    [<CustomOperation("borderLeftStyle")>]
    member inline _.borderLeftStyle([<InlineIfLambda>] comb: CombineKeyValue, style: string) = comb &>> ("border-left-style", style)
    /// Sets the width of the left border of an element.
    [<CustomOperation("borderLeftWidth")>]
    member inline _.borderLeftWidth([<InlineIfLambda>] comb: CombineKeyValue, width: int) = comb &&& mkPxWithKV ("border-left-width", width)
    /// Sets the width of the left border of an element.
    [<CustomOperation("borderLeftWidth")>]
    member inline _.borderLeftWidth([<InlineIfLambda>] comb: CombineKeyValue, width: string) = comb &>> ("border-left-width", width)
    /// Sets the color of an element's left border.
    ///
    /// It can also be set with the shorthand CSS properties border-color or border-bottom.
    [<CustomOperation("borderLeftColor")>]
    member inline _.borderLeftColor([<InlineIfLambda>] comb: CombineKeyValue, color: string) = comb &>> ("border-left-color", color)
    /// Sets the color of an element's border.
    [<CustomOperation("borderColor")>]
    member inline _.borderColor([<InlineIfLambda>] comb: CombineKeyValue, color: string) = comb &>> ("border-color", color)
    /// Rounds the corners of an element's outer border edge. You can set a single radius to make
    /// circular corners, or two radii to make elliptical corners.
    [<CustomOperation("borderRadius")>]
    member inline _.borderRadius([<InlineIfLambda>] comb: CombineKeyValue, radius: int) = comb &&& mkPxWithKV ("border-radius", radius)
    /// Rounds the corners of an element's outer border edge. You can set a single radius to make
    /// circular corners, or two radii to make elliptical corners.
    [<CustomOperation("borderRadius")>]
    member inline _.borderRadius([<InlineIfLambda>] comb: CombineKeyValue, radius: string) = comb &>> ("border-radius", radius)
    /// Sets the width of an element's border.
    [<CustomOperation("borderWidth")>]
    member inline _.borderWidth([<InlineIfLambda>] comb: CombineKeyValue, width: int) = comb &&& mkPxWithKV ("border-width", width)
    /// Sets the width of an element's border.
    [<CustomOperation("borderWidth")>]
    member inline _.borderWidth([<InlineIfLambda>] comb: CombineKeyValue, top: string, ?right: string) =
        comb
        &&& CombineKeyValue(fun x ->
            x
                .Append("border-width: ")
                .Append(
                    top
                    + (
                        match right with
                        | Some x -> ", " + string x
                        | None -> ""
                    )
                )
        )
    /// Sets the width of an element's border.
    [<CustomOperation("borderWidth")>]
    member inline _.borderWidth([<InlineIfLambda>] comb: CombineKeyValue, top: string, right: string, bottom: string, ?left: string) =
        CombineKeyValue(fun x ->
            comb
                .Invoke(x)
                .Append("border-width: ")
                .Append(top)
                .Append(", ")
                .Append(right)
                .Append(", ")
                .Append(bottom)
                .Append(", ")
                .Append(
                    match left with
                    | Some x -> ", " + x
                    | None -> ""
                )
                .Append("; ")
        )

    /// Sets one or more animations to apply to an element. Each name is an @keyframes at-rule that
    /// sets the property values for the animation sequence.
    [<CustomOperation("animationName")>]
    member inline _.animationName([<InlineIfLambda>] comb: CombineKeyValue, keyframeName: string) = comb &>> ("animation-name", keyframeName)
    /// Sets the length of time that an animation takes to complete one cycle.
    [<CustomOperation("animationDuration")>]
    member inline _.animationDuration([<InlineIfLambda>] comb: CombineKeyValue, timespan: TimeSpan) =
        comb &>> ("animation-duration", string timespan.TotalMilliseconds + "ms")
    /// Sets the length of time that an animation takes to complete one cycle.
    [<CustomOperation("animationDuration")>]
    member inline _.animationDuration([<InlineIfLambda>] comb: CombineKeyValue, seconds: int) =
        comb &>> ("animation-duration", string seconds + "s")
    /// Sets when an animation starts.
    ///
    /// The animation can start later, immediately from its beginning, or immediately and partway through the animation.
    [<CustomOperation("animationDelay")>]
    member inline _.animationDelay([<InlineIfLambda>] comb: CombineKeyValue, timespan: TimeSpan) =
        comb &>> ("animation-delay", string timespan.TotalMilliseconds + "ms")
    /// Sets when an animation starts.
    ///
    /// The animation can start later, immediately from its beginning, or immediately and partway through the animation.
    [<CustomOperation("animationDelay")>]
    member inline _.animationDelay([<InlineIfLambda>] comb: CombineKeyValue, seconds: int) =
        comb &>> ("animation-delay", string seconds + "s")
    /// The number of times the animation runs.
    [<CustomOperation("animationDurationCount")>]
    member inline _.animationDurationCount([<InlineIfLambda>] comb: CombineKeyValue, count: int) =
        comb &&& mkWithKV ("animation-duration-count", count)
    /// Sets the font family for the font specified in a @font-face rule.
    [<CustomOperation("fontFamily")>]
    member inline _.fontFamily([<InlineIfLambda>] comb: CombineKeyValue, family: string) = comb &>> ("font-family", family)
    /// Sets the color of decorations added to text by text-decoration-line.
    [<CustomOperation("textDecorationColor")>]
    member inline _.textDecorationColor([<InlineIfLambda>] comb: CombineKeyValue, color: string) = comb &>> ("text-decoration-color", color)
    /// Sets the length of empty space (indentation) that is put before lines of text in a block.
    [<CustomOperation("textIndent")>]
    member inline _.textIndent([<InlineIfLambda>] comb: CombineKeyValue, value: int) = comb &&& mkWithKV ("text-indent", value)
    /// Sets the length of empty space (indentation) that is put before lines of text in a block.
    [<CustomOperation("textIndent")>]
    member inline _.textIndent([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("text-indent", value)
    /// Sets the opacity of an element.
    ///
    /// Opacity is the degree to which content behind an element is hidden, and is the opposite of transparency.
    [<CustomOperation("opacity")>]
    member inline _.opacity([<InlineIfLambda>] comb: CombineKeyValue, value: double) = comb &&& mkWithKV ("opacity", value)
    /// Sets the minimum width of an element.
    ///
    /// It prevents the used value of the width property from becoming smaller than the value specified for min-width.
    [<CustomOperation("minWidth")>]
    member inline _.minWidth([<InlineIfLambda>] comb: CombineKeyValue, value: int) = comb &&& mkPxWithKV ("min-width", value)
    /// Sets the minimum width of an element.
    ///
    /// It prevents the used value of the width property from becoming smaller than the value specified for min-width.
    [<CustomOperation("minWidth")>]
    member inline _.minWidth([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("min-width", value)
    /// Sets the maximum width of an element.
    ///
    /// It prevents the used value of the width property from becoming larger than the value specified by max-width.
    [<CustomOperation("maxWidth")>]
    member inline _.maxWidth([<InlineIfLambda>] comb: CombineKeyValue, value: int) = comb &&& mkPxWithKV ("max-width", value)
    /// Sets the maximum width of an element.
    ///
    /// It prevents the used value of the width property from becoming larger than the value specified by max-width.
    [<CustomOperation("maxWidth")>]
    member inline _.maxWidth([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("max-width", value)

    /// Sets the width of an element.
    ///
    /// By default, the property defines the width of the content area.
    [<CustomOperation("width")>]
    member inline _.width([<InlineIfLambda>] comb: CombineKeyValue, value: int) = comb &&& mkPxWithKV ("width", value)
    /// Sets the width of an element.
    ///
    /// By default, the property defines the width of the content area.
    [<CustomOperation("width")>]
    member inline _.width([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("width", value)

    /// Sets one or more background images on an element.
    [<CustomOperation("backgroundImage")>]
    member inline _.backgroundImage([<InlineIfLambda>] comb: CombineKeyValue, value: string) = comb &>> ("background-image", value)
    /// Short-hand for `style.backgroundImage(sprintf "url('%s')", value)` to set the backround image using a url.
    [<CustomOperation("backgroundImageUrl")>]
    member inline _.backgroundImageUrl([<InlineIfLambda>] comb: CombineKeyValue, value: string) =
        comb &>> ("background-image", "url('" + value + "'); ")

    /// Sets the color of an SVG shape.
    [<CustomOperation("fill")>]
    member inline _.fill([<InlineIfLambda>] comb: CombineKeyValue, color: string) = comb &>> ("fill", color)


/// Contains a list of HTML5 colors from https://htmlcolorcodes.com/color-names/
module color =
    /// Creates a color from components [hue](https://en.wikipedia.org/wiki/Hue), [saturation](https://en.wikipedia.org/wiki/Colorfulness) and [lightness](https://en.wikipedia.org/wiki/Lightness) where hue is a number that goes from 0 to 360 and both
    /// the `saturation` and `lightness` go from 0 to 100 as they are percentages.
    let inline hsl (hue: float, saturation: float, lightness: float) = $"hsl({hue},{saturation}%%,{lightness}%%)"

    let inline rgb (r: int, g: int, b: int) = $"rgb({r},{g},{b})"

    let inline rgba (r: int, g: int, b: int, a: float) = $"rgba({r},{g},{b},{a})"

    [<Literal>]
    let indianRed = "#CD5C5C"

    [<Literal>]
    let lightCoral = "#F08080"

    [<Literal>]
    let salmon = "#FA8072"

    [<Literal>]
    let darkSalmon = "#E9967A"

    [<Literal>]
    let lightSalmon = "#FFA07A"

    [<Literal>]
    let crimson = "#DC143C"

    [<Literal>]
    let red = "#FF0000"

    [<Literal>]
    let fireBrick = "#B22222"

    [<Literal>]
    let darkRed = "#8B0000"

    [<Literal>]
    let pink = "#FFC0CB"

    [<Literal>]
    let lightPink = "#FFB6C1"

    [<Literal>]
    let hotPink = "#FF69B4"

    [<Literal>]
    let deepPink = "#FF1493"

    [<Literal>]
    let mediumVioletRed = "#C71585"

    [<Literal>]
    let paleVioletRed = "#DB7093"

    [<Literal>]
    let coral = "#FF7F50"

    [<Literal>]
    let tomato = "#FF6347"

    [<Literal>]
    let orangeRed = "#FF4500"

    [<Literal>]
    let darkOrange = "#FF8C00"

    [<Literal>]
    let orange = "#FFA500"

    [<Literal>]
    let gold = "#FFD700"

    [<Literal>]
    let yellow = "#FFFF00"

    [<Literal>]
    let lightYellow = "#FFFFE0"

    [<Literal>]
    let limonChiffon = "#FFFACD"

    [<Literal>]
    let lightGoldenRodYellow = "#FAFAD2"

    [<Literal>]
    let papayaWhip = "#FFEFD5"

    [<Literal>]
    let moccasin = "#FFE4B5"

    [<Literal>]
    let peachPuff = "#FFDAB9"

    [<Literal>]
    let paleGoldenRod = "#EEE8AA"

    [<Literal>]
    let khaki = "#F0E68C"

    [<Literal>]
    let darkKhaki = "#BDB76B"

    [<Literal>]
    let lavender = "#E6E6FA"

    [<Literal>]
    let thistle = "#D8BFD8"

    [<Literal>]
    let plum = "#DDA0DD"

    [<Literal>]
    let violet = "#EE82EE"

    [<Literal>]
    let orchid = "#DA70D6"

    [<Literal>]
    let fuchsia = "#FF00FF"

    [<Literal>]
    let magenta = "#FF00FF"

    [<Literal>]
    let mediumOrchid = "#BA55D3"

    [<Literal>]
    let mediumPurple = "#9370DB"

    [<Literal>]
    let rebeccaPurple = "#663399"

    [<Literal>]
    let blueViolet = "#8A2BE2"

    [<Literal>]
    let darkViolet = "#9400D3"

    [<Literal>]
    let darkOrchid = "#9932CC"

    [<Literal>]
    let darkMagenta = "#8B008B"

    [<Literal>]
    let purple = "#800080"

    [<Literal>]
    let indigo = "#4B0082"

    [<Literal>]
    let slateBlue = "#6A5ACD"

    [<Literal>]
    let darkSlateBlue = "#483D8B"

    [<Literal>]
    let mediumSlateBlue = "#7B68EE"

    [<Literal>]
    let greenYellow = "#ADFF2F"

    [<Literal>]
    let chartreuse = "#7FFF00"

    [<Literal>]
    let lawnGreen = "#7CFC00"

    [<Literal>]
    let lime = "#00FF00"

    [<Literal>]
    let limeGreen = "#32CD32"

    [<Literal>]
    let paleGreen = "#98FB98"

    [<Literal>]
    let lightGreen = "#90EE90"

    [<Literal>]
    let mediumSpringGreen = "#00FA9A"

    [<Literal>]
    let springGreen = "#00FF7F"

    [<Literal>]
    let mediumSeaGreen = "#3CB371"

    [<Literal>]
    let seaGreen = "#2E8B57"

    [<Literal>]
    let forestGreen = "#228B22"

    [<Literal>]
    let green = "#008000"

    [<Literal>]
    let darkGreen = "#006400"

    [<Literal>]
    let yellowGreen = "#9ACD32"

    [<Literal>]
    let oliveDrab = "#6B8E23"

    [<Literal>]
    let olive = "#808000"

    [<Literal>]
    let darkOliveGreen = "#556B2F"

    [<Literal>]
    let mediumAquamarine = "#66CDAA"

    [<Literal>]
    let darkSeaGreen = "#8FBC8B"

    [<Literal>]
    let lightSeaGreen = "#20B2AA"

    [<Literal>]
    let darkCyan = "#008B8B"

    [<Literal>]
    let teal = "#008080"

    [<Literal>]
    let aqua = "#00FFFF"

    [<Literal>]
    let cyan = "#00FFFF"

    [<Literal>]
    let lightCyan = "#E0FFFF"

    [<Literal>]
    let paleTurqouise = "#AFEEEE"

    [<Literal>]
    let aquaMarine = "#7FFFD4"

    [<Literal>]
    let turqouise = "#AFEEEE"

    [<Literal>]
    let mediumTurqouise = "#48D1CC"

    [<Literal>]
    let darkTurqouise = "#00CED1"

    [<Literal>]
    let cadetBlue = "#5F9EA0"

    [<Literal>]
    let steelBlue = "#4682B4"

    [<Literal>]
    let lightSteelBlue = "#B0C4DE"

    [<Literal>]
    let powederBlue = "#B0E0E6"

    [<Literal>]
    let lightBlue = "#ADD8E6"

    [<Literal>]
    let skyBlue = "#87CEEB"

    [<Literal>]
    let lightSkyBlue = "#87CEFA"

    [<Literal>]
    let deepSkyBlue = "#00BFFF"

    [<Literal>]
    let dodgerBlue = "#1E90FF"

    [<Literal>]
    let cornFlowerBlue = "#6495ED"

    [<Literal>]
    let royalBlue = "#4169E1"

    [<Literal>]
    let blue = "#0000FF"

    [<Literal>]
    let mediumBlue = "#0000CD"

    [<Literal>]
    let darkBlue = "#00008B"

    [<Literal>]
    let navy = "#000080"

    [<Literal>]
    let midnightBlue = "#191970"

    [<Literal>]
    let cornSilk = "#FFF8DC"

    [<Literal>]
    let blanchedAlmond = "#FFEBCD"

    [<Literal>]
    let bisque = "#FFE4C4"

    [<Literal>]
    let navajoWhite = "#FFDEAD"

    [<Literal>]
    let wheat = "#F5DEB3"

    [<Literal>]
    let burlyWood = "#DEB887"

    [<Literal>]
    let tan = "#D2B48C"

    [<Literal>]
    let rosyBrown = "#BC8F8F"

    [<Literal>]
    let sandyBrown = "#F4A460"

    [<Literal>]
    let goldenRod = "#DAA520"

    [<Literal>]
    let darkGoldenRod = "#B8860B"

    [<Literal>]
    let peru = "#CD853F"

    [<Literal>]
    let chocolate = "#D2691E"

    [<Literal>]
    let saddleBrown = "#8B4513"

    [<Literal>]
    let sienna = "#A0522D"

    [<Literal>]
    let brown = "#A52A2A"

    [<Literal>]
    let maroon = "#A52A2A"

    [<Literal>]
    let white = "#FFFFFF"

    [<Literal>]
    let snow = "#FFFAFA"

    [<Literal>]
    let honeyDew = "#F0FFF0"

    [<Literal>]
    let mintCream = "#F5FFFA"

    [<Literal>]
    let azure = "#F0FFFF"

    [<Literal>]
    let aliceBlue = "#F0F8FF"

    [<Literal>]
    let ghostWhite = "#F8F8FF"

    [<Literal>]
    let whiteSmoke = "#F5F5F5"

    [<Literal>]
    let seaShell = "#FFF5EE"

    [<Literal>]
    let beige = "#F5F5DC"

    [<Literal>]
    let oldLace = "#FDF5E6"

    [<Literal>]
    let floralWhite = "#FFFAF0"

    [<Literal>]
    let ivory = "#FFFFF0"

    [<Literal>]
    let antiqueWhite = "#FAEBD7"

    [<Literal>]
    let linen = "#FAF0E6"

    [<Literal>]
    let lavenderBlush = "#FFF0F5"

    [<Literal>]
    let mistyRose = "#FFE4E1"

    [<Literal>]
    let gainsBoro = "#DCDCDC"

    [<Literal>]
    let lightGray = "#D3D3D3"

    [<Literal>]
    let silver = "#C0C0C0"

    [<Literal>]
    let darkGray = "#A9A9A9"

    [<Literal>]
    let gray = "#808080"

    [<Literal>]
    let dimGray = "#696969"

    [<Literal>]
    let lightSlateGray = "#778899"

    [<Literal>]
    let slateGray = "#708090"

    [<Literal>]
    let darkSlateGray = "#2F4F4F"

    [<Literal>]
    let black = "#000000"

    [<Literal>]
    let transparent = "transparent"

/// Contains a list of CSS Fonts from https://www.tutorialbrain.com/css_tutorial/css_font_family_list/
module font =
    [<Literal>]
    let abadiMTCondensedLight = "Abadi MT Condensed Light"

    [<Literal>]
    let aharoni = "Aharoni"

    [<Literal>]
    let aharoniBold = "Aharoni Bold"

    [<Literal>]
    let aldhabi = "Aldhabi"

    [<Literal>]
    let alternateGothic2BT = "AlternateGothic2 BT"

    [<Literal>]
    let andaleMono = "Andale Mono"

    [<Literal>]
    let andalus = "Andalus"

    [<Literal>]
    let angsanaNew = "Angsana New"

    [<Literal>]
    let angsanaUPC = "AngsanaUPC"

    [<Literal>]
    let aparajita = "Aparajita"

    [<Literal>]
    let appleChancery = "Apple Chancery"

    [<Literal>]
    let arabicTypesetting = "Arabic Typesetting"

    [<Literal>]
    let arial = "Arial"

    [<Literal>]
    let arialBlack = "Arial Black"

    [<Literal>]
    let arialNarrow = "Arial narrow"

    [<Literal>]
    let arialNova = "Arial Nova"

    [<Literal>]
    let arialRoundedMTBold = "Arial Rounded MT Bold"

    [<Literal>]
    let arnoldboecklin = "Arnoldboecklin"

    [<Literal>]
    let avantaGarde = "Avanta Garde"

    [<Literal>]
    let bahnschrift = "Bahnschrift"

    [<Literal>]
    let bahnschriftLight = "Bahnschrift Light"

    [<Literal>]
    let bahnschriftSemiBold = "Bahnschrift SemiBold"

    [<Literal>]
    let bahnschriftSemiLight = "Bahnschrift SemiLight"

    [<Literal>]
    let baskerville = "Baskerville"

    [<Literal>]
    let batang = "Batang"

    [<Literal>]
    let batangChe = "BatangChe"

    [<Literal>]
    let bigCaslon = "Big Caslon"

    [<Literal>]
    let bizUDGothic = "BIZ UDGothic"

    [<Literal>]
    let bizUDMinchoMedium = "BIZ UDMincho Medium"

    [<Literal>]
    let blippo = "Blippo"

    [<Literal>]
    let bodoniMT = "Bodoni MT"

    [<Literal>]
    let bookAntiqua = "Book Antiqua"

    [<Literal>]
    let Bookman = "Bookman"

    [<Literal>]
    let bradlyHand = "Bradley Hand"

    [<Literal>]
    let browalliaNew = "Browallia New"

    [<Literal>]
    let browalliaUPC = "BrowalliaUPC"

    [<Literal>]
    let brushScriptMT = "Brush Script MT"

    [<Literal>]
    let brushScriptStd = "Brush Script Std"

    [<Literal>]
    let brushStroke = "Brushstroke"

    [<Literal>]
    let calibri = "Calibri"

    [<Literal>]
    let calibriLight = "Calibri Light"

    [<Literal>]
    let calistoMT = "Calisto MT"

    [<Literal>]
    let cambodian = "Cambodian"

    [<Literal>]
    let cambria = "Cambria"

    [<Literal>]
    let cambriaMath = "Cambria Math"

    [<Literal>]
    let candara = "Candara"

    [<Literal>]
    let centuryGothic = "Century Gothic"

    [<Literal>]
    let chalkDuster = "Chalkduster"

    [<Literal>]
    let cherokee = "Cherokee"

    [<Literal>]
    let comicSans = "Comic Sans"

    [<Literal>]
    let comicSansMS = "Comic Sans MS"

    [<Literal>]
    let consolas = "Consolas"

    [<Literal>]
    let constantia = "Constantia"

    [<Literal>]
    let copperPlate = "Copperplate"

    [<Literal>]
    let copperPlateGothicLight = "Copperplate Gothic Light"

    [<Literal>]
    let copperPlateGothicBold = "Copperplate Gothic Bold"

    [<Literal>]
    let corbel = "Corbel"

    [<Literal>]
    let cordiaNew = "Cordia New"

    [<Literal>]
    let cordiaUPC = "CordiaUPC"

    [<Literal>]
    let coronetScript = "Coronet script"

    [<Literal>]
    let courier = "Courier"

    [<Literal>]
    let courierNew = "Courier New"

    [<Literal>]
    let daunPenh = "DaunPenh"

    [<Literal>]
    let david = "David"

    [<Literal>]
    let dengXian = "DengXian"

    [<Literal>]
    let dfKaiSB = "DFKai-SB"

    [<Literal>]
    let didot = "Didot"

    [<Literal>]
    let dilleniaUPC = "DilleniaUPC"

    [<Literal>]
    let dokChampa = "DokChampa"

    [<Literal>]
    let dotum = "Dotum"

    [<Literal>]
    let dotumChe = "DotumChe"

    [<Literal>]
    let ebrima = "Ebrima"

    [<Literal>]
    let estrangeloEdessa = "Estrangelo Edessa"

    [<Literal>]
    let eucrosiaUPC = "EucrosiaUPC"

    [<Literal>]
    let euphemia = "Euphemia"

    [<Literal>]
    let fangSong = "FangSong"

    [<Literal>]
    let florence = "Florence"

    [<Literal>]
    let franklinGothicMedium = "Franklin Gothic Medium"

    [<Literal>]
    let frankRuehl = "FrankRuehl"

    [<Literal>]
    let fressiaUPC = "FressiaUPC"

    [<Literal>]
    let futara = "Futara"

    [<Literal>]
    let gabriola = "Gabriola"

    [<Literal>]
    let garamond = "Garamond"

    [<Literal>]
    let gautami = "Gautami"

    [<Literal>]
    let geneva = "Geneva"

    [<Literal>]
    let georgia = "Georgia"

    [<Literal>]
    let georgiaPro = "Georgia Pro"

    [<Literal>]
    let gillSans = "Gill Sans"

    [<Literal>]
    let gillSansNova = "Gill Sans Nova"

    [<Literal>]
    let gisha = "Gisha"

    [<Literal>]
    let goudyOldStyle = "Goudy Old Style"

    [<Literal>]
    let gulim = "Gulim"

    [<Literal>]
    let gulimChe = "GulimChe"

    [<Literal>]
    let gungsuh = "Gungsuh"

    [<Literal>]
    let gungsuhChe = "GungsuhChe"

    [<Literal>]
    let hebrew = "Hebrew"

    [<Literal>]
    let helvetica = "Helvetica"

    [<Literal>]
    let hoeflerText = "Hoefler Text"

    [<Literal>]
    let holoLensMDL2Assets = "HoloLens MDL2 Assets"

    [<Literal>]
    let impact = "Impact"

    [<Literal>]
    let inkFree = "Ink Free"

    [<Literal>]
    let irisUPC = "IrisUPC"

    [<Literal>]
    let iskoolaPota = "Iskoola Pota"

    [<Literal>]
    let japanese = "Japanese"

    [<Literal>]
    let jasmineUPC = "JasmineUPC"

    [<Literal>]
    let javaneseText = "Javanese Text"

    [<Literal>]
    let jazzLET = "Jazz LET"

    [<Literal>]
    let kaiTi = "KaiTi"

    [<Literal>]
    let kalinga = "Kalinga"

    [<Literal>]
    let kartika = "Kartika"

    [<Literal>]
    let khmerUI = "Khmer UI"

    [<Literal>]
    let kodchiangUPC = "KodchiangUPC"

    [<Literal>]
    let kokila = "Kokila"

    [<Literal>]
    let korean = "Korean"

    [<Literal>]
    let lao = "Lao"

    [<Literal>]
    let laoUI = "Lao UI"

    [<Literal>]
    let latha = "Latha"

    [<Literal>]
    let leelawadee = "Leelawadee"

    [<Literal>]
    let leelawadeeUI = "Leelawadee UI"

    [<Literal>]
    let leelawadeeUISemilight = "Leelawadee UI Semilight"

    [<Literal>]
    let levenimMT = "Levenim MT"

    [<Literal>]
    let lilyUPC = "LilyUPC"

    [<Literal>]
    let lucidaBright = "Lucida Bright"

    [<Literal>]
    let lucidaConsole = "Lucida Console"

    [<Literal>]
    let lucidaHandwriting = "Lucida Handwriting"

    [<Literal>]
    let lucidaSans = "Lucida Sans"

    [<Literal>]
    let lucidaSansTypewriter = "Lucida Sans Typewriter"

    [<Literal>]
    let lucidaSansUnicode = "Lucida Sans Unicode"

    [<Literal>]
    let lucidaTypewriter = "Lucidatypewriter"

    [<Literal>]
    let luminari = "Luminari"

    [<Literal>]
    let malgunGothic = "Malgun Gothic"

    [<Literal>]
    let malgunGothicSemilight = "Malgun Gothic Semilight"

    [<Literal>]
    let mangal = "Mangal"

    [<Literal>]
    let markerFelt = "Marker Felt"

    [<Literal>]
    let marlett = "Marlett"

    [<Literal>]
    let meiryo = "Meiryo"

    [<Literal>]
    let meiryoUI = "Meiryo UI"

    [<Literal>]
    let microsoftHimalaya = "Microsoft Himalaya"

    [<Literal>]
    let microsoftJhengHei = "Microsoft JhengHei"

    [<Literal>]
    let microsoftJhengHeiUI = "Microsoft JhengHei UI"

    [<Literal>]
    let microsoftNewTaiLue = "Microsoft New Tai Lue"

    [<Literal>]
    let microsoftPhagsPa = "Microsoft PhagsPa"

    [<Literal>]
    let microsoftSansSerif = "Microsoft Sans Serif"

    [<Literal>]
    let microsoftTaiLe = "Microsoft Tai Le"

    [<Literal>]
    let microsoftUighur = "Microsoft Uighur"

    [<Literal>]
    let microsoftYaHei = "Microsoft YaHei"

    [<Literal>]
    let microsoftYaHeiUI = "Microsoft YaHei UI"

    [<Literal>]
    let microsoftYiBaiti = "Microsoft Yi Baiti"

    [<Literal>]
    let mingLiU = "MingLiU"

    [<Literal>]
    let mingLiUHKSCS = "MingLiU_HKSCS"

    [<Literal>]
    let mingLiUHKSCSExtB = "MingLiU_HKSCS-ExtB"

    [<Literal>]
    let mingLiUExtB = "MingLiU-ExtB"

    [<Literal>]
    let miriam = "Miriam"

    [<Literal>]
    let monaco = "Monaco"

    [<Literal>]
    let mongolianBaiti = "Mongolian Baiti"

    [<Literal>]
    let moolBoran = "MoolBoran"

    [<Literal>]
    let msGothic = "MS Gothic"

    [<Literal>]
    let msMincho = "MS Mincho"

    [<Literal>]
    let msPGothic = "MS PGothic"

    [<Literal>]
    let msPMincho = "MS PMincho"

    [<Literal>]
    let msUIGothic = "MS UI Gothic"

    [<Literal>]
    let mvBoli = "MV Boli"

    [<Literal>]
    let myanmarText = "Myanmar Text"

    [<Literal>]
    let narkisim = "Narkisim"

    [<Literal>]
    let neueHaasGroteskTextPro = "Neue Haas Grotesk Text Pro"

    [<Literal>]
    let newCenturySchoolbook = "New Century Schoolbook"

    [<Literal>]
    let newsGothicMT = "News Gothic MT"

    [<Literal>]
    let nirmalaUI = "Nirmala UI"

    [<Literal>]
    let noAutoLanguageAssoc = "No automatic language associations"

    [<Literal>]
    let noto = "Noto"

    [<Literal>]
    let nSimSun = "NSimSun"

    [<Literal>]
    let nyala = "Nyala"

    [<Literal>]
    let oldTown = "Oldtown"

    [<Literal>]
    let optima = "Optima"

    [<Literal>]
    let palatino = "Palatino"

    [<Literal>]
    let palatinoLinotype = "Palatino Linotype"

    [<Literal>]
    let papyrus = "papyrus"

    [<Literal>]
    let parkAvenue = "Parkavenue"

    [<Literal>]
    let perpetua = "Perpetua"

    [<Literal>]
    let plantagenetCherokee = "Plantagenet Cherokee"

    [<Literal>]
    let PMingLiU = "PMingLiU"

    [<Literal>]
    let raavi = "Raavi"

    [<Literal>]
    let rockwell = "Rockwell"

    [<Literal>]
    let rockwellExtraBold = "Rockwell Extra Bold"

    [<Literal>]
    let rockwellNova = "Rockwell Nova"

    [<Literal>]
    let rockwellNovaCond = "Rockwell Nova Cond"

    [<Literal>]
    let rockwellNovaExtraBold = "Rockwell Nova Extra Bold"

    [<Literal>]
    let rod = "Rod"

    [<Literal>]
    let sakkalMajalla = "Sakkal Majalla"

    [<Literal>]
    let sanskritText = "Sanskrit Text"

    [<Literal>]
    let segoeMDL2Assets = "segoeMDL2Assets"

    [<Literal>]
    let segoePrint = "Segoe Print"

    [<Literal>]
    let segoeScript = "Segoe Script"

    [<Literal>]
    let segoeUI = "Segoe UI"

    [<Literal>]
    let segoeUIEmoji = "Segoe UI Emoji"

    [<Literal>]
    let segoeUIHistoric = "Segoe UI Historic"

    [<Literal>]
    let segoeUISymbol = "Segoe UI Symbol"

    [<Literal>]
    let shonarBangla = "Shonar Bangla"

    [<Literal>]
    let shruti = "Shruti"

    [<Literal>]
    let simHei = "SimHei"

    [<Literal>]
    let simKai = "SimKai"

    [<Literal>]
    let simplifiedArabic = "Simplified Arabic"

    [<Literal>]
    let simplifiedChinese = "Simplified Chinese"

    [<Literal>]
    let simSun = "SimSun"

    [<Literal>]
    let simSunExtB = "SimSun-ExtB"

    [<Literal>]
    let sitka = "Sitka"

    [<Literal>]
    let snellRoundhan = "Snell Roundhan"

    [<Literal>]
    let stencilStd = "Stencil Std"

    [<Literal>]
    let sylfaen = "Sylfaen"

    [<Literal>]
    let symbol = "Symbol"

    [<Literal>]
    let tahoma = "Tahoma"

    [<Literal>]
    let thai = "Thai"

    [<Literal>]
    let timesNewRoman = "Times New Roman"

    [<Literal>]
    let traditionalArabic = "Traditional Arabic"

    [<Literal>]
    let traditionalChinese = "Traditional Chinese"

    [<Literal>]
    let trattatello = "Trattatello"

    [<Literal>]
    let trebuchetMS = "Trebuchet MS"

    [<Literal>]
    let udDigiKyokasho = "UD Digi Kyokasho"

    [<Literal>]
    let udDigiKyokashoNKR = "UD Digi Kyokasho NK-R"

    [<Literal>]
    let udDigiKyokashoNPR = "UD Digi Kyokasho NP-R"

    [<Literal>]
    let udDigiKyokashoNR = "UD Digi Kyokasho N-R"

    [<Literal>]
    let urduTypesetting = "Urdu Typesetting"

    [<Literal>]
    let urwChancery = "URW Chancery"

    [<Literal>]
    let utsaah = "Utsaah"

    [<Literal>]
    let vani = "Vani"

    [<Literal>]
    let verdana = "Verdana"

    [<Literal>]
    let verdanaPro = "Verdana Pro"

    [<Literal>]
    let vijaya = "Vijaya"

    [<Literal>]
    let vrinda = "Vrinda"

    [<Literal>]
    let Webdings = "Webdings"

    [<Literal>]
    let westminster = "Westminster"

    [<Literal>]
    let wingdings = "Wingdings"

    [<Literal>]
    let yuGothic = "Yu Gothic"

    [<Literal>]
    let yuGothicUI = "Yu Gothic UI"

    [<Literal>]
    let yuMincho = "Yu Mincho"

    [<Literal>]
    let zapfChancery = "Zapf Chancery"
