[<AutoOpen>]
module Fun.Blazor.Utils

open System
open System.Diagnostics
open System.Threading.Tasks
open Microsoft.Extensions.Logging
open Microsoft.AspNetCore.Components
open Microsoft.Extensions.ObjectPool


module Internal =
    /// Helper method to create an empty AttrRenderFragment
    let inline emptyAttr () = AttrRenderFragment(fun _ _ i -> i)

    /// Helper method to create an empty NodeRenderFragment
    let inline emptyNode () = NodeRenderFragment(fun _ _ i -> i)

    let inline makeRegion (nodes: NodeRenderFragment seq) =
        NodeRenderFragment(fun comp builder sequence ->
            builder.OpenRegion(sequence)

            let mutable i = 0
            for node in nodes do
                i <- node.Invoke(comp, builder, i)

            builder.CloseRegion()
            sequence + 1
        )


    [<Literal>]
    let FunBlazorScopedServicesName = "fun-blazor-scoped-services"


    let objectPoolProvider = DefaultObjectPoolProvider()
    let stringBuilderPool = objectPoolProvider.CreateStringBuilderPool()
    let dictionaryPool =
        objectPoolProvider.Create<Collections.Generic.Dictionary<string, obj>>()


    let makeStyles (rules: (string * string) seq) =
        let sb = stringBuilderPool.Get()

        for (k, v) in rules do
            sb.Append(k).Append(": ").Append(v).Append("; ") |> ignore

        let result = sb.ToString()
        stringBuilderPool.Return sb
        result


    /// Please do not depend on this type, it maybe renamed in the future
    [<Struct>]
    type AttrRenderFragmentWrapper = | AttrRenderFragmentWrapper of AttrRenderFragment
    

    type ILogger with

        member inline this.LogDebugForPerf fn =
#if DEBUG
            let sw = Stopwatch.StartNew()
            this.LogDebug($"Function started")
            let result = fn ()
            this.LogDebug($"Function finished in {sw.ElapsedMilliseconds}")
            result
#else
            fn ()
#endif



type IComponent with

    member comp.Render(fragment: NodeRenderFragment) = RenderFragment(fun builder -> fragment.Invoke(comp, builder, 0) |> ignore)

    member comp.Callback<'T>(fn: 'T -> unit) = EventCallback.Factory.Create<'T>(comp, fn)
    member comp.Callback<'T>(fn: 'T -> Task) = EventCallback.Factory.Create<'T>(comp, fn)
