[<AutoOpen>]
module Fun.Blazor.DslAdaptive

open System.Runtime.CompilerServices
open FSharp.Data.Adaptive
open Fun.Blazor
open Operators


/// This will generate an alist<Node> as a Node parameter.
/// When the isStatic is not set to true, every time when you call this it will trigger OnParametersSet,
/// so when you write code like below:
/// <example>
/// <code lang="fsharp">
///     adaptiview(){
///         1. change hanpend
///         adaptiview(){
///             2. this will init again, so if you want to keep the state of x you should move the definition upper or set isStatic to true
///             let! x = cval 123
///         }
///     }
/// </code>
/// </example>
type AdaptiviewBuilder(?key: obj, ?isStatic: bool) =
    inherit AValBuilder()

    member _.Key = key
    member _.IsStatic = isStatic

    member this.Run(x: aval<NodeRenderFragment>) =
        ComponentWithChildBuilder<AdaptiveComponent> () {
            "Fragment" => x
            match this.IsStatic with
            | Some true -> "IsStatic" => true
            | _ -> emptyAttr
            match this.Key with
            | Some k -> html.key k
            | None -> emptyAttr
        }

    member inline _.Yield([<InlineIfLambda>] x: NodeRenderFragment) = AVal.init x
    
    member _.Yield<'T when 'T :> IElementBuilder>(x: 'T) =
        AVal.init(NodeRenderFragment(fun _ builder index ->
            builder.OpenElement(index, x.Name)
            builder.CloseElement()
            index + 1
        ))

    member _.Yield<'T, 'T1 when 'T :> IComponentBuilder<'T1>>(_: 'T) =
        AVal.init(NodeRenderFragment(fun _ builder index ->
            builder.OpenComponent<'T1>(index)
            builder.CloseComponent()
            index + 1
        ))


    member inline _.Delay([<InlineIfLambda>] fn: unit -> aval<NodeRenderFragment>) = fn ()

    member _.Combine(val1: aval<NodeRenderFragment>, val2: aval<NodeRenderFragment>) =
        adaptive {
            let! render1 = val1
            let! render2 = val2
            return render1 >=> render2
        }

    member inline _.Zero() = AVal.init emptyNode

    member inline _.For(ls: 'T seq, [<InlineIfLambda>] fn: 'T -> aval<NodeRenderFragment>) =
        ls |> Seq.map fn |> Seq.fold (AVal.map2 (>=>)) (AVal.init emptyNode)


[<Extension>]
type Extensions =
    [<Extension>]
    static member Publish(this: cval<'T>, x: 'T) = transact (fun () -> this.Value <- x)

    [<Extension>]
    static member Publish(this: cval<'T>, fn: 'T -> 'T) = transact (fun () -> this.Value <- fn this.Value)

    [<Extension>]
    static member WithSetter(this: cval<'T>) =
        let setValue x = transact (fun () -> this.Value <- x)
        this |> AVal.map (fun x -> x, setValue)


    /// The action will be triggered immediately
    /// The default AddCallback will have the same effect, but it has an override with (obj -> unit) which make type infer harder
    [<Extension>]
    static member AddInstantCallback(value: aval<'T>, action: 'T -> unit) = value.AddCallback(fun (x: 'T) -> action x)


    /// This is a helper method to avoid trigger action when you first call this function
    /// Because the default AddCallback will trigger the action immediately
    [<Extension>]
    static member AddLazyCallback(value: aval<'T>, action: 'T -> unit) =
        let last = ref ValueNone

        let sub =
            value.AddMarkingCallback(fun () ->
                Transaction.Running.Value.AddFinalizer(fun () ->
                    let v = AVal.force value
                    match last.Value with
                    | ValueSome o when DefaultEquality.equals o v -> ()
                    | _ ->
                        last.Value <- ValueSome v
                        action v
                )
            )

        match Transaction.Running with
        | ValueSome t -> t.AddFinalizer(fun () -> value |> AVal.force |> ignore)
        | ValueNone -> value |> AVal.force |> ignore

        sub


type adaptiview = AdaptiviewBuilder
