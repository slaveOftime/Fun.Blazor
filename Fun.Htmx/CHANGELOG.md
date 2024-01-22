# Changelog

## [Unreleased]

## [4.0.0-beta003] - 2024-01-22

- Use struct to improve perf

## [4.0.0-beta002] - 2024-01-15

- Revert htmx changes because it does not improve CE performance, instead it may slow it down

## [4.0.0-beta001] - 2024-01-12

Beaking changes:

- Move all events from ce custom operations to **on** type to improve CE build performance
- Auto generate standard elements and attributes instead of using one big base element to include all the attributes to improve CE build performance
- Move all the htmx attributes to **hx** type to improve CE build performance

## [3.3.0-beta003] - 2023-12-27

- Fix NativeJs UpdateQueries browser compatibility

## [3.3.0-beta002] - 2023-12-19

- Add Js type with multiple helper methods to call native js directly
- Add hxAddQueriesToHtmxParams to add or overwirte htmx current request with current browser's query parameters

## [3.3.0-beta001] - 2023-11-29

- Update htmx events convention

## [3.2.9] - 2023-11-26

- Add hxPostCustomElement overload

## [3.2.8] - 2023-11-26

- Add more overloads for hxGetComponent, hxPostComponent, hxGetCustomElement, hxPostCustomElement

## [3.2.7] - 2023-11-25

- Add hxGetComponent, hxPostComponent, hxGetCustomElement, hxPostCustomElement

## [3.2.4] - 2023-11-23

- Add more overloads for hxRequestBlazorSSR and hxRequestCustomElement

## [3.2.3] - 2023-11-22

- Add hxRequestBlazorSSR
- Add hxRequestCustomElement

## [3.2.0] - 2023-11-16

- Unify version

## [3.1.1] - 2023-11-16

- Bump version

## [3.1.0] - 2023-11-15

- Release for dotnet 8

## [3.1.0-beta007] - 2023-11-15

- Bump version

## [3.1.0-beta002] - 2023-11-07

### Added

- hx-history (1.8.5)
- hx-on (1.9.0)
- hxOnHtmx and all htmx events under hxEvt module
- hx-disable-elt

## [3.1.0-beta001] - 2023-10-24

- Support dotnet 8

## [3.0.0] - 2023-04-04

Release for 3.0.0

## [3.0.0-beta004] - 2023-02-03

Improve hxPushUrl

## [3.0.0-beta003] - 2022-11-17

- Update docs
- Refactor hx-swap

## [3.0.0-beta002] - 2022-11-16

Downgrade to dotnet 6

## [3.0.0-beta001] - 2022-11-12

Update to dotnet 7