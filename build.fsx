#r "nuget: BlackFox.Fake.BuildTask,0.1.3"

#load "docs.fsx"

open BlackFox.Fake


fsi.CommandLineArgs |> Array.skip 1 |> BuildTask.setupContextFromArgv



let generateDocs =
    BuildTask.create "GenerateDocs" [] { Docs.DocBuilder.build () }


BuildTask.runOrDefault generateDocs
