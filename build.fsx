#r "nuget: Fun.Build, 1.0.2"
#r "nuget: Fake.IO.FileSystem, 6.0.0"
#r "nuget: FsHttp, 12.0.0"

#load "docs.fsx"

open System
open System.IO
open Fun.Build
open Fun.Result
open Fake.IO
open Fake.IO.FileSystemOperators
open Fake.IO.Globbing.Operators
open FsHttp


let options = {|
    NUGET_API_KEY = EnvArg.Create("NUGET_API_KEY", description = "NUGET api key")
    WASM = CmdArg.Create(longName = "--wasm", description = "Run in blazor wasm mode, By default will run in server mode.")
|}


let getBindingInfos () =
    Directory.GetDirectories("Bindings")
    |> Seq.map (fun x -> x </> Path.GetFileName x + ".fsproj")
    |> Seq.filter File.exists
    |> Seq.map (fun file ->
        let fileContent = File.readAsString file 
        let version =
            let startIndex = fileContent.IndexOf("Version=") + 9
            let endIndex = fileContent.IndexOf("\"", startIndex)
            fileContent.Substring(startIndex, endIndex - startIndex)
        let package =
            let endIndex = fileContent.IndexOf("Version=") - 2
            let startIndex = fileContent.LastIndexOf("Include=", endIndex) + 9
            fileContent.Substring(startIndex, endIndex - startIndex)
        {| name = Path.GetFileNameWithoutExtension file; package = package; version = version |}
    )


let getNugetPackageLatestVersion package =
    printfn "Fetch latest version"
    http { GET $"https://api.nuget.org/v3-flatcontainer/{package}/index.json" }
    |> Request.send
    |> Response.deserializeJson<{| versions: string list |}>
    |> fun x -> x.versions
    |> Seq.filter (Seq.exists (fun c -> c >= 'a' && c <= 'z') >> not)
    |> Seq.last


let stage_checkEnv =
    stage "Check envs" {
        stage "generate Directory.Build.props for version control" {
            run (fun _ ->
                !! "./*/CHANGELOG.md"
                |> Seq.iter (fun file ->
                    printfn "%s %s" file (Path.getDirectory file)
                    let version = Path.getDirectory file |> Changelog.GetLastVersion |> Option.defaultWith (fun _ -> failwith "No version available")
                    $"""<!-- auto generated -->
<Project>
    <PropertyGroup>
        <Version>{version.Version}</Version>
    </PropertyGroup>
</Project>"""
                    |> File.writeString false (Path.getDirectory file </> "Directory.Build.props")
                )
            )
        }
        run "dotnet restore"
        run "dotnet build"
        run (ignore >> Docs.DocBuilder.build)
    }

let stage_test =
    stage "Test" {
        run "dotnet build"
        run "dotnet test --no-build"
    }

let stage_packNuget projDir =
    let version = Changelog.GetLastVersion(projDir) |> Option.defaultWith (fun _ -> failwith "No version available")
    stage $"Pack Nuget for {projDir}" {
        workingDir projDir
        run $"dotnet pack -c Release -o {__SOURCE_DIRECTORY__} /p:Version={version.Version}"
    }

