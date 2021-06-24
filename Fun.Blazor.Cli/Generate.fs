module Fun.Blazor.Cli.Generate

open System
open System.IO
open System.Reflection
open System.Xml.Linq
open Microsoft.Extensions.Configuration
open Spectre.Console

open Fun.Blazor.Generator


let private xn x = XName.Get x

let private (</>) x y = Path.Combine(x, y)

let private FunBlazorNamespaceAttr = "FunBlazorNamespace"


let private createCodeFile (projectFile: string) codesDirName (name, dll) =
    AnsiConsole.WriteLine ()
    AnsiConsole.MarkupLine $"Generating code for [purple]{name}[/]: [green]{dll}[/]"
    
    try
        let opens =
            """open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals"""

        let codes = Assembly.LoadFile(dll).GetTypes() |> Generator.generateCode name opens
        let codesDir = Path.GetDirectoryName projectFile </> codesDirName

        if Directory.Exists codesDir |> not then
            Directory.CreateDirectory codesDir |> ignore
        
        let path = codesDir </> name + ".fs"
        let code = 
            $"""{codes.internalCode}

// =======================================================================================================================

{codes.dslCode}"""
        
        File.WriteAllText(path, code)

        AnsiConsole.MarkupLine $"Generated code for [green]{name}[/]: {path}"

        Some path

    with ex ->
        AnsiConsole.WriteException(ex)
        None


let startGenerate (projectFile: string) (codesDirName: string) =
    AnsiConsole.MarkupLine $"Found project: [green]{projectFile}[/]"

    let project = XDocument.Load projectFile

    let target = project.Element(xn "Project").Element(xn "PropertyGroup").Element(xn "TargetFramework").Value
        
            
    AnsiConsole.WriteLine ()
    AnsiConsole.MarkupLine "Clean old generated code files"

    project.Element(xn "Project").Elements(xn "ItemGroup")
    |> Seq.map (fun x -> x.Elements(xn "Compile"))
    |> Seq.concat
    |> Seq.filter (fun x -> x.Attribute(xn "Include").Value.StartsWith codesDirName)
    |> Seq.toList
    |> Seq.iter (fun x -> 
        try 
            let file = Path.GetDirectoryName projectFile </> codesDirName </> x.Attribute(xn "Include").Value
            File.Delete file
        with _ ->
            ()

        try x.Parent.Remove() with _ -> ())

        
    AnsiConsole.WriteLine ()
    AnsiConsole.MarkupLine "Generate codes"

    let codeFiles =
        project.Element(xn "Project").Elements(xn "ItemGroup")
        |> Seq.map (fun x -> x.Elements(xn "PackageReference"))
        |> Seq.concat
        |> Seq.filter (fun x -> x.Attribute(xn FunBlazorNamespaceAttr) |> isNull |> not)
        |> Seq.map (fun node ->
            let package = node.Attribute(xn "Include").Value
            let version = node.Attribute(xn "Version").Value

            //Use this in the future
            //let config = ConfigurationBuilder().AddJsonFile(Path.GetDirectoryName projectFile </> "obj" </> "project.assets.json").Build()

            let findAnotherOneIfNotExist fn path = if File.Exists path then path else fn()

            let dll =
                let userDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
                Path.GetDirectoryName projectFile </> "bin" </> "Debug" </> target </> package + ".dll"
                |> findAnotherOneIfNotExist (fun () -> userDir </> ".nuget" </> "packages" </> package </> version </> "lib" </> target </> package + ".dll")
                |> findAnotherOneIfNotExist (fun () -> userDir </> ".nuget" </> "packages" </> package </> version </> "lib" </> "netstandard2.0" </> package + ".dll")
                |> findAnotherOneIfNotExist (fun () -> userDir </> ".nuget" </> "packages" </> package </> version </> "lib" </> "netstandard2.1" </> package + ".dll")
                |> findAnotherOneIfNotExist (fun () -> userDir </> ".nuget" </> "packages" </> package </> version </> "lib" </> "netcoreapp2.0" </> package + ".dll")
                |> findAnotherOneIfNotExist (fun () -> userDir </> ".nuget" </> "packages" </> package </> version </> "lib" </> "netcoreapp2.2" </> package + ".dll")
                |> findAnotherOneIfNotExist (fun () -> userDir </> ".nuget" </> "packages" </> package </> version </> "lib" </> "netcoreapp3.0" </> package + ".dll")
                |> findAnotherOneIfNotExist (fun () -> userDir </> ".nuget" </> "packages" </> package </> version </> "lib" </> "netcoreapp3.1" </> package + ".dll")
                |> findAnotherOneIfNotExist (fun () -> userDir </> ".nuget" </> "packages" </> package </> version </> "lib" </> "net5.0" </> package + ".dll")
                |> findAnotherOneIfNotExist (fun () -> userDir </> ".nuget" </> "packages" </> package </> version </> "lib" </> "net6.0" </> package + ".dll")
                            
            let name =
                let attr = node.Attribute(xn FunBlazorNamespaceAttr)
                if String.IsNullOrEmpty attr.Value then package
                else attr.Value

            name, dll)

        |> Seq.toList
        |> List.map (createCodeFile projectFile codesDirName)


    AnsiConsole.WriteLine ()
    AnsiConsole.MarkupLine "Attach generated code files"

    let codeItemGroup = XElement(xn "ItemGroup")

    let firstItemGroup = project.Element(xn "Project").Element(xn "ItemGroup")
    if isNull firstItemGroup then project.Add codeItemGroup
    else firstItemGroup.AddBeforeSelf codeItemGroup

    codeFiles
    |> List.choose id
    |> List.iter (fun file ->
        let code = XElement(xn "Compile")
        let codePath = codesDirName </> Path.GetFileName file

        code.Add(XAttribute(xn "Include", codePath))
        codeItemGroup.Add code

        AnsiConsole.MarkupLine $"Attach file: [green]{codePath}[/]")

    
    AnsiConsole.WriteLine ()
    AnsiConsole.MarkupLine $"Save project file changes: [green]{projectFile}[/]"

    project.Save projectFile
