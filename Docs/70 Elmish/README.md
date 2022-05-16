# Elmish

**Fun.Blazor.Elmish** is the package to support this.

I know Elmish is loved by a lot of F# developers including me. At the beginning, when I start work on my first FSharp related task, I use Fable + Elmish, then migrated to Feliz + Elmish hooks + Recoil. At that time, I really enjoy it.

For the core concept, you can check [Elmish official docs, the real MVU (LOL)](https://elmish.github.io/elmish/)

{{ElmishDemo}}

There are also some helper functions under IComponentHook which can be used to combine adaptive and elmish together for better performance in **simple use cases**. Because in adaptive data, you can subscribe the data you are interested and trigger the specific UI part when the piece of data is actually changed. Unlike normal elmish model, you will call the whole **view** function again to rerender the whole dom tree no matter which piece of the data is changed.

{{AdaptiveElmish}}
