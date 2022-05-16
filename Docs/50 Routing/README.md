# Routing

In Fun.Blazor, we have build in routing support. But you can always use your own. The build in routing is very simple and inspired by [Giraffe](https://github.com/giraffe-fsharp/Giraffe).


Under the hood, we will create a component to license to the route changes. And use adaptive internally, so if the actual path is not changed the UI will not be rerendered.

We also support some helper functions like **routeCi "/demo" demoView**. It is just a function: UrlString -> 'T option. So if the return value has some thing, then it will return that thing. It can just be a view fragment or anything else.

Take below as an example:

{{GiraffeStyleRouter}}