[<AutoOpen>]
module Fun.Blazor.FelizDsl

open System
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Routing


type FunBlazorSvgEngine(mk, ofStr, empty) =
    inherit Feliz.SvgEngine<NodeRenderFragment>(mk, ofStr, empty)


type html with

    static member route(render: string list -> NodeRenderFragment) =
        html.inject (fun (hook: IComponentHook, nav: NavigationManager, interception: INavigationInterception) ->
            let location = cval nav.Uri

            hook.OnFirstAfterRender.Add(fun () ->
                interception.EnableNavigationInterceptionAsync() |> ignore
                nav.LocationChanged.Subscribe(fun e ->
                    try
                        location.Publish e.Location
                    with
                    | _ -> ()
                )
                |> hook.AddDispose
            )

            adaptiview () {
                let! location = location
                RouterUtils.urlSegments (Uri location).PathAndQuery RouteMode.Path |> render
            }
        )


let svg =
    FunBlazorSvgEngine((fun tag nodes -> EltWithChildBuilder tag { yield! nodes }), html.text, Internal.emptyNode)

let attr =
    FunBlazorAttrEngine((fun k v -> k => v), (fun k v -> if v then k => null else Internal.emptyAttr ()))

/// Feliz is not recommend, so will reserve style for CE builder
/// If you do not use CE build, you can just create an alias "style" for styl
let styl = Feliz.CssEngine(fun k v -> k, v)
