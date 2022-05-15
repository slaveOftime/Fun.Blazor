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

And **adaptiview** can also accept parameters like isStatic/key, with this, even you recall **yourUI**, it will not affect the isolated part.

{{AdaptiviewDemo}}