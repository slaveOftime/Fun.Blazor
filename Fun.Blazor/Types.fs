namespace rec Fun.Blazor

open System
open FSharp.Data.Adaptive
open Bolero
open Bolero.Html
open Fun.Result


type FunBlazorRef<'T> = Ref<'T>


type IFunBlazorNode =
    abstract member Node: unit -> FunBlazorNode

type FunBlazorNode =
    | Elt of tag: string * IFunBlazorNode list
    | Attr of key: string * value: Choice<string, bool>
    | Fragment of IFunBlazorNode list
    | Text of string
    | BoleroNode of Bolero.Node
    | BoleroAttr of Bolero.Attr
    | BoleroAttrs of Bolero.Attr list

    static member GetBoleroNodesAndAttrs (nodes: IFunBlazorNode seq) =
        let rec getBoleroNodeAndAttrs (nodes: IFunBlazorNode seq) =
            nodes 
            |> Seq.fold
                (fun (nodes, attrs) x ->
                    match x.Node() with
                    | Attr (k, Choice1Of2 v) -> nodes, attrs@[ Bolero.Attr (k, v) ]
                    | Attr (k, Choice2Of2 true) -> nodes, attrs@[ Bolero.Attr (k, "") ]
                    | Attr _ -> nodes, attrs
                    | BoleroAttr x -> nodes, attrs@[x]
                    | BoleroAttrs x -> nodes, attrs@x
                    | node ->
                        let node =
                            match node with
                            | Elt (tag, nodes) ->
                                let nodes, attrs = getBoleroNodeAndAttrs nodes
                                Bolero.Elt(tag, attrs, nodes)
                            | Fragment nodes ->
                                let nodes, _ = getBoleroNodeAndAttrs nodes
                                Bolero.Concat nodes
                            | Text x ->
                                Bolero.Text x
                            | BoleroNode x ->
                                x
                            | BoleroAttr _
                            | BoleroAttrs _
                            | Attr _ ->
                                Bolero.Empty
                        nodes@[node], attrs)
                ([], [])
        getBoleroNodeAndAttrs nodes

    static member ToBolero node =
        let nodes, _ = FunBlazorNode.GetBoleroNodesAndAttrs [ node ]
        Bolero.ForEach nodes

    member this.ToBolero () = FunBlazorNode.ToBolero this

    interface IFunBlazorNode with
        member this.Node () = this


type [<Struct>] GenericFunBlazorNode<'T> =
    { Node: IFunBlazorNode }

    static member create x: GenericFunBlazorNode<'T> = { Node = x }

    static member create (name, value: IStore<'V>) =
        BoleroAttrs [
            name => value.Current
            Bolero.Html.attr.callback<'V> $"{name}Changed" (fun (x: 'V) -> value.Publish x)
        ]
        |> GenericFunBlazorNode<'T>.create

    static member create (name, value: cval<'V>) =
        BoleroAttrs [
            name => AVal.force value
            Bolero.Html.attr.callback<'V> $"{name}Changed" (fun x-> transact(fun _ -> value.Value <- x))
        ]
        |> GenericFunBlazorNode<'T>.create

    static member create (name, (value: 'V, fn)) =
        BoleroAttrs [
            name => value
            Bolero.Html.attr.callback<'V> $"{name}Changed" fn
        ]
        |> GenericFunBlazorNode<'T>.create


type FunBlazorContext<'Component when 'Component :> Microsoft.AspNetCore.Components.IComponent> () =
    let props = Collections.Generic.List<IFunBlazorNode>()

    member this.AddProp x = props.Add x; this

    member this.AddProp (name, value: IStore<'T>) =
        name => value.Current |> BoleroAttr |> this.AddProp |> ignore
        Bolero.Html.attr.callback<'T> $"{name}Changed" value.Publish |> BoleroAttr |> this.AddProp
    
    member this.AddProp (name, value: cval<'T>) =
        name => AVal.force value |> BoleroAttr |> this.AddProp |> ignore
        Bolero.Html.attr.callback<'T> $"{name}Changed" (fun x -> transact(fun _ -> value.Value <- x)) |> BoleroAttr |> this.AddProp

    member this.AddProp (name, (value: 'T, fn)) =
        name => value |> BoleroAttr |> this.AddProp |> ignore
        Bolero.Html.attr.callback<'T> $"{name}Changed" fn |> BoleroAttr |> this.AddProp


    member this.Props() = props

    // Executes a computation expression
    member this.Run _ = this :> IFunBlazorNode
    member this.Yield _ = this

    member this.Zero _ = Html.empty |> BoleroNode :> IFunBlazorNode
    
    [<CustomOperation("attrs")>]
    member this.attrs (_: FunBlazorContext<'Component>, nodes: IFunBlazorNode list) = nodes |> Seq.iter (this.AddProp >> ignore); this
    
    [<CustomOperation("attrs")>]
    member this.attrs (_: FunBlazorContext<'Component>, nodes: Attr list) = nodes |> Seq.iter (BoleroAttr >> this.AddProp >> ignore); this

    [<CustomOperation("ref")>]
    member this.ref (_: FunBlazorContext<'Component>, v) = Bolero.Html.attr.ref v |> BoleroAttr |> this.AddProp
    
    [<CustomOperation("onevent")>]
    member this.event (_: FunBlazorContext<'Component>, eventName, callback) = Bolero.Html.on.event eventName callback |> BoleroAttr |> this.AddProp
    
    [<CustomOperation("preventDefault")>]
    member this.preventDefault (_: FunBlazorContext<'Component>, eventName, value) = Bolero.Html.on.preventDefault eventName value |> BoleroAttr |> this.AddProp
    
    [<CustomOperation("stopPropagation")>]
    member this.stopPropagation (_: FunBlazorContext<'Component>, eventName, value) = Bolero.Html.on.stopPropagation eventName value |> BoleroAttr |> this.AddProp


    interface IFunBlazorNode with
        member this.Node () =
            let nodes, attrs = props |> FunBlazorNode.GetBoleroNodesAndAttrs
            BoleroNode (Bolero.Html.comp<'Component> attrs nodes)
            
    

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
    