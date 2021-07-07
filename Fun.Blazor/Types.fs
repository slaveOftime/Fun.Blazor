namespace rec Fun.Blazor

open System
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


type FunBlazorContext<'Component when 'Component :> Microsoft.AspNetCore.Components.IComponent> () =
    let props = Collections.Generic.List<IFunBlazorNode>()

    member this.AddProp x = props.Add x; this
    member this.Props() = props

    // Executes a computation expression
    member this.Run _ = this :> IFunBlazorNode
    member this.Yield _ = this

    member this.Zero _ = Html.empty |> BoleroNode :> IFunBlazorNode
    
    [<CustomOperation("attrs")>]
    member this.attrs (_: FunBlazorContext<'Component>, nodes: IFunBlazorNode list) = nodes |> Seq.iter (this.AddProp >> ignore); this
    
    [<CustomOperation("ref")>] member this.ref (_: FunBlazorContext<'Component>, v) = Bolero.Html.attr.ref v |> BoleroAttr |> this.AddProp
    

    interface IFunBlazorNode with
        member this.Node () =
            let nodes, attrs = props |> FunBlazorNode.GetBoleroNodesAndAttrs
            BoleroNode (Bolero.Html.comp<'Component> attrs nodes)
            
    

type IStore<'T> =
    abstract Publish: ('T -> 'T) -> unit
    abstract Publish: 'T -> unit
    abstract Observable: IObservable<'T>
    abstract Current: 'T


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


// Will serve as a scoped a service
type IShareStore =
    /// Create an IStore and share between components and dispose it after session disposed
    abstract Create: string * 'T -> IStore<'T>

    /// Create an IStore and share between components and dispose it after session disposed
    abstract Create: 'T -> IStore<'T>

    /// Create an IStore and share between components and dispose it after session disposed
    /// Default state will be NotStartedYet
    abstract CreateDeferred: string * (unit -> IObservable<DeferredState<'T, 'Error>>) -> IStore<DeferredState<'T, 'Error>>


// Will serve as a singleton service
// * Note this is not distributable
type IGlobalStore = 
    inherit IShareStore
    