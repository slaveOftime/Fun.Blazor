# Hot Reload

```sh
dotnet tool install --global Fun.Blazor.Cli --version 4.0.0
```

You can install a template to create a project that is set up for hot-reload:

```sh
dotnet new --install Fun.Blazor.Templates::4.0.0
```

![image](../../assets/site-hot-reload.gif)

## Basic Steps

1. Define an entry point

    You can pick a component as an entry point and replace it with the following code at the component usage location:

    When you have multiple projects, you can get better performance by having multiple points of entry for every project. You can use the last parameter to target different cli watch hosts.

    ```fsharp
    #if DEBUG       
        html.hotReloadComp(yourComponent, "FullNameName.yourComponent", "http://localhost:9025")
    #else
        yourComponent
    #endif
    ```

    Because of [dotnet/fsharp#14250](https://github.com/dotnet/fsharp/issues/14250), you need to add the following target to your project:

    ```xml
    <Target Name="ShimReferencePathsWhenCommonTargetsDoesNotUnderstandReferenceAssemblies"
        BeforeTargets="CoreCompile"
        Condition="'@(ReferencePathWithRefAssemblies)' == ''">
        <ItemGroup>
            <ReferencePathWithRefAssemblies Include="@(ReferencePath)" />
        </ItemGroup>
    </Target>
    ```

2. Build your project and run it.

3. Open a terminal and run:

    ```sh
    fun-blazor watch "your full path of the project which contains the entry file" --server "http://localhost:9025"
    ```

    By default, the server is running at 9025, but when you have multiple projects, you may want to use different ports, and the port should be the same as what you customized at the entry file.

4. Edit and save

    Navigate to the page that contains the **yourComponent** on the browser. At this time, it will connect to the CLI host and start receiving changes.

    Go to the file that defines **yourComponent**, add **// hot-reload** to the file's top, change whatever you want, and save. Your UI should be updated accordingly.

## Limitations

- The entry file and **yourComponent** should be defined in different files.

- Not all F# expressions can be parsed correctly, so it's better to separate your UI logic and UI layout into different files and only add **// hot-reload** to the UI layout file.
        
    For example, if you want to add an extension method to the IComponentHook to access the backend server, you can separate it into a new file.

    The file structure could be like this:

    ```
    YourComponent
        Stores.fs
        Hooks.fs
        Control1.fs // hot-reload
        Control2.fs // hot-reload
    ```

- The first save will take more time.

- To get hot-reload for other components that are defined in different files:

    - Those components must be defined in the same project.
    - Those components must be referenced directly by **yourComponent**.
    - You also need to add **// hot-reload** to those files that contain the components.

- You should not enable too many files for hot-reload because of performance concerns.

- It does not support adding a new file, renaming files, or other similar actions. Only modifying an existing file is supported.

- Only the state created in IGlobalStore or IShareStore will be kept.

> Let's cross fingers to hope F# will have hot-reload for dotnet in the future.