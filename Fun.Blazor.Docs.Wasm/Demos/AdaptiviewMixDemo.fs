module Fun.Blazor.Docs.Wasm.Demos.AdaptiviewMixDemo

open System
open Fun.Blazor
open FSharp.Control.Reactive

let private observe = Observable.interval (TimeSpan.FromSeconds(1.))
let private store: IStore<int> = new Store<int>(0)

let private adaptiveObs = AVal.ofObservable 0L ignore observe
let private adaptiveStore = AVal.ofObservable 0 ignore store.Observable

let entry = fragment {
    adapt {
        let! fromObs = adaptiveObs
        let! fromStore = adaptiveStore
        p { $"Observable: {fromObs} - Store: {fromStore}" }
    }
    button {
        onclick (fun _ -> store.Publish(store.Current + 10))
        "Update Store"
    }
}
