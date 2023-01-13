open System.IO
open Spectre.Console
open Spectre.Console.Cli
open Fun.Blazor.Generator
open Fun.Blazor.Cli


type WatchCommand() =
    inherit Command<WatchSettings>()

    override _.Execute(_, settings) =
        Watch.WatcherServer.runServer settings
        0


type GenerateCommand() =
    inherit Command<CodeGenSettings>()

    override _.Execute(_, settings) =
        let path =
            if Path.IsPathRooted settings.Project && File.Exists settings.Project then
                Some settings.Project

            elif Path.IsPathRooted settings.Project && Directory.Exists settings.Project then
                Directory.GetFiles settings.Project |> Seq.tryFind (fun f -> f.EndsWith ".fsproj")

            elif
                Path.IsPathRooted settings.Project |> not
                && File.Exists(Path.Combine(Directory.GetCurrentDirectory(), settings.Project))
            then
                Path.Combine(Directory.GetCurrentDirectory(), settings.Project) |> Some

            elif
                Path.IsPathRooted settings.Project |> not
                && Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), settings.Project))
            then
                Path.Combine(Directory.GetCurrentDirectory(), settings.Project)
                |> Directory.GetFiles
                |> Seq.tryFind (fun f -> f.EndsWith ".fsproj")

            else
                None

        match path with
        | None ->
            AnsiConsole.MarkupLine "[red] project is required[/]"
            -1
        | Some path ->
            CodeGen.Generate.startGenerate path settings.OutDir settings.Style settings.Sdk settings.GeneratorVersion settings.Inline settings.KeepCodeGenProj
            0


module Program =

    [<EntryPoint>]
    let main args =
        AnsiConsole.Write(FigletText("Fun.Blazor.Cli", Color = Color.CadetBlue))

        let application = CommandApp()

        application.Configure(fun config ->
            config
                .AddCommand<WatchCommand>("watch")
                .WithDescription("Used for hot-reload")
                .WithExample([| "watch"; "{your fsharp project}"; "--server"; "https://localhost:5001" |])
            |> ignore

            config
                .AddCommand<GenerateCommand>("generate")
                .WithDescription("Generate DSL for blazor libraries like Microsoft.AspNetCore.Components.Web, MudBlazor etc.")
                .WithExample([| "generate" |])
            |> ignore
        )

        application.Run args
