namespace Microsoft.Extensions.DependencyInjection

open System.Runtime.CompilerServices
open Microsoft.Extensions.DependencyInjection
open Fun.Blazor


[<Extension>]
type Extensions =

    [<Extension>]
    static member AddFunBlazor(this: IServiceCollection) =
        this.AddScoped<IShareStore, ShareStore>()
            .AddSingleton<IGlobalStore, GlobalStore>()
