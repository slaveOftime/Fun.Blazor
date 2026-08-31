// Copyright 2018 Fabulous contributors. See LICENSE.md for license.
//
// Processor: the hot-reload watcher's core. Responsibilities, in order below:
//   1. resolve project options + assembly references (resolveReferences)
//   2. check files with FSharp.Compiler.Service (checkFile / checkFiles)
//   3. convert checked files to PortaCode and maintain per-file caches
//      (portaCache, entityToFile, entityRefsByFile)
//   4. compute the reverse-dependency closure of a change (affectedFiles)
//   5. debounce file-watch events and trigger re-checks (scheduleCompile / recheckChanged)
//   6. watch source files (mkWatcher) and warm the cache at startup
// The "// hot-reload" first-line marker only decides which files *trigger* a
// recompile when saved; the dependency closure re-evaluates intermediate files.

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


let private readFile (fileName: string) =
    use fs = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
    use sr = new StreamReader(fs)
    sr.ReadToEnd()


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


/// Extract the declared module/type entity names from a checked implementation file,
/// so we can locate which file contains a given render entry ("Module.member").
let private entityNamesOfImplFile (i: FSharpImplementationFileContents) =
    let names = ResizeArray<string>()
    let rec walk (decls: FSharpImplementationFileDeclaration list) =
        for d in decls do
            match d with
            | FSharpImplementationFileDeclaration.Entity (e, sub) ->
                if not e.IsNamespace then
                    names.Add(defaultArg e.QualifiedName e.CompiledName)
                walk sub
            | FSharpImplementationFileDeclaration.MemberOrFunctionOrValue _ -> ()
            | FSharpImplementationFileDeclaration.InitAction _ -> ()
    walk i.Declarations
    names.ToArray()


