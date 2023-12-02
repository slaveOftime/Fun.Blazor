#r "nuget: Fake.IO.FileSystem, 5.20.4"
#r "nuget: FSharp.SystemTextJson, 0.17.4"
#r "nuget: Markdig, 0.33.0"

open System
open System.IO
open System.Text.RegularExpressions
open System.Text.Json
open System.Text.Json.Serialization
open Fake.IO
open Fake.IO.FileSystemOperators
open Fake.IO.Globbing.Operators
open Markdig
open Markdig.Parsers
open Markdig.Renderers


type Segment =
    | Html of string
    | Demo of string


type DocBrief =
    {
        Id: Guid option
        Name: string
        Names: Map<string, string>
        FolderName: string
        LastModified: DateTime
        LangSegments: Map<string, Segment list>
    }


[<RequireQualifiedAccess>]
type DocTreeNode =
    | Category of index: DocBrief * files: DocBrief list * childNodes: DocTreeNode list
    | Doc of doc: DocBrief

// TODO: refactor below messy code
module internal DocsHelper =

    [<Literal>]
    let INDEX = "README"

    [<Literal>]
    let DefaultLang = "en"

    let toJson x =
        let options = JsonSerializerOptions()
        options.WriteIndented <- true
        options.Converters.Add(JsonFSharpConverter())
        JsonSerializer.Serialize(x, options)


    let private isMainFile (file: string) = (Path.GetFileName file).Equals(INDEX + ".md", StringComparison.OrdinalIgnoreCase)
    let private isExpectedFile ext (file: string) = not((Path.GetFileName file).StartsWith(INDEX, StringComparison.OrdinalIgnoreCase)) && file.EndsWith(ext, StringComparison.OrdinalIgnoreCase)

    let private formatUrl (url: string) = url.Replace(@"\", @"/")


    let markdownToHtml baseUrl (markdown: string) =
        let pipeline = MarkdownPipelineBuilder().UseAdvancedExtensions().Build()
        use writer = new StringWriter()
        let renderer = new HtmlRenderer(writer)

        renderer.LinkRewriter <-
            fun url ->
                let index = url.IndexOf("assets/", StringComparison.OrdinalIgnoreCase)
                if index > -1 then
                    baseUrl + url.Substring(index)
                elif url.StartsWith("http://", StringComparison.CurrentCultureIgnoreCase) then
                    url
                elif url.StartsWith("https://", StringComparison.CurrentCultureIgnoreCase) then
                    url
                else
                    baseUrl + url

        pipeline.Setup(renderer)

        let document = MarkdownParser.Parse(markdown, pipeline)
        renderer.Render(document) |> ignore

        writer.Flush()
        writer.ToString()


    let markdownToSegments baseUrl (rootDir: string) file =
        let dir = Path.getDirectory file
        let fileName = Path.GetFileNameWithoutExtension file
        let content = File.readAsString file
        let results = Regex("{{([^{][\S]+)}}").Matches(content)

        File.delete file

        let mutable lastIndex = 0
        let mutable index = 0

        let makeSegFileName () = dir </> fileName + (if index = 0 then "" else "-" + string index) + ".html"
        let makeRelativeSegFileName () = makeSegFileName().Substring(rootDir.Length + 1)

        [
            for result in results do
                let demo = result.Groups[1].Value

                content.Substring(lastIndex, result.Index - lastIndex)
                |> markdownToHtml baseUrl
                |> File.writeString false (makeSegFileName ())


                yield Html(makeRelativeSegFileName () |> formatUrl)
                yield Demo demo

                index <- index + 1
                lastIndex <- result.Index + result.Value.Length

            if lastIndex < content.Length - 1 then
                let html = content.Substring(lastIndex) |> markdownToHtml baseUrl

                if String.IsNullOrWhiteSpace html |> not then
                    File.writeString false (makeSegFileName ()) html
                    yield Html(makeRelativeSegFileName () |> formatUrl)
        ]


    let generateDocBrief baseUrl rootDir (file: string) =
        let docId =
            File.ReadLines file
            |> Seq.tryHead
            |> Option.bind (fun x ->
                match Guid.TryParse x with
                | true, x -> Some x
                | _ -> None
            )

        let getDocName (file: string) =
            File.ReadLines file
            |> if docId.IsSome then Seq.skip 1 else id
            |> Seq.tryHead
            |> Option.map (fun x ->
                if x.StartsWith "#" && x.Length > 1 then
                    x.Substring(1, x.Length - 1).Trim()
                else
                    x.Trim()
            )
            |> Option.defaultValue ""

        let getLang (file: string) = 
            file
            |> Path.GetFileNameWithoutExtension
            |> Path.GetExtension
            |> fun x -> if String.IsNullOrEmpty x then DefaultLang else x.Substring(1)

        let dir = Path.getDirectory file
        let filename =
            file |> Path.GetFileNameWithoutExtension |> Path.GetFileNameWithoutExtension
        let files = Directory.GetFiles(dir, $"{filename}*.md")
        let fileInfo = FileInfo file

        {
            Id = docId
            Name = getDocName file
            Names = files |> Seq.map (fun f -> getLang f, getDocName f) |> Map.ofSeq
            FolderName = file |> Path.GetDirectoryName |> Path.GetFileName
            LastModified = fileInfo.LastWriteTimeUtc
            LangSegments =
                files
                |> Seq.map (fun file ->
                    getLang file, markdownToSegments baseUrl rootDir file
                )
                |> Map.ofSeq
        }


    let sortDocNodeByName =
        function
        | DocTreeNode.Category (d, _, _)
        | DocTreeNode.Doc d -> d.Name

    let sortDocNodeByFolderName =
        function
        | DocTreeNode.Category (d, _, _)
        | DocTreeNode.Doc d -> d.FolderName

    let rec sortDocNodesByDesc (nodes: DocTreeNode list) =
        nodes
        |> List.sortByDescending sortDocNodeByName
        |> List.map (
            function
            | DocTreeNode.Category (d, docs, nodes) ->
                DocTreeNode.Category(d, docs |> List.sortByDescending (fun x -> x.Name), sortDocNodesByDesc nodes)
            | x -> x
        )


    let rec getDocTree baseUrl rootDir (ext: string) (dir: string) =
        let files = Directory.GetFiles dir
        let dirs = Directory.GetDirectories dir |> Seq.toList

        let mainFiles, otherFiles =
            files
            |> Seq.fold
                (fun (main, other) f ->
                    if isMainFile f then f :: main, other
                    elif isExpectedFile ext f then main, f :: other
                    else main, other
                )
                ([], [])

        let otherFiles =
            otherFiles
            |> Seq.groupBy (fun x -> x.Split('.')[0])
            // Just get the default lang file, other lang should be ignored
            |> Seq.map (fun (_, g) -> g |> Seq.find (fun f -> Path.GetFileName(f).Split('.').Length = 2))
            |> Seq.toList

        match mainFiles, dirs, otherFiles with
        | [], _ :: _, _ -> dirs |> List.map (getDocTree baseUrl rootDir ext) |> List.concat

        | _ :: _, [], [] ->
            [
                DocTreeNode.Doc(mainFiles |> List.map (generateDocBrief baseUrl rootDir) |> List.item 0)
            ]

        | head :: _, _, _ ->
            let doc = generateDocBrief baseUrl rootDir head

            let isReleaseFolder =
                doc.LangSegments
                |> Map.toSeq
                |> Seq.map snd
                |> Seq.concat
                |> Seq.exists (
                    function
                    | Html x -> x.Contains("Release", StringComparison.OrdinalIgnoreCase)
                    | _ -> false
                )

            let files =
                otherFiles
                |> List.map (generateDocBrief baseUrl rootDir)
                |> if isReleaseFolder then
                       List.sortByDescending (fun x -> x.Name)
                   else
                       List.sortBy (fun x -> x.FolderName)

            let childs =
                dirs
                |> List.map (getDocTree baseUrl rootDir ext)
                |> List.concat
                |> List.sortBy sortDocNodeByFolderName

            [ DocTreeNode.Category(doc, files, childs) ]

        | _ -> []


module DocBuilder =

    let wasm = __SOURCE_DIRECTORY__ </> "Fun.Blazor.Docs.Wasm"
    let wwwroot = wasm </> "wwwroot"
    let demos = "Demos"
    let docs = "Docs"
    let baseUrl = "docs/"


    let build () =
        printfn "Process demos"
        Shell.cleanDir (wwwroot </> demos)
        Shell.copyDir (wwwroot </> demos) (wasm </> demos) (fun _ -> true)

        let demosStr =
            !!(wwwroot </> demos </> "**" </> "*.*")
            |> Seq.toList
            |> List.map (fun file ->
                let dir = Path.getDirectory file
                let name = Path.GetFileNameWithoutExtension(file)

                let code =
                    File.ReadAllLines file
                    |> Seq.skip 3
                    |> String.concat "\n"
                    |> fun x -> x.Trim()
                    |> sprintf "```fsharp\n%s\n```\n"

                DocsHelper.markdownToHtml baseUrl code |> File.writeString false (dir </> name + ".html")

                File.delete file

                $"""        "{name}", {{ View = {name}.entry; Source = "{demos + "/" + name + ".html"}" }}"""
            )
            |> String.concat "\n"


        printfn "Process docs"
        Shell.cleanDir (wwwroot </> docs)
        Shell.copyDir (wwwroot </> docs) (__SOURCE_DIRECTORY__ </> docs) (fun _ -> true)

        let docsDir = wwwroot </> docs
        DocsHelper.getDocTree baseUrl docsDir ".md" docsDir
        |> List.sortBy DocsHelper.sortDocNodeByFolderName
        |> DocsHelper.toJson
        |> File.writeString false (docsDir </> "index.json")


        File.writeString
            false
            (wasm </> "DemoMaps.fs")
            $"""// hot-reload
// Auto generated file, please do nto change it manually
[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.DemoMaps

open Fun.Blazor.Docs.Wasm.Demos

let demos =
    Map.ofList [
{demosStr}
    ]
        """
