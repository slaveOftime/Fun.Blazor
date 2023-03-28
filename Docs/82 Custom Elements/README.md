# Custom Elements

This is experimental. You will need to install **Fun.Blazor.CustomElements**.

I created this because, for some use cases, I only want ASP.NET Core to use Fun.Blazor to pre-render static content without Blazor server connected. But for some pages or components, I want to connect to Blazor server temporarily. So I can still use Blazor and hide backend API with a single WebSocket for interaction.

It is powered by **Microsoft.AspNetCore.Components.CustomElements** which is officially supported in .NET 7.

There are counters below, but shares the same `IShareStore`. So, in Blazor server mode, when you click one button, the other button will also increase automatically, which means they share the same WebSocket connection.

{{CustomElementDemo}}