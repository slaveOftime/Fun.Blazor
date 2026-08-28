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


/// Resolve the full reference set (framework ref-pack assemblies + NuGet/project
/// refs) for a project via `dotnet msbuild -getItem:ReferencePath`. Dotnet.ProjInfo's
/// getFscArgs no longer emits -r: arguments on modern SDKs (net6+), so without this
/// the checker can't resolve even System.Object and produces no implementation file.
let private resolveReferences (fsprojFile: string) (msbuildArgs: string list) : string list =
    try
        let projDir = Path.GetDirectoryName fsprojFile
        let extraArgs = msbuildArgs |> String.concat " "
        let args =
            sprintf
                "msbuild \"%s\" -t:ResolveAssemblyReferences -getItem:ReferencePath %s"
                fsprojFile
                extraArgs

        let psi = System.Diagnostics.ProcessStartInfo()
        psi.FileName <- "dotnet"
        psi.WorkingDirectory <- projDir
        psi.Arguments <- args
        psi.RedirectStandardOutput <- true
        psi.RedirectStandardError <- true
        psi.UseShellExecute <- false
        psi.CreateNoWindow <- true

        use p = new System.Diagnostics.Process()
        p.StartInfo <- psi
        p.Start() |> ignore
        let output = p.StandardOutput.ReadToEnd()
        p.WaitForExit()

        // The output is JSON: { "Items": { "ReferencePath": [ { "Identity": "..." } ] } }
        // Parse minimal: pull every "Identity": "<path>" entry.
        let refs =
            System.Text.RegularExpressions.Regex.Matches(output, "\"Identity\"\\s*:\\s*\"([^\"]+\\.dll)\"")
            |> Seq.cast<System.Text.RegularExpressions.Match>
            |> Seq.map (fun m -> m.Groups.[1].Value)
            |> Seq.filter (fun s -> s.EndsWith(".dll"))
            |> Seq.distinct
            |> Seq.toList

        if refs.IsEmpty then
            printfn "fslive: WARNING reference resolution returned no assemblies"
        else
            printfn "fslive: resolved %d references for the project" refs.Length
        refs
    with
    | ex ->
        printfn "fslive: reference resolution failed: %s" ex.Message
        []


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
    let check () =
        if File.Exists file then
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
        else
            false

    let mutable count = 0
    let mutable isCheckSuccess = false
    let mutable result = false
    while count < 3 && not isCheckSuccess do
        try
            result <- check ()
            isCheckSuccess <- true
        with
        | _ -> count <- count + 1

    if not isCheckSuccess then
        printfn "Check file hot-reload failed, please save the file again: %s" file

    result


let process' sendCode (source: Source) (msbuildArgs: string list) =
    let useEditFiles = false
    let mutable lastCompileStart = System.DateTime.Now


    let options =
        match source with
        | FSharpProj fsprojFile ->
            let fullPath = Path.GetFullPath fsprojFile
            match FSharpDaemon.ProjectCracker.load (new System.Collections.Concurrent.ConcurrentDictionary<_, _>()) fullPath msbuildArgs with
            | Ok (options, sourceFiles, _log) ->
                let options = { options with SourceFiles = Array.ofList sourceFiles }
                let sourceFilesSet = Set.ofList sourceFiles
                let otherOptions = options.OtherOptions |> Array.filter (fun s -> not (sourceFilesSet.Contains(s)))

                // Modern SDKs don't emit -r: in fsc args; add resolved references.
                let otherOptions =
                    if otherOptions |> Array.exists (fun s -> s.StartsWith("-r:")) then
                        otherOptions
                    else
                        let refs = resolveReferences fullPath msbuildArgs
                        Array.append otherOptions (refs |> List.toArray |> Array.map (fun r -> "-r:" + r))

                Result.Ok { options with OtherOptions = otherOptions }
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
                    if res.HasErrors then
                        for e in res.Diagnostics do
                            printfn "fslive: check diagnostic: %O" e
                    match res.ImplementationFile with
                    | None -> printfn "fslive: WARNING no implementation file for %s (references may be unresolved)" sourceFile
                    | Some _ -> ()
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


        // Cache which source files are hot-reload enabled so we don't re-read
        // every file from disk on each change event. The set is refreshed when a
        // file changes (its marker may have been added/removed).
        let hotReloadEnabled = System.Collections.Concurrent.ConcurrentDictionary<string, bool>()

        let isEnabled file =
            hotReloadEnabled.GetOrAdd(file, isFileHotReloadEnabled)


        // Queue of files that changed since the last compile. Change events are
        // debounced so a burst of editor events (save-all, format-on-save, etc.)
        // collapses into a single re-check, and only the files that actually
        // changed are re-checked/sent instead of the whole hot-reload set.
        let pendingChanges = System.Collections.Concurrent.ConcurrentDictionary<string, DateTime>()
        let compileGate = obj ()
        let mutable compileScheduled = false

        let debounceMs = 200


        let recheckChanged why =
            try
                printfn "fslive: COMPILING (%s)...." why
                lastCompileStart <- System.DateTime.Now

                let changedFiles = pendingChanges.Keys |> Seq.toArray
                pendingChanges.Clear()

                // Refresh the hot-reload marker for changed files, then keep only
                // the ones still enabled.
                let targets =
                    changedFiles
                    |> Array.choose (fun f ->
                        let enabled = isFileHotReloadEnabled f
                        hotReloadEnabled.[f] <- enabled
                        if enabled then Some f else None)

                match targets with
                | [||] ->
                    printfn "fslive: no hot-reload files changed, skipping"
                    Result.Ok()
                | _ ->
                    match checkFiles targets with
                    | Result.Error res -> Result.Error res
                    | Result.Ok fileContents ->
                        List.map snd fileContents |> List.toArray |> sendCode
                        Result.Ok()

            with
            | err ->
                printfn "fslive: exception: %A" (err.ToString())
                for loc in err.EvalLocationStack do
                    printfn "   --> %O" loc
                Result.Error(None, Some err, None, None)


        let scheduleCompile (changedFile: string) =
            pendingChanges.[changedFile] <- DateTime.Now
            lock compileGate (fun () ->
                if compileScheduled then
                    ()
                else
                    compileScheduled <- true
                    async {
                        do! Async.Sleep debounceMs
                        lock compileGate (fun () -> compileScheduled <- false)
                        let sw = System.Diagnostics.Stopwatch.StartNew()
                        recheckChanged (sprintf "Changed %s" changedFile) |> ignore
                        printfn "finished changes in %d ms" sw.ElapsedMilliseconds
                    }
                    |> Async.Start
            )


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

            let fileChange path =
                let lastWriteTime =
                    try
                        max (File.GetCreationTime(sourceFile)) (File.GetLastWriteTime(sourceFile))
                    with
                    | _ -> DateTime.MaxValue
                if lastWriteTime > lastCompileStart then
                    // Cheap check first (cached), then enqueue for a debounced
                    // compile. The marker refresh happens inside recheckChanged.
                    if isEnabled path || isFileHotReloadEnabled path then
                        scheduleCompile sourceFile

            watcher.Changed.Add(fun e -> fileChange e.FullPath)
            watcher.Created.Add(fun e -> fileChange e.FullPath)
            watcher.Renamed.Add(fun e -> fileChange e.FullPath)
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
