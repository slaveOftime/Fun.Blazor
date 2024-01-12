namespace Fun.Blazor.Docs.Server

open System
open Microsoft.AspNetCore.Components
open Fun.Blazor
open Fun.Htmx

[<FunBlazorCustomElement>]
type ServerDemoCounter() as this =
    inherit FunComponent()

    let mutable count = 0

    [<Parameter>]
    member val count_from_query = 0 with get, set

    [<Parameter>]
    member val count_from_form = "" with get, set

    [<Parameter>]
    member val is_loading = false with get, set

    [<Parameter>]
    member val time = DateTime.Now with get, set

    override _.Render() = div {
        p {
            $"count = {count}; count_from_query {this.count_from_query}; count_from_form {this.count_from_form}; is_loading {this.is_loading}; time {this.time}"
        }
        button {
            on.click (fun _ -> count <- count + 1)
            "Click me"
        }
    }

type CustomElementsDemo =
    static member Create() =
        let section (nodes: NodeRenderFragment seq) = section {
            style {
                margin 10
                padding 10
                border "1px black solid"
            }
            yield! nodes
        }
        div {
            section [
                p { "Custom element without prerender" }
                html.customElement<ServerDemoCounter> ()
            ]
            section [
                p { "Custom element with prerender section as container" }
                html.customElement<ServerDemoCounter> (preRender = true, preRenderContainerTagName = "section")
            ]
            section [
                p { "Custom element with lazy load in 3s" }
                html.customElement<ServerDemoCounter> (
                    preRender = true,
                    delayMs = 3000,
                    preRenderContainerAttrs = domAttr { style { backgroundColor "green" } }
                )
                p { "Custom element with lazy load in 3s and a prerender node" }
                html.customElement<ServerDemoCounter> (preRender = true, delayMs = 3000, preRenderNode = progress.create ())
            ]
            section [
                p { "Custom element with lazy load by click" }
                html.customElement<ServerDemoCounter> (
                    preRender = true,
                    renderAfter = RenderAfter.Clicked,
                    preRenderNode = button { "click me to show" }
                )
                p { "Custom element with lazy load by click or delay 5s" }
                html.customElement<ServerDemoCounter> (
                    preRender = true,
                    renderAfter = RenderAfter.ClickedOrDelay 5000,
                    preRenderNode = button { "click me to show" }
                )
            ]
            section [
                p { "Custom element with lazy load defer in viewport" }
                html.customElement<ServerDemoCounter> (preRender = true, renderAfter = RenderAfter.InViewport)
                p { "Custom element with lazy load defer in viewport and then delay 3s" }
                html.customElement<ServerDemoCounter> (
                    preRender = true,
                    renderAfter = RenderAfter.InViewportAndDelay 3000,
                    preRenderNode = div { "viewport" }
                )
                p { "Custom element with lazy load defer in viewport or delay 10s" }
                html.customElement<ServerDemoCounter> (
                    preRender = true,
                    renderAfter = RenderAfter.InViewportOrDelay 10000,
                    preRenderNode = div { "viewport" }
                )
            ]
            section [
                p { "Integrate with htmx" }
                button {
                    hx.Trigger hxEvt.mouse.click
                    hx.RequestCustomElement(
                        QueryBuilder<ServerDemoCounter>().Add((fun x -> x.count_from_query), 1).Add((fun x -> x.count_from_form), "2")
                    )
                    hx.Swap_afterend()
                    "Htmx click to add counter"
                }
            ]
            section [
                p {
                    "Integrate SSR with htmx"
                    span {
                        style { color "red" }
                        "(the counter is not interactive)"
                    }
                }
                button {
                    hx.Trigger hxEvt.mouse.click
                    name (nameof Unchecked.defaultof<ServerDemoCounter>.count_from_form)
                    value 3453453
                    hx.RequestBlazorSSR("post", (QueryBuilder<ServerDemoCounter>().Add((fun x -> x.count_from_query), 3)))
                    hx.Swap_afterend()
                    "Htmx click to add counter"
                }
            ]
        }
