namespace Fun.Blazor

open System
open Fun.Blazor
open Microsoft.AspNetCore.Components.Rendering


module private SSRTemplate =
    let partialStringCache =
        System.Collections.Concurrent.ConcurrentDictionary<int, Map<int, String>>()

/// This is not supposed to be used in blazor runtime, because it will try to excape the partial markup.
/// This is supposed to be used for server side render. For example, use it with htmx should be good.
type SSRTemplate =

    /// This method only expect for types which will be converted as string direactly, or RenderNodeFragment as the argument.
    /// If use RenderNodeFragment only, then it can be used in blazor runtime. Any other arguments which will break the markup should not be used in blazor runtime. because it will try to process the markup string and excape some characters.
    static member html(html: FormattableString) =
        let args = html.GetArguments()
        let hashKey = html.Format.GetHashCode()

        let renderArg argIndex sequence comp (builder: RenderTreeBuilder) =
            let mutable sequence = sequence
            match args[argIndex] with
            | :? NodeRenderFragment as node -> sequence <- node.Invoke(comp, builder, sequence)
            | :? System.Collections.Generic.IEnumerable<NodeRenderFragment> as nodes ->
                for node in nodes do
                    sequence <- node.Invoke(comp, builder, sequence)
            | null -> ()
            | arg ->
                builder.AddMarkupContent(sequence, arg.ToString())
                sequence <- sequence + 1
            sequence

        if args.Length = 0 then
            Static.html html.Format
        else if SSRTemplate.partialStringCache.ContainsKey(hashKey) then
            NodeRenderFragment(fun comp builder i ->
                let mutable sequence = i
                let mutable argIndex = 0
                let dicts = SSRTemplate.partialStringCache[hashKey]

                while argIndex < html.ArgumentCount do
                    builder.AddMarkupContent(sequence, dicts[argIndex])
                    sequence <- renderArg argIndex (sequence + 1) comp builder
                    argIndex <- argIndex + 1

                if dicts.ContainsKey(argIndex) then
                    builder.AddMarkupContent(sequence, dicts[argIndex])
                    sequence <- sequence + 1

                sequence
            )
        else
            NodeRenderFragment(fun comp builder i ->
                let mutable sequence = i
                let mutable argIndex = 0
                let mutable templateSpan = html.Format.AsSpan()
                let dicts = System.Collections.Generic.Dictionary<int, String>()
                while argIndex < args.Length && not templateSpan.IsEmpty do
                    let indexer = String.Format("{{{0}}}", argIndex)
                    let index = templateSpan.IndexOf(indexer)
                    let partialStr = templateSpan.Slice(0, index).ToString()

                    dicts[argIndex] <- partialStr

                    builder.AddMarkupContent(sequence, partialStr)
                    sequence <- renderArg argIndex (sequence + 1) comp builder

                    let endIndex = index + indexer.Length
                    if endIndex < templateSpan.Length - 1 then
                        templateSpan <- templateSpan.Slice(endIndex)
                    else
                        templateSpan <- ReadOnlySpan<char>.Empty

                    argIndex <- argIndex + 1

                if not templateSpan.IsEmpty then
                    let partialStr = templateSpan.ToString()
                    dicts[argIndex] <- partialStr
                    builder.AddMarkupContent(sequence, partialStr)
                    sequence <- sequence + 1

                SSRTemplate.partialStringCache.TryAdd(hashKey, dicts |> Seq.map (fun kv -> kv.Key, kv.Value) |> Map.ofSeq)
                |> ignore

                sequence
            )
