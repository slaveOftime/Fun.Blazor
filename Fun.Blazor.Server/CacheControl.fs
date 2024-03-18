namespace Fun.Blazor

open System

/// This can be used for any blazor component which is served by MapRazorComponentsForSSR or MapCustomElementsForSSR
[<AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)>]
type ComponentResponseCacheAttribute() =
    inherit Attribute()
    member val Vary = "" with get, set
    member val Pragma = "" with get, set
    member val CacheControl = "" with get, set
