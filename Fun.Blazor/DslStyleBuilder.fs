namespace Fun.Blazor.Internal

open System.Text
open Fun.Blazor
open Fun.Blazor.Operators
open Fun.Blazor.Utils.Internal


type StyleBuilder() =
    inherit Fun.Css.CssBuilder()

    member inline _.Run([<InlineIfLambda>] combine: Fun.Css.Internal.CombineKeyValue) =
        AttrRenderFragment(fun _ builder index ->
            let sb = stringBuilderPool.Get()
            try
                builder.AddAttribute(index, "style", combine.Invoke(sb).ToString())
            finally
                stringBuilderPool.Return sb
            index + 1
        )


type StyleStrBuilder() =
    inherit Fun.Css.CssBuilder()

    member inline _.Run([<InlineIfLambda>] combine: Fun.Css.Internal.CombineKeyValue) : string =
        let sb = stringBuilderPool.Get()
        try
            combine.Invoke(sb).ToString()
        finally
            stringBuilderPool.Return sb


type RulesetBuilder(ruleName: string) =
    inherit Fun.Css.CssBuilder()

    member _.RuleName = ruleName

    member inline this.Run(combine: Fun.Css.Internal.CombineKeyValue) = (this.RuleName, combine)


type KeyFrame = delegate of StringBuilder -> StringBuilder

type KeyFrameBuilder(percentage: string) =
    inherit Fun.Css.CssBuilder()

    member _.Run(combine: Fun.Css.Internal.CombineKeyValue) =
        KeyFrame(fun sb ->
            sb.Append("  ").Append(percentage).AppendLine(" {") |> ignore
            sb.Append("    ") |> ignore
            let sb = combine.Invoke(sb).AppendLine()
            sb.AppendLine("  } ")
        )

type KeyFramesBuilder(identifier: string) =

    member _.Identifier = identifier

    member inline this.Run([<InlineIfLambda>] kf: KeyFrame) = (this.Identifier, kf)

    member inline _.Yield([<InlineIfLambda>] kf: KeyFrame) = kf

    member inline _.Delay([<InlineIfLambda>] fn: unit -> KeyFrame) = KeyFrame(fun x -> fn().Invoke(x))

    member inline _.Combine([<InlineIfLambda>] kf1: KeyFrame, [<InlineIfLambda>] kf2: KeyFrame) = KeyFrame(fun sb -> kf2.Invoke(kf1.Invoke(sb)))


type StyleEltBuilder() =
    inherit EltWithChildBuilder "style"

    member inline _.Yield((identifier, kf): (string * KeyFrame)) =
        let sb = stringBuilderPool.Get()
        try
            sb.Append("@keyframes ").Append(identifier).AppendLine(" {") |> ignore
            kf.Invoke(sb) |> ignore
            sb.AppendLine("}") |> ignore
            html.raw (sb.ToString())
        finally
            stringBuilderPool.Return sb


    member inline _.Yield((ruleName, combine): (string * Fun.Css.Internal.CombineKeyValue)) =
        let sb = stringBuilderPool.Get()
        try
            sb.Append(ruleName).AppendLine(" {") |> ignore
            sb.Append("    ") |> ignore
            combine.Invoke(sb) |> ignore
            sb.AppendLine().AppendLine("}") |> ignore
            html.raw (sb.ToString())
        finally
            stringBuilderPool.Return sb


    member inline _.Combine([<InlineIfLambda>] render1: NodeRenderFragment, [<InlineIfLambda>] render2: NodeRenderFragment) = render1 >=> render2


namespace Fun.Blazor

open Internal
open FSharp.Data.Adaptive


