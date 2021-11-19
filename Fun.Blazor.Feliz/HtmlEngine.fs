[<AutoOpen>]
module Fun.Blazor.HtmlEngine

open Bolero


module private Utils =
    let mk tag nodes =
        let attrs, childs = getAttrsAndChildren nodes
        Elt(tag, attrs, childs)

    let ofStr x = Text x
    
    let ofNodes x = Attr (_childContentKey, x)
    
    let empty () = Html.empty

open Utils


type html with

    /// Create a custom element
    ///
    /// You generally shouldn't need to use this, if you notice an element missing please submit an issue.
    static member custom (key: string, children: seq<Attr>) = mk key children
    /// The empty element, renders nothing on screen
    static member none : Node = empty()

    static member a (children: seq<Attr>) = mk "a" children
    static member a (children) = mk "a" [ ofNodes children  ]

    static member abbr (value: float) = mk "abbr" [ ofNodes [ Util.asString value |> ofStr ] ]
    static member abbr (value: int) = mk "abbr" [ofNodes [ Util.asString value |> ofStr ]]
    static member abbr (value: Node) = mk "abbr" [ofNodes [ value ]]
    static member abbr (value: string) = mk "abbr" [ofNodes [ ofStr value ]]
    static member abbr (children: seq<Attr>) = mk "abbr" children
    static member abbr (children) = mk "abbr" [ ofNodes children  ]

    static member address (value: float) = mk "address" [ofNodes [ Util.asString value |> ofStr ]]
    static member address (value: int) = mk "address" [ofNodes [ Util.asString value |> ofStr ]]
    static member address (value: Node) = mk "address" [ofNodes [ value ]]
    static member address (value: string) = mk "address" [ofNodes [ ofStr value ]]
    static member address (children: seq<Attr>) = mk "address" children
    static member address (children) = mk "address" [ ofNodes children  ]

    static member anchor (children: seq<Attr>) = mk "a" children
    static member anchor (children) = mk "anchor" [ ofNodes children  ]

    static member area (children: seq<Attr>) = mk "area" children
    static member area (children) = mk "area" [ ofNodes children  ]

    static member article (children: seq<Attr>) = mk "article" children
    static member article (children) = mk "article" [ ofNodes children  ]

    static member aside (children: seq<Attr>) = mk "aside" children
    static member aside (children) = mk "aside" [ ofNodes children  ]

    static member audio (children: seq<Attr>) = mk "audio" children
    static member audio (children) = mk "audio" [ ofNodes children  ]

    static member b (value: float) = mk "b" [ofNodes [ Util.asString value |> ofStr ]]
    static member b (value: int) = mk "b" [ofNodes [ Util.asString value |> ofStr ]]
    static member b (value: Node) = mk "b" [ofNodes [ value ]]
    static member b (value: string) = mk "b" [ofNodes [ ofStr value ]]
    static member b (children: seq<Attr>) = mk "b" children
    static member b (children) = mk "b" [ ofNodes children  ]

    static member base' (children: seq<Attr>) = mk "base" children
    static member base' (children) = mk "base'" [ ofNodes children  ]

    static member bdi (value: float) = mk "bdi" [ofNodes [ Util.asString value |> ofStr ]]
    static member bdi (value: int) = mk "bdi" [ofNodes [ Util.asString value |> ofStr ]]
    static member bdi (value: Node) = mk "bdi" [ofNodes [ value ]]
    static member bdi (value: string) = mk "bdi" [ofNodes [ ofStr value ]]
    static member bdi (children: seq<Attr>) = mk "bdi" children
    static member bdi (children) = mk "bdi" [ ofNodes children  ]

    static member bdo (value: float) = mk "bdo" [ofNodes [ Util.asString value |> ofStr ]]
    static member bdo (value: int) = mk "bdo" [ofNodes [ Util.asString value |> ofStr ]]
    static member bdo (value: Node) = mk "bdo" [ofNodes [ value ]]
    static member bdo (value: string) = mk "bdo" [ofNodes [ ofStr value ]]
    static member bdo (children: seq<Attr>) = mk "bdo" children
    static member bdo (children) = mk "bdo" [ ofNodes children  ]

    static member blockquote (value: float) = mk "blockquote" [ofNodes [ Util.asString value |> ofStr ]]
    static member blockquote (value: int) = mk "blockquote" [ofNodes [ Util.asString value |> ofStr ]]
    static member blockquote (value: Node) = mk "blockquote" [ofNodes [ value ]]
    static member blockquote (value: string) = mk "blockquote" [ofNodes [ ofStr value ]]
    static member blockquote (children: seq<Attr>) = mk "blockquote" children
    static member blockquote (children) = mk "blockquote" [ ofNodes children  ]

    static member body (value: float) = mk "body" [ofNodes [ Util.asString value |> ofStr ]]
    static member body (value: int) = mk "body" [ofNodes [ Util.asString value |> ofStr ]]
    static member body (value: Node) = mk "body" [ofNodes [ value ]]
    static member body (value: string) = mk "body" [ofNodes [ ofStr value ]]
    static member body (children: seq<Attr>) = mk "body" children
    static member body (children) = mk "body" [ ofNodes children  ]

    static member br (children: seq<Attr>) = mk "br" children
    static member br (children) = mk "br" [ ofNodes children  ]

    static member button (children: seq<Attr>) = mk "button" children
    static member button (children) = mk "button" [ ofNodes children  ]

    static member canvas (children: seq<Attr>) = mk "canvas" children
    static member canvas (children) = mk "canvas" [ ofNodes children  ]

    static member caption (value: float) = mk "caption" [ofNodes [ Util.asString value |> ofStr ]]
    static member caption (value: int) = mk "caption" [ofNodes [ Util.asString value |> ofStr ]]
    static member caption (value: Node) = mk "caption" [ofNodes [ value ]]
    static member caption (value: string) = mk "caption" [ofNodes [ ofStr value ]]
    static member caption (children: seq<Attr>) = mk "caption" children
    static member caption (children) = mk "caption" [ ofNodes children  ]

    static member cite (value: float) = mk "cite" [ofNodes [ Util.asString value |> ofStr ]]
    static member cite (value: int) = mk "cite" [ofNodes [ Util.asString value |> ofStr ]]
    static member cite (value: Node) = mk "cite" [ofNodes [ value ]]
    static member cite (value: string) = mk "cite" [ofNodes [ ofStr value ]]
    static member cite (children: seq<Attr>) = mk "cite" children
    static member cite (children) = mk "cite" [ ofNodes children  ]

    // static member code (value: bool) = mk "code" value
    static member code (value: float) = mk "code" [ofNodes [ Util.asString value |> ofStr ]]
    static member code (value: int) = mk "code" [ofNodes [ Util.asString value |> ofStr ]]
    static member code (value: Node) = mk "code" [ofNodes [ value ]]
    static member code (value: string) = mk "code" [ofNodes [ ofStr value ]]
    static member code (children: seq<Attr>) = mk "code" children
    static member code (children) = mk "code" [ ofNodes children  ]

    static member col (children: seq<Attr>) = mk "col" children
    static member col (children) = mk "col" [ ofNodes children  ]

    static member colgroup (children: seq<Attr>) = mk "colgroup" children
    static member colgroup (children) = mk "colgroup" [ ofNodes children  ]

    static member data (value: float) = mk "data" [ofNodes [ Util.asString value |> ofStr ]]
    static member data (value: int) = mk "data" [ofNodes [ Util.asString value |> ofStr ]]
    static member data (value: Node) = mk "data" [ofNodes [ value ]]
    static member data (value: string) = mk "data" [ofNodes [ ofStr value ]]
    static member data (children: seq<Attr>) = mk "data" children
    static member data (children) = mk "data" [ ofNodes children  ]

    static member datalist (value: float) = mk "datalist" [ofNodes [ Util.asString value |> ofStr ]]
    static member datalist (value: int) = mk "datalist" [ofNodes [ Util.asString value |> ofStr ]]
    static member datalist (value: Node) = mk "datalist" [ofNodes [ value ]]
    static member datalist (value: string) = mk "datalist" [ofNodes [ ofStr value ]]
    static member datalist (children: seq<Attr>) = mk "datalist" children
    static member datalist (children) = mk "datalist" [ ofNodes children  ]

    static member dd (value: float) = mk "dd" [ofNodes [ Util.asString value |> ofStr ]]
    static member dd (value: int) = mk "dd" [ofNodes [ Util.asString value |> ofStr ]]
    static member dd (value: Node) = mk "dd" [ofNodes [ value ]]
    static member dd (value: string) = mk "dd" [ofNodes [ ofStr value ]]
    static member dd (children: seq<Attr>) = mk "dd" children
    static member dd (children) = mk "dd" [ ofNodes children  ]

    static member del (value: float) = mk "del" [ofNodes [ Util.asString value |> ofStr ]]
    static member del (value: int) = mk "del" [ofNodes [ Util.asString value |> ofStr ]]
    static member del (value: Node) = mk "del" [ofNodes [ value ]]
    static member del (value: string) = mk "del" [ofNodes [ ofStr value ]]
    static member del (children: seq<Attr>) = mk "del" children
    static member del (children) = mk "del" [ ofNodes children  ]

    static member details (children: seq<Attr>) = mk "details" children
    static member details (children) = mk "details" [ ofNodes children  ]

    static member dfn (value: float) = mk "dfn" [ofNodes [ Util.asString value |> ofStr ]]
    static member dfn (value: int) = mk "dfn" [ofNodes [ Util.asString value |> ofStr ]]
    static member dfn (value: Node) = mk "dfn" [ofNodes [ value ]]
    static member dfn (value: string) = mk "dfn" [ofNodes [ ofStr value ]]
    static member dfn (children: seq<Attr>) = mk "dfn" children
    static member dfn (children) = mk "dfn" [ ofNodes children  ]

    static member dialog (value: float) = mk "dialog" [ofNodes [ Util.asString value |> ofStr ]]
    static member dialog (value: int) = mk "dialog" [ofNodes [ Util.asString value |> ofStr ]]
    static member dialog (value: Node) = mk "dialog" [ofNodes [ value ]]
    static member dialog (value: string) = mk "dialog" [ofNodes [ ofStr value ]]
    static member dialog (children: seq<Attr>) = mk "dialog" children
    static member dialog (children) = mk "dialog" [ ofNodes children  ]

    static member div (value: float) = mk "div" [ofNodes [ Util.asString value |> ofStr ]]
    static member div (value: int) = mk "div" [ofNodes [ Util.asString value |> ofStr ]]
    static member div (value: Node) = mk "div" [ofNodes [ value ]]
    static member div (value: string) = mk "div" [ofNodes [ ofStr value ]]
    /// The `<div>` tag defines a division or a section in an HTML document
    static member div (children: seq<Attr>) = mk "div" children
    static member div (children) = mk "div" [ ofNodes children  ]

    static member dl (children: seq<Attr>) = mk "dl" children
    static member dl (children) = mk "dl" [ ofNodes children  ]

    static member dt (value: float) = mk "dt" [ofNodes [ Util.asString value |> ofStr ]]
    static member dt (value: int) = mk "dt" [ofNodes [ Util.asString value |> ofStr ]]
    static member dt (value: Node) = mk "dt" [ofNodes [ value ]]
    static member dt (value: string) = mk "dt" [ofNodes [ ofStr value ]]
    static member dt (children: seq<Attr>) = mk "dt" children
    static member dt (children) = mk "dt" [ ofNodes children  ]

    static member em (value: float) = mk "em" [ofNodes [ Util.asString value |> ofStr ]]
    static member em (value: int) = mk "em" [ofNodes [ Util.asString value |> ofStr ]]
    static member em (value: Node) = mk "em" [ofNodes [ value ]]
    static member em (value: string) = mk "em" [ofNodes [ ofStr value ]]
    static member em (children: seq<Attr>) = mk "em" children
    static member em (children) = mk "em" [ ofNodes children  ]

    static member fieldSet (children: seq<Attr>) = mk "fieldset" children
    static member fieldSet (children) = mk "fieldSet" [ ofNodes children  ]

    static member figcaption (children: seq<Attr>) = mk "figcaption" children
    static member figcaption (children) = mk "figcaption" [ ofNodes children  ]

    static member figure (children: seq<Attr>) = mk "figure" children
    static member figure (children) = mk "figure" [ ofNodes children  ]

    static member footer (children: seq<Attr>) = mk "footer" children
    static member footer (children) = mk "footer" [ ofNodes children  ]

    static member form (children: seq<Attr>) = mk "form" children
    static member form (children) = mk "form" [ ofNodes children  ]

    static member h1 (value: float) = mk "h1" [ofNodes [ Util.asString value |> ofStr ]]
    static member h1 (value: int) = mk "h1" [ofNodes [ Util.asString value |> ofStr ]]
    static member h1 (value: Node) = mk "h1" [ofNodes [ value ]]
    static member h1 (value: string) = mk "h1" [ofNodes [ ofStr value ]]
    static member h1 (children: seq<Attr>) = mk "h1" children
    static member h1 (children) = mk "h1" [ ofNodes children  ]
    static member h2 (value: float) = mk "h2" [ofNodes [ Util.asString value |> ofStr ]]
    static member h2 (value: int) = mk "h2" [ofNodes [ Util.asString value |> ofStr ]]
    static member h2 (value: Node) = mk "h2" [ofNodes [ value ]]
    static member h2 (value: string) = mk "h2" [ofNodes [ ofStr value ]]
    static member h2 (children: seq<Attr>) = mk "h2" children
    static member h2 (children) = mk "h2" [ ofNodes children  ]

    static member h3 (value: float) = mk "h3" [ofNodes [ Util.asString value |> ofStr ]]
    static member h3 (value: int) = mk "h3" [ofNodes [ Util.asString value |> ofStr ]]
    static member h3 (value: Node) = mk "h3" [ofNodes [ value ]]
    static member h3 (value: string) = mk "h3" [ofNodes [ ofStr value ]]
    static member h3 (children: seq<Attr>) = mk "h3" children
    static member h3 (children) = mk "h3" [ ofNodes children  ]

    static member h4 (value: float) = mk "h4" [ofNodes [ Util.asString value |> ofStr ]]
    static member h4 (value: int) = mk "h4" [ofNodes [ Util.asString value |> ofStr ]]
    static member h4 (value: Node) = mk "h4" [ofNodes [ value ]]
    static member h4 (value: string) = mk "h4" [ofNodes [ ofStr value ]]
    static member h4 (children: seq<Attr>) = mk "h4" children
    static member h4 (children) = mk "h4" [ ofNodes children  ]

    static member h5 (value: float) = mk "h5" [ofNodes [ Util.asString value |> ofStr ]]
    static member h5 (value: int) = mk "h5" [ofNodes [ Util.asString value |> ofStr ]]
    static member h5 (value: Node) = mk "h5" [ofNodes [ value ]]
    static member h5 (value: string) = mk "h5" [ofNodes [ ofStr value ]]
    static member h5 (children: seq<Attr>) = mk "h5" children
    static member h5 (children) = mk "h5" [ ofNodes children  ]

    static member h6 (value: float) = mk "h6" [ofNodes [ Util.asString value |> ofStr ]]
    static member h6 (value: int) = mk "h6" [ofNodes [ Util.asString value |> ofStr ]]
    static member h6 (value: Node) = mk "h6" [ofNodes [ value ]]
    static member h6 (value: string) = mk "h6" [ofNodes [ ofStr value ]]
    static member h6 (children: seq<Attr>) = mk "h6" children
    static member h6 (children) = mk "h6" [ ofNodes children  ]

    static member head (children: seq<Attr>) = mk "head" children
    static member head (children) = mk "head" [ ofNodes children  ]

    static member header (children: seq<Attr>) = mk "header" children
    static member header (children) = mk "header" [ ofNodes children  ]

    static member hr (children: seq<Attr>) = mk "hr" children
    static member hr (children) = mk "hr" [ ofNodes children  ]

    static member html (children: seq<Attr>) = mk "html" children
    static member html (children) = mk "html" [ ofNodes children  ]

    static member i (value: float) = mk "i" [ofNodes [ Util.asString value |> ofStr ]]
    static member i (value: int) = mk "i" [ofNodes [ Util.asString value |> ofStr ]]
    static member i (value: Node) = mk "i" [ofNodes [ value ]]
    static member i (value: string) = mk "i" [ofNodes [ ofStr value ]]
    static member i (children: seq<Attr>) = mk "i" children
    static member i (children) = mk "i" [ ofNodes children  ]

    static member iframe (children: seq<Attr>) = mk "iframe" children
    static member iframe (children) = mk "iframe" [ ofNodes children  ]

    static member img (children: seq<Attr>) = mk "img" children
    static member img (children) = mk "img" [ ofNodes children  ]

    static member input (children: seq<Attr>) = mk "input" children
    static member input (children) = mk "input" [ ofNodes children  ]

    static member ins (value: float) = mk "ins" [ofNodes [ Util.asString value |> ofStr ]]
    static member ins (value: int) = mk "ins" [ofNodes [ Util.asString value |> ofStr ]]
    static member ins (value: Node) = mk "ins" [ofNodes [ value ]]
    static member ins (value: string) = mk "ins" [ofNodes [ ofStr value ]]
    static member ins (children: seq<Attr>) = mk "ins" children
    static member ins (children) = mk "ins" [ ofNodes children  ]

    static member kbd (value: float) = mk "kbd" [ofNodes [ Util.asString value |> ofStr ]]
    static member kbd (value: int) = mk "kbd" [ofNodes [ Util.asString value |> ofStr ]]
    static member kbd (value: Node) = mk "kbd" [ofNodes [ value ]]
    static member kbd (value: string) = mk "kbd" [ofNodes [ ofStr value ]]
    static member kbd (children: seq<Attr>) = mk "kbd" children
    static member kbd (children) = mk "kbd" [ ofNodes children  ]

    static member label (children: seq<Attr>) = mk "label" children
    static member label (children) = mk "label" [ ofNodes children  ]

    static member legend (value: float) = mk "legend" [ofNodes [ Util.asString value |> ofStr ]]
    static member legend (value: int) = mk "legend" [ofNodes [ Util.asString value |> ofStr ]]
    static member legend (value: Node) = mk "legend" [ofNodes [ value ]]
    static member legend (value: string) = mk "legend" [ofNodes [ ofStr value ]]
    static member legend (children: seq<Attr>) = mk "legend" children
    static member legend (children) = mk "legend" [ ofNodes children  ]

    static member li (value: float) = mk "li" [ofNodes [ Util.asString value |> ofStr ]]
    static member li (value: int) = mk "li" [ofNodes [ Util.asString value |> ofStr ]]
    static member li (value: Node) = mk "li" [ofNodes [ value ]]
    static member li (value: string) = mk "li" [ofNodes [ ofStr value ]]
    static member li (children: seq<Attr>) = mk "li" children
    static member li (children) = mk "li" [ ofNodes children  ]

    static member listItem (value: float) = mk "li" [ofNodes [ Util.asString value |> ofStr ]]
    static member listItem (value: int) = mk "li" [ofNodes [ Util.asString value |> ofStr ]]
    static member listItem (value: Node) = mk "li" [ofNodes [ value ]]
    static member listItem (value: string) = mk "li" [ofNodes [ ofStr value ]]
    static member listItem (children: seq<Attr>) = mk "li" children
    static member listItem (children) = mk "listItem" [ ofNodes children  ]

    static member main (children: seq<Attr>) = mk "main" children
    static member main (children) = mk "main" [ ofNodes children  ]

    static member map (children: seq<Attr>) = mk "map" children
    static member map (children) = mk "map" [ ofNodes children  ]

    static member mark (value: float) = mk "mark" [ofNodes [ Util.asString value |> ofStr ]]
    static member mark (value: int) = mk "mark" [ofNodes [ Util.asString value |> ofStr ]]
    static member mark (value: Node) = mk "mark" [ofNodes [ value ]]
    static member mark (value: string) = mk "mark" [ofNodes [ ofStr value ]]
    static member mark (children: seq<Attr>) = mk "mark" children
    static member mark (children) = mk "mark" [ ofNodes children  ]

    static member metadata (children: seq<Attr>) = mk "metadata" children
    static member metadata (children) = mk "metadata" [ ofNodes children  ]

    static member meter (value: float) = mk "meter" [ofNodes [ Util.asString value |> ofStr ]]
    static member meter (value: int) = mk "meter" [ofNodes [ Util.asString value |> ofStr ]]
    static member meter (value: Node) = mk "meter" [ofNodes [ value ]]
    static member meter (value: string) = mk "meter" [ofNodes [ ofStr value ]]
    static member meter (children: seq<Attr>) = mk "meter" children
    static member meter (children) = mk "meter" [ ofNodes children  ]

    static member nav (children: seq<Attr>) = mk "nav" children
    static member nav (children) = mk "nav" [ ofNodes children  ]

    static member noscript (children: seq<Attr>) = mk "noscript" children
    static member noscript (children) = mk "noscript" [ ofNodes children  ]

    static member object (children: seq<Attr>) = mk "object" children
    static member object (children) = mk "object" [ ofNodes children  ]

    static member ol (children: seq<Attr>) = mk "ol" children
    static member ol (children) = mk "ol" [ ofNodes children  ]

    static member option (value: float) = mk "option" [ofNodes [ Util.asString value |> ofStr ]]
    static member option (value: int) = mk "option" [ofNodes [ Util.asString value |> ofStr ]]
    static member option (value: Node) = mk "option" [ofNodes [ value ]]
    static member option (value: string) = mk "option" [ofNodes [ ofStr value ]]
    static member option (children: seq<Attr>) = mk "option" children
    static member option (children) = mk "option" [ ofNodes children  ]

    static member optgroup (children: seq<Attr>) = mk "optgroup" children
    static member optgroup (children) = mk "optgroup" [ ofNodes children  ]

    static member orderedList (children: seq<Attr>) = mk "ol" children
    static member orderedList (children) = mk "orderedList" [ ofNodes children  ]

    static member output (value: float) = mk "output" [ofNodes [ Util.asString value |> ofStr ]]
    static member output (value: int) = mk "output" [ofNodes [ Util.asString value |> ofStr ]]
    static member output (value: Node) = mk "output" [ofNodes [ value ]]
    static member output (value: string) = mk "output" [ofNodes [ ofStr value ]]
    static member output (children: seq<Attr>) = mk "output" children
    static member output (children) = mk "output" [ ofNodes children  ]

    static member p (value: float) = mk "p" [ofNodes [ Util.asString value |> ofStr ]]
    static member p (value: int) = mk "p" [ofNodes [ Util.asString value |> ofStr ]]
    static member p (value: Node) = mk "p" [ofNodes [ value ]]
    static member p (value: string) = mk "p" [ofNodes [ ofStr value ]]
    static member p (children: seq<Attr>) = mk "p" children
    static member p (children) = mk "p" [ ofNodes children  ]

    static member paragraph (value: float) = mk "p" [ofNodes [ Util.asString value |> ofStr ]]
    static member paragraph (value: int) = mk "p" [ofNodes [ Util.asString value |> ofStr ]]
    static member paragraph (value: Node) = mk "p" [ofNodes [ value ]]
    static member paragraph (value: string) = mk "p" [ofNodes [ ofStr value ]]
    static member paragraph (children: seq<Attr>) = mk "p" children
    static member paragraph (children) = mk "paragraph" [ ofNodes children  ]

    static member picture (children: seq<Attr>) = mk "picture" children
    static member picture (children) = mk "picture" [ ofNodes children  ]

    // static member pre (value: bool) = mk "pre" value
    static member pre (value: float) = mk "pre" [ofNodes [ Util.asString value |> ofStr ]]
    static member pre (value: int) = mk "pre" [ofNodes [ Util.asString value |> ofStr ]]
    static member pre (value: Node) = mk "pre" [ofNodes [ value ]]
    static member pre (value: string) = mk "pre" [ofNodes [ ofStr value ]]
    static member pre (children: seq<Attr>) = mk "pre" children
    static member pre (children) = mk "pre" [ ofNodes children  ]

    static member progress (children: seq<Attr>) = mk "progress" children
    static member progress (children) = mk "progress" [ ofNodes children  ]

    static member q (children: seq<Attr>) = mk "q" children
    static member q (children) = mk "q" [ ofNodes children  ]

    static member rb (value: float) = mk "rb" [ofNodes [ Util.asString value |> ofStr ]]
    static member rb (value: int) = mk "rb" [ofNodes [ Util.asString value |> ofStr ]]
    static member rb (value: Node) = mk "rb" [ofNodes [ value ]]
    static member rb (value: string) = mk "rb" [ofNodes [ ofStr value ]]
    static member rb (children: seq<Attr>) = mk "rb" children
    static member rb (children) = mk "rb" [ ofNodes children  ]

    static member rp (value: float) = mk "rp" [ofNodes [ Util.asString value |> ofStr ]]
    static member rp (value: int) = mk "rp" [ofNodes [ Util.asString value |> ofStr ]]
    static member rp (value: Node) = mk "rp" [ofNodes [ value ]]
    static member rp (value: string) = mk "rp" [ofNodes [ ofStr value ]]
    static member rp (children: seq<Attr>) = mk "rp" children
    static member rp (children) = mk "rp" [ ofNodes children  ]

    static member rt (value: float) = mk "rt" [ofNodes [ Util.asString value |> ofStr ]]
    static member rt (value: int) = mk "rt" [ofNodes [ Util.asString value |> ofStr ]]
    static member rt (value: Node) = mk "rt" [ofNodes [ value ]]
    static member rt (value: string) = mk "rt" [ofNodes [ ofStr value ]]
    static member rt (children: seq<Attr>) = mk "rt" children
    static member rt (children) = mk "rt" [ ofNodes children  ]

    static member rtc (value: float) = mk "rtc" [ofNodes [ Util.asString value |> ofStr ]]
    static member rtc (value: int) = mk "rtc" [ofNodes [ Util.asString value |> ofStr ]]
    static member rtc (value: Node) = mk "rtc" [ofNodes [ value ]]
    static member rtc (value: string) = mk "rtc" [ofNodes [ ofStr value ]]
    static member rtc (children: seq<Attr>) = mk "rtc" children
    static member rtc (children) = mk "rtc" [ ofNodes children  ]

    static member ruby (value: float) = mk "ruby" [ofNodes [ Util.asString value |> ofStr ]]
    static member ruby (value: int) = mk "ruby" [ofNodes [ Util.asString value |> ofStr ]]
    static member ruby (value: Node) = mk "ruby" [ofNodes [ value ]]
    static member ruby (value: string) = mk "ruby" [ofNodes [ ofStr value ]]
    static member ruby (children: seq<Attr>) = mk "ruby" children
    static member ruby (children) = mk "ruby" [ ofNodes children  ]

    static member s (value: float) = mk "s" [ofNodes [ Util.asString value |> ofStr ]]
    static member s (value: int) = mk "s" [ofNodes [ Util.asString value |> ofStr ]]
    static member s (value: Node) = mk "s" [ofNodes [ value ]]
    static member s (value: string) = mk "s" [ofNodes [ ofStr value ]]
    static member s (children: seq<Attr>) = mk "s" children
    static member s (children) = mk "s" [ ofNodes children  ]

    static member samp (value: float) = mk "samp" [ofNodes [ Util.asString value |> ofStr ]]
    static member samp (value: int) = mk "samp" [ofNodes [ Util.asString value |> ofStr ]]
    static member samp (value: Node) = mk "samp" [ofNodes [ value ]]
    static member samp (value: string) = mk "samp" [ofNodes [ ofStr value ]]
    static member samp (children: seq<Attr>) = mk "samp" children
    static member samp (children) = mk "samp" [ ofNodes children  ]

    static member script (children: seq<Attr>) = mk "script" children
    static member script (children) = mk "script" [ ofNodes children  ]

    static member section (children: seq<Attr>) = mk "section" children
    static member section (children) = mk "section" [ ofNodes children  ]

    static member select (children: seq<Attr>) = mk "select" children
    static member select (children) = mk "select" [ ofNodes children  ]
    static member small (value: float) = mk "small" [ofNodes [ Util.asString value |> ofStr ]]
    static member small (value: int) = mk "small" [ofNodes [ Util.asString value |> ofStr ]]
    static member small (value: Node) = mk "small" [ofNodes [ value ]]
    static member small (value: string) = mk "small" [ofNodes [ ofStr value ]]
    static member small (children: seq<Attr>) = mk "small" children
    static member small (children) = mk "small" [ ofNodes children  ]

    static member source (children: seq<Attr>) = mk "source" children
    static member source (children) = mk "source" [ ofNodes children  ]

    static member span (value: float) = mk "span" [ofNodes [ Util.asString value |> ofStr ]]
    static member span (value: int) = mk "span" [ofNodes [ Util.asString value |> ofStr ]]
    static member span (value: Node) = mk "span" [ofNodes [ value ]]
    static member span (value: string) = mk "span" [ofNodes [ ofStr value ]]
    static member span (children: seq<Attr>) = mk "span" children
    static member span (children) = mk "span" [ ofNodes children  ]

    static member strong (value: float) = mk "strong" [ofNodes [ Util.asString value |> ofStr ]]
    static member strong (value: int) = mk "strong" [ofNodes [ Util.asString value |> ofStr ]]
    static member strong (value: Node) = mk "strong" [ofNodes [ value ]]
    static member strong (value: string) = mk "strong" [ofNodes [ ofStr value ]]
    static member strong (children: seq<Attr>) = mk "strong" children
    static member strong (children) = mk "strong" [ ofNodes children  ]

    static member style (value: string) = mk "style" [ofNodes [ ofStr value ]]

    static member sub (value: float) = mk "sub" [ofNodes [ Util.asString value |> ofStr ]]
    static member sub (value: int) = mk "sub" [ofNodes [ Util.asString value |> ofStr ]]
    static member sub (value: Node) = mk "sub" [ofNodes [ value ]]
    static member sub (value: string) = mk "sub" [ofNodes [ ofStr value ]]
    static member sub (children: seq<Attr>) = mk "sub" children
    static member sub (children) = mk "sub" [ ofNodes children  ]

    static member summary (value: float) = mk "summary" [ofNodes [ Util.asString value |> ofStr ]]
    static member summary (value: int) = mk "summary" [ofNodes [ Util.asString value |> ofStr ]]
    static member summary (value: Node) = mk "summary" [ofNodes [ value ]]
    static member summary (value: string) = mk "summary" [ofNodes [ ofStr value ]]
    static member summary (children: seq<Attr>) = mk "summary" children
    static member summary (children) = mk "summary" [ ofNodes children  ]

    static member sup (value: float) = mk "sup" [ofNodes [ Util.asString value |> ofStr ]]
    static member sup (value: int) = mk "sup" [ofNodes [ Util.asString value |> ofStr ]]
    static member sup (value: Node) = mk "sup" [ofNodes [ value ]]
    static member sup (value: string) = mk "sup" [ofNodes [ ofStr value ]]
    static member sup (children: seq<Attr>) = mk "sup" children
    static member sup (children) = mk "sup" [ ofNodes children  ]

    static member table (children: seq<Attr>) = mk "table" children
    static member table (children) = mk "table" [ ofNodes children  ]

    static member tableBody (children: seq<Attr>) = mk "tbody" children
    static member tableBody (children) = mk "tableBody" [ ofNodes children  ]

    static member tableCell (children: seq<Attr>) = mk "td" children
    static member tableCell (children) = mk "tableCell" [ ofNodes children  ]

    static member tableHeader (children: seq<Attr>) = mk "th" children
    static member tableHeader (children) = mk "tableHeader" [ ofNodes children  ]

    static member tableRow (children: seq<Attr>) = mk "tr" children
    static member tableRow (children) = mk "tableRow" [ ofNodes children  ]

    static member tbody (children: seq<Attr>) = mk "tbody" children
    static member tbody (children) = mk "tbody" [ ofNodes children  ]

    static member td (value: float) = mk "td" [ofNodes [ Util.asString value |> ofStr ]]
    static member td (value: int) = mk "td" [ofNodes [ Util.asString value |> ofStr ]]
    static member td (value: Node) = mk "td" [ofNodes [ value ]]
    static member td (value: string) = mk "td" [ofNodes [ ofStr value ]]
    static member td (children: seq<Attr>) = mk "td" children
    static member td (children) = mk "td" [ ofNodes children  ]

    static member template (children: seq<Attr>) = mk "template" children
    static member template (children) = mk "template" [ ofNodes children  ]

    static member textarea (children: seq<Attr>) = mk "textarea" children
    static member textarea (children) = mk "textarea" [ ofNodes children  ]

    static member tfoot (children: seq<Attr>) = mk "tfoot" children
    static member tfoot (children) = mk "tfoot" [ ofNodes children  ]

    static member th (value: float) = mk "th" [ofNodes [ Util.asString value |> ofStr ]]
    static member th (value: int) = mk "th" [ofNodes [ Util.asString value |> ofStr ]]
    static member th (value: Node) = mk "th" [ofNodes [ value ]]
    static member th (value: string) = mk "th" [ofNodes [ ofStr value ]]
    static member th (children: seq<Attr>) = mk "th" children
    static member th (children) = mk "th" [ ofNodes children  ]

    static member thead (children: seq<Attr>) = mk "thead" children
    static member thead (children) = mk "thead" [ ofNodes children  ]

    static member time (children: seq<Attr>) = mk "time" children
    static member time (children) = mk "time" [ ofNodes children  ]

    static member tr (children: seq<Attr>) = mk "tr" children
    static member tr (children) = mk "tr" [ ofNodes children  ]

    static member track (children: seq<Attr>) = mk "track" children
    static member track (children) = mk "track" [ ofNodes children  ]

    static member u (value: float) = mk "u" [ofNodes [ Util.asString value |> ofStr ]]
    static member u (value: int) = mk "u" [ofNodes [ Util.asString value |> ofStr ]]
    static member u (value: Node) = mk "u" [ofNodes [ value ]]
    static member u (value: string) = mk "u" [ofNodes [ ofStr value ]]
    static member u (children: seq<Attr>) = mk "u" children
    static member u (children) = mk "u" [ ofNodes children  ]

    static member ul (children: seq<Attr>) = mk "ul" children
    static member ul (children) = mk "ul" [ ofNodes children  ]

    static member unorderedList (children: seq<Attr>) = mk "ul" children
    static member unorderedList (children) = mk "unorderedList" [ ofNodes children  ]

    static member var (value: float) = mk "var" [ofNodes [ Util.asString value |> ofStr ]]
    static member var (value: int) = mk "var" [ofNodes [ Util.asString value |> ofStr ]]
    static member var (value: Node) = mk "var" [ofNodes [ value ]]
    static member var (value: string) = mk "var" [ofNodes [ ofStr value ]]
    static member var (children: seq<Attr>) = mk "var" children
    static member var (children) = mk "var" [ ofNodes children  ]

    static member video (children: seq<Attr>) = mk "video" children
    static member video (children) = mk "video" [ ofNodes children  ]

    static member wbr (children: seq<Attr>) = mk "wbr" children
    static member wbr (children) = mk "wbr" [ ofNodes children  ]
