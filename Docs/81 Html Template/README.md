# HTML Template

With the VSCode plugin and NuGet package **Fun.Blazor.HtmlTemplate**, we can nicely parse HTML templates at runtime and get IntelliSense at design-time.

However, currently, it is not very efficient, so it is not recommended to use heavily. But it should still be ok because we have an adaptive model and runtime cache.

The reason I built this is that for component libraries like shoelacejs, they are web components and do not have a Blazor wrapper around them. So to use them, we can auto-generate the DOM tree at runtime based on the plain string.

Additionally, VSCode has a very cool plugin (Highlight HTML/SQL templates in F#) that enables HTML/JS/CSS languages to be embedded in F#.

![image](../assets/js-intellisense-in-fsharp.gif)

![image](../assets/template-html-intelligence.gif)

{{HtmlTemplateDemo}}