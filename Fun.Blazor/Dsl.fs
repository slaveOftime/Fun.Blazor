namespace Fun.Blazor

open System
open System.Threading.Tasks
open FSharp.Data.Adaptive
open Microsoft.AspNetCore.Components
open Operators


type html() =

    static member inline none = emptyNode

    static member inline fragment = fragment

    static member inline mergeAttrs attrs = attrs |> Seq.fold (==>) emptyAttr
    static member inline mergeNodes nodes = nodes |> Seq.fold (>=>) emptyNode

    static member inline renderFragment<'TItem>(name: string, render: 'TItem -> NodeRenderFragment) =
        AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(
                index,
                name,
                box (
                    Microsoft.AspNetCore.Components.RenderFragment<'TItem>(fun x ->
                        Microsoft.AspNetCore.Components.RenderFragment(fun tb -> render(x).Invoke(comp, tb, 0) |> ignore
                        )
                    )
                )
            )
            index + 1
        )

    static member inline renderFragment(name: string, fragment: NodeRenderFragment) =
        AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(
                index,
                name,
                box (Microsoft.AspNetCore.Components.RenderFragment(fun tb -> fragment.Invoke(comp, tb, 0) |> ignore))
            )
            index + 1
        )


    static member inline key k =
        AttrRenderFragment(fun _ builder index ->
            builder.SetKey k
            index
        )

    static member inline ref([<InlineIfLambda>] fn) =
        AttrRenderFragment(fun _ builder index ->
            builder.AddElementReferenceCapture(index, Action<ElementReference> fn)
            index + 1
        )

    static member inline bind<'T>(name: string, store: IStore<'T>) =
        AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(index, name, store.Current)
            builder.AddAttribute(
                index + 1,
                name + "Changed",
                EventCallback.Factory.Create(comp, Action<'T> store.Publish)
            )
            index + 2
        )

    static member inline bind<'T>(name: string, store: cval<'T>) =
        AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(index, name, store.Value)
            builder.AddAttribute(
                index + 1,
                name + "Changed",
                EventCallback.Factory.Create(comp, Action<'T>(fun x -> transact (fun () -> store.Value <- x)))
            )
            index + 2
        )

    static member inline bind<'T>(name: string, (value: 'T, fn: 'T -> unit)) =
        AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(index, name, value)
            builder.AddAttribute(index + 1, name + "Changed", EventCallback.Factory.Create(comp, Action<'T> fn))
            index + 2
        )


    static member inline callback<'T>(eventName, fn: 'T -> unit) =
        AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(index, eventName, EventCallback.Factory.Create(comp, Action<'T> fn))
            index + 1
        )

    static member inline callbackTask<'T>(eventName, fn: 'T -> Task) =
        AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(index, eventName, EventCallback.Factory.Create(comp, Func<'T, Task> fn))
            index + 1
        )


    static member inline raw x =
        NodeRenderFragment(fun _ builder index ->
            builder.AddMarkupContent(index, x)
            index + 1
        )


    //static member doctypeHtml(nodes, ?lang) =
    //    html.fragment {
    //        html.doctype "html"

    //        html.html {
    //            "lang" => (defaultArg lang "en")

    //        }
    //    }

    //static member doctypeHtml(lang: string, nodes: Node list) = html.doctypeHtml (nodes, lang)

    static member inline text(x: int) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, box x)
            index + 1
        )

    static member text(x: float) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, box x)
            index + 1
        )

    static member text(x: Guid) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, string x)
            index + 1
        )

    static member inline text(x: string) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, x)
            index + 1
        )

    static member inline style(x: string) = "style" => x
    static member inline styles(x) = "style" => (makeStyles x)
    static member inline class'(x: string) = "class" => x
    static member inline classes(x: string seq) = "class" => (String.concat " " x)
