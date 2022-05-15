# How to Contribute

If you want to contribute to the source code, just make a PR and @ me then I will take a look as soon as possible.

If you want to contribute to documents (very welcomed, because my English is is not very good, so my documentation may not be very readable), there are some conventions:

- All the docs is under **Fun.Blazor.Docs.Wasm/Docs**. They are just markdown, you can change it accordingly.
- In the markdown file, the first line should be something like: **# your topic**
- There is a number before every topic folder, it is used to sort the final menu accordingly
- Under every folder, there is a **index** file. Which is the main entry to the topic. **en** is for English.
- You can make **tree** for your topic, if it has a lot of content. You just create subfolder and create another index file in it.
- You can also include some live demos. You just need to add exactly this: **{{the demo name under Fun.Blazor.Docs.Wasm/Demos}}**. Take **Counter** as example

{{Counter}}

- You can also test your docs changes locally. 
        
        After you changed the docs, then under repo's root folder,  
        Run **dotnet fsi build.fsx -t GenerateDocs**  
        Run **dotnet run --project .\Fun.Blazor.Docs.Server\Fun.Blazor.Docs.Server.fsproj**

- To write demo components, you must create something like:

    ```fsharp
    module Fun.Blazor.Docs.Wasm.Demos.DemoName

    open Fun.Blazor

    // must be called entry
    let entry = div { "hi" }
    ```