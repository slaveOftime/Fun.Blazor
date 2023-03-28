# HTML 模板

使用 VSCode 插件和 NuGet 包 **Fun.Blazor.HtmlTemplate**，我们可以在运行时漂亮地解析 HTML 模板，并在设计时获得智能提示。

但是，目前它的效率不高，所以不建议频繁使用。但还是可以使用的，因为我们有自适应模型和运行时缓存。

我构建这个工具的原因是，对于像 shoelacejs 这样的组件库，它们是 Web 组件，没有 Blazor 的封装。因此，为了使用它们，我们可以根据普通字符串在运行时自动生成 DOM 树。

此外，VSCode 有一个非常酷的插件（Highlight HTML/SQL templates in F#），可以在 F# 中嵌入 HTML/JS/CSS 语言。

![image](../assets/js-intellisense-in-fsharp.gif)

![image](../assets/template-html-intelligence.gif)

{{HtmlTemplateDemo}}