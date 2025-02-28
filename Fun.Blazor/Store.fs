namespace Fun.Blazor

open System
open System.Threading.Tasks
open System.Collections.Generic
open System.Collections.Concurrent
open FSharp.Data.Adaptive
open Fun.Result


type IStoreManager =

    /// Create an adaptive value and share between components.
    /// This is recommend way because you can use it with adaptiview easier.
    abstract CreateCVal: string * 'T -> cval<'T>

    /// Create an adaptive value and share between components.
    /// This is recommend way because you can use it with adaptiview easier.
    abstract CreateCVal: string * defautValue: 'T * init: (unit -> aval<'T>) -> cval<'T>

    /// Create an adaptive value and share between components.
    /// This is recommend way because you can use it with adaptiview easier.
    abstract CreateCVal: string * defautValue: 'T * init: (unit -> Task<'T>) -> cval<'T>

    /// Create an adaptive list and share between components.
    abstract CreateCList: string * ?defautValue: 'T seq -> clist<'T>

    /// Create an adaptive map and share between components.
    abstract CreateCHashSet: string * ?defautValue: 'T seq -> ChangeableHashSet<'T>

    /// Create an adaptive map and share between components.
    abstract CreateCMap: string * ?defautValue: ('K * 'T) seq -> cmap<'K, 'T>

    // Help us to access DI container
    abstract ServiceProvider: IServiceProvider

    /// This is for library authors.
    /// For example, with this we can abstract the FSharp.Control.Reactive out to a separate pacakges to consume.
    abstract GetOrAddDisposableStore: string * (unit -> IDisposable) -> IDisposable

    /// This is for library authors.
    /// Can be used to add subscriptions resources, so we can clean it up when the store manager is disposing.
    abstract AddDispose: IDisposable -> unit


// You can consume it from a DI container, and it is served as a scoped service
type IShareStore =
    inherit IStoreManager

// You can consume it from a DI container, and it is served as a singleton service
// * Note this is not distributable, and only works for long runing single instance of web service.
type IGlobalStore =
    inherit IStoreManager


type StoreManager(sp: IServiceProvider) =
    let avals = ConcurrentDictionary<string, obj>()
    let stores = ConcurrentDictionary<string, IDisposable>()
    let disposes = List<IDisposable>()


    interface IShareStore with

        member _.CreateCVal(key: string, defaultValue: 'T) =
            let x = avals.GetOrAdd(key, valueFactory = (fun _ -> cval defaultValue))

            x :?> cval<'T>

        member _.CreateCVal(key: string, defaultValue: 'T, init: unit -> aval<'T>) =
            avals.GetOrAdd(
                key,
                valueFactory =
                    fun _ ->
                        let data = cval defaultValue
                        init().AddCallback(fun x -> transact (fun () -> data.Value <- x)) |> ignore
                        data
            )
            :?> cval<'T>

        member _.CreateCVal(key: string, defaultValue: 'T, init: unit -> Task<'T>) =
            avals.GetOrAdd(
                key,
                valueFactory =
                    fun _ ->
                        let data = cval defaultValue
                        init () |> Task.map (fun x -> transact (fun () -> data.Value <- x)) |> ignore
                        data
            )
            :?> cval<'T>

        member _.CreateCList(key: string, ?defaultValue: 'T seq) =
            avals.GetOrAdd(key, valueFactory = (fun _ -> clist (defaultArg defaultValue Seq.empty))) :?> clist<'T>

        member _.CreateCHashSet(key: string, ?defaultValue: 'T seq) =
            avals.GetOrAdd(key, valueFactory = (fun _ -> ChangeableHashSet(defaultArg defaultValue Seq.empty))) :?> ChangeableHashSet<'T>

        member _.CreateCMap(key: string, ?defaultValue: ('K * 'T) seq) =
            avals.GetOrAdd(key, valueFactory = (fun _ -> cmap<'K, 'T> (defaultArg defaultValue Seq.empty))) :?> cmap<'K, 'T>

        member _.ServiceProvider = sp

        member _.GetOrAddDisposableStore(key, maker) = stores.GetOrAdd(key, (fun _ -> maker ()))

        member _.AddDispose x = disposes.Add x


    interface IDisposable with
        member _.Dispose() =
            stores |> Seq.iter (fun store -> store.Value.Dispose())
            disposes |> Seq.iter (fun sub -> sub.Dispose())


type ShareStore(sp: IServiceProvider) =
    inherit StoreManager(sp)

    interface IShareStore


type GlobalStore(sp: IServiceProvider) =
    inherit StoreManager(sp)

    interface IGlobalStore
