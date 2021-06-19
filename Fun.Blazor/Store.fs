namespace Fun.Blazor

open System
open System.Collections.Generic
open FSharp.Control.Reactive


type Store<'T> (defaultValue: 'T) =
    let subject = Subject<'T>.broadcast
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

    interface IDisposable with
        member _.Dispose() =
            subject.Dispose()
            if subsribtion <> null then 
                subsribtion.Dispose()


type LocalStore () =
    let stores = List<IDisposable>()


    interface ILocalStore with
        member _.Create<'T> x =
            let store = new Store<'T>(x)
            stores.Add store
            store :> IStore<'T>


    interface IDisposable with
        member _.Dispose() =
            stores |> Seq.iter (fun store -> store.Dispose())


type ShareStore () =
    let stores = Dictionary<string, IDisposable>()


    interface IShareStore with
        member _.Create (key: string, defaultValue: 'T) =
            if stores.ContainsKey key then
                stores.[key] :?> IStore<'T>
            else
                let store = new Store<'T>(defaultValue)
                stores.Add(key, store)
                store :> IStore<'T>

        member this.Create (defaultValue: 'T) =
            let key = typeof<'T>.FullName
            (this :> IShareStore).Create(key, defaultValue)


    interface IDisposable with
        member _.Dispose() =
            stores |> Seq.iter (fun store -> store.Value.Dispose())
