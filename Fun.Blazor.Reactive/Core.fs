namespace Fun.Blazor

open System
open FSharp.Control.Reactive


type IStore<'T> =
    /// <summary>
    /// Takes an identity function, useful for updating or computing new values from previous ones
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// users.Publish(fun user -> { user with name = newName })
    /// </code>
    /// </example>
    abstract Publish : ('T -> 'T) -> unit
    /// <summary>
    /// Takes a new value and replaces the content of the store completely
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// users.Publish(newUser)
    /// </code>
    /// </example>
    abstract Publish : 'T -> unit

    /// <summary>
    /// An observable that contains the changes made to the store over the time
    /// </summary>
    abstract Observable : IObservable<'T>
    /// <summary>
    /// The current value in the store, defaults to the initial value supplied when creating the store
    /// </summary>
    abstract Current : 'T
    /// <summary>
    /// A unique identifier for the current store, this can help to track the origin in shared or global stores
    /// </summary>
    abstract Key : string


type IObserveValue<'T> =
    abstract member Current : 'T


type Store<'T>(defaultValue: 'T) =
    let subject = Subject<'T>.broadcast
    let key = Guid.NewGuid().ToString()
    let mutable value = defaultValue
    let mutable subsribtion = null

    do
        subject.OnNext value
        subsribtion <- subject.Subscribe(fun (x': 'T) -> value <- x')


    interface IStore<'T> with
        member _.Publish(fn: 'T -> 'T) = subject.OnNext(fn value)
        member _.Publish(x: 'T) = subject.OnNext x
        member _.Observable = subject :> IObservable<'T>
        member _.Current = value
        member _.Key = key


    interface IDisposable with
        member _.Dispose() =
            subject.Dispose()
            if subsribtion <> null then subsribtion.Dispose()