let stage_generateBindingProjects name package nsp patch =
    let projectName = "Fun.Blazor." + name
    let projectDir = "Bindings" </> projectName

    stage name {
        workingDir projectDir
        whenAny {
            whenNot { cmdArg "--package" }
            whenCmd {
                longName "--package"
                description "Generate when specified"
                acceptValues [ projectName ]
            }
        }
        noStdRedirectForStep
        run (fun _ ->
            let version = getNugetPackageLatestVersion()
            printfn $"Found verion {version} for package {package}"

            let version = if String.IsNullOrEmpty patch then version else version + "." + "patch"

            Directory.ensure projectDir
            File.write false (projectDir </> projectName + ".fsproj") [
                $"""
<Project Sdk="Microsoft.NET.Sdk.Razor">
  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <GenerateDocumentationFile>true</GenerateDocumentationFile>
    <TrimMode>link</TrimMode>
    <IsTrimmable>true</IsTrimmable>
    <Version>{version}</Version>
  </PropertyGroup>
  <ItemGroup>
    <PackageReference FunBlazor="" FunBlazorNamespace="{nsp}" Include="{package}" Version="{version}" />
  </ItemGroup>
  <ItemGroup>
    <ProjectReference Include="..\..\Fun.Blazor\Fun.Blazor.fsproj" />
  </ItemGroup>
</Project>"""
            ]
        )
        run $"dotnet run --project ../../Fun.Blazor.Cli/Fun.Blazor.Cli.fsproj --framework net8.0 -- generate {projectName}.fsproj"
        run (fun ctx -> async {
            let! result = ctx.RunCommand "dotnet build"
            result |> Result.mapError (sprintf "[red]build failed %s[/]" >> Spectre.Console.AnsiConsole.MarkupLine) |> ignore
            return Ok()
        })
    }

let stage_pack =
    stage "Pack" {
        stage "core projects" {
            whenNot { cmdArg "--bindings" }
            stage_packNuget "Fun.Blazor"
            stage_packNuget "Fun.Blazor.CustomElements"
            stage_packNuget "Fun.Blazor.Cli"
            stage_packNuget "Fun.Blazor.Elmish"
            stage_packNuget "Fun.Blazor.Generator"
            stage_packNuget "Fun.Blazor.HotReload"
            stage_packNuget "Fun.Blazor.HtmlTemplate"
            stage_packNuget "Fun.Blazor.Reactive"
            stage_packNuget "Fun.Blazor.Server"
            stage_packNuget "Fun.Blazor.Wasm"
            stage_packNuget "Fun.Htmx"
        }
        stage "bindings projects" {
            whenCmdArg "--bindings"
            run (fun ctx -> asyncResult {
                let files = 
                    Directory.GetDirectories("Bindings")
                    |> Seq.map (fun x -> x </> Path.GetFileName x + ".fsproj")
                    |> Seq.filter File.exists
                for file in files do
                    do! ctx.RunCommand $"dotnet pack {file} -c Release -o {__SOURCE_DIRECTORY__}"
            })
        }
    }


pipeline "dev" {
    description "Start develop with Fun.Blazor.Docs"
    stage_checkEnv
    stage "docs" {
        paralle
        stage "wasm" {
            workingDir "./Fun.Blazor.Docs.Wasm"
            whenCmdArg options.WASM
            run "dotnet run"
        }
        stage "server" {
            workingDir "./Fun.Blazor.Docs.Server"
            whenNot { cmdArg options.WASM }
            run "dotnet run"
        }
        stage "hot-reload" {
            workingDir "./Fun.Blazor.Cli"
            whenCmdArg "--hot-reload"
            run "dotnet run --framework net8.0 -- watch ../Fun.Blazor.Docs.Wasm/Fun.Blazor.Docs.Wasm.fsproj"
        }
    }
    runIfOnlySpecified
}


