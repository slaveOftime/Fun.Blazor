[<AutoOpen>]
module Fun.Blazor.Docs.Controls.BasicControls

open Microsoft.AspNetCore.Components.Web
open MudBlazor
open Fun.Blazor


let private spaceV (x: int) = div { style { height x } }

let private spaceH (x: int) = span { style { width x } }

let spaceV1 = spaceV 2
let spaceV2 = spaceV 6
let spaceV3 = spaceV 10
let spaceV4 = spaceV 16

let spaceH1 = spaceH 2
let spaceH2 = spaceH 6
let spaceH3 = spaceH 10
let spaceH4 = spaceH 16


let linearProgress =
    MudProgressLinear'' {
        Indeterminate true
        Color Color.Primary
    }


let notFound = div {
    style { padding 20 }
    MudText'' {
        Typo Typo.subtitle1
        "Content not found"
    }
}


let errorBundary (views: NodeRenderFragment) =
    ErrorBoundary'() {
        ErrorContent(fun ex ->
            MudPaper'' {
                style {
                    padding 10
                    margin 20
                }
                Elevation 10
                childContent [|
                    MudText'' {
                        Color Color.Error
                        Typo Typo.subtitle1
                        "Some error hanppened, you can try to refresh."
                    }
                    spaceV4
                    MudAlert'' {
                        Severity Severity.Error
                        ex.Message
                    }
                |]
            }
        )
        views
    }
