namespace Fun.Blazor.Generator

open System.IO
open System.Reflection


type Style =
    | Feliz = 0
    | CE = 1


module CodeGen =

    let private (</>) x y = Path.Combine(x, y)


    let createCodeFile codesDir style (targetNamespace: string) (sourceAssemblyName: string) =
        printfn $"Generating code for {targetNamespace}: {sourceAssemblyName}"

        let formatedName = targetNamespace.Replace("-", "_")

        try
            let opens =
                $"""open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor
open Microsoft.AspNetCore.Components.{Utils.internalSegment}
open Microsoft.AspNetCore.Components.Web.{Utils.internalSegment}
open {targetNamespace}.{Utils.internalSegment}"""

            let types = Assembly.Load(sourceAssemblyName).GetTypes()
            let path = codesDir </> formatedName + ".fs"

            if Directory.Exists codesDir |> not then
                Directory.CreateDirectory codesDir |> ignore

            let codes =
                match style with
                | Style.Feliz -> Generator.generateCode formatedName opens types
                | Style.CE -> CEGenerator.generateCode formatedName opens types
                | x -> failwith $"Not supportted style: {x}"

            let code =
                $"""{codes.internalCode}

// =======================================================================================================================

{codes.dslCode}"""

            File.WriteAllText(path, code)


            printfn $"Generated code for {formatedName}: {path}"

        with
            | ex -> printfn "Generate code failed %s" ex.Message