let process' sendCode (source: Source) (msbuildArgs: string list) (getEntries: unit -> string []) =
    let mutable lastCompileStart = System.DateTime.Now


    let options =
        match source with
        | FSharpProj fsprojFile ->
            let fullPath = Path.GetFullPath fsprojFile
            match FSharpDaemon.ProjectCracker.load (new System.Collections.Concurrent.ConcurrentDictionary<_, _>()) fullPath msbuildArgs with
            | Ok (options, sourceFiles, _log) ->
                let sourceFilesSet = Set.ofList sourceFiles
                let otherOptions = options.OtherOptions |> Array.filter (fun s -> not (sourceFilesSet.Contains(s)))
                let projectDir = Path.GetDirectoryName fullPath
                let sourceFiles =
                    sourceFiles
                    |> List.map (fun file ->
                        if Path.IsPathRooted file then file else Path.Combine(projectDir, file))
                    |> List.map Path.GetFullPath
                let options = { options with SourceFiles = Array.ofList sourceFiles }

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
            let text = readFile script
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
        let entityRefsByFile = System.Collections.Concurrent.ConcurrentDictionary<string, DEntityRef []>()
        let fileVersions = System.Collections.Concurrent.ConcurrentDictionary<string, int>()

        let rec checkFile count sourceFile =
            try
                let fileVersion =
                    fileVersions.AddOrUpdate(Path.GetFullPath sourceFile, 1, fun _ version -> version + 1)
                let parseResults, checkResults =
                    checker.ParseAndCheckFileInProject(sourceFile, fileVersion, SourceText.ofString (readFile sourceFile), options)
                    |> Async.RunSynchronously
                match checkResults with
                | FSharpCheckFileAnswer.Aborted ->
                    failwith "unexpected aborted"
                    Result.Error(Some parseResults.ParseTree, None, None, None)

                | FSharpCheckFileAnswer.Succeeded res ->
                    entityRefsByFile.[Path.GetFullPath sourceFile] <-
                        res.GetAllUsesOfAllSymbolsInFile()
                        |> Seq.choose (fun (symbolUse: FSharpSymbolUse) ->
                            if symbolUse.IsFromDefinition then
                                None
                            else
                                match symbolUse.Symbol with
                                | :? FSharpMemberOrFunctionOrValue as value when value.IsModuleValueOrMember ->
                                    value.DeclaringEntity
                                    |> Option.map (fun entity -> DEntityRef(defaultArg entity.QualifiedName entity.CompiledName))
                                | _ -> None)
                        |> Seq.distinct
                        |> Seq.toArray

                    if res.HasErrors then
                        for e in res.Diagnostics do
                            printfn "fslive: check diagnostic: %O" e
                    match res.ImplementationFile with
                    | None -> printfn "fslive: WARNING no implementation file for %s (references may be unresolved)" sourceFile
                    | Some _ -> ()
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


        // Accepts already-converted (fileName * DFile) pairs so unchanged files can be
        // served from the PortaCode cache without reconversion.
        let sendConverted (changes: (string * DFile) []) =
            try
                printfn "fslive: Serialize code ..."
                let data = { Changes = changes }.ToBytes()
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

        // Per-file PortaCode cache. FCS caches type-checks, but the PortaCode AST
        // conversion + serialization run per call, so we only reconvert files that
        // actually changed and reuse the cached DFile for the rest.
        let portaCache = System.Collections.Concurrent.ConcurrentDictionary<string, string * DFile>()

        // Map of declared entity (module/type) qualified name -> the file that declares
        // it. Used to locate the file containing a registered render entry.
        let entityToFile = System.Collections.Concurrent.ConcurrentDictionary<string, string>()

        // Entity references used by each converted file. This lets us follow actual
        // cross-file value dependencies instead of re-evaluating every marked file
        // between a change and the entry in compilation order.
        let indexEntities (implFile: FSharpImplementationFileContents) =
            let file = Path.GetFullPath implFile.FileName
            for name in entityNamesOfImplFile implFile do
                entityToFile.[name] <- file

        // The module part of a render entry name ("Full.Name.Module.member" -> "Full.Name.Module").
        let entryModule (entryName: string) =
            match entryName.LastIndexOf '.' with
            | i when i > 0 -> Some entryName.[.. i - 1]
            | _ -> None

        // Files that contain a registered render entry and are hot-reload enabled.
        let entryFiles () =
            getEntries ()
            |> Array.choose entryModule
            |> Array.choose (fun m ->
                match entityToFile.TryGetValue m with
                | true, f when isEnabled f -> Some f
                | _ -> None)
            |> Array.distinct

        let sourceFiles =
            options.SourceFiles
            |> Array.map Path.GetFullPath

        let sourceOrder =
            sourceFiles
            |> Array.mapi (fun index file -> file, index)
            |> dict

        let orderFiles files =
            files
            |> Array.distinct
            |> Array.sortBy (fun file -> sourceOrder.[file])

        let referencedEntities (dfile: DFile) =
            let refs = System.Collections.Generic.HashSet<DEntityRef>(HashIdentity.Structural)
            let bindings =
                System.Reflection.BindingFlags.Public
                ||| System.Reflection.BindingFlags.NonPublic

            let rec visit (value: obj) =
                match value with
                | null -> ()
                | :? DMemberRef as memberRef -> refs.Add memberRef.Entity |> ignore
                | :? string -> ()
                | :? System.Collections.IEnumerable as items ->
                    for item in items do visit item
                | value ->
                    let ty = value.GetType()

                    if ty.Assembly = typeof<DFile>.Assembly then
                        if Microsoft.FSharp.Reflection.FSharpType.IsUnion(ty, bindings) then
                            let _, fields = Microsoft.FSharp.Reflection.FSharpValue.GetUnionFields(value, ty, bindings)
                            for field in fields do visit field
                        elif Microsoft.FSharp.Reflection.FSharpType.IsRecord(ty, bindings) then
                            for field in Microsoft.FSharp.Reflection.FSharpValue.GetRecordFields(value, bindings) do
                                visit field

            visit dfile.Code
            refs |> Seq.toArray

        let cacheConverted (implFile: FSharpImplementationFileContents) =
            indexEntities implFile
            let fileName, dfile = convFile implFile
            let file = Path.GetFullPath fileName
            portaCache.[file] <- (fileName, dfile)
            entityRefsByFile.[file] <-
                match entityRefsByFile.TryGetValue file with
                | true, symbolRefs -> Array.append symbolRefs (referencedEntities dfile) |> Array.distinct
                | _ -> referencedEntities dfile

        // Follow actual reverse dependencies in F# compilation order. A later file is
        // affected when one of its member references belongs to an already affected file.
        // This walks the whole dependency closure regardless of the "// hot-reload"
        // marker: the marker only decides which files *trigger* a recompile when saved,
        // but intermediate files between a changed file and the render entry must still
        // be re-evaluated so their cached module values are refreshed.
        let affectedFiles (changedFiles: string []) =
            let affected = System.Collections.Generic.HashSet<string>(changedFiles)

            for file in sourceFiles do
                if not (affected.Contains file) then
                    match entityRefsByFile.TryGetValue file with
                    | true, entityRefs ->
                        let dependsOnAffected =
                            entityRefs
                            |> Array.exists (fun (DEntityRef entityName) ->
                                match entityToFile.TryGetValue entityName with
                                | true, dependencyFile -> affected.Contains dependencyFile
                                | _ -> false)

                        if dependsOnAffected then affected.Add file |> ignore
                    | _ -> ()

            entryFiles ()
            |> Array.iter (affected.Add >> ignore)

            affected |> Seq.toArray |> orderFiles


        let recheckChanged why =
            try
                printfn "fslive: COMPILING (%s)...." why
                lastCompileStart <- System.DateTime.Now

                let changedFiles = pendingChanges.Keys |> Seq.toArray
                pendingChanges.Clear()

                // Refresh the hot-reload marker for changed files, then keep only
                // the ones still enabled.
                let enabledChanged =
                    changedFiles
                    |> Array.choose (fun f ->
                        let enabled = isFileHotReloadEnabled f
                        hotReloadEnabled.[f] <- enabled
                        if enabled then Some(Path.GetFullPath f) else None)

                match enabledChanged with
                | [||] ->
                    printfn "fslive: no hot-reload files changed, skipping"
                    Result.Ok()
                | _ ->
                    let affected = affectedFiles enabledChanged
                    printfn
                        "fslive: affected files: %s"
                        (affected |> Array.map Path.GetFileName |> String.concat ", ")

                    // Only changed files need a fresh FCS check and PortaCode conversion.
                    // Unchanged dependents are re-evaluated from the startup cache.
                    let missingFromCache =
                        affected
                        |> Array.filter (portaCache.ContainsKey >> not)

                    let toRecheck =
                        Array.append enabledChanged missingFromCache
                        |> orderFiles

                    match checkFiles toRecheck with
                    | Result.Error res -> Result.Error res
                    | Result.Ok fileContents ->
                        // Refresh the entity index + PortaCode cache for the re-checked files.
                        for (_, implFile) in fileContents do
                            cacheConverted implFile

                        // Re-evaluate the affected path in F# compilation order. This is
                        // important for cached module values: an entry may reference an
                        // intermediate value (e.g. App.app -> Routes.routes -> HomeView.home).
                        let toSend =
                            affected
                            |> Array.choose (fun f ->
                                match portaCache.TryGetValue f with
                                | true, df -> Some df
                                | _ -> None)

                        sendConverted toSend
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
            ]


        for watcher in watchers do
            watcher.EnableRaisingEvents <- true

        // One-time index of all project source files so the entity->file map and the
        // PortaCode cache are warm for the whole dependency closure (including
        // unmarked intermediate files between a changed file and the render entry).
        // FCS caches the checks, so later edits only reconvert changed files.
        async {
            let allFiles = options.SourceFiles |> Array.map Path.GetFullPath

            match checkFiles allFiles with
            | Result.Error _ -> printfn "fslive: initial indexing had errors (non-fatal)"
            | Result.Ok fileContents ->
                for (_, implFile) in fileContents do
                    cacheConverted implFile
                printfn "fslive: indexed %d source files" fileContents.Length
        }
        |> Async.Start

        { new IDisposable with
            member _.Dispose() =
                for watcher in watchers do
                    watcher.EnableRaisingEvents <- false
        }
