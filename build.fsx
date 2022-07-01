#r "nuget: BlackFox.Fake.BuildTask,0.1.3"
#r "nuget: Fake.IO.FileSystem,5.20.4"

#load "docs.fsx"

open BlackFox.Fake
open Fake.IO
open Fake.IO.FileSystemOperators
open Fake.IO.Globbing.Operators


fsi.CommandLineArgs |> Array.skip 1 |> BuildTask.setupContextFromArgv



let generateDocs = BuildTask.create "GenerateDocs" [] { Docs.DocBuilder.build () }

let processGitHubDocs =
    BuildTask.create "ProcessGitHubDocs" [ generateDocs ] {
        let targetDir = "Fun.Blazor.Docs.Wasm.Release"
        !!(targetDir </> "**" </> "index.html")
        |> Seq.iter (File.applyReplace (fun x -> x.Replace("""<base href="/"/>""", """<base href="/Fun.Blazor.Docs/" /> """)))
    }

BuildTask.runOrDefault generateDocs
