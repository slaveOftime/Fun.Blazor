﻿[<AutoOpen>]
module Microsoft.Extensions.DependencyInjection.Extensions

open Microsoft.Extensions.DependencyInjection
open Fun.Blazor


type IServiceCollection with
    member this.AddFunBlazor() =
       this.AddScoped<IShareStore, ShareStore>() |> ignore
       this