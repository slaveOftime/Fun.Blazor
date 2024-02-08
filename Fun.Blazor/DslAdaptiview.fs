[<AutoOpen>]
module Fun.Blazor.DslAdaptive

open System
open System.Threading.Tasks
open System.Runtime.CompilerServices
open System.Diagnostics.CodeAnalysis
open FSharp.Data.Adaptive
open Fun.Result
open Fun.Blazor
open Operators
open Internal


type AdaptiviewBuilder
    [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AdaptiviewBuilder>)>]
    (?key: obj, ?isStatic: bool, ?disableEventTriggerStateHasChanged)
    =
    inherit AValBuilder()

    member _.Key = key
    member _.IsStatic = isStatic

    member this.Run(x: aval<NodeRenderFragment>) = ComponentWithChildBuilder<AdaptiveComponent>() {
        "Fragment" => x
        "DisableEventTriggerStateHasChangedParam" => defaultArg disableEventTriggerStateHasChanged true
        match this.IsStatic with
        | Some true -> "IsStatic" => true
        | _ -> emptyAttr ()
        match this.Key with
        | Some k -> html.key k
        | None -> emptyAttr ()
    }

    member inline _.Yield([<InlineIfLambda>] x: NodeRenderFragment) = AVal.constant x

    member inline _.Yield<'T when 'T :> IElementBuilder>(x: 'T) =
        AVal.constant (
            NodeRenderFragment(fun _ builder index ->
                builder.OpenElement(index, x.Name)
                builder.CloseElement()
                index + 1
            )
        )

    member inline _.Yield<'T, 'T1 when 'T :> IComponentBuilder<'T1>>(_: 'T) =
        AVal.constant (
            NodeRenderFragment(fun _ builder index ->
                builder.OpenComponent<'T1>(index)
                builder.CloseComponent()
                index + 1
            )
        )


    member inline _.Delay([<InlineIfLambda>] fn: unit -> aval<NodeRenderFragment>) = fn ()

    member inline _.Combine(val1: aval<NodeRenderFragment>, val2: aval<NodeRenderFragment>) = adaptive {
        let! render1 = val1
        let! render2 = val2
        return render1 >=> render2
    }

    member inline _.Zero() = AVal.constant (emptyNode ())

    member inline _.For(items: 'T seq, [<InlineIfLambda>] fn: 'T -> aval<NodeRenderFragment>) =
        let mutable state = AVal.constant (emptyNode ())
        for item in items do
            state <- AVal.map2 (fun x y -> x >=> y) state (fn item)
        state


type IAdaptiveValue<'T> with

    /// Evaluates the given adaptive value and returns its current value. This should not be used inside the adaptive evaluation of other AdaptiveObjects since it does not track dependencies.
    member this.Value = AVal.force this


[<Extension>]
type Extensions =
    /// Change the value in a transact
    [<Extension>]
    static member Publish(this: cval<'T>, x: 'T) = transact (fun () -> this.Value <- x)

    /// Change the value in a transact
    [<Extension>]
    static member Publish(this: cval<'T>, fn: 'T -> 'T) = transact (fun () -> this.Value <- fn this.Value)

    /// Make a tuple: (value, setValue)
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


[<RequireQualifiedAccess>]
module AVal =
    let ofTask (defaultValue: 'T) (ts: Task<'T>) =
        let data = cval defaultValue
        ts |> Task.map data.Publish |> ignore
        data :> aval<'T>

    let ofObservable (defaultValue: 'T) (handleDispose) (obs: IObservable<'T>) =
        let data = cval defaultValue
        obs |> Observable.subscribe data.Publish |> handleDispose
        data :> aval<'T>


    let inline addLazyCallback fn (data: aval<_>) = data.AddLazyCallback fn
    let inline addInstantCallback fn (data: aval<_>) = data.AddInstantCallback fn


/// This will generate an alist<Node> as a Node parameter.
/// When the isStatic is not set to true, every time when you call this it will trigger OnParametersSet,
/// so when you write code like below:
/// <example>
/// <code lang="fsharp">
///     1. change hanppened
///     adaptiview(isStatic = false){
///         2. this will init again, so if you want to keep the state of x you should move the definition of x upper or set isStatic to true
///         let! x = cval 123
///     }
///
/// let counters =
///    adaptiview () {
///        let! count1, setCount1 = cval(1).WithSetter()
///        let! count2, setCount2 = cval(2).WithSetter()
///        div {
///            button {
///                on.click (fun _ -> setCount1 (count1 + 1))
///                "Increase count1 will casuse count2 be reset"
///            }
///            button {
///                on.click (fun _ -> setCount2 (count2 + 1))
///                "Increase count2"
///            }
///         }
///     }
///
/// But you can define like below
/// let counters =
///    let count1 = cval 1
///    let count2 = cval 2
///    adaptiview () {
///        let! count1, setCount1 = count1.WithSetter()
///        let! count2, setCount2 = count2.WithSetter()
///        div {
///            button {
///                on.click (fun _ -> setCount1 (count1 + 1))
///                "Increase count1 will casuse count2 be reset"
///            }
///            button {
///                on.click (fun _ -> setCount2 (count2 + 1))
///                "Increase count2"
///            }
///         }
///     }
/// </code>
/// </example>
type adaptiview = AdaptiviewBuilder
