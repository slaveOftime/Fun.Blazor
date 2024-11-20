namespace Fun.Htmx

open Fun.Blazor

/// A component return empty content, so htmx can use it to make some content empty. And it will be cached.
[<ComponentResponseCache(CacheControl = "public, max-age=2147483647")>]
type EmptyComp() =
    inherit FunComponent()

    override _.Render() = html.none
