namespace Microsoft.Extensions.DependencyInjection

open System.Reflection
open System.Runtime.CompilerServices
open Microsoft.AspNetCore.Components.Web
open Fun.Result
open Fun.Blazor
open Fun.Blazor.CustomElements


[<Extension>]
type FunBlazorCustomElementsExtensions =

    /// Please make sure the Component name has at least two upper case like DemoComp, or use tagName with snake style like "demo-comp".
    /// For example for blazor server: services.AddServerSideBlazor(fun options -> options.RootComponents.RegisterCustomElementForFunBlazor<YourComponent>()).
    /// When you use this you should use CustomElement.lazyBlazorJs and CustomElement.initBlazorJs accordingly.
    [<Extension>]
    static member RegisterCustomElementForFunBlazor(this: IJSComponentConfiguration, ty: System.Type, identifier: string) =
        if identifier.Contains "-" |> not then
            failwith $"Blazor custom element's tag name must be snake name with at least two words, like xxx-xxx"
        // https://github.com/dotnet/aspnetcore/blob/main/src/Components/CustomElements/src/JSComponentConfigurationExtensions.cs
        this.RegisterForJavaScript(ty, identifier, "registerBlazorCustomElement")

    /// Please make sure the Component name has at least two upper case like DemoComp, or use tagName with snake style like "demo-comp".
    /// For example for blazor server: services.AddServerSideBlazor(fun options -> options.RootComponents.RegisterCustomElementForFunBlazor<YourComponent>()).
    /// When you use this you should use CustomElement.lazyBlazorJs and CustomElement.initBlazorJs accordingly.
    [<Extension>]
    static member RegisterCustomElementForFunBlazor<'Component when 'Component :> Microsoft.AspNetCore.Components.IComponent>
        (
            this: IJSComponentConfiguration,
            ?tagName
        )
        =
        this.RegisterCustomElement<'Component>(
            tagName
            |> Option.defaultWith (fun _ -> Utils.GetTagNameForType(typeof<'Component>, failIfWithoutFunBlazorCustomElementAttribute = false))
        )

    /// You will need to add FunBlazorCustomElementAttribute to the target components.
    /// Please make sure the Component name has at least two upper case like DemoComp, or use tagName with snake style like "demo-comp".
    /// For example for blazor server: services.AddServerSideBlazor(fun options -> options.RootComponents.RegisterCustomElementForFunBlazor<YourComponent>()).
    /// When you use this you should use CustomElement.lazyBlazorJs and CustomElement.initBlazorJs accordingly.
    [<Extension>]
    static member RegisterCustomElementForFunBlazor(this: IJSComponentConfiguration, assembly: Assembly) =
        for ty in assembly.GetTypes() do
            let attr = ty.GetCustomAttribute<FunBlazorCustomElementAttribute>()
            if attr |> box |> isNull |> not then
                this.RegisterCustomElementForFunBlazor(ty, Utils.GetTagNameForType(ty, failIfWithoutFunBlazorCustomElementAttribute = true))
