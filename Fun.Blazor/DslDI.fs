[<AutoOpen>]
module Fun.Blazor.DslDI

open System
open Bolero
open Bolero.Html


type FunBlazorHtmlEngine with
    
    /// This function will create a blazor component with a random key.
    /// In other words, every time you recall this it will create a brand new component.
    /// So it is not performed well, but it is simple and bug lesser
    ///
    /// 'Services should be something you defined in the asp.net core DI or unit
    /// 'Services must be a tuple like (hook: IComponentHook, sp: IServiceProvider)
    member html.inject (render: 'Services -> Node) =
        Bolero.Node.BlazorComponent<DIComponent<'Services>>
            ([
                "RenderFn" => render
                Bolero.Key (Guid.NewGuid())
            ]
            ,[])


    /// This function will create a blazor component with a specific key.
    /// If the key is not changed its state will not be erased, the render function will not call again.
    ///
    /// 'Services should be something you defined in the asp.net core DI.
    /// 'Services must be a tuple like (hook: IComponentHook, sp: IServiceProvider) or unit
    ///
    /// For example:
    ///
    /// Below string will never change no matter how you change externalX
    /// 
    /// let demo (externalX: int) = html.inject ("demo-key", fun () -> html.text $"externalX = {externalX}")
    member html.inject (key, render: 'Services -> Node) =
        Bolero.Node.BlazorComponent<DIComponent<'Services>>
            ([
                "RenderFn" => render
                Bolero.Key key
            ]
            ,[])


    /// This function will create a blazor component with no key.
    /// It is recommend to add key in if else or looping code block to tell blazor when to rerender.
    ///
    /// 'Services should be something you defined in the asp.net core DI or unit
    /// 'Services must be a tuple like (hook: IComponentHook, sp: IServiceProvider)
    member html.injectWithNoKey (render: 'Services -> Node) =
        Bolero.Node.BlazorComponent<DIComponent<'Services>>
            ([
                "RenderFn" => render
            ]
            ,[])
