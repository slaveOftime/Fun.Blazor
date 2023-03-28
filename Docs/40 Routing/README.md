# Routing

In Fun.Blazor, we have built-in routing support, but you can always use your own. The built-in routing is very simple and inspired by [Giraffe](https://github.com/giraffe-fsharp/Giraffe).

Under the hood, we will create a component to listen to the route changes and use an adaptive model internally, so if the actual path is not changed, the UI will not be re-rendered.

We also support some helper functions like **routeCi "/demo" demoView**. It is just a function: `UrlString -> 'T option`. So if the return value has something, then it will return that thing. It can just be a view fragment or anything else.

Take the code below as an example:

{{GiraffeStyleRouter}}