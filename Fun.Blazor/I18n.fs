[<AutoOpen>]
module Fun.Blazor.I18n

open System
open System.Collections.Generic
open System.Text.Json


let private (<.>) prefix name = if String.IsNullOrEmpty(prefix) then name else prefix + "." + name


let rec private fillDictionary (dict: Dictionary<string, string>) (token: JsonElement) (prefix: string) =
    match token.ValueKind with
    | JsonValueKind.Object ->
        for prop in token.EnumerateObject() do
            fillDictionary dict prop.Value (prefix <.> prop.Name)
    | JsonValueKind.Array ->
        let mutable index = 0
        for value in token.EnumerateArray() do
            fillDictionary dict value (prefix <.> string index)
            index <- index + 1
    | _ -> dict.[prefix] <- token.GetString()

let private fromJsonToMap (dict: Dictionary<string, string>) (json: string) =
    let doc = JsonDocument.Parse(json)
    fillDictionary dict doc.RootElement ""
    dict


/// <summary>
/// This is a placeholder function.
/// It will not hanve any effect. It is used when you do not actually want to translate a key, you just want to make sure the key is valid.
/// </summary>
let inline tran x = x


/// <summary>
/// Translate json tranlstion string into a flated dictionary.
/// Used together with VSCode extension "i18n Ally" to provide intellicense.
/// </summary>
/// <example>
/// <code lang="json">
/// settings for "i18n Ally"
/// usageMatchRegex:
/// # The following example shows how to detect `t("your.i18n.keys")`
/// # the `{key}` will be placed by a proper keypath matching regex,
/// # you can ignore it and use your own matching rules as well
/// - "[^\\w\\d]tran[\\s]*[\\(]*['\"`]({key})['\"`]"
/// - "[^\\w\\d]tryTran[\\s]*\\(['\"`]({key})['\"`]"
/// </code>
/// </example>
type I18n(?newJson: string, ?defaultTrans: Dictionary<string, string>) =
    let trans =
        lazy (fromJsonToMap (defaultArg defaultTrans (Dictionary())) (defaultArg newJson "{}"))

    /// Merge new translations into existing dictionary.
    /// With base translations then add other translations to override its key value.
    member _.MergeToNew(newJson: string) = I18n(newJson, trans.Value)

    /// Translate a key, if it does not exist then return the key it self.
    member _.tran(key: string, [<ParamArray>] args) =
        match trans.Value.TryGetValue(key) with
        | true, x -> String.Format(x, args)
        | _ -> key

    member _.tryTran(key: string, [<ParamArray>] args) =
        match trans.Value.TryGetValue(key) with
        | true, x -> Some(String.Format(x, args))
        | _ -> None
