namespace Microsoft.Extensions.DependencyInjection

open System.Runtime.CompilerServices
open Microsoft.Extensions.DependencyInjection
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.WebAssembly.Hosting
open Fun.Blazor



/// This cannot be marked as internal because blazor need it
type FunBlazorNodeComponent() =
    inherit Bolero.Component()

    [<Parameter>]
    member val Node = html.none with get, set

    override this.Render() = this.Node.Node().ToBolero()


[<Extension>]
type Extensions =

    [<Extension>]
    static member AddFunBlazor(this: IServiceCollection) =
        this.AddScoped<IShareStore, ShareStore>()
            .AddSingleton<IGlobalStore, GlobalStore>()

    [<Extension>]
    static member AddFunBlazorNode(this: WebAssemblyHostBuilder, selector: string, node: IFunBlazorNode) =
        let parameters = ParameterView.FromDictionary(dict ["Node", box node ])
        this.RootComponents.Add(typeof<FunBlazorNodeComponent>, selector, parameters)
        this
