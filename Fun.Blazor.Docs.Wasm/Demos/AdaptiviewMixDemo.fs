module Fun.Blazor.Docs.Wasm.Demos.AdaptiviewMixDemo

open System
open Fun.Blazor
open FSharp.Control.Reactive
open FSharp.Data.Adaptive

let observe = Observable.interval (TimeSpan.FromSeconds(1.))
let store: IStore<int> = new Store<int>(0)

let adaptiveObs = AVal.ofObservable 0L ignore observe
let adaptiveStore = AVal.ofObservable 0 ignore store.Observable

let entry = fragment {
    adaptiview () {
        let! fromObs = adaptiveObs
        let! fromStore = adaptiveStore
        p { $"Observable: {fromObs} - Store: {fromStore}" }
    }
    button {
        onclick (fun _ -> store.Publish(store.Current + 10))
        "Update Store"
    }
}
