# About

This is a project to make F# developer to write blazor easier.

It is based on [bolero](https://github.com/fsbolero/Bolero) and  [Feliz.Engine](https://github.com/alfonsogarciacaro/Feliz.Engine) before. \
Now **(in V2)** the dependency of bolero is removed to make it lighter. **Feliz style is deprecated** because it will cause more allocation and render loop than CE style, also it is too verbose as a DSL.

Anyway it is opinionated project, because I really like CE style, even its intellisense is not that good. Also I prefer adaptive model instead of Elmish. But you are not limited to use that, there is a package **Fun.Blazor.Elmish** to support that. Another thing is about dependency injection, I like that idea and find it is very useful when manage big application. I know, I know, some functional programmers may not like that.


Below is a very simple counter which is using adaptive model.

{{counter}}

