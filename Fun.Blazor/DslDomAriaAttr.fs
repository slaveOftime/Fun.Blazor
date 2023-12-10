[<AutoOpen>]
module Fun.Blazor.DslDomAriaAttr

[<RequireQualifiedAccess>]
module aria =
    let inline autocomplete x = "aria-autocomplete", string x
    let inline checked' x = "aria-checked", string x
    let inline disabled x = "aria-disabled", string x
    let inline errormessage x = "aria-errormessage", string x
    let inline expanded x = "aria-expanded", string x
    let inline haspopup x = "aria-haspopup", string x
    let inline hidden x = "aria-hidden", string x
    let inline invalid x = "aria-invalid", string x
    let inline label x = "aria-label", string x
    let inline level x = "aria-level", string x
    let inline modal x = "aria-modal", string x
    let inline multiline x = "aria-multiline", string x
    let inline multiselectable x = "aria-multiselectable", string x
    let inline orientation x = "aria-orientation", string x
    let inline placeholder x = "aria-placeholder", string x
    let inline pressed x = "aria-pressed", string x
    let inline readonly x = "aria-readonly", string x
    let inline required x = "aria-required", string x
    let inline selected x = "aria-selected", string x
    let inline sort x = "aria-sort", string x
    let inline valuemax x = "aria-valuemax", string x
    let inline valuemin x = "aria-valuemin", string x
    let inline valuenow x = "aria-valuenow", string x
    let inline valuetext x = "aria-valuetext", string x
    let inline busy x = "aria-busy", string x
    let inline live x = "aria-live", string x

    let inline relevant x = "aria-relevant", string x
    let inline atomic x = "aria-atomic", string x
    let inline dropeffect x = "aria-dropeffect", string x
    let inline grabbed x = "aria-grabbed", string x
    let inline activedescendant x = "aria-activedescendant", string x
    let inline colcount x = "aria-colcount", string x
    let inline colindex x = "aria-colindex", string x
    let inline colspan x = "aria-colspan", string x
    let inline controls x = "aria-controls", string x
    let inline describedby x = "aria-describedby", string x
    let inline description x = "aria-description", string x
    let inline details x = "aria-details", string x
    let inline flowto x = "aria-flowto", string x
    let inline labelledby x = "aria-labelledby", string x
    let inline owns x = "aria-owns", string x
    let inline posinset x = "aria-posinset", string x
    let inline rowcount x = "aria-rowcount", string x
    let inline rowindex x = "aria-rowindex", string x
    let inline rowspan x = "aria-rowspan", string x
    let inline setsize x = "aria-setsize", string x
    let inline current x = "aria-current", string x
    let inline keyshortcuts x = "aria-keyshortcuts", string x
    let inline roledescription x = "aria-roledescription", string x
