namespace Fun.Blazor

open System
open System.Collections.Generic
open System.Collections.Concurrent
open FSharp.Data.Adaptive
open FSharp.Control.Reactive
open Fun.Result


type Store<'T> (defaultValue: 'T) =
    let subject = Subject<'T>.broadcast
    let key = Guid.NewGuid().ToString()
    let mutable value = defaultValue
    let mutable subsribtion = null

    do
        subject.OnNext value
        subsribtion <- subject.Subscribe (fun (x': 'T) -> value <- x')

    interface IStore<'T> with
        member _.Publish (fn: 'T -> 'T) = subject.OnNext (fn value)
        member _.Publish (x: 'T) = subject.OnNext x
        member _.Observable = subject :> IObservable<'T>
        member _.Current = value
        member _.Key = key

    interface IDisposable with
        member _.Dispose() =
            subject.Dispose()
            if subsribtion <> null then 
                subsribtion.Dispose()


type ShareStore () =
    let stores = ConcurrentDictionary<string, IDisposable>()
    let avals = ConcurrentDictionary<string, IAdaptiveValue>()
    let subscriptions = List<IDisposable>()


    interface IShareStore with
        member _.Create (key: string, defaultValue: 'T) =
            stores.GetOrAdd(key, fun _ -> new Store<'T>(defaultValue) :> IDisposable)
            :?> IStore<'T>

        member _.CreateDeferred (key: string, getData: unit -> IObservable<DeferredState<'T, 'Error>>) =
            stores.GetOrAdd(key, fun _ ->
                let store = new Store<_>(DeferredState.NotStartYet)
                let subscription = getData().Subscribe (fun x -> (store :> IStore<_>).Publish(x))
                subscriptions.Add subscription
                store :> IDisposable
            )
            :?> IStore<_>

        member this.Create (defaultValue: 'T) =
            let key = typeof<'T>.FullName
            (this :> IShareStore).Create(key, defaultValue)

        member _.CreateCVal (key: string, defaultValue: 'T) =
            avals.GetOrAdd(key, fun _ -> cval defaultValue :> IAdaptiveValue)
            :?> cval<'T>


    interface IDisposable with
        member _.Dispose() =
            stores |> Seq.iter (fun store -> store.Value.Dispose())
            subscriptions |> Seq.iter (fun sub -> sub.Dispose())


type GlobalStore () =
    inherit ShareStore()

    interface IGlobalStore
