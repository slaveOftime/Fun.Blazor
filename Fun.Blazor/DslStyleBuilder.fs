namespace Fun.Blazor.Internal

open System.Text
open Fun.Blazor
open Fun.Blazor.Utils.Internal


type StyleBuilder() =
    inherit Fun.Css.CssBuilder()

    member inline _.Run([<InlineIfLambda>] combine: Fun.Css.Internal.CombineKeyValue) =
        AttrRenderFragment(fun _ builder index ->
            let sb = stringBuilderPool.Get()
            builder.AddAttribute(index, "style", combine.Invoke(sb).ToString())
            stringBuilderPool.Return sb
            index + 1
        )


type StyleStrBuilder() =
    inherit Fun.Css.CssBuilder()

    member inline _.Run([<InlineIfLambda>] combine: Fun.Css.Internal.CombineKeyValue) =
        let sb = stringBuilderPool.Get()
        let str = combine.Invoke(sb).ToString()
        stringBuilderPool.Return sb
        str


type RulesetBuilder(ruleName: string) =
    inherit Fun.Css.CssBuilder()

    member _.Run(combine: Fun.Css.Internal.CombineKeyValue) = struct (ruleName, combine)


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

    member _.Run(kf: KeyFrame) = struct (identifier, kf)

    member inline _.Yield([<InlineIfLambda>] kf: KeyFrame) = kf

    member inline _.Delay([<InlineIfLambda>] fn: unit -> KeyFrame) = KeyFrame(fun x -> fn().Invoke(x))

    member inline _.Combine([<InlineIfLambda>] kf1: KeyFrame, [<InlineIfLambda>] kf2: KeyFrame) = KeyFrame(fun sb -> kf2.Invoke(kf1.Invoke(sb)))


type StyleEltBuilder() =
    inherit EltWithChildBuilder "style"

    member inline _.Yield((identifier, kf): struct (string * KeyFrame)) =
        let sb = stringBuilderPool.Get()

        sb.Append("@keyframes ").Append(identifier).AppendLine(" {") |> ignore
        kf.Invoke(sb) |> ignore
        sb.AppendLine("}") |> ignore

        let result = sb.ToString()
        stringBuilderPool.Return sb
        html.raw result

    member inline _.Yield((ruleName, combine): struct (string * Fun.Css.Internal.CombineKeyValue)) =
        let sb = stringBuilderPool.Get()
        sb.Append(ruleName).AppendLine(" {") |> ignore
        sb.Append("    ") |> ignore
        combine.Invoke(sb) |> ignore
        sb.AppendLine().AppendLine("}") |> ignore
        let str = sb.ToString()
        stringBuilderPool.Return sb
        html.raw str


namespace Fun.Blazor

open Internal

[<AutoOpen>]
module DslStyle =

    let styleElt = StyleEltBuilder()

    /// Build a link stylesheet node
    let inline stylesheet (x: string) =
        link {
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
