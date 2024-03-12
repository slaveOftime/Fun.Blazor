# Changelog

## [Unreleased]

## [4.0.4] - 2024-03-12

- Upgrade dependencies

## [4.0.3] - 2024-03-11

- Upgrade dependencies

## [4.0.2] - 2024-02-13

- Pin FSharp.Core version to remove build warning

## [4.0.0] - 2024-02-08

- Bump version

## [4.0.0-beta007] - 2024-01-29

- Update packages

## [4.0.0-beta002] - 2024-01-22

- Clean old stuff

## [4.0.0-beta001] - 2024-01-12

Beaking changes:

- Move all events from ce custom operations to **on** type to improve CE build performance
- Auto generate standard elements and attributes instead of using one big base element to include all the attributes to improve CE build performance

## [3.3.0-beta006] - 2024-01-10

- Move ComponentResponseCacheAttribute to Fun.Blazor namespace

## [3.3.0-beta005] - 2024-01-10

- Add ComponentResponseCacheAttribute for MapRazorComponentsForSSR or MapCustomElementsForSSR to support cache

## [3.3.0-beta004] - 2023-12-30

- Add Parsable<'T> to support better ssr dev experience

## [3.3.0-beta003] - 2023-12-19

- Improve null parsing

## [3.3.0-beta002] - 2023-12-10

- enableAntiforgery

## [3.3.0-beta001] - 2023-11-29

- Rename MapFunBlazorCustomElements to MapCustomElementsForSSR
- Rename MapBlazorSSRComponents to MapRazorComponentsForSSR

## [3.2.8] - 2023-11-26

- Add overloads for MapFunBlazorCustomElements and MapBlazorSSRComponents
- Only take the last value when query or form got same keys in MapFunBlazorCustomElements and MapBlazorSSRComponents

## [3.2.7] - 2023-11-24

- Enable antiforgery for MapBlazorSSRComponents and MapFunBlazorCustomElements

## [3.2.6] - 2023-11-24

- Improve MapBlazorSSRComponents and MapFunBlazorCustomElements to support nullable

## [3.2.5] - 2023-11-24

- Improve MapBlazorSSRComponents
- Improve MapFunBlazorCustomElements

## [3.2.4] - 2023-11-23

- Automatically set parameters from form or query for MapBlazorSSRComponents and MapFunBlazorCustomElements

## [3.2.3] - 2023-11-22

- Add MapBlazorSSRComponents
- Add MapFunBlazorCustomElements

## [3.2.0] - 2023-11-16

- Unify version

## [3.1.1] - 2023-11-16

- Bump version

## [3.1.0] - 2023-11-15

- Release for dotnet 8

## [3.1.0-beta007] - 2023-11-15

- Bump version

## [3.1.0-beta002] - 2023-11-06

- Enable set preventStreamingRendering and statusCode for FunBlazorEndpointFilter
- Remove MapFunBlazor<'Component> for dotnet 8

## [3.1.0-beta001] - 2023-10-24

- Support dotnet 8
- Use new service introduced in dotnet 8 for rendering component

## [3.0.1] - 2023-06-01

Improve performance for WriteFunDom api

## [3.0.0] - 2023-04-04

Release for 3.0.0

## [3.0.0-beta002] - 2022-11-16

Downgrade to dotnet 6

## [3.0.0-beta001] - 2022-11-12

Update to dotnet 7