// Copyright 2018 Fabulous contributors. See LICENSE.md for license.

[<AutoOpen>]
module Fun.Blazor.Cli.Watch.Processor

open System
open System.IO
open FSharp.Compiler.Text
open FSharp.Compiler.CodeAnalysis
open FSharp.Compiler.Symbols
open FSharp.Compiler.PortaCode.CodeModel
open FSharp.Compiler.PortaCode.Interpreter
open FSharp.Compiler.PortaCode.FromCompilerService


type Source =
    | FSharpProj of string
    | SourceFiles of string list
    | Script of string


let private checker = FSharpChecker.Create(keepAssemblyContents = true)


let private editDirAndFile (fileName: string) =
    let infoDir = Path.Combine(Path.GetDirectoryName fileName, ".fsharp")
    let editFile = Path.Combine(infoDir, Path.GetFileName fileName + ".edit")
    if not (Directory.Exists infoDir) then
        Directory.CreateDirectory infoDir |> ignore
    infoDir, editFile


let private readFile useEditFiles (fileName: string) =
    let readAllText file =
        use fs = File.Open(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
        use sr = new StreamReader(fs)
        sr.ReadToEnd()

    if useEditFiles then
        let infoDir, editFile = editDirAndFile fileName
        let preferEditFile =
            try
                Directory.Exists infoDir
                && File.Exists editFile
                && File.Exists fileName
                && File.GetLastWriteTime(editFile) > File.GetLastWriteTime(fileName)
            with
            | _ -> false
        if preferEditFile then
            printfn "*** preferring %s to %s ***" editFile fileName
            readAllText editFile
        else
            readAllText fileName
    else
        readAllText fileName


let private convFile (i: FSharpImplementationFileContents) =
    //(i.QualifiedName, i.FileName
    i.FileName, { Code = Convert(true, true).ConvertDecls i.Declarations }


let private isFileHotReloadEnabled (file: string) =
    use fs = File.Open(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
    use sr = new StreamReader(fs)
    if sr.Peek() >= 0 then
        if sr.ReadLine().Contains("// hot-reload", StringComparison.OrdinalIgnoreCase) then
            true
        else
            //printfn "ignored %s: because no \"// hot-reload\" at the top of the source file" x
            false
    else
        false


let process' sendCode (source: Source) (msbuildArgs: string list) =
    let useEditFiles = false
    let mutable lastCompileStart = System.DateTime.Now


    let options =
        match source with
        | FSharpProj fsprojFile ->
            match FSharpDaemon.ProjectCracker.load (new System.Collections.Concurrent.ConcurrentDictionary<_, _>()) fsprojFile msbuildArgs with
            | Ok (options, sourceFiles, _log) ->
                let options = { options with SourceFiles = Array.ofList sourceFiles }
                let sourceFilesSet = Set.ofList sourceFiles
                let options =
                    { options with
                        OtherOptions = options.OtherOptions |> Array.filter (fun s -> not (sourceFilesSet.Contains(s)))
                    }
                Result.Ok options
            | Error err -> failwithf "Couldn't parse project file: %A" err

        | SourceFiles sourceFiles ->
            let options =
                checker.GetProjectOptionsFromCommandLineArgs("tmp.fsproj", List.toArray msbuildArgs)
            let options =
                { options with
                    SourceFiles = sourceFiles |> List.toArray |> Array.map Path.GetFullPath
                }
            Result.Ok options

        | Script script ->
            let text = readFile useEditFiles script
            let otherFlags = msbuildArgs @ [ "--targetprofile:netcore" ]
            let options, errors =
                checker.GetProjectOptionsFromScript(
                    script,
                    SourceText.ofString text,
                    otherFlags = List.toArray otherFlags,
                    assumeDotNetFramework = false
                )
                |> Async.RunSynchronously
            let options =
                { options with
                    OtherOptions = Array.append options.OtherOptions [| "--target:library" |]
                }
            if errors.Length > 0 then
                for error in errors do
                    printfn "%s" (error.ToString())
                Result.Error()
            else
                Result.Ok options


    match options with
    | Result.Error () -> failwith "fslive: error processing project options or script"

    | Result.Ok options ->
        let rec checkFile count sourceFile =
            try
                let parseResults, checkResults =
                    checker.ParseAndCheckFileInProject(sourceFile, 0, SourceText.ofString (readFile useEditFiles sourceFile), options)
                    |> Async.RunSynchronously
                match checkResults with
                | FSharpCheckFileAnswer.Aborted ->
                    failwith "unexpected aborted"
                    Result.Error(Some parseResults.ParseTree, None, None, None)

                | FSharpCheckFileAnswer.Succeeded res ->
                    let mutable hasErrors = false
                    if hasErrors then
                        Result.Error(Some parseResults.ParseTree, None, Some [ "error" ], res.ImplementationFile)
                    else
                        Result.Ok(Some parseResults.ParseTree, res.ImplementationFile)
            with
            | :? System.IO.IOException when count = 0 ->
                System.Threading.Thread.Sleep 500
                checkFile 1 sourceFile
            | exn ->
                printfn "%s" (exn.ToString())
                Result.Error(None, Some exn, None, None)


        let checkFiles files =
            let rec loop rest acc =
                match rest with
                | file :: rest ->
                    match checkFile 0 (Path.GetFullPath(file)) with
                    | Result.Error ((_, _, _, None) as info) -> Result.Error info
                    | Result.Ok (_, None) -> Result.Error(None, None, None, None)
                    | Result.Error (parseTree, _, _, Some implFile)
                    | Result.Ok (parseTree, Some implFile) ->
                        printfn "fslive: GOT PortaCode for %s" file
                        loop rest ((parseTree, implFile) :: acc)
                | [] -> Result.Ok(List.rev acc)
            loop (List.ofArray files) []


        let sendCode fileContents =
            try
                printfn "fslive: Serialize code ..."
                let data = { Changes = Array.map convFile fileContents }.ToBytes()
                printfn "fslive: GOT Serialized data, length = %d" data.Length

                printfn "fslive: SENDING ... "
                sendCode data
                printfn "fslive: Send code successful"

            with
            | err -> printfn "fslive: ERROR SENDING: %A" (err.ToString())


        let changed why _ =
            try
                printfn "fslive: COMPILING (%s)...." why
                lastCompileStart <- System.DateTime.Now

                let result =
                    options.SourceFiles |> Array.filter isFileHotReloadEnabled |> checkFiles

                match result with
                | Result.Error res -> Result.Error res
                | Result.Ok allFileContents ->
                    List.map snd allFileContents |> List.toArray |> sendCode
                    Result.Ok()

            with
            | err ->
                printfn "fslive: exception: %A" (err.ToString())
                for loc in err.EvalLocationStack do
                    printfn "   --> %O" loc
                Result.Error(None, Some err, None, None)


        let mkWatcher (sourceFile: string) =
            let path = Path.GetDirectoryName(sourceFile)
            let fileName = Path.GetFileName(sourceFile)

            printfn "fslive: WATCHING %s in %s" fileName path
            
            let watcher = new FileSystemWatcher(path, fileName)
            
            watcher.NotifyFilter <-
                NotifyFilters.CreationTime
                ||| NotifyFilters.DirectoryName
                ||| NotifyFilters.FileName
                ||| NotifyFilters.LastWrite
                ||| NotifyFilters.Size

            let fileChange msg e =
                let lastWriteTime =
                    try
                        max (File.GetCreationTime(sourceFile)) (File.GetLastWriteTime(sourceFile))
                    with
                    | _ -> DateTime.MaxValue
                printfn "change %s, lastCOmpileStart=%A, lastWriteTime = %O" sourceFile lastCompileStart lastWriteTime
                if lastWriteTime > lastCompileStart then
                    let sw = System.Diagnostics.Stopwatch.StartNew()
                    printfn "changed %s" sourceFile
                    changed msg e |> ignore
                    printfn "finished changes in %d ms" sw.ElapsedMilliseconds

            watcher.Changed.Add(fileChange (sprintf "Changed %s" fileName))
            watcher.Created.Add(fileChange (sprintf "Created %s" fileName))
            watcher.Deleted.Add(fileChange (sprintf "Deleted %s" fileName))
            watcher.Renamed.Add(fileChange (sprintf "Renamed %s" fileName))
            watcher


        let watchers =
            [
                for sourceFile in options.SourceFiles do
                    yield mkWatcher sourceFile
                    if useEditFiles then yield mkWatcher sourceFile
            ]


        for watcher in watchers do
            watcher.EnableRaisingEvents <- true

        { new IDisposable with
            member _.Dispose() =
                for watcher in watchers do
                    watcher.EnableRaisingEvents <- false
        }
