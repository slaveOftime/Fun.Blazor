# Dependency injection (DI)

**html.inject** maybe the <span style="background:orangered">hardest api</span> in Fun.Blazor because its render behavior. (Even we do not have many apis, just a bunch of dsl for building dom). By default, every time you call it you will get a fresh new component. So if you want to keep some state which should not be erased by its caller, you should specify a key as its first parameter.

Another hard thing is its internal rendering. It requires a function as its parameter, this function is **'Services -> NodeRenderFragment**. 'Services is a tuple of service types you want to inject. NodeRenderFragment is a delegate which compose the dom tree (which can be treat as another function). By default, the dom tree will not change unless you manually trigger it by **hook.StateHasChanged()**, or do things like below:

{{BlazorStyleComp}}


    **DisableEventTriggerStateHasChanged** is turn on for all component which inherited from **FunBlazorComponent**. It is just a design decision. If you do not like the pattern like **html.inject/adaptiview** you can just create your own component and get the benefit of dom dsl and third party dsl support like MudBlazor from Fun.Blazor.


**Dependency injection** (DI) in a lot of softwares are very important. ASP.NET Core has build in support for that. And it is also good for testing and cross concern solutions. Not just services but also UI components can be powered by **dependency injection**.

**html.inject (they are same but with different name for different context)** is used to inject the service you defined in DI container.

{{SimpleInjectionDemo}}

We also provide **html.scope** which can be used to create another scope, so you can use it to isolate some data or service state.

{{ScopedServiceDemo}}

**html.inject** also support async rendering. Because the function you passed in is will be called in **OnInitializedAsync** of the related blazor component, so at this point, we can invoke the task.

{{AsyncInjectionDemo}}