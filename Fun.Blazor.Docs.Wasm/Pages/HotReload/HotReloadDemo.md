```
dotnet tool install --global Fun.Blazor.Cli --version 2.0.0-beta*
```

You can install template to create project with setted up hot-reload

```
dotnet new --install Fun.Blazor.Templates::2.0.0-beta*
```

The basic steps:

1. Define entry point

    You can pick a component as an entry point and replace it with below code at its use place. Add **// hot-reload** at the top of the usage file (**entry file**).

    When you have multiple projects, to get better performance. You can have multiple entry for every project. You can use the last parameter to target to different cli watch host.

    ```
    #if DEBUG       
        html.hotReloadComp (yourComponent, "FullNameName.yourComponent", "http://localhost:9025")
    #else
        yourComponent
    #endif
    ```

2. Build your project and run it

3. Open a terminal and run:

    ```
    fun-blazor watch "your full path of the project which contains the entry file" --server "http://localhost:9025"
    ```

    By default the server is running at 9025, but when you have multiple project, you may want to use different port, and the port should be the same as what you customized at the entry file.

4. Edit and save

    Navigate to the page which contains **yourComponent** first on the browser. At this time, it will connect to the cli host and start receive changes.
    
    Go to the file which define **yourComponent**, add **// hot-reload** at its top, change whatever you want and save. Your UI should be updated accordingly.


## Limitations

- Entry file and **yourComponent** should be defined in different files

- Not all fsharp expression can be parsed correctly. So it is better to separate your UI logic and UI layout in different file, and only add **// hot-reload** to the UI layout file.

    For example, if you want to add extension method to the IComponentHook to access backend server, you may separate it in a new file.

    File structure can be like this:
    ```
    YourComponent
        Stores.fs
        Hooks.fs
        Control1.fs // hot-reload
        Control2.fs // hot-reload
    ```

    Below expression will not work for hot-reload

    ```fsharp
    div {
        for item in items do // ❌
            div { string item }
    }
     // Use this:
     ```fsharp
    div {
        childContent [ // ✅
            for item in items do
                div { string item }
        ]
    }
    ```

- The first save will take more time

- To get hot-reload for other components which is defined in different files

    Those components must be defined in the same project  
    Those components must be referenced directly by **yourComponent**  
    You also need to add **// hot-reload** to those files which contains the components 

- You should not enable too much files for hot reload for performance concern

- It does not support add new file or rename file etc. Only modify is supported.

- Only the state created in IGlobalStore or IShareStore will be kept.
