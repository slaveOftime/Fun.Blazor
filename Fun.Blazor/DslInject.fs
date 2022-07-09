[<AutoOpen>]
module Fun.Blazor.DslDI

open System
open Microsoft.Extensions.DependencyInjection
open Operators


type html with

    /// <summary>
    /// This function will create a blazor component with a random key.
    /// In other words, every time you recall this it will create a brand new component.
    /// So it is not performed well, but it is simple and bug lesser
    ///
    /// 'Services should be something you defined in the asp.net core DI or unit
    /// 'Services must be a tuple like (hook: IComponentHook, sp: IServiceProvider)
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// let view =
    ///   html.inject (hook: IComponentHook, jsRuntime: IJsRuntime) =
    ///      div {
    ///          ...
    ///      }
    ///   )
    /// </code>
    /// </example>
    static member inject(render: 'Services -> NodeRenderFragment) =
        ComponentWithChildBuilder<DIComponent<'Services>>() {
            key (Guid.NewGuid())
            "RenderFn" => render
            "IsStatic" => false
        }


    /// This function will create a blazor component with a specific key.
    /// If the key is not changed its state will not be erased, the render function will not call again.
    ///
    /// 'Services should be something you defined in the asp.net core DI.
    /// 'Services must be a tuple like (hook: IComponentHook, sp: IServiceProvider) or unit
    /// <example>
    /// <code lang="fsharp">
    /// // Below string will never change no matter how you change externalX
    /// let demo (externalX: int) =
    ///   html.inject ("demo-key", fun () -> html.text $"externalX = {externalX}")
    /// </code>
    /// </example>
    static member inject(k, render: 'Services -> NodeRenderFragment) =
        ComponentWithChildBuilder<DIComponent<'Services>>() {
            key k
            "RenderFn" => render
            "IsStatic" => true
        }


    /// This function will create a blazor component with no key.
    /// It is recommend to add key in `if else` or `looping` code block to tell blazor when to recreate component.
    ///
    /// 'Services should be something you defined in the asp.net core DI or unit
    /// 'Services must be a tuple like (hook: IComponentHook, sp: IServiceProvider)
    static member injectWithNoKey(render: 'Services -> NodeRenderFragment) =
        ComponentWithChildBuilder<DIComponent<'Services>>() {
            "RenderFn" => render
            "IsStatic" => true
        }


    /// This will create a component.
    /// It is same as html.inject, but with different name which may make more sense from different point of view.
    static member comp(render: 'Services -> NodeRenderFragment) = html.inject (render)

    /// This will create a component.
    /// It is same as html.inject, but with different name which may make more sense from different point of view.
    static member comp(key, render: 'Services -> NodeRenderFragment) = html.inject (key, render)


    /// This will get a IServiceScopeFactory from container and create a new scope and add it to CascadingValue.
    /// So all its child content can get service from this new scope by using hook.ScopedServiceProvider.
    /// The new scope will be disposed when this component is disposed.
    /// If useRootScope = true, the root ServiceProvider will be added to CascadingValue instead of create a new scope.
    static member scoped(useRootScope, node: NodeRenderFragment) =
        html.inject (fun (hook: IComponentHook) ->
            let scope =
                if useRootScope then
                    None
                else
                    hook.ServiceProvider.GetService<IServiceScopeFactory>().CreateScope() |> Some

            hook.OnDispose.Add(fun _ -> scope |> Option.iter (fun x -> x.Dispose()))

            CascadingValue'() {
                Name Internal.FunBlazorScopedServicesName
                IsFixed true
                Value(
                    match scope with
                    | Some scope -> scope.ServiceProvider
                    | None -> hook.ServiceProvider
                )
            }
        )

    /// This will get a IServiceScopeFactory from container and create a new scope and add it to CascadingValue.
    /// So all its child content can get service from this new scope by using hook.ScopedServiceProvider.
    /// The new scope will be disposed when this component is disposed.
    static member scoped(node: NodeRenderFragment) = html.scoped (false, node)

    /// This will get a IServiceScopeFactory from container and create a new scope and add it to CascadingValue.
    /// So all its child content can get service from this new scope by using hook.ScopedServiceProvider.
    /// The new scope will be disposed when this component is disposed.
    static member scoped(nodes: NodeRenderFragment seq) = html.scoped (html.fragment nodes)
