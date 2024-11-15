# Styling

[Fun.Css]: https://github.com/slaveOftime/Fun.Css
[rule's Specificity]: https://developer.mozilla.org/en-US/docs/Web/CSS/Specificity

Adding styles is common in every web application, Fun.Blazor provides out of the box support for inline css and also there's the [Fun.Css] package that provides support for style tags (using classes and rulesets).

## Inline Styles

Adding inline styles to elements is very straight forward

```fsharp
div {
    style {
        color "red"
    }
}
```

Would produce

```html
<div style="color: red;"></div>
```

If you like to pursue inline styles you can also share those styles, for that we have to add a reference to [Fun.Css] in our project and then we can start sharing styles:

```fsharp
module SharedStyles =
    let ClickableGreen = css {
        cursorPointer
        color "green"
    }

let styledDiv = div {
    style {
        SharedStyles.ClickableGreen
        fontSize 16
    }
}
```

> Note: The normal styling rules still apply, if we supply a `color "red"` attribute in our button, the browser will pick up that instead of our shared style. Keep in mind however that it also means you will have duplicated css properties in inline styles.

## Style Sheets

To create style tags you can use the `ruleset` builder, this will produce a css rule that can be applied to any element within the scope of the style tag (e.g. when it loads)

```fsharp
module SharedClasses =
    let Page = ruleset ".page" {
        margin 0
        padding "1em"
        displayFlex
        flexDirectionColumn
        height "100vh"
    }

  let Title = ruleset ".title" { fontSize "calc(10px + 3vmin)" }

  let Text = ruleset ".text" { fontSize "calc(10px + 1vmin)" }
```

With those rules in mind we can then add a "home page"

```fsharp
let HomePage = article {
    class' "page home"
    h1 { class' "title"; "This is the title" }

    section {
        p { class' "text"; "This is some text" }
        p { "This is another text" }
    }

    styleElt {
        ruleset ".home" {
            fontSize "medium"
            boxShadow "5px 5px 0.5em rgba(0, 0, 0, 0.5)"
        }
        SharedClasses.Page
        SharedClasses.Title
        SharedClasses.Text
    }
  }
```

That would produce something like

```html
<article class="page home">
  <h1 class="title">This is the title</h1>
  <section>
    <p class="text">This is some text</p>
    <p>This is another text</p>
  </section>
  <style>
    .home {
      font-size: medium;
      box-shadow: 5px 5px 0.5em rgba(0, 0, 0, 0.5);
    }
    .page {
      margin: 0;
      padding: 1em;
      display: flex;
      flex-direction: column;
      height: 100vh;
    }
    .title {
      font-size: calc(10px + 3vmin);
    }
    .text {
      font-size: calc(10px + 1vmin);
    }
  </style>
</article>
```

> Note: Keep in mind that these styles are loaded in style tags along their declaring elements, so if you have styles already loaded you could have rules clashing and overriding depending on the [rule's specificity]

## Sharing Inline Styles Globally

There are some cases where you'd like yo have certain styles available for any element you can also create an extension operation method to create something to reuse.

We'll add a couple of "stacks" to our styles using flexbox, for this we have to extend the style builder in Fun.Blazor.

```fsharp
[<AutoOpen>]
module StyleExtensions =
    open Fun.Blazor.Internal
    open Fun.Css.Internal

    type StyleBuilder with

        [<CustomOperation "VStack">]
        member inline _.VStack([<InlineIfLambda>] comb: CombineKeyValue) =
            comb
            &&& css {
                displayFlex
                flexDirectionColumn
            }

        [<CustomOperation "HStack">]
        member inline _.HStack([<InlineIfLambda>] comb: CombineKeyValue) = comb &&& css { displayFlex }

        [<CustomOperation "EvenHStack">]
        member inline this.EvenHStack([<InlineIfLambda>] comb: CombineKeyValue) =
            this.HStack comb &&& css { custom "justify-content" "space-evenly" }

```

> Note: `&&&` is a custom operator provided by Fun.Css so we don't have to manually combine those styles ourselves.

Once we have defined our extension members on the style builder, we can use those in the following way:

```fsharp
let MyItems = ul {
    // display: flex; flex-direction: column;
    style { VStack }

    // content
  }

let MyItems2 = ul {
    // display: flex;
    style { HStack }

    // content
}

let MyItems3 = ul {
    // display: flex; justify-content: space-evenly;
    style { EvenHStack }
    // content
}
```

### Other Examples:

{{InlineStyleDemo}}

Using CSS rules:

{{CssRuleDemo}}

Using keyframes:

{{KeyFramesDemo}}
