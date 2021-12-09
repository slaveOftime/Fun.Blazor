namespace Fun.Blazor

open System
open HtmlTemplate.Internals


type Template =
    static member html(html: FormattableString) =
        caches.GetOrAdd(html.Format.GetHashCode(), (fun _ -> parseNodes html.Format))
        |> buildNodeTree (html.GetArguments())
        |> Bolero.ForEach
