# About

Adaptive is a based on [FSharp.Data.Adaptive](https://github.com/fsprojects/FSharp.Data.Adaptive). In Fun.Blazor, we only used very small piece of its power **ChangableValue**, and the result is already very great. For its core concept, you can check on their documents.

In Fun.Blazor, we use it to isolate dynamic UI part. Because most of the time, your data changes will only affect specific part of the whole UI. So you can define things like:

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

You may notice that you can also do below things and it may look cleaner from different point of view. But **DisableEventTriggerStateHasChanged** is turned on by default. The reason is just for reducing the calculating virtual dom. With adaptiview we can narrow dom to a specific part for recalculating the dom in an isolated way. If you check the **Form** documents, you will see it use this pattern a lot. With that, we can have better performance for large UI dom tree. 

{{BlazorStyleComp}}


And **adaptiview** can also accept parameters like isStatic/key, with this, even you recall **yourUI**, it will not affect the isolated part.

{{AdaptiviewDemo}}

{{AdaptiviewMathDemo}}