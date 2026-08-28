module Fun.Blazor.Tests.StoreTests

open System
open System.Threading.Tasks
open FSharp.Data.Adaptive
open Microsoft.Extensions.DependencyInjection
open Xunit
open Fun.Blazor


type private TrackingDisposable() =
    member val IsDisposed = false with get, set

    interface IDisposable with
        member this.Dispose() = this.IsDisposed <- true


let private createStore () =
    let services = ServiceCollection().BuildServiceProvider()
    let manager = new ShareStore(services)
    manager, manager :> IShareStore, services


[<Fact>]
let ``cval is initialized once and shared by key`` () =
    let manager, store, services = createStore ()
    use _manager = manager :> IDisposable
    use _services = services
    let mutable initializations = 0
    let defaultValue = store.CreateCVal("default", 5)

    let first =
        store.CreateCVal(
            "counter",
            0,
            fun () ->
                initializations <- initializations + 1
                AVal.constant 10
        )

    let second = store.CreateCVal("counter", -1)

    Assert.Same(first, second)
    Assert.Equal(5, AVal.force defaultValue)
    Assert.Equal(1, initializations)
    Assert.Equal(10, AVal.force first)
    Assert.Same(services, store.ServiceProvider)


[<Fact>]
let ``global store exposes the store manager API`` () =
    use services = ServiceCollection().BuildServiceProvider()
    use manager = new GlobalStore(services)
    let store = manager :> IGlobalStore

    let value = store.CreateCVal("global", 3)

    Assert.Equal(3, AVal.force value)
    Assert.Same(services, store.ServiceProvider)


[<Fact>]
let ``cval tracks an adaptive initializer`` () =
    let manager, store, services = createStore ()
    use _manager = manager :> IDisposable
    use _services = services
    let source = cval 1
    let value = store.CreateCVal("adaptive", 0, fun () -> source :> aval<int>)

    Assert.Equal(1, AVal.force value)

    transact (fun () -> source.Value <- 2)

    Assert.Equal(2, AVal.force value)


[<Fact>]
let ``cval supports an asynchronous initializer`` () =
    task {
        let manager, store, services = createStore ()
        use _manager = manager :> IDisposable
        use _services = services
        let initialized = TaskCompletionSource<int>()
        let value = store.CreateCVal("async", 0, fun () -> initialized.Task)

        Assert.Equal(0, AVal.force value)

        initialized.SetResult 42

        let mutable attempts = 0

        while AVal.force value <> 42 && attempts < 20 do
            attempts <- attempts + 1
            do! Task.Delay 10

        Assert.Equal(42, AVal.force value)
    }


[<Fact>]
let ``adaptive collections are shared by key`` () =
    let manager, store, services = createStore ()
    use _manager = manager :> IDisposable
    use _services = services

    let list = store.CreateCList("list", [ 1; 2 ])
    let hashSet = store.CreateCHashSet("set", [ 1; 2 ])
    let map = store.CreateCMap("map", [ "one", 1 ])

    Assert.Same(list, store.CreateCList<int>("list"))
    Assert.Same(hashSet, store.CreateCHashSet<int>("set"))
    Assert.Same(map, store.CreateCMap<string, int>("map"))


[<Fact>]
let ``disposing a store disposes registered resources once`` () =
    let manager, store, services = createStore ()
    use _services = services
    let keyed = new TrackingDisposable()
    let duplicate = new TrackingDisposable()
    let additional = new TrackingDisposable()

    let first = store.GetOrAddDisposableStore("subscription", fun () -> keyed)
    let second = store.GetOrAddDisposableStore("subscription", fun () -> duplicate)
    store.AddDispose additional

    Assert.Same(first, second)

    (manager :> IDisposable).Dispose()

    Assert.True(keyed.IsDisposed)
    Assert.False(duplicate.IsDisposed)
    Assert.True(additional.IsDisposed)
