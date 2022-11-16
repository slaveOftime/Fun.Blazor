#r "nuget: Fun.Build, 0.2.8"
#r "nuget: Fake.IO.FileSystem, 5.20.4"

#load "docs.fsx"

open Fun.Build
open Fake.IO
open Fake.IO.FileSystemOperators
open Fake.IO.Globbing.Operators


let checkEnv =
    stage "Check envs" {
        run "dotnet restore"
        run "dotnet build"
        run (ignore >> Docs.DocBuilder.build)
    }

let test =
    stage "Test" {
        run "dotnet build"
        run "dotnet test --no-build"
    }

let pack =
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
    checkEnv
    stage "docs" {
        paralle
        stage "wasm" {
            workingDir "./Fun.Blazor.Docs.Wasm"
            whenCmdArg "--wasm" "" "Run in blazor wasm mode, By default will run in server mode."
            run "dotnet run"
        }
        stage "server" {
            workingDir "./Fun.Blazor.Docs.Server"
            whenNot { cmdArg "--wasm" }
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
    checkEnv
    test
    stage "Publish docs" {
        whenBranch "master"
        run "dotnet publish Fun.Blazor.Docs.Wasm/Fun.Blazor.Docs.Wasm.fsproj -c Release -o Fun.Blazor.Docs.Wasm.Release --nologo"
        run (fun _ ->
            !!("Fun.Blazor.Docs.Wasm.Release" </> "**" </> "index.html")
            |> Seq.iter (File.applyReplace (fun x -> x.Replace("""<base href="/"/>""", """<base href="/Fun.Blazor.Docs/" /> """)))
        )
        run "cp Fun.Blazor.Docs.Wasm.Release/wwwroot/index.html Fun.Blazor.Docs.Wasm.Release/wwwroot/404.html"
        run "touch Fun.Blazor.Docs.Wasm.Release/wwwroot/.nojekyll"
    }
    runIfOnlySpecified
}


pipeline "deploy" {
    description "Deploy packages to nuget"
    checkEnv
    test
    pack
    stage "Publish to nuget" {
        whenAll {
            branch "master"
            whenAny {
                envVar "NUGET_API_KEY"
                cmdArg "NUGET_API_KEY"
            }
        }
        run (fun ctx ->
            let key = ctx.GetCmdArgOrEnvVar "NUGET_API_KEY"
            cmd $"""dotnet nuget push *.nupkg -s https://api.nuget.org/v3/index.json --skip-duplicate -k {key}"""
        )
    }
    runIfOnlySpecified false
}


tryPrintPipelineCommandHelp ()
