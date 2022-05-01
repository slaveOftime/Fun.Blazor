#nowarn "0020"

open System
open Microsoft.AspNetCore.Builder
open Microsoft.Extensions.Hosting
open Microsoft.Extensions.DependencyInjection
open MudBlazor.Services
open Fun.Blazor.Docs.Server


let builder = WebApplication.CreateBuilder(Environment.GetCommandLineArgs())

builder.Services.AddControllersWithViews()
builder.Services.AddServerSideBlazor().Services.AddFunBlazorServer().AddMudServices()
builder.Services.AddScoped<Fun.Blazor.Docs.Wasm.Pages.HelperFunctions.InjectDemo.ScopedDemoService>()


let app = builder.Build()

app.UseStaticFiles()

app.MapBlazorHub()
app.MapFunBlazor(Index.page2)

app.Run()
