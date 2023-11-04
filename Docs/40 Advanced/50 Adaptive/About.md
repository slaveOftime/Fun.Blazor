# About

Adaptive is based on [FSharp.Data.Adaptive](https://github.com/fsprojects/FSharp.Data.Adaptive). In Fun.Blazor, we only use a very small piece of its power **ChangableValue**, and the result is already great. For its core concept, you can check their documentation.

In Fun.Blazor, we use it to isolate dynamic UI parts. Because most of the time, your data changes will only affect a specific part of the whole UI. So you can define things like the following:

```fsharp
let yourUI =
    div {
        style { ... }
        childContent [
            ... a lot of stuff
            adaptiview () {
                let! msg = from store
                // only below part will be rerendered.
                div {
                    style { ... }
                    msg
                }
            } 
            ... a lot of stuff
        ]
    }
```

<p style="color: red">Please remember, the adaptive model is optional. If you do not like it, you can use your own model.</p>

You may notice that you can also do the following, and it may look cleaner from a different point of view. But **DisableEventTriggerStateHasChanged** is turned on by default. The reason is to reduce the calculation of the virtual dom. With **adaptiview**, we can narrow the dom to a specific part for recalculating the dom in an isolated way. If you check the **Form** documentation, you will see it uses this pattern a lot. With that, we can have better performance for large UI dom trees. 

{{BlazorStyleComp}}

And **adaptiview** can also accept parameters like `isStatic/key`. With this, even if you re-call `yourUI`, it will not affect the isolated part.

{{AdaptiviewDemo}}

{{AdaptiviewMathDemo}}