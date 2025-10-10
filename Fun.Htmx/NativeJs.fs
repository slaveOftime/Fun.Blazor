namespace Fun.Htmx

open Fun.Blazor


type NativeJs =
    /// Native script for updating queries
    static member UpdateQueries(?queriesToAdd: (string * obj) seq, ?queriesToDelete: string seq) =
        let queriesToAdd =
            queriesToAdd
            |> Option.defaultValue []
            |> Seq.map (fun (k, v) -> sprintf $"query.set('{k}', '{v}')")
            |> String.concat "; "

        let queriesToDelete =
            queriesToDelete |> Option.defaultValue [] |> Seq.map (fun k -> sprintf $"query.delete('{k}')") |> String.concat "; "

        $$"""
        (function(){
            const query = new URLSearchParams(window.location.search);
            {{queriesToDelete}}
            {{queriesToAdd}}
            const queryStr = query.toString();
            window.history.replaceState(null, null, window.location.pathname + (!!queryStr ? ('?' + queryStr) : ''));
        })()"""

    /// Native script directly for updating queries
    static member UpdateQueries(query: string) =
        $$"""
        (function(){
            const queryStr = '{{query}}';
            window.history.replaceState(null, null, window.location.pathname + (!!queryStr ? ('?' + queryStr) : ''));
        })()"""

    /// Native script directly for updating queries
    static member UpdateQueries(query: QueryBuilder<_>) = NativeJs.UpdateQueries(query.ToString())

    
    /// Native script directly  for updating queries. 
    /// This should be used together with hxOnHtmx like: hxOnHtmx hxEvt.configRequest (Js.AddQueriesToHtmxParams())
    static member AddQueriesToHtmxParams(?overwrite: bool) =
        let overwrite = defaultArg overwrite false
        $$"""
        (function(){
            const overwrite = {{overwrite.ToString().ToLower()}};
            const query = new URLSearchParams(document.location.search);     
            for(const key of query.keys()) {
                if (!event.detail.parameters[key] || overwrite) {
                    event.detail.parameters[key] = query.get(key);
                }
            }
        })()"""


    /// Native script for setting location href.
    static member GoTo(url: string) = $"window.location.href = '{url}';"

    /// Native script for reloading current page.
    static member ReloadPage() = $"window.location.reload();"

    /// Native script for going back in history.
    static member GoBack() = "window.history.back();"
