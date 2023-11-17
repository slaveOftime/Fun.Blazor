# Changelog

## [Unreleased]

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
