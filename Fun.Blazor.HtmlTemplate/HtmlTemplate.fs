[<AutoOpen>]
module Fun.Blazor.HtmlTemplate

open System
open System.IO
open System.Text
open FSharp.Data
open Microsoft.FSharp.Quotations
open Microsoft.FSharp.Quotations.Patterns
open FSharp.Quotations.Evaluator


type Template =
    static member html(_: string) = Bolero.Empty


let private parseStringTemplate (str: string) (holes: Expr list) =
    let getLambda index =
        match holes.[index] with
        | Call (_, _, [ exp ]) ->
            match exp with
            | Lambda (_, _) -> exp.EvaluateUntyped()
            | _ -> raise (exn "Should be a lambda")
        | _ -> raise (exn "Should be a lambda")

    let makeNode (ty: Type) v =
        if ty = typeof<Bolero.Node> then v |> unbox<Bolero.Node>
        elif ty = typeof<string> then v |> unbox<string> |> Bolero.Text
        elif ty = typeof<int> then v |> unbox<int> |> string |> Bolero.Text
        elif ty = typeof<float> then v |> unbox<float> |> string |> Bolero.Text
        else raise (exn "Unsupportted")

    let getNode index =
        match holes.[index] with
        | Call (_, _, [ PropertyGet (_, prop, _) ]) -> makeNode prop.PropertyType (holes.[index].EvaluateUntyped())
        | Call (_, _, [ Value (v, ty) ]) -> makeNode ty v
        | _ -> raise (exn "Unsupportted")


    use stream = new MemoryStream(Encoding.UTF8.GetBytes str)
    let doc = HtmlDocument.Load stream

    let mutable index = -1

    let rec loop (nodes: HtmlNode seq) =
        [
            for e in nodes do
                let name = e.Name()
                if String.IsNullOrEmpty name then
                    Bolero.Text(e.ToString())
                else
                    Bolero.Elt(
                        name,
                        [
                            for attr in e.Attributes() do
                                let name = attr.Name()
                                let value = attr.Value()
                                if name.StartsWith "on" && value = "%P()" then
                                    index <- index + 1
                                    Bolero.Html.on.event name (getLambda index |> unbox)
                                else
                                    Bolero.Attr(name, value)
                        ],
                        [
                            for child in e.Descendants() do
                                if String.IsNullOrEmpty(child.Name()) |> not then
                                    yield! loop [ child ]
                                else
                                    for i, txt in child.ToString().Split("%P()") |> Seq.indexed do
                                        if i > 0 then
                                            index <- index + 1
                                            getNode index
                                        let trimedTxt = txt.Trim()
                                        if String.IsNullOrEmpty trimedTxt |> not then Bolero.Text trimedTxt
                        ]
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
    | _ -> raise (exn "Not supported")


let HtmlTemplate (exp: Expr) =
    match exp with
    | Call (_, methodInfo, exps) ->
        if methodInfo.ReturnType = typeof<Bolero.Node> then
            parseFormatStringExpr exps
        elif methodInfo.Name.StartsWith "PrintFormatToString" then
            parseFormatStringExpr exps
        else
            raise (exn "Not supported")
    | _ -> raise (exn "Not supported")
