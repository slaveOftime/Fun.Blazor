// Copyright 2018 Fabulous contributors. See LICENSE.md for license.

// F# PortaCode command processing (e.g. used by Fabulous.Cli)

module FSharp.Compiler.PortaCode.ProcessCommandLine

open System
open System.IO
open FSharp.Compiler.Text
open FSharp.Compiler.CodeAnalysis
open FSharp.Compiler.Symbols
open FSharp.Compiler.PortaCode.CodeModel
open FSharp.Compiler.PortaCode.Interpreter
open FSharp.Compiler.PortaCode.FromCompilerService


let checker = FSharpChecker.Create(keepAssemblyContents = true)

let ProcessCommandLine sendCode (argv: string []) =
    let mutable fsproj = None
    let mutable dump = false
    let mutable livecheck = false
    let mutable dyntypes = false
    let mutable watch = true
    let mutable useEditFiles = false
    let mutable writeinfo = true
    let mutable webhook = None
    let mutable otherFlags = []
    let mutable msbuildArgs = []
    let defaultUrl = "http://localhost:9867/update"

    let fsharpArgs =
        let mutable haveDashes = false

        [|
            for arg in argv do
                let arg = arg.Trim()
                if arg.StartsWith("@") then
                    for line in File.ReadAllLines(arg.[1..]) do
                        let line = line.Trim()
                        if not (String.IsNullOrWhiteSpace(line)) then yield line
                elif arg.EndsWith(".fsproj") then
                    fsproj <- Some arg
                elif arg = "--" then
                    haveDashes <- true
                elif arg.StartsWith "--projarg:" then
                    msbuildArgs <- msbuildArgs @ [ arg.["----projarg:".Length..] ]
                elif arg.StartsWith "--define:" then
                    otherFlags <- otherFlags @ [ arg ]
                elif arg = "--once" then
                    watch <- false
                elif arg = "--dump" then
                    dump <- true
                elif arg = "--livecheck" then
                    dyntypes <- true
                    livecheck <- true
                    writeinfo <- true
                //useEditFiles <- true
                elif arg = "--enablelivechecks" then
                    livecheck <- true
                elif arg = "--useeditfles" then
                    useEditFiles <- true
                elif arg = "--dyntypes" then
                    dyntypes <- true
                elif arg = "--writeinfo" then
                    writeinfo <- true
                elif arg.StartsWith "--send:" then
                    webhook <- Some arg.["--send:".Length..]
                elif arg = "--send" then
                    webhook <- Some defaultUrl
                elif arg = "--version" then
                    printfn ""
                    printfn "*** NOTE: if sending the code to a device the versions of CodeModel.fs and Interpreter.fs on the device must match ***"
                    printfn ""
                    printfn "CLI tool assembly version: %A" (System.Reflection.Assembly.GetExecutingAssembly().GetName().Version)
                    printfn "CLI tool name: %s" (System.Reflection.Assembly.GetExecutingAssembly().GetName().Name)
                    printfn ""
                elif arg = "--help" || arg = "-h" then
                    printfn "Command line tool for watching and interpreting F# projects"
                    printfn ""
                    printfn "Usage: <tool> arg .. arg [-- <other-args>]"
                    printfn "       <tool> @args.rsp  [-- <other-args>]"
                    printfn "       <tool> ... Project.fsproj ... [-- <other-args>]"
                    printfn ""
                    printfn "The default source is a single project file in the current directory."
                    printfn "The default output is a JSON dump of the PortaCode."
                    printfn ""
                    printfn "Arguments:"
                    printfn "   --once            Don't enter watch mode (default: watch the source files of the project for changes)"
                    printfn "   --send:<url>      Send the JSON-encoded contents of the PortaCode to the webhook"
                    printfn "   --send            Equivalent to --send:%s" defaultUrl
                    printfn "   --projarg:arg  An MSBuild argument e.g. /p:Configuration=Release"
                    printfn "   --dump            Dump the contents to console after each update"
                    printfn "   --livecheck       Only evaluate those with a *CheckAttribute (e.g. LiveCheck or ShapeCheck)"
                    printfn "                     This uses on-demand execution semantics for top-level declarations"
                    printfn "                     Also write an info file based on results of evaluation."
                    printfn
                        "                     Also watch for .fsharp/foo.fsx.edit files and use the contents of those in preference to the source file"
                    printfn "   --dyntypes      Dynamically compile and load so full .NET types exist"
                    printfn "   <other-args>      All other args are assumed to be extra F# command line arguments, e.g. --define:FOO"
                    exit 1
                else
                    yield arg
        |]

    if fsharpArgs.Length = 0 && fsproj.IsNone then
        match Seq.toList (Directory.EnumerateFiles(Environment.CurrentDirectory, "*.fsproj")) with
        | [] -> failwithf "no project file found, no compilation arguments given and no project file found in \"%s\"" Environment.CurrentDirectory
        | [ file ] ->
            printfn "fslive: using implicit project file '%s'" file
            fsproj <- Some file
        | file1 :: file2 :: _ -> failwithf "multiple project files found, e.g. %s and %s" file1 file2

    let editDirAndFile (fileName: string) =
        assert useEditFiles
        let infoDir = Path.Combine(Path.GetDirectoryName fileName, ".fsharp")
        let editFile = Path.Combine(infoDir, Path.GetFileName fileName + ".edit")
        if not (Directory.Exists infoDir) then
            Directory.CreateDirectory infoDir |> ignore
        infoDir, editFile

    let readFile (fileName: string) =
        let readAllText file =
            use fs = File.Open(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
            use sr = new StreamReader(fs)
            sr.ReadToEnd()

        if useEditFiles && watch then
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

    let options =
        match fsproj with
        | Some fsprojFile ->
            if fsharpArgs.Length > 1 then
                failwith "can't give both project file and compilation arguments"
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

        | None ->
            let sourceFiles, otherFlags2 =
                fsharpArgs
                |> Array.partition (fun arg -> arg.EndsWith(".fs") || arg.EndsWith(".fsi") || arg.EndsWith(".fsx"))
            let otherFlags = [| yield! otherFlags; yield! otherFlags2 |]
            let sourceFiles = sourceFiles |> Array.map Path.GetFullPath
            printfn "CurrentDirectory = %s" Environment.CurrentDirectory

            match sourceFiles with
            | [| script |] when script.EndsWith(".fsx") ->
                let text = readFile script
                let otherFlags = Array.append otherFlags [| "--targetprofile:netcore" |]
                let options, errors =
                    checker.GetProjectOptionsFromScript(script, SourceText.ofString text, otherFlags = otherFlags, assumeDotNetFramework = false)
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
            | _ ->
                let options = checker.GetProjectOptionsFromCommandLineArgs("tmp.fsproj", otherFlags)
                let options = { options with SourceFiles = sourceFiles }
                Result.Ok options

    match options with
    | Result.Error () -> failwith "fslive: error processing project options or script"

    | Result.Ok options ->
        let options =
            { options with
                OtherOptions = Array.append options.OtherOptions (Array.ofList otherFlags)
            }
        //printfn "options = %A" options

        let rec checkFile count sourceFile =
            try
                let parseResults, checkResults =
                    checker.ParseAndCheckFileInProject(sourceFile, 0, SourceText.ofString (readFile sourceFile), options)
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

        let keepRanges = not dump
        let tolerateIncompleteExpressions = livecheck && watch
        let convFile (i: FSharpImplementationFileContents) =
            //(i.QualifiedName, i.FileName
            i.FileName,
            {
                Code = Convert(keepRanges, tolerateIncompleteExpressions).ConvertDecls i.Declarations
            }

        let checkFiles files =
            let rec loop rest acc =
                match rest with
                | file :: rest ->
                    match checkFile 0 (Path.GetFullPath(file)) with

                    // Note, if livecheck are on, we continue on regardless of errors
                    | Result.Error iopt when not livecheck ->
                        printfn "fslive: ERRORS for %s" file
                        Result.Error iopt

                    | Result.Error ((_, _, _, None) as info) -> Result.Error info
                    | Result.Ok (_, None) -> Result.Error(None, None, None, None)
                    | Result.Error (parseTree, _, _, Some implFile)
                    | Result.Ok (parseTree, Some implFile) ->
                        printfn "fslive: GOT PortaCode for %s" file
                        loop rest ((parseTree, implFile) :: acc)
                | [] -> Result.Ok(List.rev acc)
            loop (List.ofArray files) []


        let serializeCodeChanges files = { Changes = Array.map convFile files }.ToBytes()


        let sendToWebHook (hook: string) fileContents =
            try
                printfn "fslive: Serialize code ..."
                let data = Array.ofList fileContents |> serializeCodeChanges
                printfn "fslive: GOT Serialized data, length = %d" data.Length

                printfn "fslive: SENDING TO WEBHOOK... "
                sendCode data
                printfn "fslive: Send code successful"

            with
                | err -> printfn "fslive: ERROR SENDING TO WEBHOOK: %A" (err.ToString())


        let mutable lastCompileStart = System.DateTime.Now


        let changed why _ =
            try
                printfn "fslive: COMPILING (%s)...." why
                lastCompileStart <- System.DateTime.Now

                let filteredFiles =
                    options.SourceFiles
                    |> Array.filter (fun x ->
                        use fs = File.Open(x, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                        use sr = new StreamReader(fs)
                        if sr.Peek() >= 0 then
                            if sr.ReadLine().Contains("// hot-reload", StringComparison.OrdinalIgnoreCase) then
                                true
                            else
                                //printfn "ignored %s: because no \"// hot-reload\" at the top of the source file" x
                                false
                        else
                            false
                    )

                match checkFiles filteredFiles with
                | Result.Error res -> Result.Error res

                | Result.Ok allFileContents ->

                    // let parseTrees = List.choose fst allFileContents
                    let implFiles = List.map snd allFileContents
                    match webhook with
                    | Some hook ->
                        sendToWebHook hook implFiles
                        Result.Ok()
                    | None ->

                        if not dump && webhook.IsNone then
                            printfn "fslive: EVALUATING ALL INPUTS...."
                            let evaluator =
                                LiveCheckEvaluation(options.OtherOptions, dyntypes, writeinfo, keepRanges, livecheck, tolerateIncompleteExpressions)
                            match evaluator.EvaluateDecls implFiles with
                            | Error _ when not watch -> exit 1
                            | _ -> ()

                        // The default is to dump
                        if dump && webhook.IsNone then
                            let fileConvContents = serializeCodeChanges (Array.ofList implFiles)

                            printfn "%A" fileConvContents
                        Result.Ok()

            with
                | err when watch ->
                    printfn "fslive: exception: %A" (err.ToString())
                    for loc in err.EvalLocationStack do
                        printfn "   --> %O" loc
                    Result.Error(None, Some err, None, None)

        for o in options.OtherOptions do
            printfn "compiling, option %s" o

        if watch then
            // Send an immediate changed() event
            if webhook.IsNone then
                printfn "Sending initial changes... "
                changed "initial" () |> ignore

            let mkWatcher (sourceFile: string) =
                let path = Path.GetDirectoryName(sourceFile)
                let fileName = Path.GetFileName(sourceFile)
                printfn "fslive: WATCHING %s in %s" fileName path
                let watcher = new FileSystemWatcher(path, fileName)
                watcher.NotifyFilter <-
                    NotifyFilters.Attributes
                    ||| NotifyFilters.CreationTime
                    ||| NotifyFilters.FileName
                    ||| NotifyFilters.LastAccess
                    ||| NotifyFilters.LastWrite
                    ||| NotifyFilters.Size
                    ||| NotifyFilters.Security

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

            0, (fun () ->
                for watcher in watchers do
                    watcher.EnableRaisingEvents <- false
            )

        else
            -1, ignore
