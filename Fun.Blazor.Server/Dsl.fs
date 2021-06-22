namespace Fun.Blazor.Server

open Microsoft.AspNetCore.Components
open Bolero
open Bolero.Server

open Fun.Blazor


[<AutoOpen>]
module Dsl =
    type FunBlazorHtmlEngine with
        member _.doctypeHtml (nodes: FunBlazorNode list) = Html.doctypeHtml [] [ (Fragment nodes).ToBolero() ] |> BoleroNode

        member _.root<'T when 'T :> IComponent> () = Bolero.Server.Html.rootComp<'T> |> BoleroNode
