#r "nuget: Fun.Build, 0.5.1"
#r "nuget: Fake.IO.FileSystem, 5.20.4"

#load "docs.fsx"

open Fun.Build
open Fake.IO
open Fake.IO.FileSystemOperators
open Fake.IO.Globbing.Operators


let options = {|
    NUGET_API_KEY = EnvArg.Create("NUGET_API_KEY", description = "NUGET api key")
    WASM = CmdArg.Create(longName = "--wasm", description = "Run in blazor wasm mode, By default will run in server mode.")
|}


let stage_checkEnv =
    stage "Check envs" {
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
    stage "Pack" {
        whenBranch "master"
        run "dotnet pack -c Release Fun.Blazor/Fun.Blazor.fsproj -o ."
        run "dotnet pack -c Release Fun.Blazor.CustomElements/Fun.Blazor.CustomElements.fsproj -o ."
        run "dotnet pack -c Release Fun.Blazor.Cli/Fun.Blazor.Cli.fsproj -o ."
        run "dotnet pack -c Release Fun.Blazor.Elmish/Fun.Blazor.Elmish.fsproj -o ."
        run "dotnet pack -c Release Fun.Blazor.Generator/Fun.Blazor.Generator.fsproj -o ."
        run "dotnet pack -c Release Fun.Blazor.HotReload/Fun.Blazor.HotReload.fsproj -o ."
        run "dotnet pack -c Release Fun.Blazor.HtmlTemplate/Fun.Blazor.HtmlTemplate.fsproj -o ."
        run "dotnet pack -c Release Fun.Blazor.Reactive/Fun.Blazor.Reactive.fsproj -o ."
        run "dotnet pack -c Release Fun.Blazor.Server/Fun.Blazor.Server.fsproj -o ."
        run "dotnet pack -c Release Fun.Blazor.Wasm/Fun.Blazor.Wasm.fsproj -o ."
        run "dotnet pack -c Release Fun.Htmx/Fun.Htmx.fsproj -o ."
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
            workingDir "./Fun.Blazor.Docs.Wasm"
            run "fun-blazor watch ./Fun.Blazor.Docs.Wasm.fsproj"
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
                        x.Remove(startIndex, endIndex - startIndex)
                    )
                )
            )
        }
        stage "Tune" {
            whenBranch "master"
            whenEnvVar "GITHUB_ACTION"
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


pipeline "deploy" {
    description "Deploy packages to nuget"
    stage_checkEnv
    stage_test
    stage_pack
    stage "Publish to nuget" {
        failIfIgnored
        whenBranch "master"
        whenEnvVar options.NUGET_API_KEY
        run (fun ctx ->
            let key = ctx.GetEnvVar options.NUGET_API_KEY.Name
            ctx.RunSensitiveCommand $"""dotnet nuget push *.nupkg -s https://api.nuget.org/v3/index.json --skip-duplicate -k {key}"""
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
