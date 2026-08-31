# Hot Reload (experimental)

This hot-reload pipeline predates .NET's built-in hot reload and interprets F# code changes at runtime (via PortaCode) so UI updates apply without restarting the app. It is experimental: not every F# construct can be interpreted. Prefer the built-in `dotnet watch` hot reload when it works for your scenario, and use this only if you need it.

```sh
dotnet tool install --global Fun.Blazor.Cli
```

You can install a template to create a project that is set up for hot-reload:

```sh
dotnet new --install Fun.Blazor.Templates
```

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

2. Build your project and run it.

3. Open a terminal and run:

    ```sh
    fun-blazor watch "your full path of the project which contains the entry file" --server "http://localhost:9025"
    ```

    By default, the server is running at 9025, but when you have multiple projects, you may want to use different ports, and the port should be the same as what you customized at the entry file.

4. Edit and save

    Navigate to the page that contains the **yourComponent** on the browser. At this time, it will connect to the CLI host and start receiving changes.

    Go to the file that defines **yourComponent**, add **// hot-reload** to the file's top, change whatever you want, and save. Your UI should be updated accordingly.

## Performance

The interpreter (`EvalContext`) is reused per render entry across saves, so after the first save only the changed declarations are re-added and re-evaluated. The first save is the most expensive; subsequent saves of the same entry are much faster. Keeping the number of hot-reload-enabled files small keeps the per-save F# check cheap too.

On the CLI side, the work on each save is now bounded to what actually changed:

- A single long-lived `FSharpChecker` is kept, and files are checked with `ParseAndCheckFileInProject`, so the F# compiler service caches the type-check of every unchanged file. Only the edited file is re-type-checked against those cached dependencies.
- Only changed files are re-checked and converted to the portable AST. The server combines compiler symbol uses (including argument-less module values) with portable-AST member references, then sends the actual cached dependency closure through the render-entry files in F# compilation order. Intermediate module values are refreshed before the entry is evaluated without evaluating unrelated files. The dependency closure is walked over **all** project files, so intermediate files between a changed file and the entry are re-evaluated even when they don't carry the marker. Entry files are discovered automatically: the client registers each entry name with the watch server over SignalR (`RegisterEntry`), and the server maps it back to its file via a one-time index of all project source files built at startup.

The net effect is that editing a helper file (one that does not contain the entry) now re-evaluates the entry so the change propagates — fixing the `couldn't find declaration called '...App.app'` failure — while keeping the per-save cost to roughly a few hundred ms instead of several seconds for a full-set resend.

## Limitations

- Not all F# expressions can be interpreted. **This is now tolerated rather than fatal:** when a declaration cannot be interpreted it is skipped and reported in the browser console with its source location, and the last good render is kept on screen instead of the update failing (or the UI going blank). So you can keep complex logic in a hot-reload file if you want — the parts that can't be interpreted simply won't update until you move them out and save again.

    For the best experience, still separate UI layout from heavy logic and only add **// hot-reload** to the layout files:

    ```
    YourComponent
        Stores.fs
        Hooks.fs          // extension methods, backend access, etc. (no marker needed)
        Control1.fs // hot-reload
        Control2.fs // hot-reload
    ```

    When you hit an uninterpretable construct, the console message tells you exactly which declaration/line to move into a non hot-reload file.

- The first save will take more time (the interpreter emits its shell types and does a full initial check). Subsequent saves of the same entry reuse the interpreter and only re-check the changed files.

- To get hot-reload for other components that are defined in different files:

    - Those components must be defined in the same project.
    - Those components must be referenced (transitively) by **yourComponent**, so that they are part of its render tree.
    - Add **// hot-reload** only to the files you actually edit and want to see update. Files *between* an edited file and the entry no longer need the marker — the server re-evaluates the whole dependency closure (including unmarked intermediate files) so cached module values like `DemoMaps.demos` are refreshed.

    The **// hot-reload** marker now only controls *which saves trigger a recompile*, not which files are sent. Only components reachable from your entry point get re-rendered. A failed update keeps the previous render, so an uninterpretable helper will not blank your UI — it just won't update until you fix it.

- Every save of a marked file re-checks that file, so keeping the number of marked files small keeps the per-save F# check cheap. (The full dependency index is built once at startup and is cached afterwards, so unmarked files no longer add to per-save cost.)

- It does not support adding a new file, renaming files, or other similar actions. Only modifying an existing file is supported.

- Only the state created in IGlobalStore or IShareStore will be kept.

> Let's cross fingers to hope F# will have hot-reload for dotnet in the future.
