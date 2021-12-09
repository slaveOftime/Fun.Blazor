[<AutoOpen>]
module Fun.Blazor.HtmlTemplate

open System
open System.IO
open System.Text
open FSharp.Data
open Microsoft.FSharp.Quotations
open Microsoft.FSharp.Quotations.Patterns
open FSharp.Quotations.Evaluator


let private makeNode (ty: Type) v =
    if ty = typeof<Bolero.Node> then
        v |> unbox<Bolero.Node>
    else
        v.ToString() |> Bolero.Text


let private parseStringTemplate (str: string) (holes: Expr list) =
    let getFunc index =
        match holes.[index] with
        | Call (_, _, [ exp ]) ->
            match exp with
            | Lambda (_, _)
            | Call (_, _, _) -> exp.EvaluateUntyped()
            | _ -> failwith "Expecting a function or lambda"
        | _ -> failwith "Expecting a function or lambda"

    let getNode index =
        match holes.[index] with
        | Call (_, _, [ PropertyGet (_, prop, _) ]) -> makeNode prop.PropertyType (holes.[index].EvaluateUntyped())
        | Call (_, _, [ Value (v, ty) ]) -> makeNode ty v
        | Call _ ->
            match tryUnbox<Bolero.Node> (holes.[index].EvaluateUntyped()) with
            | Some v -> v
            | None -> failwith "Expecting a node"
        | _ -> failwith "Expecting a node"

    let inline invokeFunction (fn: obj) (x: obj) =
        fn.GetType().InvokeMember("Invoke", Reflection.BindingFlags.InvokeMethod, null, fn, [| x |])


    // TODO: implement cache

    use stream = new MemoryStream(Encoding.UTF8.GetBytes str)
    let doc = HtmlDocument.Load stream

    let mutable index = -1

    let rec loop (nodes: HtmlNode seq) =
        [
            for node in nodes do
                let name = node.Name()
                if String.IsNullOrEmpty name then
                    for i, txt in node.ToString().Split("%P()") |> Seq.indexed do
                        if i > 0 then
                            index <- index + 1
                            getNode index
                        let trimedTxt = txt.Trim()
                        if String.IsNullOrEmpty trimedTxt |> not then Bolero.Text trimedTxt
                else
                    Bolero.Elt(
                        name,
                        [
                            for attr in node.Attributes() do
                                let name = attr.Name()
                                let value = attr.Value()
                                if name.StartsWith "on" && value = "%P()" then
                                    index <- index + 1
                                    let lambda = getFunc index
                                    Bolero.Html.attr.callback name (fun x -> invokeFunction lambda x :?> unit)
                                else
                                    Bolero.Attr(name, value)
                        ],
                        loop (node.Elements())
                    )
        ]

    doc.Elements() |> loop |> Bolero.ForEach


let private parseFormatStringExpr (exps: Expr list) =
    match exps with
    | [ Call (_, _, [ NewObject (_, Value (stringTemplate, _) :: tail) ]) ]
    | [ NewObject (_, Value (stringTemplate, _) :: tail) ] ->
        let holes =
            match tail with
            | NewArray (_, exps) :: _ -> exps
            | _ -> []
        parseStringTemplate (string stringTemplate) holes
    | [ Value (v, _) ] -> parseStringTemplate (string v) []
    | _ -> failwith "Not supported"


let private htmlTemplate (exp: Expr) =
    match exp with
    | Call (_, methodInfo, exps) ->
        if methodInfo.ReturnType = typeof<Bolero.Node> then
            parseFormatStringExpr exps
        elif methodInfo.Name.StartsWith "PrintFormatToString" then
            parseFormatStringExpr exps
        else
            failwith "Expression is not supported"
    | Value (v, ty) when ty = typeof<String> -> parseStringTemplate (unbox v) []
    | _ -> failwith "Expression is not supported"


type Template =
    static member html(_: string) = Bolero.Empty
    static member html exp = htmlTemplate exp
