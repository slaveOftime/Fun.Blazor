namespace Microsoft.Extensions.DependencyInjection

open System.Runtime.CompilerServices
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.WebAssembly.Hosting
open Fun.Blazor


[<Extension>]
type FunBlazorWasmExtensions =
    
    [<Extension>]
    static member AddFunBlazorWasm(this: IServiceCollection) =
        this.AddScoped<IShareStore, ShareStore>()
            .AddScoped<IScopedCssRules, ScopedCssRules>()
            .AddSingleton<IGlobalStore, GlobalStore>()


    [<Extension>]
    static member AddFunBlazor(this: WebAssemblyHostBuilder, selector: string, node: NodeRenderFragment) =
        let parameters = ParameterView.FromDictionary(dict [ "Fragment", box node ])
        this.RootComponents.Add(typeof<FunFragmentComponent>, selector, parameters)
        this
