namespace Fun.Blazor

open System
open System.Threading.Tasks
open System.Collections.Generic
open System.Collections.Concurrent
open FSharp.Data.Adaptive
open Fun.Result


type StoreManager(sp: IServiceProvider) =
    let avals = ConcurrentDictionary<string, IAdaptiveValue>()
    let stores = ConcurrentDictionary<string, IDisposable>()
    let disposes = List<IDisposable>()


    interface IShareStore with

        member _.CreateCVal(key: string, defaultValue: 'T) = avals.GetOrAdd(key, (fun _ -> cval defaultValue :> IAdaptiveValue)) :?> cval<'T>

        member _.CreateCVal(key: string, defaultValue: 'T, init: unit -> aval<'T>) =
            avals.GetOrAdd(
                key,
                fun _ ->
                    let data = cval defaultValue
                    init().AddCallback(fun x -> transact (fun () -> data.Value <- x)) |> ignore
                    data :> IAdaptiveValue
            )
            :?> cval<'T>

        member _.CreateCVal(key: string, defaultValue: 'T, init: unit -> Task<'T>) =
            avals.GetOrAdd(
                key,
                fun _ ->
                    let data = cval defaultValue
                    init () |> Task.map (fun x -> transact (fun () -> data.Value <- x)) |> ignore
                    data :> IAdaptiveValue
            )
            :?> cval<'T>

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
