# Dependency injection (DI)

The importance of **dependency injection** (DI) in a lot of softwares are very important. ASP.NET Core has build in support for that. And it is also good for testing and cross concern solutions. But just service but also UI components can be powered by **dependency injection**.

**html.inject** is used to inject the service you defined in DI container.

{{SimpleInjectionDemo}}

We also provide **html.scope** which can be used to create another scope, so you can use it to isolate some data or service state:

{{ScopedServiceDemo}}