# Changelog

## [4.1.0-beta002] - 2024-11-14

- When a type does not has ChildContent attribute and has no other types inherit from it, we should use ComponentWithDomAttrBuilder

## [4.1.0-beta001] - 2024-10-18

- Ignore _Imports from code gen
- Do not generate Classes and Styles for string of seq
- Use overload instead of optional arg to reduce alloc
- Add more inline to code gen
- Clean code

## [4.0.7] - 2024-08-02

- Improve ce code gen for ce instances

## [4.0.6] - 2024-08-02

- Support expose static CE instance for lesser allocation

## [4.0.5] - 2024-07-01

- Improve CE code gen for struct and interface constraints

## [4.0.4] - 2024-05-17

- Fix generic case: CheckboxGroup<TValue> : AntInputComponentBase<TValue[]>
- When a ChildContent is a RenderFragment<'T> we should not inherit ComponentWithDomAndChildAttrBuilder 

## [4.0.3] - 2024-02-20

- Support optional for bool property
- Improve callback generation

## [4.0.2] - 2024-02-13

- Pin FSharp.Core version to remove build warning

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

## [3.0.0] - 2023-04-04

Release for 3.0.0

## [3.0.0-beta003] - 2023-01-16

Use fullname for DynamicDependency in builder

## [3.0.0-beta002] - 2022-11-16

Downgrade to dotnet 6

## [3.0.0-beta001] - 2022-11-12

Update to dotnet 7