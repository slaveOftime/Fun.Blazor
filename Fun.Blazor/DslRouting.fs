[<AutoOpen>]
module Fun.Blazor.DslRouting

open System
open FSharp.Data.Adaptive
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Routing
open Fun.Blazor.Router
open Internal


type html with

    /// By default we will set key for this component.
    static member route(routes: Router<NodeRenderFragment> list, ?key: obj) =
        html.inject (
            defaultArg key "fun-blazor-routers",
            fun (hook: IComponentHook, nav: NavigationManager, interception: INavigationInterception) ->
                let location = cval (Uri nav.Uri).PathAndQuery

                hook.OnFirstAfterRender.Add(fun () ->
                    interception.EnableNavigationInterceptionAsync() |> ignore
                    nav.LocationChanged.Subscribe(fun e ->
                        try
                            location.Publish (Uri e.Location).PathAndQuery
                        with
                        | _ -> ()
                    )
                    |> hook.AddDispose
                )

                adaptiview () {
                    let! location = location
                    choose routes location |> Option.defaultWith emptyNode
                }
        )

    static member route(key: obj, routes: Router<NodeRenderFragment> list) = html.route (routes, key = key)
