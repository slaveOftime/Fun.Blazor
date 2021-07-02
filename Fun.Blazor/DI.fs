[<AutoOpen>]
module Microsoft.Extensions.DependencyInjection.Extensions

open Microsoft.Extensions.DependencyInjection
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.WebAssembly.Hosting
open Fun.Blazor


type IServiceCollection with
    member this.AddFunBlazor() =
        this.AddScoped<IShareStore, ShareStore>()
            .AddSingleton<IGlobalStore, GlobalStore>()


/// This cannot be marked as internal because blazor need it
type FunBlazorNodeComponent() =
    inherit Bolero.Component()

    [<Parameter>]
    member val Node = html.none with get, set

    override this.Render() = this.Node.Node().ToBolero()


type WebAssemblyHostBuilder with
    member this.AddFunBlazorNode(selector: string, node: IFunBlazorNode) =
        let parameters = ParameterView.FromDictionary(dict ["Node", box node ])
        this.RootComponents.Add(typeof<FunBlazorNodeComponent>, selector, parameters)
        this
