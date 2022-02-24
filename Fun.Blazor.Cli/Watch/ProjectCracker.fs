module FSharpDaemon.ProjectCracker

open System
open System.IO
open System.Collections.Concurrent
open FSharp.Compiler.CodeAnalysis


module MSBuildPrj = Dotnet.ProjInfo.Inspect

type NavigateProjectSM =
    | NoCrossTargeting of NoCrossTargetingData
    | CrossTargeting of string list
and NoCrossTargetingData =
    {
        FscArgs: string list
        P2PRefs: MSBuildPrj.ResolvedP2PRefsInfo list
        Properties: Map<string, string>
    }

module MSBuildKnownProperties =
    let TargetFramework = "TargetFramework"
    let DefineConstants = "DefineConstants"

module Option =
    let getOrElse defaultValue option =
        match option with
        | None -> defaultValue
        | Some x -> x


type FilePath = string

[<RequireQualifiedAccess>]
type ProjectSdkType = | DotnetSdk of ProjectSdkTypeDotnetSdk
and ProjectSdkTypeVerbose = { TargetPath: string }
and ProjectSdkTypeDotnetSdk =
    {
        Configuration: string // Debug
        TargetFramework: string // netcoreapp1.0
        DefineConstants: string
        RestoreSuccess: bool // True
        Configurations: string list // Debug;Release
        TargetFrameworks: string list // netcoreapp1.0;netstandard1.6
        TargetPath: string
    }

type ExtraProjectInfoData =
    {
        ProjectOutputType: ProjectOutputType
        ProjectSdkType: ProjectSdkType
    }
and ProjectOutputType =
    | Library
    | Exe
    | Custom of string


type private ProjectParsingSdk =
    | DotnetSdk
#if OLDFORMATS
    | VerboseSdk
#endif

type ParsedProject = string * FSharpProjectOptions * ((string * string) list)
type ParsedProjectCache = ConcurrentDictionary<string, ParsedProject>

let chooseByPrefix (prefix: string) (s: string) =
    if s.StartsWith(prefix) then Some(s.Substring(prefix.Length)) else None

let chooseByPrefix2 prefixes (s: string) =
    prefixes |> List.tryPick (fun prefix -> chooseByPrefix prefix s)

let splitByPrefix (prefix: string) (s: string) =
    if s.StartsWith(prefix) then Some(prefix, s.Substring(prefix.Length)) else None

let splitByPrefix2 prefixes (s: string) =
    prefixes |> List.tryPick (fun prefix -> splitByPrefix prefix s)

let outType rsp =
    match List.tryPick (chooseByPrefix "--target:") rsp with
    | Some "library" -> ProjectOutputType.Library
    | Some "exe" -> ProjectOutputType.Exe
    | Some v -> ProjectOutputType.Custom v
    | None -> ProjectOutputType.Exe // default if arg is not passed to fsc

let private outputFileArg = [ "--out:"; "-o:" ]

let private makeAbs projDir (f: string) =
    if Path.IsPathRooted f then f else Path.Combine(projDir, f)

let outputFile projDir rsp =
    rsp |> List.tryPick (chooseByPrefix2 outputFileArg) |> Option.map (makeAbs projDir)

let isCompileFile (s: string) = s.EndsWith(".fs") || s.EndsWith(".fsi")

let compileFiles =
    //TODO filter the one without initial -
    List.filter isCompileFile

let references = List.choose (chooseByPrefix "-r:")

let useFullPaths projDir (s: string) =
    match s |> splitByPrefix2 outputFileArg with
    | Some (prefix, v) -> prefix + (v |> makeAbs projDir)
    | None -> if isCompileFile s then s |> makeAbs projDir |> Path.GetFullPath else s

let msbuildPropProjectOutputType (s: string) =
    match s.Trim() with
    | MSBuildPrj.MSBuild.ConditionEquals "Exe" -> ProjectOutputType.Exe
    | MSBuildPrj.MSBuild.ConditionEquals "Library" -> ProjectOutputType.Library
    | x -> ProjectOutputType.Custom x

let msbuildPropBool (s: string) =
    match s.Trim() with
    | "" -> None
    | Dotnet.ProjInfo.Inspect.MSBuild.ConditionEquals "True" -> Some true
    | _ -> Some false

let msbuildPropStringList (s: string) =
    match s.Trim() with
    | "" -> []
    | Dotnet.ProjInfo.Inspect.MSBuild.StringList list -> list
    | _ -> []

