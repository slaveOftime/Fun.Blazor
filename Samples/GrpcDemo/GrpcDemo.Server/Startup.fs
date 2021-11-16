namespace GrpcDemo.Server

open System.Threading.Tasks
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.AspNetCore.Http
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Hosting
open GrpcDemo.Protos.Greeter


type GreeterService() =
    inherit Greeter.GreeterBase()

    override _.SayHello (req, ctx) = task {
        do! Task.Delay 1000
        return HelloReply(Message = "Hello from grpc")
    }


type Startup() =
    member _.ConfigureServices(services: IServiceCollection) =
        services.AddGrpc() |> ignore
        services.AddCors(fun o ->
            o.AddPolicy("AllowAll", fun builder ->
                builder
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .WithExposedHeaders("Grpc-Status", "Grpc-Message", "Grpc-Encoding", "Grpc-Accept-Encoding")
                    |> ignore
            )
        ) |> ignore


    member _.Configure(app: IApplicationBuilder, env: IWebHostEnvironment) =
        if env.IsDevelopment() then
            app.UseDeveloperExceptionPage() |> ignore

        app.UseRouting()
           .UseGrpcWeb()
           .UseCors()
           .UseEndpoints(fun endpoints ->
                endpoints.MapGrpcService<GreeterService>().EnableGrpcWeb().RequireCors("AllowAll") |> ignore
                endpoints.MapGet("/", fun context ->
                    context.Response.WriteAsync("Hello World!")) |> ignore
            ) |> ignore
