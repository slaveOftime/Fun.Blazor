namespace Fun.Blazor.CustomElements

open System
open System.Text
open Fun.Blazor


type Utils =
    static member private ToSnakeCase(text: string) =
        if text = null || text.Length < 2 then
            text
        else
            let sb = StringBuilder()

            sb.Append(Char.ToLowerInvariant(text[0])) |> ignore

            for c in text |> Seq.skip 1 do
                if Char.IsUpper(c) then
                    sb.Append('-').Append(Char.ToLowerInvariant(c)) |> ignore
                else
                    sb.Append(c) |> ignore

            sb.ToString()


    static member GetTagNameForType(componentType: Type, ?failIfWithoutFunBlazorCustomElementAttribute) =
        let failIfWithoutFunBlazorCustomElementAttribute =
            defaultArg failIfWithoutFunBlazorCustomElementAttribute false

        let ceAttr =
            componentType.GetCustomAttributes(typeof<FunBlazorCustomElementAttribute>, false)
            |> Seq.tryHead
            |> Option.map (fun x -> x :?> FunBlazorCustomElementAttribute)

        match ceAttr with
        | None when failIfWithoutFunBlazorCustomElementAttribute ->
            failwith $"Component must add attribute {nameof (FunBlazorCustomElementAttribute)}"

        | Some ceAttr when not (String.IsNullOrEmpty ceAttr.TagName) -> ceAttr.TagName

        | _ -> Utils.ToSnakeCase componentType.Name
