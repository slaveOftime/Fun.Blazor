[<AutoOpen>]
module Fun.Blazor.DslDI

open System
open Bolero.Html


type FunBlazorHtmlEngine with
    
    /// This function will create a blazor component with a random key.
    /// In other words, every time you recall this it will create a brand new component.
    ///
    /// 'Services should be something you defined in the asp.net core DI
    member html.inject (render: 'Services -> IFunBlazorNode) =
        html.bolero 
            (Bolero.Node.BlazorComponent<DIComponent<'Services>>
                ([
                    "RenderFn" => render
                    Bolero.Key (Guid.NewGuid())
                ]
                ,[]))


    /// This function will create a blazor component with a specific key.
    /// If the key is not changed its state will not be erased, the render function will not call again.
    ///
    /// 'Services should be something you defined in the asp.net core DI.
    ///
    /// For example:
    ///
    /// Below string will never change no matter how you change externalX
    /// 
    /// let demo (externalX: int) = html.inject ("demo-key", fun () -> html.text $"externalX = {externalX}")
    member html.inject (key, render: 'Services -> IFunBlazorNode) =
        html.bolero 
            (Bolero.Node.BlazorComponent<DIComponent<'Services>>
                ([
                    "RenderFn" => render
                    Bolero.Key key
                ]
                ,[]))
