# Changelog


## [Unreleased]

- Retarget Fun.Blazor.Cli to net10.0
- Update FSharp.Compiler.Service to 43.12.400 and adapt to its option-based `ApparentEnclosingEntity`/`QualifiedName` API
- Update Spectre.Console to 0.57.2, CliWrap to 3.10.5, Microsoft.Build.Utilities.Core to 18.9.6 and pin MessagePack to 2.5.302 (security fixes)
- Re-enable and improve the `watch` hot-reload command:
    - Resolve project references via `dotnet msbuild -getItem:ReferencePath` so hot reload works on modern (net6+) SDKs where `getFscArgs` no longer emits `-r:` arguments
    - Only re-check the files that actually changed (debounced), instead of re-checking every hot-reload file on each save — much faster on large CE-heavy projects
    - Convert only changed files, then combine compiler symbol uses (including argument-less module values) with portable-AST member references to send their actual cached dependency closure through the render-entry files (registered by the client via the new `RegisterEntry` hub call) in F# compilation order. This refreshes intermediate module values (for example `Counter.entry` → `DemoMaps.demos` → `DocView.docView` → `Routes.routes` → `App.app`) without evaluating unrelated component classes or re-converting the whole hot-reload set
    - Index the enabled `// hot-reload` files once at startup (entity → file map + converted-AST cache) so entry files can be located cheaply per save
    - Increment the FCS source version on every check so repeated edits cannot reuse a stale parse/check result

## [4.1.2] - 2026-05-21

- Make the --generator-version default value to 4.1.1

## [4.1.1] - 2025-11-18

- Make the --generator-version default value to 4.1.0

## [4.1.0] - 2024-11-14

- Update generator version

## [4.1.0-beta002] - 2024-11-14

- Fix empty body issue for component ce builder

## [4.1.0-beta001] - 2024-11-14

- Obsolete watch command (hot-reload)
- Update generator version
- Update packages

## [4.0.5] - 2024-08-02

- Improve ce code gen for ce instances

## [4.0.4] - 2024-07-01

- Support expose static CE instance for lesser allocation

## [4.0.3] - 2024-07-01

- Improve CE code gen for struct and interface constraints

## [4.0.2] - 2024-02-20

- Update generator versions

## [4.0.1] - 2024-02-20

- Update code generation packages

## [4.0.0] - 2024-02-08

- Bump version

## [4.0.0-beta007] - 2024-01-29

- Update packages

## [4.0.0-beta001] - 2024-01-12

Beaking changes:

- Move all events from ce custom operations to **on** type to improve CE build performance
- Auto generate standard elements and attributes instead of using one big base element to include all the attributes to improve CE build performance

## [3.3.0-beta001] - 2023-11-29

- INIT

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

## [3.0.1] - 2023-04-17

Add target for 7.0

## [3.0.0] - 2023-04-04

Release for 3.0.0

## [3.0.0-beta005] - 2023-03-27

- Add comments
- Fix namespace conflict

## [3.0.0-beta004] - 2023-01-16

Update dependencies

## [3.0.0-beta003] - 2023-01-13

Change code generation folder to target project bin folder

## [3.0.0-beta002] - 2022-11-16

Downgrade to dotnet 6

## [3.0.0-beta001] - 2022-11-12

* Support directory for watch
* Fix code-gen multiple namespace issue
