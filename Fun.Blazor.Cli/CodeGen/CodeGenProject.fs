﻿namespace Fun.Blazor.Cli.CodeGen

open System
open System.IO
open System.Text
open System.Reflection
open System.Threading.Tasks
open Spectre.Console
open CliWrap
open Fun.Blazor.Generator


[<RequireQualifiedAccess>]
type Package =
    | Project of string
    | Package of {| Name: string; Version: string |}


type PackageMeta =
    {
        Package: Package
        SourceAssemblyName: string
        TargetNamespace: string
        Style: Style
        UseInline: bool
    }


module CodeGenProject =

    let private (</>) x y = Path.Combine(x, y)

    let private outputPipe =
        PipeTarget.ToDelegate(fun (str: string) -> task { AnsiConsole.Write str } :> Task)

    let private errorPipe =
        PipeTarget.ToDelegate(fun (str: string) -> task { AnsiConsole.Write str } :> Task)

    type Command with

        member this.Run() =
            this.WithStandardOutputPipe(outputPipe).WithStandardErrorPipe(errorPipe).ExecuteAsync().GetAwaiter().GetResult()
            |> ignore


    let createAndRun keepCodeGenProj (projectFile: string) codesDirName sdk generatorVersion packages =
        AnsiConsole.MarkupLine "[green]Create temp project[/]"
        
        let projDir = Path.GetDirectoryName projectFile
        let codesDir = projDir </> codesDirName
        let codeGenFolder = projDir </> "bin" </> "FunBlazorCli-" + Guid.NewGuid().ToString()

        Directory.CreateDirectory codeGenFolder |> ignore

        let command =
            match sdk with
            | None -> "new console -lang f#"
            | Some x -> $"new console -lang f# -f net{x}"

        Cli.Wrap("dotnet").WithArguments(command).WithWorkingDirectory(codeGenFolder).Run()

        
        AnsiConsole.WriteLine()
        AnsiConsole.MarkupLine "[green]Add Fun.Blazor.Generator[/]"

#if DEBUG
        let generatorProject =
            __SOURCE_DIRECTORY__ </> ".." </> ".." </> "Fun.Blazor.Generator" </> "Fun.Blazor.Generator.fsproj"
        Cli.Wrap("dotnet").WithArguments($"add reference {generatorProject}").WithWorkingDirectory(codeGenFolder).Run()
#else
        let version =
            if String.IsNullOrEmpty generatorVersion then ""
            elif generatorVersion = "prerelease" then "--prerelease"
            else $"--version {generatorVersion}"
        Cli.Wrap("dotnet").WithArguments($"add package Fun.Blazor.Generator {version}").WithWorkingDirectory(codeGenFolder).Run()
#endif


        let bootstrapCode = StringBuilder()

        for package in packages do
            AnsiConsole.WriteLine()
            AnsiConsole.MarkupLine $"[green]Add package {package.Package}[/]"
            match package.Package with
            | Package.Package package ->
                Cli
                    .Wrap("dotnet")
                    .WithArguments($"add package {package.Name} --version {package.Version}")
                    .WithWorkingDirectory(codeGenFolder)
                    .Run()
            | Package.Project project ->
                Cli
                    .Wrap("dotnet")
                    .WithArguments($"add reference \"{project}\"")
                    .WithWorkingDirectory(codeGenFolder)
                    .Run()

            bootstrapCode.AppendLine
                $"Fun.Blazor.Generator.CodeGen.createCodeFile @\"{codesDir}\" Fun.Blazor.Generator.Style.{package.Style} \"{package.TargetNamespace}\" \"{package.SourceAssemblyName}\" {package.UseInline.ToString().ToLower()}"
            |> ignore
        
        AnsiConsole.WriteLine()
        AnsiConsole.MarkupLine $"[green]Add bootstrap codes[/]"
        File.WriteAllText(codeGenFolder </> "Program.fs", bootstrapCode.ToString())
        
        AnsiConsole.WriteLine()
        AnsiConsole.MarkupLine $"[green]Start generating code[/]"
        Cli.Wrap("dotnet").WithArguments($"run").WithWorkingDirectory(codeGenFolder).Run()

        AnsiConsole.MarkupLine $"[green]Clean temp project[/]"
        try
            if not keepCodeGenProj then Directory.Delete(codeGenFolder, true)
        with
            | _ -> ()
