# How to Contribute

If you want to contribute to the source code, simply create a PR and mention me with @, then I will review it as soon as possible.

If you want to contribute to the documentation (which is very welcome, as my English is not very good, so my documentation may not be very readable), there are some conventions:

- All documentation is located under **Docs**. They are just markdown files, so you can make changes accordingly.

- The first line of the markdown file should be something like: **# your topic**.

- There is a number before every topic folder; this is used to sort the final menu accordingly.

- Under every folder, there is a **README.md** file, which is the main entry point to the topic. 

- If your topic has a lot of content, you can create subfolders and another **README.md** file in it to create a **tree** for better content organization.

- You can also include some live demos. To do so, you simply need to add this: **{{the demo name under Fun.Blazor.Docs.Wasm/Demos}}**. Use **Counter** as an example:

{{Counter}}

- You can also test your documentation locally by:

   a. Changing the docs.
   
   b. Under the repo's root folder, Run: dotnet fsi build.fsx -- -p docs.
   
   c. Run: dotnet run --project .\Fun.Blazor.Docs.Server\Fun.Blazor.Docs.Server.fsproj.

- To write demo components, you must create something like:

    ```fsharp
    // The namespace should keep exactly the same
    module Fun.Blazor.Docs.Wasm.Demos.DemoName

    open Fun.Blazor

    // must be called entry without arguments
    let entry = div { "hi" }
    ```