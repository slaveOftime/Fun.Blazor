[<AutoOpen>]
module App

open FSharp.Data.Adaptive
open Fun.Result
open Fun.Blazor
open Fun.Blazor.DslCE
open Grpc.Net.Client
open GrpcDemo.Protos.Greeter


let app = html.inject <| fun (chanel: GrpcChannel, hook: IComponentHook) ->
    let message = cval DeferredState.Loading


    let sayHello () =
        task {
            try
                DeferredState.Loading |> message.Publish
                let greeter = Greeter.GreeterClient(chanel)
                let! resp = greeter.SayHelloAsync(HelloRequest(Name = "WASM")).ResponseAsync
                DeferredState.Loaded resp.Message |> message.Publish
            with ex ->
                DeferredState.LoadFailed ex.Message |> message.Publish
        }
        |> ignore


    sayHello()


    adaptiview(){
        let! msg = message

        div(){
            styles [ ]
            childContent [
                match msg with
                | DeferredState.Loading -> html.div "Loading from grpc service"
                | DeferredState.Loaded x -> html.div $"Responsed from grpc service: {x}"
                | DeferredState.LoadFailed e -> html.div $"Error: {e}"
                | _ -> html.none
                button(){
                    onclick (ignore >> sayHello)
                    childContent "Retry"
                }
            ]
        }
    }
