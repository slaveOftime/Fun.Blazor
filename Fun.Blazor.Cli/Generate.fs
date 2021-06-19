module Fun.Blazor.Cli.Generate

open System.IO
open System.Reflection
open System.Xml.Linq
open Spectre.Console

open Fun.Blazor.Generator


let private xn x = XName.Get x

let private (</>) x y = Path.Combine(x, y)

let private FunBlazorNamespaceAttr = "FunBlazorNamespace"


let private createCodeFile (projectFile: string) codesDirName (name, dll) =
    AnsiConsole.WriteLine ()
    AnsiConsole.MarkupLine $"Generating code for [purple]{name}[/]: [green]{dll}[/]"
    
    Assembly.LoadFile(dll).GetTypes()
    |> Generator.generateCode
    |> fun codes ->
        let codesDir = Path.GetDirectoryName projectFile </> codesDirName

        if Directory.Exists codesDir |> not then
            Directory.CreateDirectory codesDir |> ignore
        
        let path = codesDir </> name + ".fs"
        let code = 
            $"""namespace rec {name}.Internal

open Bolero
open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.Internal

{codes.internalCode}


namespace rec {name}

{codes.dslCode}"""
        
        File.WriteAllText(path, code)

        AnsiConsole.MarkupLine $"Generated code for [purple]{name}[/]: {path}"

        path



let startGenerate (projectFile: string) (codesDirName: string) =
    AnsiConsole.MarkupLine $"Found project: [green]{projectFile}[/]"
    AnsiConsole.WriteLine ()

    let project = XDocument.Load projectFile

    let target = project.Element(xn "Project").Element(xn "PropertyGroup").Element(xn "TargetFramework").Value

    let codeFiles =
        project.Element(xn "Project").Elements(xn "ItemGroup")
        |> Seq.map (fun x -> x.Elements(xn "PackageReference"))
        |> Seq.concat
        |> Seq.filter (fun x -> 
            x.Attribute(xn FunBlazorNamespaceAttr) |> isNull |> not)
        |> Seq.map (fun x ->
            let name = x.Attribute(xn FunBlazorNamespaceAttr).Value
            let package = x.Attribute(xn "Include").Value
            let dll = Path.GetDirectoryName(projectFile) </> "bin" </> "Debug" </> target </> package + ".dll"
            name, dll)
        |> Seq.toList
        |> List.map (createCodeFile projectFile codesDirName)


    project.Element(xn "Project").Elements(xn "ItemGroup")
    |> Seq.map (fun x -> x.Elements(xn "Compile"))
    |> Seq.concat
    |> Seq.filter (fun x -> x.Attribute(xn "Include").Value.StartsWith codesDirName)
    |> Seq.toList
    |> Seq.iter (fun x -> try x.Parent.Remove() with _ -> ())


    let codeItemGroup = XElement(xn "ItemGroup")

    let firstItemGroup = project.Element(xn "Project").Element(xn "ItemGroup")
    if isNull firstItemGroup then project.Add codeItemGroup
    else firstItemGroup.AddBeforeSelf codeItemGroup

    codeFiles
    |> List.iter (fun file ->
        let code = XElement(xn "Compile")
        code.Add(XAttribute(xn "Include", codesDirName </> Path.GetFileName file))
        codeItemGroup.Add code)

    project.Save projectFile
