[<AutoOpen>]
module Fun.Blazor.DslDomInputAttr

open Fun.Blazor
open Operators


[<RequireQualifiedAccess>]
type InputTypes =
    | button
    | checkbox
    | color
    | date
    | ``datetime-local``
    | email
    | file
    | hidden
    | image
    | month
    | number
    | password
    | radio
    | range
    | reset
    | search
    | submit
    | tel
    | text
    | time
    | url
    | week

[<RequireQualifiedAccess>]
module AutoCompleteValues =
    let off = "off"
    let on = "on"

    [<RequireQualifiedAccess>]
    module name =
        let honorific_prefix = "honorific-prefix"
        let given_name = "given-name"
        let additional_name = "additional-name"
        let family_name = "family-name"
        let honorific_suffix = "honorific-suffix"
        let nickname = "nickname"

    let email = "email"
    let username = "username"
    let new_password = "new-password"
    let current_password = "current-password"
    let one_time_code = "one-time-code"
    let organization_title = "organization-title"
    let organization = "organization"
    let street_address = "street-address"
    let address_line1 = "address-line1"
    let address_line2 = "address-line2"
    let address_line3 = "address-line3"
    let address_level4 = "address-level4"
    let address_level3 = "address-level3"
    let address_level2 = "address-level2"
    let address_level1 = "address-level1"
    let country = "country"
    let country_name = "country-name"
    let postal_code = "postal-code"
    let cc_name = "cc-name"
    let cc_given_name = "cc-given-name"
    let cc_additional_name = "cc-additional-name"
    let cc_family_name = "cc-family-name"
    let cc_number = "cc-number"
    let cc_exp = "cc-exp"
    let cc_exp_month = "cc-exp-month"
    let cc_exp_year = "cc-exp-year"
    let cc_csc = "cc-csc"
    let cc_type = "cc-type"
    let transaction_currency = "transaction-currency"
    let transaction_amount = "transaction-amount"
    let language = "language"
    let bday = "bday"
    let bday_day = "bday-day"
    let bday_month = "bday-month"
    let bday_year = "bday-year"
    let sex = "sex"

    [<RequireQualifiedAccess>]
    module tel =
        let tel_country_code = "tel-country-code"
        let tel_national = "tel-national"
        let tel_area_code = "tel-area-code"
        let tel_local = "tel-local"
        let tel_extension = "tel-extension"

    let impp = "impp"
    let url = "url"
    let photo = "photo"

type DomAttrBuilder with

    [<CustomOperation("type'")>]
    member inline _.type'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("type" => v)

    [<CustomOperation("type'")>]
    member inline _.type'([<InlineIfLambda>] render: AttrRenderFragment, v: InputTypes) = render ==> ("type" => v.ToString())
