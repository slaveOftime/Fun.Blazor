# Region

Unlike blazor in csharp which is using razor engine to generate csharp code from html template. So it can create a static sequence number when compile to help improve DOM diff calculation. For more information about the [sequence number and diff performance](https://learn.microsoft.com/en-us/aspnet/core/blazor/advanced-scenarios?view=aspnetcore-7.0#sequence-numbers-relate-to-code-line-numbers-and-not-execution-order).

But in Fun.Blazor everything is dynamic, so the sequence number can also change dynamically when you compose different fragment or component. For example:

```fsharp
div { // sequence 0
    childContent [
        if isLoading then
            loader
        div { // sequence may change
            "hi"
        }
    ]
}
```

When **isLoading** is true, then the **loader** will be added, and the sequence number will change, because every time when we add attribute or node, we will increase the sequence number.

According to the official document, we developed **region** to help with this:

```fsharp
div { // sequence 0
    childContent [
        region { // sequence 1
            // Below content's sequence number is isolated
            if isLoading then
                loader
        }
        div { // sequence 2
            "hi" // sequence 3
        }
    ]
}
```

Most of the time, we will not even notice the difference with or without the **region**, but it is better to keep dynamic pieces in an isolated area both for readability and performance. And in Fun.Blazor, the **fragment**, **adaptiview** and **html.inject** already use **region** under the hood to isolate its content, so the sequence number changing will not amplifying. For example:

```fsharp
div { // sequence 0
    childContent [
        adaptiview () { // sequence 1
            match! isLoading with
            | true -> loader
            | false -> someDataView
        }
        div { // sequence 2
            "hi" // sequence 3
        }
    ]
}
```
