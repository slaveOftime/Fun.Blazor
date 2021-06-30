[<AutoOpen>]
module Fun.Blazor.Router.GiraffeDsl

open Giraffe.FormatExpressions
open Microsoft.AspNetCore.WebUtilities


type RouteUrl = string

type Router<'View> = RouteUrl -> 'View Option


let private getUrlMainPath (url: string) =
    let index = url.IndexOf '?'
    if index > -1 then url.Substring(0, index)
    else url

let private getQuery (url: string) =
    let spliterIndex = url.IndexOf '?'
    if spliterIndex > -1 then url.Substring(spliterIndex + 1)
    else ""


/// Find the first matched router in the list
let choose<'View> (routes: Router<'View> list): Router<'View> =
    fun url ->
        routes
        |> List.tryPick (fun router -> router url)


/// Check the start of the url for the parttern and ignore case sensitive
let subRouteCi (pattern: string) routes: Router<'View> =
    fun url ->
        if url.ToLower().StartsWith (pattern.ToLower()) then
            choose routes (url.Substring(pattern.Length))
        else
            None


/// Exact match the url and ignore case sensitive
let routeCi (pattern: string) view: Router<'View> =
    fun url ->
        if (getUrlMainPath url).ToLower() = pattern.ToLower() then
            Some view
        elif (url = "" || url = "/") && pattern = "" then
            Some view
        else
            None

/// Match the url, extract parameters and ignore case sensitive
let routeCif (path: PrintfFormat<_,_,_,_, 'T>) viewFn: Router<'View> =
    fun url ->
        let option = { IgnoreCase = true; MatchMode = MatchMode.StartsWith }
        tryMatchInput path option (getUrlMainPath url)
        |> Option.map viewFn

/// Match the url, extract parameters and query strings and ignore case sensitive
let routeCiWithQuery (pattern: string) view: Router<'View> =
    fun url ->
        if (getUrlMainPath url).ToLower() = pattern.ToLower() ||
           (url = "" || url = "/") && pattern = ""
        then
            let query = getQuery url
            Some (view query)
        else
            None
  
/// Match the url, extract parameters and query strings and ignore case sensitive
let routeCifWithQuery (path: PrintfFormat<_,_,_,_, 'T>) view: Router<'View> =
    fun url ->
        let option = { IgnoreCase = true; MatchMode = MatchMode.StartsWith }
        let spliterIndex = url.IndexOf '?'
        let newUrl =
            if spliterIndex > -1 then url.Substring(0, spliterIndex)
            else url
        let query =
            if spliterIndex > -1 then url.Substring(spliterIndex + 1)
            else ""
        tryMatchInput path option newUrl
        |> Option.map (fun v -> view v query)

let routeCifWithQueries path view: Router<'View> =
    routeCifWithQuery
        (path)
        (fun routeParams query ->
            let queries = QueryHelpers.ParseNullableQuery query |> Seq.map (|KeyValue|) |> Map.ofSeq 
            view routeParams queries)


let routeCiWithQueries path view: Router<'View> =
    routeCiWithQuery
        (path)
        (QueryHelpers.ParseNullableQuery >> Seq.map (|KeyValue|) >> Map.ofSeq >> view)


/// Match any url
let routeAny view: Router<'View> =
    fun _ -> Some view

