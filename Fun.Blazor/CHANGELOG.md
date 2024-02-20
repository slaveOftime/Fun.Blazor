# Changelog

## [Unreleased]

- Add all events as extensions for DomAttrBuilder and obsolete on.xxx, because it builds faster

  Before we think the number of custom operations on a ce will affect the speed, but it turns out that the yield or combination etc. is the cause.

## [4.0.6] - 2024-02-20

- We should not use location as component key to for choosed page, because it make nested html.route not as power as it can be, because the nested routed page cannot keep it's state because of the key change.

  Use should use key by themself to control if related route page should re-create or not.

## [4.0.5] - 2024-02-20

- Should alwasys do refresh render for html.route views when location changed

## [4.0.4] - 2024-02-17

- Support yield RenderFragment for ComponentWithDomAndChildAttrBuilder

## [4.0.3] - 2024-02-16

- Simplify html.callback

## [4.0.2] - 2024-02-13

- Pin FSharp.Core version to remove build warning

## [4.0.1] - 2024-02-13

- Fix valueless issue for component

## [4.0.0] - 2024-02-08

- Improve performance
- html.renderAsString
- Support yield seq
- Enable combine key value pair for component builder

Beaking changes:

- Move all events from ce custom operations to **on** type to improve CE build performance
- Auto generate standard elements and attributes instead of using one big base element to include all the attributes to improve CE build performance

## [4.0.0-beta014] - 2024-02-06

- Fix AdaptiviewBuilder for loop

## [4.0.0-beta013] - 2024-02-05

- Improve performance

## [4.0.0-beta012] - 2024-02-03

- html.renderAsString

## [4.0.0-beta011] - 2024-02-03

- Support yield seq

## [4.0.0-beta010] - 2024-02-01

- Update Fun.Css version

## [4.0.0-beta009] - 2024-01-29

- Remove warning for combine, let user decide instead of annoying them

## [4.0.0-beta008] - 2024-01-29

- Fix EltBuilder_form
- Remove combine warning for EltBuilder_html, EltBuilder_body, EltBuilder_script for better view

## [4.0.0-beta007] - 2024-01-29

- Remove html.comp to make the reduce confusion
- Refactor and clean code

## [4.0.0-beta006] - 2024-01-28

- Enable combine key value pair for component builder

## [4.0.0-beta006] - 2024-01-22

- Use struct to improve perf
- Add warning to allow user to avoid CE abuse for better build time performance utill fsharp core team fix/improve this

## [4.0.0-beta005] - 2024-01-14

- Auto open GlobalAttrs

## [4.0.0-beta004] - 2024-01-12

- Move global attrs to DomAttrBuilder

## [4.0.0-beta003] - 2024-01-12

- Control global attributes manually, so some can be set as manual open to improve ce performance 

## [4.0.0-beta002] - 2024-01-12

- Improve autoplay attribute

## [4.0.0-beta001] - 2024-01-12

Beaking changes:

- Move all events from ce custom operations to **on** type to improve CE build performance
- Auto generate standard elements and attributes instead of using one big base element to include all the attributes to improve CE build performance

## [3.3.0-beta008] - 2023-12-30

- Improve some bool dom attributes

## [3.3.0-beta007] - 2023-12-19

- Improve script tag
- Add more helpers for html.renderFragment
- Add IScopedCssRules

## [3.3.0-beta006] - 2023-12-11

- Improve QueryBuilder

## [3.3.0-beta005] - 2023-12-11

- Improve QueryBuilder

## [3.3.0-beta004] - 2023-12-11

- Improve QueryBuilder
- Add unsafe events (can be used for simple SSR)

## [3.3.0-beta003] - 2023-12-10

- Improve script CE

## [3.3.0-beta002] - 2023-12-10

- Yield string as raw content for script
- Support "**data key value**" for domAttr
- Support aria-xxx

## [3.3.0-beta001] - 2023-11-29

- Remove obsolete html.blazor overloads

