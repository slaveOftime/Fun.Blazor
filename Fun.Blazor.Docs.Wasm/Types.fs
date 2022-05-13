namespace Fun.Blazor.Docs.Wasm

open System
open Fun.Blazor


type Demo = { View: NodeRenderFragment; Source: string }


type Segment =
    | Html of string
    | Demo of string


type DocBrief =
    {
        Id: Guid option
        Name: string
        FolderName: string
        LastModified: DateTime
        LangSegments: Map<string, Segment list>
    }

[<RequireQualifiedAccess>]
type DocTreeNode =
    | Category of index: DocBrief * files: DocBrief list * childNodes: DocTreeNode list
    | Doc of doc: DocBrief
