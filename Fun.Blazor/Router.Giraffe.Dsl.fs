[<AutoOpen>]
module Fun.Blazor.Router.GiraffeDsl

open System
open Giraffe.FormatExpressions
open Microsoft.AspNetCore.WebUtilities

open type System.Net.WebUtility


type RouteUrl = string

type Router<'View> = RouteUrl -> 'View Option


let tailIndicator = "{*}"

let private getUrlMainPath (url: string) =
    let index = url.IndexOf '?'
    if index > -1 then url.Substring(0, index) else url

let private getQuery (url: string) =
    let spliterIndex = url.IndexOf '?'
    if spliterIndex > -1 then url.Substring(spliterIndex + 1) else ""


/// Find the first matched router in the list
let choose<'View> (routes: Router<'View> seq) : Router<'View> = fun url -> routes |> Seq.tryPick (fun router -> router url)


/// Check the start of the url for the parttern and ignore case sensitive
let subRouteCi (pattern: string) routes : Router<'View> =
    fun url ->
        if UrlDecode(url.ToLower()).StartsWith(pattern.ToLower()) then
            choose routes (url.Substring(pattern.Length))
        else
            None


/// Exact match the url and ignore case sensitive
let routeCi (pattern: string) view : Router<'View> =
    fun url ->
        let url = UrlDecode((getUrlMainPath url))

        let isMatch =
            if pattern.Contains tailIndicator then
                let pattern = pattern.Substring(0, pattern.IndexOf tailIndicator)
                url.StartsWith(pattern, StringComparison.OrdinalIgnoreCase)
            else
                url.Equals(pattern, StringComparison.OrdinalIgnoreCase)

        if isMatch then Some view
        elif (url = "" || url = "/") && pattern = "" then Some view
        else None


/// Match the url, extract parameters and ignore case sensitive
let routeCif (path: PrintfFormat<_, _, _, _, 'T>) viewFn : Router<'View> =
    fun url ->
        let url = UrlDecode((getUrlMainPath url))
        let path =
            if path.Value.Contains tailIndicator then
                path.Value.Substring(0, path.Value.IndexOf tailIndicator)
            else
                path.Value
        let option = { IgnoreCase = true; MatchMode = MatchMode.StartsWith }
        tryMatchInput<'T> path option url |> Option.map viewFn


/// Match the url, extract parameters and query strings and ignore case sensitive
let routeCiWithQuery (pattern: string) view : Router<'View> =
    fun url ->
        if UrlDecode((getUrlMainPath url)).ToLower() = pattern.ToLower()
           || (url = "" || url = "/") && pattern = "" then
            let query = getQuery url
            Some(view query)
        else
            None

/// Match the url, extract parameters and query strings and ignore case sensitive
let routeCifWithQuery (path: PrintfFormat<_, _, _, _, 'T>) view : Router<'View> =
    fun url ->
        let option = { IgnoreCase = true; MatchMode = MatchMode.StartsWith }
        let spliterIndex = url.IndexOf '?'
        let newUrl = if spliterIndex > -1 then url.Substring(0, spliterIndex) else url
        let query = if spliterIndex > -1 then url.Substring(spliterIndex + 1) else ""
        tryMatchInput<'T> path.Value option newUrl |> Option.map (fun v -> view v query)

let routeCifWithQueries path view : Router<'View> =
    routeCifWithQuery
        (path)
        (fun routeParams query ->
            let queries =
                try
                    QueryHelpers.ParseNullableQuery query |> Seq.map (|KeyValue|) |> Map.ofSeq
                with
                | _ -> Map.empty
            view routeParams queries
        )

let routeCiWithQueries path view : Router<'View> =
    routeCiWithQuery
        (path)
        (fun query ->
            let quries =
                try
                    QueryHelpers.ParseNullableQuery query |> Seq.map (|KeyValue|) |> Map.ofSeq
                with
                | _ -> Map.empty
            view quries
        )


/// Match any url
let routeAny view : Router<'View> = fun _ -> Some view
