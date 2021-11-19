namespace rec Fun.Blazor

open System
open FSharp.Data.Adaptive
open Bolero
open Bolero.Html
open Fun.Result


type FunBlazorRef<'T> = Ref<'T>


type FunBlazorComponent = Bolero.Component


/// Little wrapper node for feliz style DSL
[<Struct>]
type FelizNode<'T> =
    { Attrs: Attr seq }

    static member concat (nodes: FelizNode<'T> seq) = nodes |> Seq.map (fun x -> x.Attrs) |> Seq.concat |> Seq.toList

    static member create x: FelizNode<'T> = { Attrs = [x] }
    static member create x: FelizNode<'T> = { Attrs = x }

    static member create (name, value: IStore<'V>) =
        FelizNode<'T>.create [
            name => value.Current
            Bolero.Html.attr.callback<'V> $"{name}Changed" (fun (x: 'V) -> value.Publish x)
        ]

    static member create (name, value: cval<'V>) =
        FelizNode<'T>.create [
            name => AVal.force value
            Bolero.Html.attr.callback<'V> $"{name}Changed" (fun x-> transact(fun _ -> value.Value <- x))
        ]

    static member create (name, (value: 'V, fn)) =
        FelizNode<'T>.create [
            name => value
            Bolero.Html.attr.callback<'V> $"{name}Changed" fn
        ]


/// Base class for Computation Expression style DSL
type FunBlazorBuilder<'Component when 'Component :> Microsoft.AspNetCore.Components.IComponent> () =
    let attrs = Collections.Generic.List<Attr>()
    let nodes = Collections.Generic.List<Node>()

    member this.AddAttr x = attrs.Add x; this
    member this.AddNode x = nodes.Add x; this
    member this.AddNodes x = nodes.AddRange x; this

    member this.AddBinding (name, value: IStore<'T>) =
        name => value.Current |> this.AddAttr |> ignore
        Bolero.Html.attr.callback<'T> $"{name}Changed" value.Publish |> this.AddAttr
    
    member this.AddBinding (name, value: cval<'T>) =
        name => AVal.force value |> this.AddAttr |> ignore
        Bolero.Html.attr.callback<'T> $"{name}Changed" (fun x -> transact(fun _ -> value.Value <- x)) |> this.AddAttr

    member this.AddBinding (name, (value: 'T, fn)) =
        name => value |> this.AddAttr |> ignore
        Bolero.Html.attr.callback<'T> $"{name}Changed" fn |> this.AddAttr


    member this.Props() = attrs, nodes
    member this.CreateNode() = Bolero.Html.comp<'Component> (Seq.toList attrs) (Seq.toList nodes)

    // Executes a computation expression
    member this.Run _ = Bolero.Html.comp<'Component> (Seq.toList attrs) (Seq.toList nodes)
    member this.Yield _ = this

    member this.Zero _ = Html.empty
    
    [<CustomOperation("ref")>]
    member this.ref (_: FunBlazorBuilder<'Component>, v) = Bolero.Html.attr.ref v |> this.AddAttr
    
    [<CustomOperation("onevent")>]
    member this.event (_: FunBlazorBuilder<'Component>, eventName, callback) = Bolero.Html.on.event eventName callback |> this.AddAttr
    
    [<CustomOperation("preventDefault")>]
    member this.preventDefault (_: FunBlazorBuilder<'Component>, eventName, value) = Bolero.Html.on.preventDefault eventName value |> this.AddAttr
    
    [<CustomOperation("stopPropagation")>]
    member this.stopPropagation (_: FunBlazorBuilder<'Component>, eventName, value) = Bolero.Html.on.stopPropagation eventName value |> this.AddAttr

    

type IStore<'T> =
    abstract Publish: ('T -> 'T) -> unit
    abstract Publish: 'T -> unit
    abstract Observable: IObservable<'T>
    abstract Current: 'T
    abstract Key: string


type IObserveValue<'T> =
    abstract member Current: 'T


type IComponentHook =
    //abstract OnParametersSet: IEvent<unit>
    //abstract OnInitialized: IEvent<unit>
    abstract OnAfterRender: IEvent<bool>
    abstract OnFirstAfterRender: IEvent<unit>
    abstract OnDispose: IEvent<unit>
    abstract AddDispose: IDisposable -> unit
    abstract AddDisposes: IDisposable seq -> unit
    abstract StateHasChanged: unit -> unit
    /// Create an IStore and hold in component and dispose it after component disposed
    abstract UseStore: 'T -> IStore<'T>
    abstract UseCVal: IStore<'T> -> cval<'T>
    abstract UseAVal: IStore<'T> -> aval<'T>
    abstract UseAVal: defaultValue: 'T * IObservable<'T> -> aval<'T>

// Will serve as a scoped a service
type IShareStore =
    /// Create an IStore and share between components and dispose it after session disposed
    abstract Create: string * 'T -> IStore<'T>

    /// Create an IStore and share between components and dispose it after session disposed
    abstract Create: 'T -> IStore<'T>

    /// Create an IStore and share between components and dispose it after session disposed
    /// Default state will be NotStartedYet
    abstract CreateDeferred: string * (unit -> IObservable<DeferredState<'T, 'Error>>) -> IStore<DeferredState<'T, 'Error>>

    abstract CreateCVal: string * 'T -> cval<'T>


// Will serve as a singleton service
// * Note this is not distributable
type IGlobalStore = 
    inherit IShareStore
    