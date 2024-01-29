[<AutoOpen>]
module Fun.Blazor.DslElementBuilder_extensions

open System.Reflection
open Microsoft.AspNetCore.Components
open Fun.Blazor
open Fun.Blazor.Operators
open Fun.Blazor.DslElementBuilder_generated


#if !NET6_0
type EltBuilder_form with

    /// Enhanced form handling isn't hierarchical and doesn't flow to child forms:
    [<CustomOperation("dataEnhance")>]
    member inline _.dataEnhance([<InlineIfLambda>] render: AttrRenderFragment, v: bool) =
        render ==> ("data-enhance" => (if v then "true" else "false"))

    /// Enhanced form handling isn't hierarchical and doesn't flow to child forms:
    [<CustomOperation("dataEnhance")>]
    member inline this.dataEnhance([<InlineIfLambda>] render: AttrRenderFragment) = this.dataEnhance (render, true)


    [<CustomOperation("formName")>]
    member inline _.formName([<InlineIfLambda>] render: AttrRenderFragment, value: string) =
        struct (render,
                PostRenderFragment(fun _ builder index ->
                    builder.AddNamedEvent("onsubmit", value)
                    index
                ))

    [<CustomOperation("formName")>]
    member inline _.formName((render1, render2): struct (AttrRenderFragment * PostRenderFragment), value: string) =
        struct (render1,
                PostRenderFragment(fun comp builder index ->
                    let nextIndex = render2.Invoke(comp, builder, index)
                    builder.AddNamedEvent("onsubmit", value)
                    nextIndex
                ))
#endif


/// Put raw js into the script tag
let inline js (x: string) =
    NodeRenderFragment(fun _ builder index ->
        builder.OpenElement(index, "script")
        builder.AddMarkupContent(index + 1, x)
        builder.CloseElement()
        index + 2
    )


let inline doctype decl =
    NodeRenderFragment(fun _ builder index ->
        builder.AddMarkupContent(index, $"<!DOCTYPE {decl}>\n")
        index + 1
    )

let inline baseUrl (x: string) = base' { href x }

let inline viewport (x: string) = meta {
    name "viewport"
    content x
}

let chartsetUTF8 = meta { charset "utf-8" }

/// Can be used to build shared dom attributes fragment
let domAttr = DomAttrBuilder()


type html with

    /// Build hidden inputs for a given state's public properties.
    /// If the type is IComponent, only the property with attribute ParameterAttribute will be taken
    static member createHiddenInputs<'T>(data: 'T) =
        let ty = typeof<'T>

        data.GetType().GetProperties(BindingFlags.Instance ||| BindingFlags.Public)
        |> Seq.choose (fun p ->
            if ty = typeof<IComponent> then
                let attr = p.GetCustomAttribute<ParameterAttribute>()
                if isNull attr then None else Some p
            else
                Some p
        )
        |> Seq.map (fun p ->
            match p.GetValue data with
            | null -> html.none
            | x -> input {
                type' InputTypes.hidden
                name p.Name
                value x
              }
        )
        |> html.fragment
