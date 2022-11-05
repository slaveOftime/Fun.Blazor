# Custom Elements

This is experimental, you will need to install **Fun.Blazor.CustomElements**.

I create this is because for some use cases, I only want asp.net core to use Fun.Blazor to pre-render static content without blazor server connected. But for some pages or components I want to connect to blazor server temporarily. So I can still use blazor and hide backend api with a single websocket for interaction.

It is powered by **Microsoft.AspNetCore.Components.CustomElements** which will be officially supported in dotnet 7.

Below is a tow counter but share the same IShareStore, so in blazor server mode, when you click one button, the other button will also increase automatically. Which means they are sharing the some websocket connection.  

{{CustomElementDemo}}