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

    member inline this.Run(x: aval<FunRenderFragment>) =
        html.comp<AdaptiveComponent> () {
            "Fragment" => x
            match this.IsStatic with
            | Some true -> "IsStatic" => true
            | _ -> ()
            match this.Key with
            | Some k -> html.key k
            | None -> ()
        }

    member inline _.Yield([<InlineIfLambda>] x: FunRenderFragment) = AVal.init x

    member inline _.Delay(fn: unit -> aval<FunRenderFragment>) = fn ()

    member inline _.Combine(val1: aval<FunRenderFragment>, val2: aval<FunRenderFragment>) =
        adaptive {
            let! render1 = val1
            let! render2 = val2
            return render1 ==> render2
        }


[<Extension>]
type Extensions =
    [<Extension>]
    static member inline Publish(this: cval<'T>, x: 'T) = transact (fun () -> this.Value <- x)

    [<Extension>]
    static member inline Publish(this: cval<'T>, fn: 'T -> 'T) = transact (fun () -> this.Value <- fn this.Value)

    [<Extension>]
    static member inline WithSetter(this: cval<'T>) =
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
