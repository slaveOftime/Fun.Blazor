// hot-reload
module Fun.Blazor.Docs.Wasm.Demos.CustomElementDemo

open Fun.Blazor

type DemoCounter() =
    inherit FunComponent()

    let mutable count = 0

    override _.Render() = div {
        p { $"count = {count}" }
        button {
            on.click (fun _ -> count <- count + 1)
            "Click me"
        }
    }

let entry = div {
    p { "Custom elements is supposed to be used when the main app is not in blazor server or WASM mode. And should be used with static html context." }
    p { "Below will render two custom elements which will powered by blazor:" }
    p { "html.customElement behave similar like the default blazor custom elements, which need you to define class based component and register at the begining of your program." }
    html.customElement<DemoCounter> (preRender = false) // prerender is only work when the main app is not in normal blazor mode like server or wasm.
    html.customElement<DemoCounter> (renderAfter = RenderAfter.Delay 3000, preRenderContainerAttrs = domAttr {
        style { backgroundColor "green" }
    })
    div { style { height "100vh" } }
    html.customElement<DemoCounter> (renderAfter = RenderAfter.InViewportAndDelay 3000, preRenderContainerAttrs = domAttr {
        style { backgroundColor "green" }
    })
}
