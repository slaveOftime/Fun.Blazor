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
    |> Seq.map (fun x -> x.Elements())
    |> Seq.concat
    |> Seq.filter (fun x ->
        let item = x.Attribute(xn "Include")
        item <> null && item.Value.StartsWith codesDirName
    )
    |> Seq.toList
    |> Seq.iter (fun x ->
        try
            let file = Path.GetDirectoryName projectFile </> x.Attribute(xn "Include").Value
            File.Delete file
        with ex ->
            AnsiConsole.MarkupLine $"[red]Delete file failed: {ex.Message}[/]"

        try
            x.Parent.Remove()
        with _ ->
            ()
    )


let private findPackageMetas projectDir (project: XDocument) style useInline =
    project.Element(xn "Project").Elements(xn "ItemGroup")
    |> Seq.map (fun x -> seq {
        yield! x.Elements(xn "PackageReference")
        yield! x.Elements(xn "ProjectReference")
    })
    |> Seq.concat
    |> Seq.filter (fun x -> x.Attributes() |> Seq.exists (fun x -> x.Name.LocalName.StartsWith FunBlazorPrefix))
    |> Seq.map (fun node ->
        let includeValue = node.Attribute(xn "Include").Value
        let isPackageRef = node.Name.LocalName = "PackageReference"
        {
            Package =
                if isPackageRef then
                    Package.Package {|
                        Name = includeValue
                        Version = node.Attribute(xn "Version").Value
                    |}
                else
                    Package.Project(
                        if Path.IsPathRooted includeValue then
                            includeValue
                        else
                            Path.Combine(projectDir, includeValue)
                    )
            SourceAssemblyName =
                match node.Attribute(xn FunBlazorAssemblyNameAttr) with
                | null when isPackageRef -> includeValue
                | null -> Path.GetFileNameWithoutExtension includeValue
                | x -> x.Value
            TargetNamespace =
                let attr = node.Attribute(xn FunBlazorNamespaceAttr)
                if attr = null || String.IsNullOrEmpty attr.Value then
                    if isPackageRef then
                        includeValue
                    else
                        Path.GetFileNameWithoutExtension includeValue
                else
                    attr.Value
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
    let codeFiles =
        Directory.GetFiles(Path.GetDirectoryName projectFile </> codesDirName, "*.fs")
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

    let projectName = Path.GetFileNameWithoutExtension projectFile
    File.WriteAllText(
        Path.GetDirectoryName projectFile </> "ILLink.Substitutions.xml",
        $"""<linker>
	<assembly fullname="{projectName}">
		<resource name="FSharpSignatureCompressedData.{projectName}" action="remove" />
		<resource name="FSharpSignatureCompressedDataB.{projectName}" action="remove" />
		<resource name="FSharpOptimizationCompressedData.{projectName}" action="remove" />
		<resource name="FSharpOptimizationCompressedDataB.{projectName}" action="remove" />
	</assembly>
</linker>"""
    )

    printfn $"Generated ILLink.Substitutions.xml"

    let linker = XElement(xn "EmbeddedResource")
    linker.Add(XAttribute(xn "Include", "ILLink.Substitutions.xml"))
    linker.Add(XAttribute(xn "LogicalName", "ILLink.Substitutions.xml"))
    codeItemGroup.Add linker
    printfn $"Attach ILLink.Substitutions.xml"


let startGenerate (projectFile: string) (codesDirName: string) (style: Style) sdkStr generatorVersion useInline keepCodeGenProj =
    AnsiConsole.MarkupLine $"Found project: [green]{projectFile}[/]"
    AnsiConsole.WriteLine()

    let sdk = if String.IsNullOrEmpty sdkStr then None else Some sdkStr
    let project = XDocument.Load projectFile


    let codesDir =
        Path.Combine(Path.GetDirectoryName(Path.GetFullPath(projectFile)), codesDirName)
    if codesDir |> Directory.Exists |> not then
        Directory.CreateDirectory codesDir |> ignore


    AnsiConsole.MarkupLine "Clean previous generated code files"
    clean project projectFile codesDirName


    AnsiConsole.WriteLine()
    AnsiConsole.MarkupLine "Find packages and generate codes"
    findPackageMetas (Path.GetDirectoryName projectFile) project style useInline
    |> CodeGenProject.createAndRun keepCodeGenProj projectFile codesDirName sdk generatorVersion


    AnsiConsole.WriteLine()
    AnsiConsole.MarkupLine "Attach generated code files"
    attachCodeFiles project projectFile codesDirName


    AnsiConsole.WriteLine()
    AnsiConsole.MarkupLine $"Save project file changes: [green]{projectFile}[/]"
    project.Save projectFile
