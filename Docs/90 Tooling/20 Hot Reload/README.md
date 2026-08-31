# Hot Reload (experimental)

Interprets F# code changes at runtime (via PortaCode) so UI updates apply without restarting the app. Prefer the built-in `dotnet watch` hot reload when it works for you; use this only if you need it.

```sh
dotnet tool install --global Fun.Blazor.Cli
```

A template with hot-reload preconfigured is available:

```sh
dotnet new --install Fun.Blazor.Templates
```

## Usage

1. Mark the entry point. At the component usage location, wrap it:

    ```fsharp
    #if DEBUG
        html.hotReloadComp(yourComponent, "FullName.yourComponent", "http://localhost:9025")
    #else
        yourComponent
    #endif
    ```

    With multiple projects, use one entry (and a distinct port) per project for better performance.

2. Build and run your project.

3. In a terminal, start the watcher (port must match the entry):

    ```sh
    fun-blazor watch "full path of the project containing the entry file" --server "http://localhost:9025"
    ```

4. Open the page containing **yourComponent** in the browser — it connects to the watcher. Add `// hot-reload` to the top of any file you want to edit, make your change, and save. The UI updates in place.

## Performance

The interpreter and the F# compiler service are reused across saves, so the first save is the slowest and later saves of the same entry are much faster (typically a few hundred ms). The watcher only re-checks the files that changed and re-evaluates the dependency chain up to the entry. Keep the number of marked files small to keep each save cheap.

## Limitations

- Not every F# construct can be interpreted. This is tolerated, not fatal: an uninterpretable declaration is skipped and reported in the browser console, and the previous render stays on screen. For the best experience, keep heavy logic (extension methods, backend access) in unmarked files and only mark layout files:

    ```
    YourComponent
        Stores.fs
        Hooks.fs          // extension methods, backend access (no marker)
        Control1.fs       // hot-reload
        Control2.fs       // hot-reload
    ```

- Cross-file components update if they are in the same project and referenced (transitively) by the entry. Add `// hot-reload` only to the files you actually edit — intermediate files between an edited file and the entry are re-evaluated automatically and do not need the marker. The marker only controls *which saves trigger a recompile*.

- The first save is slower (initial check + shell-type emission); subsequent saves reuse the interpreter.

- Only modifying an existing file is supported — adding, renaming, or deleting files requires a rebuild.

- Only state in `IGlobalStore` or `IShareStore` is preserved across reloads.

> Let's cross fingers to hope F# will have hot-reload for dotnet in the future.
