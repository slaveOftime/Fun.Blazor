namespace Microsoft.AspNetCore.Components.Authorization

[<AutoOpen>]
module Bindings =
  
    open System.Diagnostics.CodeAnalysis
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
        inherit RouteView'()

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
