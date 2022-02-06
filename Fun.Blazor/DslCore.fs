namespace Fun.Blazor

open System
open System.Collections.Concurrent
open System.Threading.Tasks
open FSharp.Data.Adaptive
open Microsoft.AspNetCore.Components
open Operators


type html() =

    static member inline none = emptyNode


    static member mergeAttrs attrs = attrs |> Seq.fold (==>) emptyAttr
    static member mergeNodes nodes = nodes |> Seq.fold (>=>) emptyNode


    static member internal compCache = lazy (fun () -> ConcurrentDictionary<Type, Reflection.PropertyInfo []>())

    /// With this we can init a blazor component easier without always write string for binding paratemters.
    /// But it will use reflection so you will pay for the performance cost so we should use it carefully.
    /// Only property with attribute ParameterAttribute will be passed through.
    /// ```fsharp
    ///     html.blazor (fun _ ->
    ///         SomeComp(
    ///             Param1 = ...,
    ///             Param2 = ...,
    ///         )
    ///     )
    /// ```
    static member blazor<'T when 'T :> IComponent>(fn: IComponent -> 'T, ?render: AttrRenderFragment) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent<'T>(index)

            let mutable nextIndex = index + 1
            let instance = fn comp
            let props =
                html
                    .compCache
                    .Value()
                    .GetOrAdd(
                        typeof<'T>,
                        fun _ ->
                            instance.GetType().GetProperties()
                            |> Array.filter (fun prop ->
                                prop.CustomAttributes
                                |> Seq.exists (fun x -> x.AttributeType = typeof<ParameterAttribute>)
                            )
                    )

            for prop in props do
                let value = prop.GetValue(instance)
                builder.AddAttribute(nextIndex, prop.Name, value)
                nextIndex <- nextIndex + 1

            nextIndex <-
                match render with
                | None -> nextIndex
                | Some r -> r.Invoke(comp, builder, nextIndex)

            builder.CloseComponent()
            nextIndex
        )


    static member inline fromBuilder<'Comp, 'T when 'Comp :> IComponentBuilder<'T>>(_: 'Comp) =
        NodeRenderFragment(fun _ builder index ->
            builder.OpenComponent<'T>(index)
            builder.CloseComponent()
            index + 1
        )

    static member inline fromBuilder<'Elt when 'Elt :> IElementBuilder>(elt: 'Elt) =
        NodeRenderFragment(fun _ builder index ->
            builder.OpenElement(index, elt.Name)
            builder.CloseElement()
            index + 1
        )


    static member renderFragment<'TItem>(name: string, render: 'TItem -> NodeRenderFragment) =
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

    static member renderFragment(name: string, fragment: NodeRenderFragment) =
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

    static member inline ref(fn) =
        RefRenderFragment(fun _ builder index ->
            builder.AddElementReferenceCapture(index, Action<ElementReference> fn)
            index + 1
        )


    static member bind<'T>(name: string, store: IStore<'T>) =
        AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(index, name, store.Current)
            builder.AddAttribute(
                index + 1,
                name + "Changed",
                EventCallback.Factory.Create(comp, Action<'T> store.Publish)
            )
            index + 2
        )

    static member bind<'T>(name: string, store: cval<'T>) =
        AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(index, name, store.Value)
            builder.AddAttribute(
                index + 1,
                name + "Changed",
                EventCallback.Factory.Create(comp, Action<'T>(fun x -> transact (fun () -> store.Value <- x)))
            )
            index + 2
        )

    static member bind<'T>(name: string, (value: 'T, fn: 'T -> unit)) =
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


    static member inline text(x: int) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, box x)
            index + 1
        )

    static member inline text(x: float) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, box x)
            index + 1
        )

    static member inline text(x: Guid) =
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
