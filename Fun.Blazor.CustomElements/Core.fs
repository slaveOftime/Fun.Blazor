namespace Fun.Blazor

open System


[<AttributeUsage(AttributeTargets.Class)>]
type FunBlazorCustomElementAttribute() =
    inherit Attribute()

    member val TagName = "" with get, set


[<RequireQualifiedAccess>]
type RenderAfter =
    /// Render after timeout in ms
    | Delay of int
    /// Render after prerender container received click event
    | Clicked
    /// Render after prerender container received click event or timeout in ms
    | ClickedOrDelay of int
    /// Render after element is in viewport
    | InViewport
    /// Render after element is in viewport or timeout in ms
    | InViewportOrDelay of int
    /// Render after element is in viewport, and delay for some time in ms
    | InViewportAndDelay of int
