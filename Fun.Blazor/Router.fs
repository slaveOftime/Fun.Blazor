/// Source from https://github.com/Zaid-Ajaj/Feliz.Router/blob/master/src/Router.fs

namespace Fun.Blazor

open System
open System.Net
open Microsoft.AspNetCore.WebUtilities


[<RequireQualifiedAccess>]
type RouteMode =
    | Hash = 1
    | Path = 2


[<RequireQualifiedAccess; System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>]
module Router =

    [<RequireQualifiedAccess>]
    module String =
        let (|Prefix|) (prefix: string) (str: string) =
            if str.StartsWith prefix then Some str
            else None

        let (|Suffix|) (suffix: string) (str: string) =
            if str.EndsWith suffix then Some str
            else None

        let inline split (sep: char) (str: string) =
            str.Split(sep)

    let inline hashPrefix str = "#/" + str
    let inline combine xs = String.concat "/" xs

    let encodeURIComponent = WebUtility.UrlEncode
    let decodeURIComponent = WebUtility.UrlDecode

    let encodeQueryString queryStringPairs =
        queryStringPairs
        |> List.map (fun (key, value) ->
            String.concat "=" [ encodeURIComponent key; encodeURIComponent value ])
        |> String.concat "&"
        |> function
            | "" -> ""
            | pairs -> "?" + pairs

    let encodeQueryStringInts queryStringIntPairs =
        queryStringIntPairs
        |> List.map (fun (key, value: int) ->
            String.concat "=" [ encodeURIComponent key; unbox<string> value ])
        |> String.concat "&"
        |> function
            | "" -> ""
            | pairs -> "?" + pairs

    let private normalizeRoute routeMode =
        if routeMode = RouteMode.Hash then
            function
            | String.Prefix "/" (Some path) -> "#" + path
            | String.Prefix "#/" (Some path) -> path
            | String.Prefix "#" (Some path) -> "#/" + path.Substring(1, path.Length - 1)
            | path -> "#/" + path
        else
            function
            | String.Prefix "/" (Some path) -> path
            | path -> "/" + path

    let encodeParts xs routeMode =
        xs
        |> List.map (fun (part: string) ->
            if part.Contains "?" || part.StartsWith "#" || part.StartsWith "/" then part
            else encodeURIComponent part)
        |> combine
        |> normalizeRoute routeMode

    /// Safely returns tuple of list items without last one and last item
    let trySeparateLast xs =
        match xs |> List.rev with
        | [] -> None
        | [ single ] -> Some([], single)
        | list -> Some (list |> List.tail |> List.rev, list.Head)


    let urlSegments (path: string) (mode: RouteMode) =
        match path with
        | String.Prefix "#" (Some _) ->
            // remove the hash sign
            path.Substring(1, path.Length - 1)
        | _ when mode = RouteMode.Hash ->
            match path with
            | String.Suffix "#" (Some _)
            | String.Suffix "#/" (Some _) -> ""
            | _ -> path
        | _ -> path
        |> String.split '/'
        |> List.ofArray
        |> List.collect (fun segment ->
            if String.IsNullOrWhiteSpace segment then []
            else
                let segment = segment.TrimEnd '#'

                match segment with
                | "?" -> []
                | String.Prefix "?" (Some _) -> [ segment ]
                | _ ->
                    match segment.Split [| '?' |] with
                    | [| value |] -> [ decodeURIComponent value ]
                    | [| value; "" |] -> [ decodeURIComponent value ]
                    | [| value; query |] -> [ decodeURIComponent value; "?" + query ]
                    | _ -> [])


module Route =
    let (|Int|_|) (input: string) =
        match Int32.TryParse input with
        | true, value -> Some value
        | _ -> None

    let (|Int64|_|) (input: string) =
        match Int64.TryParse input with
        | true, value -> Some value
        | _ -> None

    let (|Guid|_|) (input: string) =
        match Guid.TryParse input with
        | true, value -> Some value
        | _ -> None

    let (|Number|_|) (input: string) =
        match Double.TryParse input with
        | true, value -> Some value
        | _ -> None

    let (|Decimal|_|) (input: string) =
        match Decimal.TryParse input with
        | true, value -> Some value
        | _ -> None

    let (|Bool|_|) (input: string) =
        match input.ToLower() with
        | ("1"|"true")  -> Some true
        | ("0"|"false") -> Some false
        | "" -> Some true
        | _ -> None

    /// Used to parse the query string parameter of the route.
    ///
    /// For example to match against
    ///
    /// `/users?id={value}`
    ///
    /// You can pattern match:
    ///
    /// `[ "users"; Route.Query [ "id", value ] ] -> value`
    ///
    /// When `{value}` is an integer then you can pattern match:
    ///
    /// `[ "users"; Route.Query [ "id", Route.Int userId ] ] -> userId`
    let (|Query|_|) (input: string) =
        try
            QueryHelpers.ParseQuery input
            |> Seq.map (fun kv -> kv.Key, kv.Value.ToString())
            |> Seq.toList
            |> Some 
        with
        | _ -> None
