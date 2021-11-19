namespace Fun.Blazor

open System


type internal Util =
    static member inline asString(x: string): string = x
    static member inline asString(x: int): string = string x
    static member inline asString(x: int option): string = match x with Some x -> Util.asString x | None -> ""
    static member inline asString(x: float): string = string x
    static member inline asString(x: Guid): string = string x

type FunHtmlEngine<'Attr, 'Node>
    /// <summary>Customizable HTML generator API.</summary>
    ///
    /// <param name="mk">Make a node with tag name and children.</param>
    /// <param name="ofStr">Make a node from a string.</param>
    /// <param name="empty">Make an empty node.</param>
    (mk: string -> 'Attr seq -> 'Node, ofStr: string -> 'Node, ofNodes: 'Node seq -> 'Attr, empty: unit -> 'Node) =

    /// Create a custom element
    ///
    /// You generally shouldn't need to use this, if you notice an element missing please submit an issue.
    member _.custom (key: string, children: seq<'Attr>) = mk key children
    /// The empty element, renders nothing on screen
    member _.none : 'Node = empty()

    member _.a (children: seq<'Attr>) = mk "a" children
    member _.a (children) = mk "a" [ ofNodes children  ]

    member _.abbr (value: float) = mk "abbr" [ ofNodes [ Util.asString value |> ofStr ] ]
    member _.abbr (value: int) = mk "abbr" [ofNodes [ Util.asString value |> ofStr ]]
    member _.abbr (value: 'Node) = mk "abbr" [ofNodes [ value ]]
    member _.abbr (value: string) = mk "abbr" [ofNodes [ ofStr value ]]
    member _.abbr (children: seq<'Attr>) = mk "abbr" children
    member _.abbr (children) = mk "abbr" [ ofNodes children  ]

    member _.address (value: float) = mk "address" [ofNodes [ Util.asString value |> ofStr ]]
    member _.address (value: int) = mk "address" [ofNodes [ Util.asString value |> ofStr ]]
    member _.address (value: 'Node) = mk "address" [ofNodes [ value ]]
    member _.address (value: string) = mk "address" [ofNodes [ ofStr value ]]
    member _.address (children: seq<'Attr>) = mk "address" children
    member _.address (children) = mk "address" [ ofNodes children  ]

    member _.anchor (children: seq<'Attr>) = mk "a" children
    member _.anchor (children) = mk "anchor" [ ofNodes children  ]

    member _.area (children: seq<'Attr>) = mk "area" children
    member _.area (children) = mk "area" [ ofNodes children  ]

    member _.article (children: seq<'Attr>) = mk "article" children
    member _.article (children) = mk "article" [ ofNodes children  ]

    member _.aside (children: seq<'Attr>) = mk "aside" children
    member _.aside (children) = mk "aside" [ ofNodes children  ]

    member _.audio (children: seq<'Attr>) = mk "audio" children
    member _.audio (children) = mk "audio" [ ofNodes children  ]

    member _.b (value: float) = mk "b" [ofNodes [ Util.asString value |> ofStr ]]
    member _.b (value: int) = mk "b" [ofNodes [ Util.asString value |> ofStr ]]
    member _.b (value: 'Node) = mk "b" [ofNodes [ value ]]
    member _.b (value: string) = mk "b" [ofNodes [ ofStr value ]]
    member _.b (children: seq<'Attr>) = mk "b" children
    member _.b (children) = mk "b" [ ofNodes children  ]

    member _.base' (children: seq<'Attr>) = mk "base" children
    member _.base' (children) = mk "base'" [ ofNodes children  ]

    member _.bdi (value: float) = mk "bdi" [ofNodes [ Util.asString value |> ofStr ]]
    member _.bdi (value: int) = mk "bdi" [ofNodes [ Util.asString value |> ofStr ]]
    member _.bdi (value: 'Node) = mk "bdi" [ofNodes [ value ]]
    member _.bdi (value: string) = mk "bdi" [ofNodes [ ofStr value ]]
    member _.bdi (children: seq<'Attr>) = mk "bdi" children
    member _.bdi (children) = mk "bdi" [ ofNodes children  ]

    member _.bdo (value: float) = mk "bdo" [ofNodes [ Util.asString value |> ofStr ]]
    member _.bdo (value: int) = mk "bdo" [ofNodes [ Util.asString value |> ofStr ]]
    member _.bdo (value: 'Node) = mk "bdo" [ofNodes [ value ]]
    member _.bdo (value: string) = mk "bdo" [ofNodes [ ofStr value ]]
    member _.bdo (children: seq<'Attr>) = mk "bdo" children
    member _.bdo (children) = mk "bdo" [ ofNodes children  ]

    member _.blockquote (value: float) = mk "blockquote" [ofNodes [ Util.asString value |> ofStr ]]
    member _.blockquote (value: int) = mk "blockquote" [ofNodes [ Util.asString value |> ofStr ]]
    member _.blockquote (value: 'Node) = mk "blockquote" [ofNodes [ value ]]
    member _.blockquote (value: string) = mk "blockquote" [ofNodes [ ofStr value ]]
    member _.blockquote (children: seq<'Attr>) = mk "blockquote" children
    member _.blockquote (children) = mk "blockquote" [ ofNodes children  ]

    member _.body (value: float) = mk "body" [ofNodes [ Util.asString value |> ofStr ]]
    member _.body (value: int) = mk "body" [ofNodes [ Util.asString value |> ofStr ]]
    member _.body (value: 'Node) = mk "body" [ofNodes [ value ]]
    member _.body (value: string) = mk "body" [ofNodes [ ofStr value ]]
    member _.body (children: seq<'Attr>) = mk "body" children
    member _.body (children) = mk "body" [ ofNodes children  ]

    member _.br (children: seq<'Attr>) = mk "br" children
    member _.br (children) = mk "br" [ ofNodes children  ]

    member _.button (children: seq<'Attr>) = mk "button" children
    member _.button (children) = mk "button" [ ofNodes children  ]

    member _.canvas (children: seq<'Attr>) = mk "canvas" children
    member _.canvas (children) = mk "canvas" [ ofNodes children  ]

    member _.caption (value: float) = mk "caption" [ofNodes [ Util.asString value |> ofStr ]]
    member _.caption (value: int) = mk "caption" [ofNodes [ Util.asString value |> ofStr ]]
    member _.caption (value: 'Node) = mk "caption" [ofNodes [ value ]]
    member _.caption (value: string) = mk "caption" [ofNodes [ ofStr value ]]
    member _.caption (children: seq<'Attr>) = mk "caption" children
    member _.caption (children) = mk "caption" [ ofNodes children  ]

    member _.cite (value: float) = mk "cite" [ofNodes [ Util.asString value |> ofStr ]]
    member _.cite (value: int) = mk "cite" [ofNodes [ Util.asString value |> ofStr ]]
    member _.cite (value: 'Node) = mk "cite" [ofNodes [ value ]]
    member _.cite (value: string) = mk "cite" [ofNodes [ ofStr value ]]
    member _.cite (children: seq<'Attr>) = mk "cite" children
    member _.cite (children) = mk "cite" [ ofNodes children  ]

    // member _.code (value: bool) = mk "code" value
    member _.code (value: float) = mk "code" [ofNodes [ Util.asString value |> ofStr ]]
    member _.code (value: int) = mk "code" [ofNodes [ Util.asString value |> ofStr ]]
    member _.code (value: 'Node) = mk "code" [ofNodes [ value ]]
    member _.code (value: string) = mk "code" [ofNodes [ ofStr value ]]
    member _.code (children: seq<'Attr>) = mk "code" children
    member _.code (children) = mk "code" [ ofNodes children  ]

    member _.col (children: seq<'Attr>) = mk "col" children
    member _.col (children) = mk "col" [ ofNodes children  ]

    member _.colgroup (children: seq<'Attr>) = mk "colgroup" children
    member _.colgroup (children) = mk "colgroup" [ ofNodes children  ]

    member _.data (value: float) = mk "data" [ofNodes [ Util.asString value |> ofStr ]]
    member _.data (value: int) = mk "data" [ofNodes [ Util.asString value |> ofStr ]]
    member _.data (value: 'Node) = mk "data" [ofNodes [ value ]]
    member _.data (value: string) = mk "data" [ofNodes [ ofStr value ]]
    member _.data (children: seq<'Attr>) = mk "data" children
    member _.data (children) = mk "data" [ ofNodes children  ]

    member _.datalist (value: float) = mk "datalist" [ofNodes [ Util.asString value |> ofStr ]]
    member _.datalist (value: int) = mk "datalist" [ofNodes [ Util.asString value |> ofStr ]]
    member _.datalist (value: 'Node) = mk "datalist" [ofNodes [ value ]]
    member _.datalist (value: string) = mk "datalist" [ofNodes [ ofStr value ]]
    member _.datalist (children: seq<'Attr>) = mk "datalist" children
    member _.datalist (children) = mk "datalist" [ ofNodes children  ]

    member _.dd (value: float) = mk "dd" [ofNodes [ Util.asString value |> ofStr ]]
    member _.dd (value: int) = mk "dd" [ofNodes [ Util.asString value |> ofStr ]]
    member _.dd (value: 'Node) = mk "dd" [ofNodes [ value ]]
    member _.dd (value: string) = mk "dd" [ofNodes [ ofStr value ]]
    member _.dd (children: seq<'Attr>) = mk "dd" children
    member _.dd (children) = mk "dd" [ ofNodes children  ]

    member _.del (value: float) = mk "del" [ofNodes [ Util.asString value |> ofStr ]]
    member _.del (value: int) = mk "del" [ofNodes [ Util.asString value |> ofStr ]]
    member _.del (value: 'Node) = mk "del" [ofNodes [ value ]]
    member _.del (value: string) = mk "del" [ofNodes [ ofStr value ]]
    member _.del (children: seq<'Attr>) = mk "del" children
    member _.del (children) = mk "del" [ ofNodes children  ]

    member _.details (children: seq<'Attr>) = mk "details" children
    member _.details (children) = mk "details" [ ofNodes children  ]

    member _.dfn (value: float) = mk "dfn" [ofNodes [ Util.asString value |> ofStr ]]
    member _.dfn (value: int) = mk "dfn" [ofNodes [ Util.asString value |> ofStr ]]
    member _.dfn (value: 'Node) = mk "dfn" [ofNodes [ value ]]
    member _.dfn (value: string) = mk "dfn" [ofNodes [ ofStr value ]]
    member _.dfn (children: seq<'Attr>) = mk "dfn" children
    member _.dfn (children) = mk "dfn" [ ofNodes children  ]

    member _.dialog (value: float) = mk "dialog" [ofNodes [ Util.asString value |> ofStr ]]
    member _.dialog (value: int) = mk "dialog" [ofNodes [ Util.asString value |> ofStr ]]
    member _.dialog (value: 'Node) = mk "dialog" [ofNodes [ value ]]
    member _.dialog (value: string) = mk "dialog" [ofNodes [ ofStr value ]]
    member _.dialog (children: seq<'Attr>) = mk "dialog" children
    member _.dialog (children) = mk "dialog" [ ofNodes children  ]

    member _.div (value: float) = mk "div" [ofNodes [ Util.asString value |> ofStr ]]
    member _.div (value: int) = mk "div" [ofNodes [ Util.asString value |> ofStr ]]
    member _.div (value: 'Node) = mk "div" [ofNodes [ value ]]
    member _.div (value: string) = mk "div" [ofNodes [ ofStr value ]]
    /// The `<div>` tag defines a division or a section in an HTML document
    member _.div (children: seq<'Attr>) = mk "div" children
    member _.div (children) = mk "div" [ ofNodes children  ]

    member _.dl (children: seq<'Attr>) = mk "dl" children
    member _.dl (children) = mk "dl" [ ofNodes children  ]

    member _.dt (value: float) = mk "dt" [ofNodes [ Util.asString value |> ofStr ]]
    member _.dt (value: int) = mk "dt" [ofNodes [ Util.asString value |> ofStr ]]
    member _.dt (value: 'Node) = mk "dt" [ofNodes [ value ]]
    member _.dt (value: string) = mk "dt" [ofNodes [ ofStr value ]]
    member _.dt (children: seq<'Attr>) = mk "dt" children
    member _.dt (children) = mk "dt" [ ofNodes children  ]

    member _.em (value: float) = mk "em" [ofNodes [ Util.asString value |> ofStr ]]
    member _.em (value: int) = mk "em" [ofNodes [ Util.asString value |> ofStr ]]
    member _.em (value: 'Node) = mk "em" [ofNodes [ value ]]
    member _.em (value: string) = mk "em" [ofNodes [ ofStr value ]]
    member _.em (children: seq<'Attr>) = mk "em" children
    member _.em (children) = mk "em" [ ofNodes children  ]

    member _.fieldSet (children: seq<'Attr>) = mk "fieldset" children
    member _.fieldSet (children) = mk "fieldSet" [ ofNodes children  ]

    member _.figcaption (children: seq<'Attr>) = mk "figcaption" children
    member _.figcaption (children) = mk "figcaption" [ ofNodes children  ]

    member _.figure (children: seq<'Attr>) = mk "figure" children
    member _.figure (children) = mk "figure" [ ofNodes children  ]

    member _.footer (children: seq<'Attr>) = mk "footer" children
    member _.footer (children) = mk "footer" [ ofNodes children  ]

    member _.form (children: seq<'Attr>) = mk "form" children
    member _.form (children) = mk "form" [ ofNodes children  ]

    member _.h1 (value: float) = mk "h1" [ofNodes [ Util.asString value |> ofStr ]]
    member _.h1 (value: int) = mk "h1" [ofNodes [ Util.asString value |> ofStr ]]
    member _.h1 (value: 'Node) = mk "h1" [ofNodes [ value ]]
    member _.h1 (value: string) = mk "h1" [ofNodes [ ofStr value ]]
    member _.h1 (children: seq<'Attr>) = mk "h1" children
    member _.h1 (children) = mk "h1" [ ofNodes children  ]
    member _.h2 (value: float) = mk "h2" [ofNodes [ Util.asString value |> ofStr ]]
    member _.h2 (value: int) = mk "h2" [ofNodes [ Util.asString value |> ofStr ]]
    member _.h2 (value: 'Node) = mk "h2" [ofNodes [ value ]]
    member _.h2 (value: string) = mk "h2" [ofNodes [ ofStr value ]]
    member _.h2 (children: seq<'Attr>) = mk "h2" children
    member _.h2 (children) = mk "h2" [ ofNodes children  ]

    member _.h3 (value: float) = mk "h3" [ofNodes [ Util.asString value |> ofStr ]]
    member _.h3 (value: int) = mk "h3" [ofNodes [ Util.asString value |> ofStr ]]
    member _.h3 (value: 'Node) = mk "h3" [ofNodes [ value ]]
    member _.h3 (value: string) = mk "h3" [ofNodes [ ofStr value ]]
    member _.h3 (children: seq<'Attr>) = mk "h3" children
    member _.h3 (children) = mk "h3" [ ofNodes children  ]

    member _.h4 (value: float) = mk "h4" [ofNodes [ Util.asString value |> ofStr ]]
    member _.h4 (value: int) = mk "h4" [ofNodes [ Util.asString value |> ofStr ]]
    member _.h4 (value: 'Node) = mk "h4" [ofNodes [ value ]]
    member _.h4 (value: string) = mk "h4" [ofNodes [ ofStr value ]]
    member _.h4 (children: seq<'Attr>) = mk "h4" children
    member _.h4 (children) = mk "h4" [ ofNodes children  ]

    member _.h5 (value: float) = mk "h5" [ofNodes [ Util.asString value |> ofStr ]]
    member _.h5 (value: int) = mk "h5" [ofNodes [ Util.asString value |> ofStr ]]
    member _.h5 (value: 'Node) = mk "h5" [ofNodes [ value ]]
    member _.h5 (value: string) = mk "h5" [ofNodes [ ofStr value ]]
    member _.h5 (children: seq<'Attr>) = mk "h5" children
    member _.h5 (children) = mk "h5" [ ofNodes children  ]

    member _.h6 (value: float) = mk "h6" [ofNodes [ Util.asString value |> ofStr ]]
    member _.h6 (value: int) = mk "h6" [ofNodes [ Util.asString value |> ofStr ]]
    member _.h6 (value: 'Node) = mk "h6" [ofNodes [ value ]]
    member _.h6 (value: string) = mk "h6" [ofNodes [ ofStr value ]]
    member _.h6 (children: seq<'Attr>) = mk "h6" children
    member _.h6 (children) = mk "h6" [ ofNodes children  ]

    member _.head (children: seq<'Attr>) = mk "head" children
    member _.head (children) = mk "head" [ ofNodes children  ]

    member _.header (children: seq<'Attr>) = mk "header" children
    member _.header (children) = mk "header" [ ofNodes children  ]

    member _.hr (children: seq<'Attr>) = mk "hr" children
    member _.hr (children) = mk "hr" [ ofNodes children  ]

    member _.html (children: seq<'Attr>) = mk "html" children
    member _.html (children) = mk "html" [ ofNodes children  ]

    member _.i (value: float) = mk "i" [ofNodes [ Util.asString value |> ofStr ]]
    member _.i (value: int) = mk "i" [ofNodes [ Util.asString value |> ofStr ]]
    member _.i (value: 'Node) = mk "i" [ofNodes [ value ]]
    member _.i (value: string) = mk "i" [ofNodes [ ofStr value ]]
    member _.i (children: seq<'Attr>) = mk "i" children
    member _.i (children) = mk "i" [ ofNodes children  ]

    member _.iframe (children: seq<'Attr>) = mk "iframe" children
    member _.iframe (children) = mk "iframe" [ ofNodes children  ]

    member _.img (children: seq<'Attr>) = mk "img" children
    member _.img (children) = mk "img" [ ofNodes children  ]

    member _.input (children: seq<'Attr>) = mk "input" children
    member _.input (children) = mk "input" [ ofNodes children  ]

    member _.ins (value: float) = mk "ins" [ofNodes [ Util.asString value |> ofStr ]]
    member _.ins (value: int) = mk "ins" [ofNodes [ Util.asString value |> ofStr ]]
    member _.ins (value: 'Node) = mk "ins" [ofNodes [ value ]]
    member _.ins (value: string) = mk "ins" [ofNodes [ ofStr value ]]
    member _.ins (children: seq<'Attr>) = mk "ins" children
    member _.ins (children) = mk "ins" [ ofNodes children  ]

    member _.kbd (value: float) = mk "kbd" [ofNodes [ Util.asString value |> ofStr ]]
    member _.kbd (value: int) = mk "kbd" [ofNodes [ Util.asString value |> ofStr ]]
    member _.kbd (value: 'Node) = mk "kbd" [ofNodes [ value ]]
    member _.kbd (value: string) = mk "kbd" [ofNodes [ ofStr value ]]
    member _.kbd (children: seq<'Attr>) = mk "kbd" children
    member _.kbd (children) = mk "kbd" [ ofNodes children  ]

    member _.label (children: seq<'Attr>) = mk "label" children
    member _.label (children) = mk "label" [ ofNodes children  ]

    member _.legend (value: float) = mk "legend" [ofNodes [ Util.asString value |> ofStr ]]
    member _.legend (value: int) = mk "legend" [ofNodes [ Util.asString value |> ofStr ]]
    member _.legend (value: 'Node) = mk "legend" [ofNodes [ value ]]
    member _.legend (value: string) = mk "legend" [ofNodes [ ofStr value ]]
    member _.legend (children: seq<'Attr>) = mk "legend" children
    member _.legend (children) = mk "legend" [ ofNodes children  ]

    member _.li (value: float) = mk "li" [ofNodes [ Util.asString value |> ofStr ]]
    member _.li (value: int) = mk "li" [ofNodes [ Util.asString value |> ofStr ]]
    member _.li (value: 'Node) = mk "li" [ofNodes [ value ]]
    member _.li (value: string) = mk "li" [ofNodes [ ofStr value ]]
    member _.li (children: seq<'Attr>) = mk "li" children
    member _.li (children) = mk "li" [ ofNodes children  ]

    member _.listItem (value: float) = mk "li" [ofNodes [ Util.asString value |> ofStr ]]
    member _.listItem (value: int) = mk "li" [ofNodes [ Util.asString value |> ofStr ]]
    member _.listItem (value: 'Node) = mk "li" [ofNodes [ value ]]
    member _.listItem (value: string) = mk "li" [ofNodes [ ofStr value ]]
    member _.listItem (children: seq<'Attr>) = mk "li" children
    member _.listItem (children) = mk "listItem" [ ofNodes children  ]

    member _.main (children: seq<'Attr>) = mk "main" children
    member _.main (children) = mk "main" [ ofNodes children  ]

    member _.map (children: seq<'Attr>) = mk "map" children
    member _.map (children) = mk "map" [ ofNodes children  ]

    member _.mark (value: float) = mk "mark" [ofNodes [ Util.asString value |> ofStr ]]
    member _.mark (value: int) = mk "mark" [ofNodes [ Util.asString value |> ofStr ]]
    member _.mark (value: 'Node) = mk "mark" [ofNodes [ value ]]
    member _.mark (value: string) = mk "mark" [ofNodes [ ofStr value ]]
    member _.mark (children: seq<'Attr>) = mk "mark" children
    member _.mark (children) = mk "mark" [ ofNodes children  ]

    member _.metadata (children: seq<'Attr>) = mk "metadata" children
    member _.metadata (children) = mk "metadata" [ ofNodes children  ]

    member _.meter (value: float) = mk "meter" [ofNodes [ Util.asString value |> ofStr ]]
    member _.meter (value: int) = mk "meter" [ofNodes [ Util.asString value |> ofStr ]]
    member _.meter (value: 'Node) = mk "meter" [ofNodes [ value ]]
    member _.meter (value: string) = mk "meter" [ofNodes [ ofStr value ]]
    member _.meter (children: seq<'Attr>) = mk "meter" children
    member _.meter (children) = mk "meter" [ ofNodes children  ]

    member _.nav (children: seq<'Attr>) = mk "nav" children
    member _.nav (children) = mk "nav" [ ofNodes children  ]

    member _.noscript (children: seq<'Attr>) = mk "noscript" children
    member _.noscript (children) = mk "noscript" [ ofNodes children  ]

    member _.object (children: seq<'Attr>) = mk "object" children
    member _.object (children) = mk "object" [ ofNodes children  ]

    member _.ol (children: seq<'Attr>) = mk "ol" children
    member _.ol (children) = mk "ol" [ ofNodes children  ]

    member _.option (value: float) = mk "option" [ofNodes [ Util.asString value |> ofStr ]]
    member _.option (value: int) = mk "option" [ofNodes [ Util.asString value |> ofStr ]]
    member _.option (value: 'Node) = mk "option" [ofNodes [ value ]]
    member _.option (value: string) = mk "option" [ofNodes [ ofStr value ]]
    member _.option (children: seq<'Attr>) = mk "option" children
    member _.option (children) = mk "option" [ ofNodes children  ]

    member _.optgroup (children: seq<'Attr>) = mk "optgroup" children
    member _.optgroup (children) = mk "optgroup" [ ofNodes children  ]

    member _.orderedList (children: seq<'Attr>) = mk "ol" children
    member _.orderedList (children) = mk "orderedList" [ ofNodes children  ]

    member _.output (value: float) = mk "output" [ofNodes [ Util.asString value |> ofStr ]]
    member _.output (value: int) = mk "output" [ofNodes [ Util.asString value |> ofStr ]]
    member _.output (value: 'Node) = mk "output" [ofNodes [ value ]]
    member _.output (value: string) = mk "output" [ofNodes [ ofStr value ]]
    member _.output (children: seq<'Attr>) = mk "output" children
    member _.output (children) = mk "output" [ ofNodes children  ]

    member _.p (value: float) = mk "p" [ofNodes [ Util.asString value |> ofStr ]]
    member _.p (value: int) = mk "p" [ofNodes [ Util.asString value |> ofStr ]]
    member _.p (value: 'Node) = mk "p" [ofNodes [ value ]]
    member _.p (value: string) = mk "p" [ofNodes [ ofStr value ]]
    member _.p (children: seq<'Attr>) = mk "p" children
    member _.p (children) = mk "p" [ ofNodes children  ]

    member _.paragraph (value: float) = mk "p" [ofNodes [ Util.asString value |> ofStr ]]
    member _.paragraph (value: int) = mk "p" [ofNodes [ Util.asString value |> ofStr ]]
    member _.paragraph (value: 'Node) = mk "p" [ofNodes [ value ]]
    member _.paragraph (value: string) = mk "p" [ofNodes [ ofStr value ]]
    member _.paragraph (children: seq<'Attr>) = mk "p" children
    member _.paragraph (children) = mk "paragraph" [ ofNodes children  ]

    member _.picture (children: seq<'Attr>) = mk "picture" children
    member _.picture (children) = mk "picture" [ ofNodes children  ]

    // member _.pre (value: bool) = mk "pre" value
    member _.pre (value: float) = mk "pre" [ofNodes [ Util.asString value |> ofStr ]]
    member _.pre (value: int) = mk "pre" [ofNodes [ Util.asString value |> ofStr ]]
    member _.pre (value: 'Node) = mk "pre" [ofNodes [ value ]]
    member _.pre (value: string) = mk "pre" [ofNodes [ ofStr value ]]
    member _.pre (children: seq<'Attr>) = mk "pre" children
    member _.pre (children) = mk "pre" [ ofNodes children  ]

    member _.progress (children: seq<'Attr>) = mk "progress" children
    member _.progress (children) = mk "progress" [ ofNodes children  ]

    member _.q (children: seq<'Attr>) = mk "q" children
    member _.q (children) = mk "q" [ ofNodes children  ]

    member _.rb (value: float) = mk "rb" [ofNodes [ Util.asString value |> ofStr ]]
    member _.rb (value: int) = mk "rb" [ofNodes [ Util.asString value |> ofStr ]]
    member _.rb (value: 'Node) = mk "rb" [ofNodes [ value ]]
    member _.rb (value: string) = mk "rb" [ofNodes [ ofStr value ]]
    member _.rb (children: seq<'Attr>) = mk "rb" children
    member _.rb (children) = mk "rb" [ ofNodes children  ]

    member _.rp (value: float) = mk "rp" [ofNodes [ Util.asString value |> ofStr ]]
    member _.rp (value: int) = mk "rp" [ofNodes [ Util.asString value |> ofStr ]]
    member _.rp (value: 'Node) = mk "rp" [ofNodes [ value ]]
    member _.rp (value: string) = mk "rp" [ofNodes [ ofStr value ]]
    member _.rp (children: seq<'Attr>) = mk "rp" children
    member _.rp (children) = mk "rp" [ ofNodes children  ]

    member _.rt (value: float) = mk "rt" [ofNodes [ Util.asString value |> ofStr ]]
    member _.rt (value: int) = mk "rt" [ofNodes [ Util.asString value |> ofStr ]]
    member _.rt (value: 'Node) = mk "rt" [ofNodes [ value ]]
    member _.rt (value: string) = mk "rt" [ofNodes [ ofStr value ]]
    member _.rt (children: seq<'Attr>) = mk "rt" children
    member _.rt (children) = mk "rt" [ ofNodes children  ]

    member _.rtc (value: float) = mk "rtc" [ofNodes [ Util.asString value |> ofStr ]]
    member _.rtc (value: int) = mk "rtc" [ofNodes [ Util.asString value |> ofStr ]]
    member _.rtc (value: 'Node) = mk "rtc" [ofNodes [ value ]]
    member _.rtc (value: string) = mk "rtc" [ofNodes [ ofStr value ]]
    member _.rtc (children: seq<'Attr>) = mk "rtc" children
    member _.rtc (children) = mk "rtc" [ ofNodes children  ]

    member _.ruby (value: float) = mk "ruby" [ofNodes [ Util.asString value |> ofStr ]]
    member _.ruby (value: int) = mk "ruby" [ofNodes [ Util.asString value |> ofStr ]]
    member _.ruby (value: 'Node) = mk "ruby" [ofNodes [ value ]]
    member _.ruby (value: string) = mk "ruby" [ofNodes [ ofStr value ]]
    member _.ruby (children: seq<'Attr>) = mk "ruby" children
    member _.ruby (children) = mk "ruby" [ ofNodes children  ]

    member _.s (value: float) = mk "s" [ofNodes [ Util.asString value |> ofStr ]]
    member _.s (value: int) = mk "s" [ofNodes [ Util.asString value |> ofStr ]]
    member _.s (value: 'Node) = mk "s" [ofNodes [ value ]]
    member _.s (value: string) = mk "s" [ofNodes [ ofStr value ]]
    member _.s (children: seq<'Attr>) = mk "s" children
    member _.s (children) = mk "s" [ ofNodes children  ]

    member _.samp (value: float) = mk "samp" [ofNodes [ Util.asString value |> ofStr ]]
    member _.samp (value: int) = mk "samp" [ofNodes [ Util.asString value |> ofStr ]]
    member _.samp (value: 'Node) = mk "samp" [ofNodes [ value ]]
    member _.samp (value: string) = mk "samp" [ofNodes [ ofStr value ]]
    member _.samp (children: seq<'Attr>) = mk "samp" children
    member _.samp (children) = mk "samp" [ ofNodes children  ]

    member _.script (children: seq<'Attr>) = mk "script" children
    member _.script (children) = mk "script" [ ofNodes children  ]

    member _.section (children: seq<'Attr>) = mk "section" children
    member _.section (children) = mk "section" [ ofNodes children  ]

    member _.select (children: seq<'Attr>) = mk "select" children
    member _.select (children) = mk "select" [ ofNodes children  ]
    member _.small (value: float) = mk "small" [ofNodes [ Util.asString value |> ofStr ]]
    member _.small (value: int) = mk "small" [ofNodes [ Util.asString value |> ofStr ]]
    member _.small (value: 'Node) = mk "small" [ofNodes [ value ]]
    member _.small (value: string) = mk "small" [ofNodes [ ofStr value ]]
    member _.small (children: seq<'Attr>) = mk "small" children
    member _.small (children) = mk "small" [ ofNodes children  ]

    member _.source (children: seq<'Attr>) = mk "source" children
    member _.source (children) = mk "source" [ ofNodes children  ]

    member _.span (value: float) = mk "span" [ofNodes [ Util.asString value |> ofStr ]]
    member _.span (value: int) = mk "span" [ofNodes [ Util.asString value |> ofStr ]]
    member _.span (value: 'Node) = mk "span" [ofNodes [ value ]]
    member _.span (value: string) = mk "span" [ofNodes [ ofStr value ]]
    member _.span (children: seq<'Attr>) = mk "span" children
    member _.span (children) = mk "span" [ ofNodes children  ]

    member _.strong (value: float) = mk "strong" [ofNodes [ Util.asString value |> ofStr ]]
    member _.strong (value: int) = mk "strong" [ofNodes [ Util.asString value |> ofStr ]]
    member _.strong (value: 'Node) = mk "strong" [ofNodes [ value ]]
    member _.strong (value: string) = mk "strong" [ofNodes [ ofStr value ]]
    member _.strong (children: seq<'Attr>) = mk "strong" children
    member _.strong (children) = mk "strong" [ ofNodes children  ]

    member _.style (value: string) = mk "style" [ofNodes [ ofStr value ]]

    member _.sub (value: float) = mk "sub" [ofNodes [ Util.asString value |> ofStr ]]
    member _.sub (value: int) = mk "sub" [ofNodes [ Util.asString value |> ofStr ]]
    member _.sub (value: 'Node) = mk "sub" [ofNodes [ value ]]
    member _.sub (value: string) = mk "sub" [ofNodes [ ofStr value ]]
    member _.sub (children: seq<'Attr>) = mk "sub" children
    member _.sub (children) = mk "sub" [ ofNodes children  ]

    member _.summary (value: float) = mk "summary" [ofNodes [ Util.asString value |> ofStr ]]
    member _.summary (value: int) = mk "summary" [ofNodes [ Util.asString value |> ofStr ]]
    member _.summary (value: 'Node) = mk "summary" [ofNodes [ value ]]
    member _.summary (value: string) = mk "summary" [ofNodes [ ofStr value ]]
    member _.summary (children: seq<'Attr>) = mk "summary" children
    member _.summary (children) = mk "summary" [ ofNodes children  ]

    member _.sup (value: float) = mk "sup" [ofNodes [ Util.asString value |> ofStr ]]
    member _.sup (value: int) = mk "sup" [ofNodes [ Util.asString value |> ofStr ]]
    member _.sup (value: 'Node) = mk "sup" [ofNodes [ value ]]
    member _.sup (value: string) = mk "sup" [ofNodes [ ofStr value ]]
    member _.sup (children: seq<'Attr>) = mk "sup" children
    member _.sup (children) = mk "sup" [ ofNodes children  ]

    member _.table (children: seq<'Attr>) = mk "table" children
    member _.table (children) = mk "table" [ ofNodes children  ]

    member _.tableBody (children: seq<'Attr>) = mk "tbody" children
    member _.tableBody (children) = mk "tableBody" [ ofNodes children  ]

    member _.tableCell (children: seq<'Attr>) = mk "td" children
    member _.tableCell (children) = mk "tableCell" [ ofNodes children  ]

    member _.tableHeader (children: seq<'Attr>) = mk "th" children
    member _.tableHeader (children) = mk "tableHeader" [ ofNodes children  ]

    member _.tableRow (children: seq<'Attr>) = mk "tr" children
    member _.tableRow (children) = mk "tableRow" [ ofNodes children  ]

    member _.tbody (children: seq<'Attr>) = mk "tbody" children
    member _.tbody (children) = mk "tbody" [ ofNodes children  ]

    member _.td (value: float) = mk "td" [ofNodes [ Util.asString value |> ofStr ]]
    member _.td (value: int) = mk "td" [ofNodes [ Util.asString value |> ofStr ]]
    member _.td (value: 'Node) = mk "td" [ofNodes [ value ]]
    member _.td (value: string) = mk "td" [ofNodes [ ofStr value ]]
    member _.td (children: seq<'Attr>) = mk "td" children
    member _.td (children) = mk "td" [ ofNodes children  ]

    member _.template (children: seq<'Attr>) = mk "template" children
    member _.template (children) = mk "template" [ ofNodes children  ]

    member _.textarea (children: seq<'Attr>) = mk "textarea" children
    member _.textarea (children) = mk "textarea" [ ofNodes children  ]

    member _.tfoot (children: seq<'Attr>) = mk "tfoot" children
    member _.tfoot (children) = mk "tfoot" [ ofNodes children  ]

    member _.th (value: float) = mk "th" [ofNodes [ Util.asString value |> ofStr ]]
    member _.th (value: int) = mk "th" [ofNodes [ Util.asString value |> ofStr ]]
    member _.th (value: 'Node) = mk "th" [ofNodes [ value ]]
    member _.th (value: string) = mk "th" [ofNodes [ ofStr value ]]
    member _.th (children: seq<'Attr>) = mk "th" children
    member _.th (children) = mk "th" [ ofNodes children  ]

    member _.thead (children: seq<'Attr>) = mk "thead" children
    member _.thead (children) = mk "thead" [ ofNodes children  ]

    member _.time (children: seq<'Attr>) = mk "time" children
    member _.time (children) = mk "time" [ ofNodes children  ]

    member _.tr (children: seq<'Attr>) = mk "tr" children
    member _.tr (children) = mk "tr" [ ofNodes children  ]

    member _.track (children: seq<'Attr>) = mk "track" children
    member _.track (children) = mk "track" [ ofNodes children  ]

    member _.u (value: float) = mk "u" [ofNodes [ Util.asString value |> ofStr ]]
    member _.u (value: int) = mk "u" [ofNodes [ Util.asString value |> ofStr ]]
    member _.u (value: 'Node) = mk "u" [ofNodes [ value ]]
    member _.u (value: string) = mk "u" [ofNodes [ ofStr value ]]
    member _.u (children: seq<'Attr>) = mk "u" children
    member _.u (children) = mk "u" [ ofNodes children  ]

    member _.ul (children: seq<'Attr>) = mk "ul" children
    member _.ul (children) = mk "ul" [ ofNodes children  ]

    member _.unorderedList (children: seq<'Attr>) = mk "ul" children
    member _.unorderedList (children) = mk "unorderedList" [ ofNodes children  ]

    member _.var (value: float) = mk "var" [ofNodes [ Util.asString value |> ofStr ]]
    member _.var (value: int) = mk "var" [ofNodes [ Util.asString value |> ofStr ]]
    member _.var (value: 'Node) = mk "var" [ofNodes [ value ]]
    member _.var (value: string) = mk "var" [ofNodes [ ofStr value ]]
    member _.var (children: seq<'Attr>) = mk "var" children
    member _.var (children) = mk "var" [ ofNodes children  ]

    member _.video (children: seq<'Attr>) = mk "video" children
    member _.video (children) = mk "video" [ ofNodes children  ]

    member _.wbr (children: seq<'Attr>) = mk "wbr" children
    member _.wbr (children) = mk "wbr" [ ofNodes children  ]
