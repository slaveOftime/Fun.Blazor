open System
open System.IO
open System.ComponentModel
open Spectre.Console
open Spectre.Console.Cli

open Fun.Blazor.Cli
open Fun.Blazor.Cli.Generate


type GenerateSettings() =
    inherit CommandSettings()

    [<Description("Project you want to add bindings")>]
    [<CommandArgument(0, "[PROJECT]")>]
    member val Project = "" with get, set

    [<Description("Output directory of generated codes")>]
    [<CommandOption("-o|--outDir")>]
    member val OutDir = "Fun.Blazor.Bindings" with get, set
    
    [<Description("Dsl style Feliz|CE")>]
    [<CommandOption("-s|--style")>]
    member val Style = Style.Feliz with get, set


type GenerateCommand() =
    inherit Command<GenerateSettings>()

    override _.Execute (ctx, settings) =
        let path =
            if Path.IsPathRooted settings.Project && File.Exists settings.Project then
                Some settings.Project

            elif Path.IsPathRooted settings.Project && Directory.Exists settings.Project then
                Directory.GetFiles settings.Project
                |> Seq.tryFind (fun f -> f.EndsWith ".fsproj")

            elif Path.IsPathRooted settings.Project |> not && File.Exists(Path.Combine(Directory.GetCurrentDirectory(), settings.Project)) then
                Path.Combine(Directory.GetCurrentDirectory(), settings.Project) |> Some

            elif Path.IsPathRooted settings.Project |> not && Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), settings.Project)) then
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
            Generate.startGenerate path settings.OutDir settings.Style
            0


module Program =

    [<EntryPoint>]
    let main args =
        AnsiConsole.Render(FigletText("Fun.Blazor.Cli", Color = Color.CadetBlue))

        let application = CommandApp()

        application.Configure(fun config ->
            config.AddCommand<GenerateCommand>("generate") |> ignore)

        application.Run args