## [3.2.9] - 2023-11-26

- Improve html.createHiddenInputs

## [3.2.8] - 2023-11-26

- Refactor style dsl
- Add html.hiddenInputs helper

## [3.2.7] - 2023-11-25

- Fix value for DomAttrBuilder

## [3.2.6] - 2023-11-24

- Improve ComponentAttrBuilder
- Improve QueryBuilder

## [3.2.5] - 2023-11-24

- Improve ComponentAttrBuilder
- Improve QueryBuilder

## [3.2.4] - 2023-11-23

- Add more overloads for html.blazor
- Add ComponentAttrBuilder
- Add QueryBuilder

## [3.2.3] - 2023-11-22

- Add more overloads for html.blazor

## [3.2.2] - 2023-11-20

- Improve sequence number usage

## [3.2.1] - 2023-11-17

- Fix hidden attribute

## [3.2.0] - 2023-11-16

- Unify version

## [3.1.3] - 2023-11-16

- Fix CompnentBuilder

## [3.1.2] - 2023-11-16

- Add FunInteractiveAutoAttribute and FunInteractiveServerAttribute and FunInteractiveWebAssemblyAttribute
- Add formName

## [3.1.1] - 2023-11-16

- Add FunRenderModeAttribute
- Fix renderMode issue

## [3.1.0] - 2023-11-15

- Release for dotnet 8

## [3.1.0-beta007] - 2023-11-15

- Fix rendermode
- Add data-enhance-nav
- Add data-enhance for form elt
- Add data-permanent

## [3.1.0-beta006] - 2023-11-13

- Support for loop for element and component

## [3.1.0-beta005] - 2023-11-08

- Add SectionOutlet' and SectionContent'

## [3.1.0-beta004] - 2023-11-07

- Add html.streaming

## [3.1.0-beta003] - 2023-11-03

- Enable yield RenderFragment directly

## [3.1.0-beta002] - 2023-11-03

- Add blazor defualt routing components
- Add **html.renderFragment** to render blazor **RenderFragment** directly
- Add **Fun.Component**

## [3.1.0-beta001] - 2023-10-24

- Support dotnet 8
- Support multiple render mode introduced in dotnet 8


## [3.0.3] - 2023-06-21

Add html.region:
If the input node is dynamic in structure, for example the number of nodes/attributes will change based on some conditions,
Then use this we can reset the sequence number for the input node, so it will not make the sequence number dynamic/changed at runtime for its caller.

For razor file in csharp, it will generate the sequence number as much as possible at compile time, so the most of the sequence number will not change at run time. 
But for Fun.Blazor, everything is runtime, so to keep the diff more efficient we should use the region to help to isolate the changed places.

## [3.0.2] - 2023-04-27

- Improve error handling for AdaptiveForm

## [3.0.1] - 2023-04-20

- Add GetSubForm API
- Add parameterless CustomOperation controls for dom attr CE

## [3.0.0] - 2023-04-04

Release for 3.0.0

## [3.0.0-beta008] - 2023-02-23

Enable async rendering for html.inject

## [3.0.0-beta007] - 2023-01-18

- Improve download attribute
- Add html.emptyAttr
- Add viewport, chartsetUTF8

## [3.0.0-beta006] - 2023-01-17

- Add UseLoader for AdaptiveForm

## [3.0.0-beta005] - 2023-01-17

- Add default for draggable and hidden attributes
- Add error related method for AdaptiveForm

## [3.0.0-beta004] - 2023-01-16

- Add InputTypes for type' attribute
- Fix hidden attribute
- Improve autocomplete attribute
- Add default override with true for bool value attributes

## [3.0.0-beta003] - 2023-01-13

- Fix attribute name
- Add IFunBlazorBuilder so we can share attributes between element and component

## [3.0.0-beta002] - 2022-11-16

Downgrade to dotnet 6

## [3.0.0-beta001] - 2022-11-12

- Update to dotnet 7
- Add CustomElement
