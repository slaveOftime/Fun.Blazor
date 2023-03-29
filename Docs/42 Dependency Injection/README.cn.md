# 依赖注入 (DI)

由于其渲染行为，**html.inject** 可能是 Fun.Blazor 中<span style="background:orangered">最具挑战性的 API</span>。虽然我们没有很多 API，只是一堆用于构建 DOM 的 DSL。默认情况下，每次调用它时，都会获得一个全新的组件。因此，如果您想保留一些不应被其调用者擦除的状态，则应将其第一个参数设置为键。

另一个具有挑战性的事情是它的内部渲染。它需要一个函数作为参数，这个函数是<code>'Services -> NodeRenderFragment</code>。其中的 *'Services* 是您想要注入的服务类型的元组。NodeRenderFragment 是一个将组成 DOM 树的委托（可以被视为另一个函数）。默认情况下，DOM 树不会更改，除非您手动触发它，如调用 **hook.StateHasChanged()**，或执行以下示例所示的操作：

{{BlazorStyleComp}}

所有从 FunBlazorComponent 继承的组件都开启了 DisableEventTriggerStateHasChanged。这只是一个设计决定。如果你不喜欢像 html.inject/adaptiview 这样的模式，你可以创建自己的组件，并获得 DOM DSL 和第三方 DSL 支持，如 Fun.Blazor.Cli 生成的 MudBlazor 绑定。

依赖注入 (DI) 对于许多软件应用程序都是必不可少的。ASP.NET Core 内置了它的支持，也有助于测试等。不仅服务，UI 组件也可以使用依赖注入。

html.inject 用于注入你在 DI 容器中定义的服务。

{{SimpleInjectionDemo}}

我们还提供 **html.scope**，可以用来创建另一个作用域，以便用它来隔离一些数据或服务状态。

{{ScopedServiceDemo}}

**html.inject** 也支持异步渲染。因为你传递的函数将在相关的 Blazor 组件的 **OnInitializedAsync** 中调用，所以这时，我们可以调用该任务。

{{AsyncInjectionDemo}}
