namespace Microsoft.Extensions.DependencyInjection

open System.Runtime.CompilerServices
open Microsoft.Extensions.DependencyInjection
open Fun.Blazor


[<Extension>]
type FunBlazorServerExtensions =

    /// Add a function for creating services which require IComponentHook.
    /// This can be used for better unit testing when using hook.
    /// To consume it, you should use hook.GetHookService<'T>().
    [<Extension>]
    static member AddHookService<'T>(this: IServiceCollection, fn: IComponentHook -> 'T) = this.AddSingleton<IComponentHook -> 'T>(fn)
