# Changelog

## [Unreleased]

## [4.1.0-beta001] - 2024-10-18

- Drop net7.0 support for Fun.Blazor.CustomElements

## [4.0.2] - 2024-02-13

- Pin FSharp.Core version to remove build warning

## [4.0.1] - 2024-02-13

- Fix html.customElement parameter type

## [4.0.0] - 2024-02-08

- Bump version

## [4.0.0-beta007] - 2024-01-29

- Update packages

## [4.0.0-beta001] - 2024-01-22

- Use struct to improve perf

## [4.0.0-beta001] - 2024-01-12

Beaking changes:

- Move all events from ce custom operations to **on** type to improve CE build performance
- Auto generate standard elements and attributes instead of using one big base element to include all the attributes to improve CE build performance

## [3.3.0-beta001] - 2023-11-29

- INIT

## [3.2.5] - 2023-11-24

- Improve html.customElement

## [3.2.4] - 2023-11-23

- Add more overloads for html.customElement

## [3.2.3] - 2023-11-22

- Add more overloads for html.customElement

## [3.2.2] - 2023-11-21

- Obsolete CustomElement.create 
- Improve html.customElement to support render after delay, click in prerender container, or in viewport

## [3.2.0] - 2023-11-16

- Unify version

## [3.1.1] - 2023-11-16

- Bump version

## [3.1.0] - 2023-11-15

- Release for dotnet 8

## [3.1.0-beta007] - 2023-11-15

- Bump version

## [3.1.0-beta001] - 2023-10-24

- Support dotnet 8

## [3.0.1] - 2023-08-30

Fix js for pre-rendering node handling

## [3.0.0] - 2023-04-04

Release for 3.0.0

## [3.0.0-beta007] - 2023-02-09

- Add preRenderContainerAttrs and delayMs to html.customElement

## [3.0.0-beta006] - 2023-02-01

Fix lazyBlazorJs init for multiple times

## [3.0.0-beta005] - 2023-02-01

Add FunBlazorCustomElementAttribute and enable RegisterCustomElementForFunBlazor by assembly

## [3.0.0-beta004] - 2023-01-13

Add CustomElement.lazyBlazorJs helper

## [3.0.0-beta003] - 2023-01-13

Improve custom elements

## [3.0.0-beta002] - 2022-11-16

Update to dotnet 7

## [0.0.2] - 2022-11-06

Refactor APIs

## [0.0.1] - 2022-11-05

First release