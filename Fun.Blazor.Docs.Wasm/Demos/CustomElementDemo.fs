// hot-reload
module Fun.Blazor.Docs.Wasm.Demos.CustomElementDemo

open Fun.Blazor


let private count =
    html.inject (fun (store: IShareStore) ->
        let count = store.CreateCVal("count", 1)
        div {
            adaptiview () {
                let! count, setCount = count.WithSetter()
                button {
                    onclick (fun _ -> setCount (count + 1))
                    $"count = {count}"
                }
            }
        }
    )


type DemoCounter() =
    inherit FunBlazorComponent()

    override _.Render() = count

[<FunBlazorCustomElement(TagName = "my-demo-counter2")>]
type DemoCounter2() =
    inherit FunBlazorComponent()

    override _.Render() = count

let entry = div {
    p {
        "Custom elements is supposed to be used when the main app is not in blazor server or WASM mode. And should be used with static html context."
    }
    p { "Below will render two custome elements which will powered by blazor:" }
    p { "CustomElement.create can only be used for a long running single instance app, not for distribution env." }
    //CustomElement.create (count, div { "pre-render-child" }) // prerender is only work when the main app is not in normal blazor mode like server or wasm.
    CustomElement.create count
    CustomElement.create (fun (store: IShareStore) ->
        let count = store.CreateCVal("count", 1)
        div {
            adaptiview () {
                let! count, setCount = count.WithSetter()
                button {
                    onclick (fun _ -> setCount (count + 1))
                    $"count = {count}"
                }
            }
        }
    )
    CustomElement.create (div { "Demo string" })
    p {
        "html.customElement behave similar like the default blazor custom elements, which need you to define class based component and register at the begining of your program."
    }
    html.customElement<DemoCounter> (preRender = false) // prerender is only work when the main app is not in normal blazor mode like server or wasm.
    html.customElement<DemoCounter2> (tagName = "my-demo-counter2", preRender = false) // registered by assembly
    html.customElement<DemoCounter2> (delayMs = 3000, preRenderContainerAttrs = domAttr {
        style { backgroundColor "green" }
        asAttrRenderFragment
    })
}
