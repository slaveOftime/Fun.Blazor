namespace Fun.Blazor

open System
open HtmlTemplate.Internals


[<AutoOpen>]
module Utils =
    let callback fn : MkAttrWithName = fun name -> [ Bolero.Html.attr.callback name fn ]

    let callbackTask fn : MkAttrWithName =
        fun name -> [ Bolero.Html.attr.task.callback name fn ]


type Template =
    /// This will generate bolero node tree and put them in caches
    /// For none standard event you can prefix with 'on' to indicate it is a callback. onsl-change="{callback (fun (e: SlChangeEventArgs) -> ...)}".
    /// For none standard event, you also need to wireup the event argument type by: https://docs.microsoft.com/en-us/aspnet/core/blazor/components/event-handling?view=aspnetcore-6.0#custom-event-arguments
    /// But it is only supported in aspnet 6. So currently you cannot get the event args very easily.
    static member html(html: FormattableString) =
        caches.GetOrAdd(html.Format.GetHashCode(), (fun _ -> parseNodes html.Format))
        |> buildNodeTree (html.GetArguments())
        |> Bolero.ForEach
