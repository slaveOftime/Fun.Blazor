# Dependency injection (DI)

**html.inject** may be the <span style="background:orangered">most challenging API</span> in Fun.Blazor due to its render behavior. (Even though we do not have many APIs, just a bunch of DSLs for building the DOM.) By default, every time you call it, you will get a fresh new component. So, if you want to keep some state that should not be erased by its caller, you should specify a key as its first parameter.

Another challenging thing is its internal rendering. It requires a function as its parameter, this function is <code>'Services -> NodeRenderFragment</code>. *'Services* is a tuple of service types you want to inject. NodeRenderFragment is a delegate that composes the DOM tree (which can be treated as another function). By default, the DOM tree will not change unless you manually trigger it by calling **hook.StateHasChanged()**, or by doing things like the example below:

{{BlazorStyleComp}}

**DisableEventTriggerStateHasChanged** is turned on for all components that are inherited from **FunBlazorComponent**. It is just a design decision. If you don't like the pattern like **html.inject/adaptiview**, you can just create your component and get the benefit of the DOM DSL and third-party DSL support like MudBlazor from Fun.Blazor.

**Dependency injection (DI)** is essential in many software applications. ASP.NET Core has built-in support for it, and it is also helpful for testing and cross-concern solutions. Not only services but also UI components can be powered by **dependency injection**.

**html.inject** is used to inject the service you defined in the DI container.

{{SimpleInjectionDemo}}

We also provide **html.scope** which can be used to create another scope, so you can use it to isolate some data or service state.

{{ScopedServiceDemo}}

**html.inject** also supports async rendering. Because the function you passed in will be called in **OnInitializedAsync** of the related Blazor component, so at this point, we can invoke the task.

{{AsyncInjectionDemo}}