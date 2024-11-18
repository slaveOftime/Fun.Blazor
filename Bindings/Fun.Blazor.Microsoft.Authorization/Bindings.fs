namespace Microsoft.AspNetCore.Components.Authorization


[<AutoOpen>]
module Bindings =
  
    open System
    open System.Diagnostics.CodeAnalysis
    open Microsoft.AspNetCore.Components
    open Microsoft.AspNetCore.Components.Authorization
    open Fun.Blazor
    open Fun.Blazor.Operators

    /// <summary>
    /// Combines the behaviors of <see cref="T:Microsoft.AspNetCore.Components.Authorization.AuthorizeView" /> and <see cref="T:Microsoft.AspNetCore.Components.RouteView" />,
    /// so that it displays the page matching the specified route but only if the user
    /// is authorized to see it.
    ///
    /// Additionally, this component supplies a cascading parameter of type <see cref="T:System.Threading.Tasks.Task`1" />,
    /// which makes the user's current authentication state available to descendants.
    /// </summary>
    type AuthorizeRouteView' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AuthorizeRouteView>)>] () = 
        inherit ComponentBuilder<AuthorizeRouteView>()
        
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
        /// The content that will be displayed if the user is not authorized.
        /// </summary>
        [<CustomOperation("NotAuthorized")>] member inline _.NotAuthorized ([<InlineIfLambda>] render: AttrRenderFragment, fn: AuthenticationState -> NodeRenderFragment) = render ==> html.renderFragment("NotAuthorized", fn)
        
        /// <summary>
        /// The content that will be displayed while asynchronous authorization is in progress.
        /// </summary>
        [<CustomOperation("Authorizing")>] member inline _.Authorizing ([<InlineIfLambda>] render: AttrRenderFragment, x: NodeRenderFragment) = render ==> html.renderFragment("Authorizing", x)
        
        /// <summary>
        /// The resource to which access is being controlled.
        /// </summary>
        [<CustomOperation("Resource")>] member inline _.Resource ([<InlineIfLambda>] render: AttrRenderFragment, x: obj) = render ==> ("Resource" => x)
    
    let AuthorizeRouteView'' = AuthorizeRouteView'()
