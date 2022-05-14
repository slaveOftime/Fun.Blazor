// hot-reload
module Fun.Blazor.Docs.Wasm.Demos.GiraffeStyleRouter

open MudBlazor
open Fun.Blazor
open Fun.Blazor.Router
open Fun.Blazor.Docs.Controls


let private formatQueries =
    Map.toList >> List.map (fun (k, v) -> $"key = {k}, value = {v}") >> String.concat "; "

let private routerView (msg: string) =
    MudContainer'() {
        MudPaper'() {
            style { padding 20 }
            Elevation 5
            MudText'() {
                Typo Typo.subtitle1
                "This is fr om GiraffeStyleRouter"
            }
            spaceV1
            MudText'() {
                Typo Typo.caption
                msg
            }
        }
    }


// This will be added to Fun.Blazor.Docs.Wasm/App.fs
let demoRouting =
    subRouteCi
        "/router"
        [
            routeCi "/document" (routerView "Dcoument page")
            routeCif "/document/%i" (fun x -> routerView $"Document {x}")
            routeCiWithQueries "/documents" (fun queries -> routerView $"Documents with query: {formatQueries queries}")
            routeCifWithQueries "/documents/%s" (fun param queries -> routerView $"Documents(Param: {param}) with query: {formatQueries queries}")
        ]


let entry =
    let link (hrefStr: string) (name': string) =
        MudLink'() {
            style { marginRight 10 }
            Href hrefStr
            Underline Underline.Always
            name'
        }

    div.create [
        MudText'() {
            Typo Typo.subtitle2
            Color Color.Secondary
        }
        link "./router/document" "Route to document"
        link "./router/document/12" "Route to document 12"
        link "./router/documents?filter=test&q2=2" "Route to documents with query"
        link "./router/documents/fun-blazor?filter=test&q2=2" "Route to documents with query"
    ]
