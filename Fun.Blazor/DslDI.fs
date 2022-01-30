[<AutoOpen>]
module Fun.Blazor.DslDI

open System
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
    /// let View() =
    ///   let _view (hook: IComponentHook, jsRuntime: IJsRuntime) =
    ///     button() { (* ... code ... *)
    ///   html.inject _view
    /// </code>
    /// </example>
    static member inject(render: 'Services -> NodeRenderFragment) =
        html.comp<DIComponent<'Services>> () {
            "RenderFn" => render
            "IsStatic" => false
            key (Guid.NewGuid())
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
        html.comp<DIComponent<'Services>> () {
            "RenderFn" => render
            "IsStatic" => true
            key k
        }


    /// This function will create a blazor component with no key.
    /// It is recommend to add key in `if else` or `looping` code block to tell blazor when to recreate component.
    ///
    /// 'Services should be something you defined in the asp.net core DI or unit
    /// 'Services must be a tuple like (hook: IComponentHook, sp: IServiceProvider)
    static member injectWithNoKey(render: 'Services -> AttrRenderFragment) =
        html.comp<DIComponent<'Services>> () {
            "RenderFn" => render
            "IsStatic" => true
        }
