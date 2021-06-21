#r "nuget: FSharp.Formatting"
#r "nuget: Fake.Core.Process,5.20.0"
#r "nuget: Fake.IO.FileSystem,5.20.0"
#r "nuget: Fake.IO.Zip,5.20.0"
#r "nuget: BlackFox.Fake.BuildTask,0.1.3"

open System.IO
open Fake.IO
open Fake.IO.FileSystemOperators
open Fake.IO.Globbing.Operators
open BlackFox.Fake
open FSharp.Formatting.Markdown


fsi.CommandLineArgs
|> Array.skip 1
|> BuildTask.setupContextFromArgv 



let generateDocForWasm =
    BuildTask.create "GenerateDocForWasm" [] {
        let codeRootDir = __SOURCE_DIRECTORY__ </> "Fun.Blazor.Docs.Wasm"
        let outputDir = codeRootDir </> "wwwroot" </> "code-docs"

        Shell.cleanDir outputDir

        let fsCodes =
            !!(codeRootDir </> "**" </> "*Demo.fs")
            |> Seq.map (fun path ->
                let markdown = 
                    $"""```fsharp
{File.readAsString path}
```             """
                path, markdown)

        let rawMarkdowns =
            !!(codeRootDir </> "**" </> "*Demo.md")
            |> Seq.map (fun path -> path, File.readAsString path)

        fsCodes
        |> Seq.append rawMarkdowns
        |> Seq.iter (fun (path, markdown) ->
            let html = Markdown.Parse markdown |> Markdown.ToHtml
            let relativePath = Path.GetRelativePath(codeRootDir, path)
            let filePath = outputDir </> Path.getDirectory relativePath </> Path.GetFileNameWithoutExtension relativePath + ".html"
            Directory.ensure (Path.getDirectory filePath)
            File.writeString false filePath html)

        let readmeMd = __SOURCE_DIRECTORY__ </> "README.md"
        let readmeHtml = File.readAsString readmeMd |> Markdown.Parse |> Markdown.ToHtml
        File.writeString false (outputDir </> "README.html") readmeHtml
    }


BuildTask.runOrDefault generateDocForWasm
