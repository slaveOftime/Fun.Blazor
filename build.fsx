#r "nuget: Fun.Build, 1.0.2"
#r "nuget: Fake.IO.FileSystem, 6.0.0"

#load "docs.fsx"

open Fun.Build
open Fun.Result
open Fake.IO
open Fake.IO.FileSystemOperators
open Fake.IO.Globbing.Operators


let options = {|
    NUGET_API_KEY = EnvArg.Create("NUGET_API_KEY", description = "NUGET api key")
    WASM = CmdArg.Create(longName = "--wasm", description = "Run in blazor wasm mode, By default will run in server mode.")
|}


let stage_checkEnv =
    stage "Check envs" {
        stage "generate Directory.build.props for version control" {
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

let stage_pack =
    let stage_packNuget projDir =
        let version = Changelog.GetLastVersion(projDir) |> Option.defaultWith (fun _ -> failwith "No version available")
        stage $"Pack Nuget for {projDir}" {
            workingDir projDir
            run $"dotnet pack -c Release -o {__SOURCE_DIRECTORY__} /p:Version={version.Version}"
        }
    stage "Pack" {
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


pipeline "test" {
    description "Test related functions"
    stage_checkEnv
    stage_test
    runIfOnlySpecified
}


tryPrintPipelineCommandHelp ()