let getExtraInfo targetPath props =
    let msbuildPropBool prop =
        props |> Map.tryFind prop |> Option.bind msbuildPropBool
    let msbuildPropStringList prop =
        props |> Map.tryFind prop |> Option.map msbuildPropStringList
    let msbuildPropString prop = props |> Map.tryFind prop

    {
        Configuration = msbuildPropString "Configuration" |> Option.getOrElse ""
        TargetFramework = msbuildPropString MSBuildKnownProperties.TargetFramework |> Option.getOrElse ""
        DefineConstants = msbuildPropString MSBuildKnownProperties.DefineConstants |> Option.getOrElse ""
        TargetPath = targetPath
        RestoreSuccess = msbuildPropBool "RestoreSuccess" |> Option.getOrElse false
        Configurations = msbuildPropStringList "Configurations" |> Option.getOrElse []
        TargetFrameworks = msbuildPropStringList "TargetFrameworks" |> Option.getOrElse []
    }

let (|MsbuildOk|_|) x =
    match x with
    | Ok x -> Some x
    | Error _ -> None

let (|MsbuildError|_|) x =
    match x with
    | Ok _ -> None
    | Error x -> Some x

let runProcess (log: string -> unit) (workingDir: string) (exePath: string) (args: string) =
    let psi = System.Diagnostics.ProcessStartInfo()
    psi.FileName <- exePath
    psi.WorkingDirectory <- workingDir
    psi.RedirectStandardOutput <- true
    psi.RedirectStandardError <- true
    psi.Arguments <- args
    psi.CreateNoWindow <- true
    psi.UseShellExecute <- false

    use p = new System.Diagnostics.Process()
    p.StartInfo <- psi

    p.OutputDataReceived.Add(fun ea -> log (ea.Data))

    p.ErrorDataReceived.Add(fun ea -> log (ea.Data))

    printfn "running: %s %s" psi.FileName psi.Arguments

    p.Start() |> ignore
    p.BeginOutputReadLine()
    p.BeginErrorReadLine()
    p.WaitForExit()

    let exitCode = p.ExitCode

    exitCode, (workingDir, exePath, args)


