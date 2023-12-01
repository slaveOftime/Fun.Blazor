[<AutoOpen>]
module Fun.Blazor.DslRouting

open System
open System.Reflection
open System.Threading.Tasks
open System.Collections.Generic
open System.Diagnostics.CodeAnalysis
open FSharp.Data.Adaptive
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Routing
open Fun.Blazor.Router
open Fun.Blazor.Operators
open Internal


/// A component that supplies route data corresponding to the current navigation state.
type Router' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Router>)>] () =
    inherit ComponentBuilder<Router>()

    /// Gets or sets the assembly that should be searched for components matching the URI.
    [<CustomOperation("AppAssembly")>]
    member inline _.AppAssembly([<InlineIfLambda>] render: AttrRenderFragment, x: Assembly) = render ==> ("AppAssembly" => x)

    /// Gets or sets a collection of additional assemblies that should be searched for components
    [<CustomOperation("AdditionalAssemblies")>]
    member inline _.AdditionalAssemblies([<InlineIfLambda>] render: AttrRenderFragment, x: IEnumerable<Assembly>) =
        render ==> ("AdditionalAssemblies" => x)

    /// Gets or sets the content to display when no match is found for the requested route.
    [<CustomOperation("Found")>]
    member inline _.Found([<InlineIfLambda>] render: AttrRenderFragment, createNode: RouteData -> NodeRenderFragment) =
        render ==> html.renderFragment<RouteData> ("Found", createNode)

    /// Gets or sets the content to display when a match is found for the requested route.
    [<CustomOperation("NotFound")>]
    member inline _.NotFound([<InlineIfLambda>] render: AttrRenderFragment, node: NodeRenderFragment) =
        render ==> html.renderFragment ("NotFound", node)

    /// Get or sets the content to display when asynchronous navigation is in progress.
    [<CustomOperation("Navigating")>]
    member inline _.Navigating([<InlineIfLambda>] render: AttrRenderFragment, node: NodeRenderFragment) =
        render ==> html.renderFragment ("Navigating", node)

    /// Gets or sets a handler that should be called before navigating to a new page.
    [<CustomOperation("OnNavigateAsync")>]
    member inline _.OnNavigateAsync([<InlineIfLambda>] render: AttrRenderFragment, fn: NavigationContext -> Task<unit>) =
        render ==> html.callbackTask ("OnNavigateAsync", fn)

/// Displays the specified page component, rendering it inside its layout and any further nested layouts.
type RouteView' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<RouteView>)>] () =
    inherit ComponentBuilder<RouteView>()

    /// Gets or sets the route data.
    /// This determines the page that will be displayed and the parameter values that will be supplied to the page.
    [<CustomOperation("RouteData")>]
    member inline _.RouteData([<InlineIfLambda>] render: AttrRenderFragment, x: RouteData) = render ==> ("RouteData" => x)

    /// <summary>
    /// Gets or sets the type of a layout to be used if the page does not
    /// declare any layout. If specified, the type must implement <see cref="T:Microsoft.AspNetCore.Components.IComponent" />
    /// and accept a parameter named <see cref="P:Microsoft.AspNetCore.Components.LayoutComponentBase.Body" />.
    /// </summary>
    [<CustomOperation("DefaultLayout")>]
    member inline _.DefaultLayout([<InlineIfLambda>] render: AttrRenderFragment, x: Type) = render ==> ("DefaultLayout" => x)

/// <summary>
/// After navigating from one page to another, sets focus to an element
/// matching a CSS selector. This can be used to build an accessible
/// navigation system compatible with screen readers.
/// </summary>
type FocusOnNavigate' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<FocusOnNavigate>)>] () =
    inherit ComponentBuilder<FocusOnNavigate>()

    /// Gets or sets the route data.
    [<CustomOperation("RouteData")>]
    member inline _.RouteData([<InlineIfLambda>] render: AttrRenderFragment, x: RouteData) = render ==> ("RouteData" => x)

    /// Gets or sets a CSS selector describing the element to be focused after navigation between pages.
    [<CustomOperation("Selector")>]
    member inline _.Selector([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("Selector" => x)


type html with

    /// By default we will set key (fun-blazor-routers) for this component. So it can keep it's state when its parent rerender. 
    /// And only rerender when location is changed.
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
