# Region

和 blazor 在 csharp razor 里的使用不同，razor 引擎会使用 source generator 来将 html 模板在编译时转化为 csharp 代码。所以它可以生成静态的序列号来优化 DOM 的 DIFF 计算。更多的信息可以查看 [sequence number and diff performance](https://learn.microsoft.com/en-us/aspnet/core/blazor/advanced-scenarios?view=aspnetcore-7.0#sequence-numbers-relate-to-code-line-numbers-and-not-execution-order).

但是，在 Fun.Blazor，所有的东西都是动态的（一堆 delegate 的集成），所以序列号也可能动态改变。比如：

```fsharp
div { // 序列号 0
    childContent [
        if isLoading then
            loader
        div { // 序列号可能在此处改变
            "hi"
        }
    ]
}
```

当 **isLoading** 是 true，**loader** 就会被调用，从而导致余下的所有部分的序列号变动。因为每当我们添加 DOM 属性或 节点都会把序列号加1。

根据官方文档，我们开发了 **region** 来优化这个问题：

```fsharp
div { // 序列号 0
    childContent [
        region { // 序列号 1
            // 下面的序列号将不会影响外面的序列号
            if isLoading then
                loader
        }
        div { // 序列号 2
            "hi" // 序列号 3
        }
    ]
}
```

大多数时候我们都不会觉察出任何区别，但是如果能使用 **region** 来隔离动态的部分，那会更好，不但性能有更好，而且更容易阅读。另外在 Fun.Blazor 中，我们有 **fragment**, **adaptiview** 和 **html.inject**，它们低层其实已经使用了 **region** 来隔离子元素，所以序列号变更不会扩散太大。比如：

```fsharp
div { // 序列号 0
    childContent [
        adaptiview () { // 序列号 1
            match! isLoading with
            | true -> loader
            | false -> someDataView
        }
        div { // 序列号 2
            "hi" // 序列号 3
        }
    ]
}
```