type ICssRules =
    /// All the consumed style classes
    abstract member Styles: aval<Map<string, Fun.Css.Internal.CombineKeyValue>>
    /// All the consumed keyframes
    abstract member KeyFrames: aval<Map<string, Fun.Blazor.Internal.KeyFrame>>
    /// Add or override a style class
    abstract member IncludeStyle: (string * Fun.Css.Internal.CombineKeyValue) -> unit
    /// Add or override a style class
    abstract member IncludeStyle: (string * Fun.Css.Internal.CombineKeyValue) seq -> unit
    /// Add or override keyframe
    abstract member IncludeKeyFrame: (string * Fun.Blazor.Internal.KeyFrame) -> unit
    /// Add or override keyframe
    abstract member IncludeKeyFrame: (string * Fun.Blazor.Internal.KeyFrame) seq -> unit

/// Implementation for IInlineStyles
type CssRules() as this =
    let styles = cval (Map.empty<string, Fun.Css.Internal.CombineKeyValue>)
    let keyFrames = cval (Map.empty<string, Fun.Blazor.Internal.KeyFrame>)

    interface ICssRules with
        member _.Styles = styles :> aval<_>
        member _.KeyFrames = keyFrames :> aval<_>

        member _.IncludeStyle((k, f): (string * Fun.Css.Internal.CombineKeyValue)) = transact (fun () -> styles.Value <- Map.add k f styles.Value)

        member _.IncludeStyle(styles: (string * Fun.Css.Internal.CombineKeyValue) seq) =
            for style in styles do
                (this :> ICssRules).IncludeStyle(style)

        member _.IncludeKeyFrame((k, f): (string * Fun.Blazor.Internal.KeyFrame)) =
            transact (fun () -> keyFrames.Value <- Map.add k f keyFrames.Value)

        member _.IncludeKeyFrame(keyframes: (string * Fun.Blazor.Internal.KeyFrame) seq) =
            for keyframe in keyframes do
                (this :> ICssRules).IncludeKeyFrame(keyframe)


/// This is already registered as a scope service by AddFunBlazorXXX, you can consume it directly.
/// You will also need to add html.scopedCssRules to the head of your page, so it can inject the consumed styles for you.
type IScopedCssRules =
    inherit ICssRules

type ScopedCssRules() =
    inherit CssRules()
    interface IScopedCssRules


[<AutoOpen>]
module DslStyle =

    let styleElt = StyleEltBuilder()

    /// Build a link stylesheet node
    let inline stylesheet (x: string) = link {
        rel "stylesheet"
        href x
    }

    /// Build a style string
    let styleStr = StyleStrBuilder()

    /// <summary>
    /// You can use it to build a style attribute for dom
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// div {
    ///     style {
    ///         color "red"
    ///     }
    /// }
    /// </code>
    /// </example>
    let style = StyleBuilder()

    /// <summary>
    /// You can use it as build block when you have complex logic for style
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// div {
    ///     style {
    ///         color "red"
    ///         if true then
    ///             css {
    ///                 backgroundColor "green"
    ///             }
    ///     }
    /// }
    /// </code>
    /// </example>
    let css = Fun.Css.CssBuilder()


    /// Only used for styleElt
    let ruleset ruleName = RulesetBuilder ruleName


    /// Only used for styleElt
    let inline keyframes identifier = KeyFramesBuilder identifier

    /// Only used for styleElt
    let inline keyframe (x: int) = KeyFrameBuilder(sprintf "%d%%" x)

    /// Only used for keyframe
    let keyframeFrom = KeyFrameBuilder "from"

    /// Only used for keyframe
    let keyframeTo = KeyFrameBuilder "to"


    type html with

        /// This will add all the consumed styles or keyframes from IScopedInlineStyles
        static member scopedCssRules =
            html.inject (fun (scopedCssRules: IScopedCssRules) -> fragment {
                adaptiview () {
                    let! styles' = scopedCssRules.Styles
                    if not styles'.IsEmpty then
                        styleElt {
                            for KeyValue(k, v) in styles' do
                                k, v
                        }
                }
                adaptiview () {
                    let! keyframes = scopedCssRules.KeyFrames
                    if not keyframes.IsEmpty then
                        styleElt {
                            for KeyValue(k, v) in keyframes do
                                k, v
                        }
                }
            })
