module Fun.Blazor.Cli.CodeGen.Generate

open System
open System.IO
open System.Xml.Linq
open Spectre.Console
open Fun.Result
open Fun.Blazor.Generator


let private xn x = XName.Get x

let private (</>) x y = Path.Combine(x, y)

let private FunBlazorPrefix = "FunBlazor"
let private FunBlazorAssemblyNameAttr = $"{FunBlazorPrefix}AssemblyName"
let private FunBlazorNamespaceAttr = $"{FunBlazorPrefix}Namespace"
let private FunBlazorStyleAttr = $"{FunBlazorPrefix}Style"
let private FunBlazorInlineAttr = $"{FunBlazorPrefix}Inline"


let private clean (project: XDocument) (projectFile: string) (codesDirName: string) =
    project.Element(xn "Project").Elements(xn "ItemGroup")
    |> Seq.map (fun x -> x.Elements(xn "Compile"))
    |> Seq.concat
    |> Seq.filter (fun x -> x.Attribute(xn "Include").Value.StartsWith codesDirName)
    |> Seq.toList
    |> Seq.iter (fun x ->
        try
            let file = Path.GetDirectoryName projectFile </> x.Attribute(xn "Include").Value
            File.Delete file
        with
            | ex -> AnsiConsole.MarkupLine $"[red]Delete file failed: {ex.Message}[/]"

        try
            x.Parent.Remove()
        with
            | _ -> ()
    )


let private findPackageMetas (project: XDocument) style useInline =
    project.Element(xn "Project").Elements(xn "ItemGroup")
    |> Seq.map (fun x -> x.Elements(xn "PackageReference"))
    |> Seq.concat
    |> Seq.filter (fun x -> x.Attributes() |> Seq.exists (fun x -> x.Name.LocalName.StartsWith FunBlazorPrefix))
    |> Seq.map (fun node ->
        let package = node.Attribute(xn "Include").Value
        {
            Package = package
            Version = node.Attribute(xn "Version").Value
            SourceAssemblyName =
                match node.Attribute(xn FunBlazorAssemblyNameAttr) with
                | null -> package
                | x -> x.Value
            TargetNamespace =
                let attr = node.Attribute(xn FunBlazorNamespaceAttr)
                if attr = null || String.IsNullOrEmpty attr.Value then package else attr.Value
            Style =
                match node.Attribute(xn FunBlazorStyleAttr) with
                | null -> style
                | attr ->
                    match attr.Value with
                    | nameof Style.Feliz -> Style.Feliz
                    | nameof Style.CE -> Style.CE
                    | _ -> style
            UseInline =
                match node.Attribute(xn FunBlazorInlineAttr) with
                | null -> useInline
                | attr ->
                    match attr.Value with
                    | SafeStringLower "false" -> false
                    | _ -> true
        }
    )


let private attachCodeFiles (project: XDocument) (projectFile: string) (codesDirName: string) =
    let codeFiles = Directory.GetFiles(Path.GetDirectoryName projectFile </> codesDirName)
    let codeItemGroup = XElement(xn "ItemGroup")

    let firstItemGroup = project.Element(xn "Project").Element(xn "ItemGroup")
    if isNull firstItemGroup then
        project.Add codeItemGroup
    else
        firstItemGroup.AddBeforeSelf codeItemGroup

    for file in codeFiles do
        let code = XElement(xn "Compile")
        let codePath = codesDirName </> Path.GetFileName file

        code.Add(XAttribute(xn "Include", codePath))
        codeItemGroup.Add code

        AnsiConsole.MarkupLine $"Attach file: [green]{codePath}[/]"



let startGenerate (projectFile: string) (codesDirName: string) (style: Style) sdkStr generatorVersion useInline =
    AnsiConsole.MarkupLine $"Found project: [green]{projectFile}[/]"
    AnsiConsole.WriteLine()

    let sdk = if String.IsNullOrEmpty sdkStr then None else Some sdkStr
    let project = XDocument.Load projectFile


    AnsiConsole.MarkupLine "Clean previous generated code files"
    clean project projectFile codesDirName


    AnsiConsole.WriteLine()
    AnsiConsole.MarkupLine "Find packages and generate codes"
    findPackageMetas project style useInline |> CodeGenProject.createAndRun projectFile codesDirName sdk generatorVersion


    AnsiConsole.WriteLine()
    AnsiConsole.MarkupLine "Attach generated code files"
    attachCodeFiles project projectFile codesDirName


    AnsiConsole.WriteLine()
    AnsiConsole.MarkupLine $"Save project file changes: [green]{projectFile}[/]"
    project.Save projectFile
