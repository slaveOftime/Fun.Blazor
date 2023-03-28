# Elmish

**Fun.Blazor.Elmish** is the package that supports Elmish.

I know Elmish is loved by a lot of F# developers, including myself. When I started working on my first F# related task, I used Fable + Elmish, then migrated to Feliz + Elmish hooks + Recoil, which I really enjoyed at the time.

For the core concept, you can check the [Elmish official docs for the real MVU (LOL)](https://elmish.github.io/elmish/)

{{ElmishDemo}}

There are also some helper functions under IComponentHook which can be used to combine adaptive and elmish together for better performance in **simple use cases**. Because in adaptive data, you can subscribe to the data you're interested in and trigger the specific UI part when the piece of data actually changes. Unlike normal Elmish model, where you would call the whole **view** function again to re-render the whole DOM tree no matter which piece of data has changed.

{{AdaptiveElmish}}