let private getProjectOptionsFromProjectFile (cache: ParsedProjectCache) parseAsSdk (file: string) msbuildArgs =

    let rec projInfoOf additionalMSBuildProps (file: string) : ParsedProject =
        let projDir = Path.GetDirectoryName file

        match parseAsSdk with
        | ProjectParsingSdk.DotnetSdk ->
            let projectAssetsJsonPath = Path.Combine(projDir, "obj", "project.assets.json")
            if not (File.Exists(projectAssetsJsonPath)) then
                failwithf "project '%s' not restored" file

        let getFscArgs =
            match parseAsSdk with
            | ProjectParsingSdk.DotnetSdk -> Dotnet.ProjInfo.Inspect.getFscArgs

        let getP2PRefs = Dotnet.ProjInfo.Inspect.getResolvedP2PRefs
        let additionalInfo = //needed for extra
            [
                "OutputType"
                "Configuration"
                MSBuildKnownProperties.TargetFramework
                "RestoreSuccess"
                "Configurations"
                "TargetFrameworks"
            ]
        let gp () =
            Dotnet.ProjInfo.Inspect.getProperties ([ "TargetPath"; "IsCrossTargetingBuild"; "TargetFrameworks" ] @ additionalInfo)

        let results, log =
            let loggedMessages = System.Collections.Concurrent.ConcurrentQueue<string>()

            let runCmd exePath args =
                let args = args @ msbuildArgs
                runProcess loggedMessages.Enqueue projDir exePath (args |> String.concat " ")

            let msbuildExec =
                let msbuildPath =
                    match parseAsSdk with
                    | ProjectParsingSdk.DotnetSdk -> Dotnet.ProjInfo.Inspect.MSBuildExePath.DotnetMsbuild "dotnet"
                Dotnet.ProjInfo.Inspect.msbuild msbuildPath runCmd

            let additionalArgs =
                additionalMSBuildProps |> List.map (Dotnet.ProjInfo.Inspect.MSBuild.MSbuildCli.Property)

            let inspect =
                match parseAsSdk with
                | ProjectParsingSdk.DotnetSdk -> Dotnet.ProjInfo.Inspect.getProjectInfos

            let infoResult =
                file |> inspect loggedMessages.Enqueue msbuildExec [ getFscArgs; getP2PRefs; gp ] additionalArgs

            infoResult, (loggedMessages.ToArray() |> Array.toList)

        let todo =
            match results with
            | MsbuildOk [ getFscArgsResult; getP2PRefsResult; gpResult ] ->
                match getFscArgsResult, getP2PRefsResult, gpResult with
                | MsbuildError (MSBuildPrj.MSBuildSkippedTarget),
                  MsbuildError (MSBuildPrj.MSBuildSkippedTarget),
                  MsbuildOk (MSBuildPrj.GetResult.Properties props) ->
                    // Projects with multiple target frameworks, fails if the target framework is not choosen
                    let prop key = props |> Map.ofList |> Map.tryFind key

                    match prop "IsCrossTargetingBuild", prop "TargetFrameworks" with
                    | Some (MSBuildPrj.MSBuild.ConditionEquals "true"), Some (MSBuildPrj.MSBuild.StringList tfms) -> CrossTargeting tfms
                    | _ -> failwithf "error getting msbuild info: some targets skipped, found props: %A" props
                | MsbuildOk (MSBuildPrj.GetResult.FscArgs fa),
                  MsbuildOk (MSBuildPrj.GetResult.ResolvedP2PRefs p2p),
                  MsbuildOk (MSBuildPrj.GetResult.Properties p) ->
                    NoCrossTargeting
                        {
                            FscArgs = fa
                            P2PRefs = p2p
                            Properties = p |> Map.ofList
                        }
                | r -> failwithf "error getting msbuild info: %A" r
            | MsbuildOk r -> failwithf "error getting msbuild info: internal error, more info returned than expected %A" r
            | MsbuildError r ->
                match r with
                | Dotnet.ProjInfo.Inspect.GetProjectInfoErrors.MSBuildSkippedTarget -> failwithf "Unexpected MSBuild result, all targets skipped"
                | Dotnet.ProjInfo.Inspect.GetProjectInfoErrors.UnexpectedMSBuildResult (r) -> failwithf "Unexpected MSBuild result %s" r
                | Dotnet.ProjInfo.Inspect.GetProjectInfoErrors.MSBuildFailed (exitCode, (workDir, exePath, args)) ->
                    let logMsg = [ yield "Log: "; yield! log ] |> String.concat (Environment.NewLine)
                    let msbuildErrorMsg =
                        [
                            sprintf "MSBuild failed with exitCode %i" exitCode
                            sprintf "Working Directory: '%s'" workDir
                            sprintf "Exe Path: '%s'" exePath
                            sprintf "Args: '%s'" args
                        ]
                        |> String.concat " "

                    failwithf "%s%s%s" msbuildErrorMsg (Environment.NewLine) logMsg
            | _ -> failwithf "error getting msbuild info: internal error"

        match todo with
        | CrossTargeting (tfm :: _) ->
            // Atm setting a preferenece is not supported in FSAC
            // As workaround, lets choose the first of the target frameworks and use that
            file
            |> projInfo [
                MSBuildKnownProperties.TargetFramework, tfm
               ]
        | CrossTargeting [] -> failwithf "Unexpected, found cross targeting but empty target frameworks list"
        | NoCrossTargeting { FscArgs = rsp; P2PRefs = p2ps; Properties = props } ->

            //TODO cache projects info of p2p ref
            let p2pProjects =
                p2ps
                // do not follow others lang project, is not supported by FCS anyway
                |> List.filter (fun p2p -> p2p.ProjectReferenceFullPath.ToLower().EndsWith(".fsproj"))
                |> List.map (fun p2p ->
                    let followP2pArgs =
                        p2p.TargetFramework
                        |> Option.map (fun tfm -> MSBuildKnownProperties.TargetFramework, tfm)
                        |> Option.toList
                    p2p.ProjectReferenceFullPath |> projInfo followP2pArgs
                )

            let tar =
                match props |> Map.tryFind "TargetPath" with
                | Some t -> t
                | None -> failwith "error, 'TargetPath' property not found"

            let rspNormalized =
                //workaround, arguments in rsp can use relative paths
                rsp |> List.map (useFullPaths projDir)

            let sdkTypeData, log =
                match parseAsSdk with
                | ProjectParsingSdk.DotnetSdk ->
                    let extraInfo = getExtraInfo tar props
                    ProjectSdkType.DotnetSdk(extraInfo), []

            let po =
                {
                    ProjectId = Some file
                    ProjectFileName = file
                    SourceFiles = [||]
                    OtherOptions = rspNormalized |> Array.ofList
                    ReferencedProjects = [||] //p2pProjects |> List.map (fun (x,y,_) -> (x,y)) |> Array.ofList
                    IsIncompleteTypeCheckEnvironment = false
                    UseScriptResolutionRules = false
                    LoadTime = DateTime.Now
                    UnresolvedReferences = None
                    OriginalLoadReferences = []
                    Stamp = None
                }

            tar, po, log

    and projInfo additionalMSBuildProps file : ParsedProject =
        let key = sprintf "%s;%A" file additionalMSBuildProps
        match cache.TryGetValue(key) with
        | true, alreadyParsed -> alreadyParsed
        | false, _ ->
            let p = file |> projInfoOf additionalMSBuildProps
            cache.AddOrUpdate(key, p, (fun _ _ -> p))


    let _, po, log = projInfo [] file
    po, log


let private loadBySdk (cache: ParsedProjectCache) parseAsSdk msbuildArgs file =
    let po, log = getProjectOptionsFromProjectFile cache parseAsSdk msbuildArgs file

    let compileFiles = compileFiles (po.OtherOptions |> List.ofArray)

    Ok(po, Seq.toList compileFiles, (log |> Map.ofList))

let load (cache: ParsedProjectCache) msbuildArgs file =
    loadBySdk cache ProjectParsingSdk.DotnetSdk msbuildArgs file