pipeline "docs" {
    description "Publish docs to github"
    stage_checkEnv
    stage "Publish docs" {
        run "dotnet publish Fun.Blazor.Docs.Wasm/Fun.Blazor.Docs.Wasm.fsproj -c Release -o Fun.Blazor.Docs.Wasm.Release --nologo"
        stage "Clean HEADOUTLET because it prevent app start" {
            run (fun _ ->
                !!("Fun.Blazor.Docs.Wasm.Release" </> "**" </> "index.html")
                |> Seq.iter (
                    File.applyReplace (fun x ->
                        let startIndex = x.IndexOf("<!-- %%-PRERENDERING-HEADOUTLET-BEGIN-%% -->")
                        let endIndex = x.IndexOf("<!-- %%-PRERENDERING-HEADOUTLET-END-%% -->") + 44
                        if startIndex > -1 then
                            x.Remove(startIndex, endIndex - startIndex)
                        else
                            x
                    )
                )
            )
        }
        stage "Tune" {
            whenBranch "master"
            whenEnvVar "GITHUB_ENV"
            run (fun _ ->
                !!("Fun.Blazor.Docs.Wasm.Release" </> "**" </> "index.html")
                |> Seq.iter (File.applyReplace (fun x -> x.Replace("""<base href="/"/>""", """<base href="/Fun.Blazor.Docs/" /> """)))
            )
            run "cp Fun.Blazor.Docs.Wasm.Release/wwwroot/index.html Fun.Blazor.Docs.Wasm.Release/wwwroot/404.html"
            run "touch Fun.Blazor.Docs.Wasm.Release/wwwroot/.nojekyll"
        }
    }
    runIfOnlySpecified
}


pipeline "packages" {
    description "Push packages to nuget"
    stage_checkEnv
    stage_test
    stage_pack
    stage "Push to nuget" {
        failIfIgnored
        whenBranch "master"
        whenEnvVar "GITHUB_ENV"
        whenEnvVar options.NUGET_API_KEY
        run (fun ctx ->
            let key = ctx.GetEnvVar options.NUGET_API_KEY.Name
            ctx.RunSensitiveCommand $"dotnet nuget push *.nupkg -s https://api.nuget.org/v3/index.json --skip-duplicate -k {key}"
        )
    }
    runIfOnlySpecified
}


pipeline "bindings" {
    description "Generate bindings project"
    stage_generateBindingProjects "Microsoft.Web" "Microsoft.AspNetCore.Components.Web" "Microsoft.AspNetCore.Components" ""
    stage_generateBindingProjects "Microsoft.Authorization" "Microsoft.AspNetCore.Components.Authorization" "Microsoft.AspNetCore.Components.Authorization" ""
    stage_generateBindingProjects "Microsoft.FluentUI" "Microsoft.FluentUI.AspNetCore.Components" "Microsoft.FluentUI.AspNetCore.Components" ""
    stage_generateBindingProjects "Microsoft.QuickGrid" "Microsoft.AspNetCore.Components.QuickGrid" "Microsoft.AspNetCore.Components.QuickGrid" ""
    stage_generateBindingProjects "AntDesign" "AntDesign" "AntDesign" ""
    stage_generateBindingProjects "MudBlazor" "MudBlazor" "MudBlazor" ""
    stage_generateBindingProjects "ApexCharts" "Blazor-ApexCharts" "ApexCharts" ""
    stage_generateBindingProjects "BlazorMonaco" "BlazorMonaco" "BlazorMonaco" ""
    stage "pack for binding projects" {
        run (fun _ ->
            printfn "Update binding docs"
            File.write false ("Docs" </> "17 Bindings" </> "README.md") [
                "# Bindings"
                ""
                "Below is auto generated bindings, if the version does not match your requirements you can use the Fun.Blazor.Cli to generate your own."
                ""
                "```bash"
                for info in getBindingInfos() do
                    $"dotnet add package {info.name} --version {info.version}"
                "```"
            ]
        )
    }
    runIfOnlySpecified
}


pipeline "bindings-check" {
    description "Check if there is new version for the binding project"
    stage "check" {
        run (fun _ ->
            getBindingInfos()
            |> Seq.choose (fun info ->
                let latestVersion = getNugetPackageLatestVersion info.package
                if latestVersion <> info.version then Some $"Package {info.package} should be updated from {info.version} to {latestVersion}"
                else None
            )
            |> String.concat "\n"
            |> function
                | SafeString x -> Error x
                | _ -> Ok()
        )
    }
    runIfOnlySpecified
}


pipeline "test" {
    description "Test related functions"
    stage_checkEnv
    stage_test
    runIfOnlySpecified
}


tryPrintPipelineCommandHelp ()
