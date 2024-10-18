namespace Fun.Blazor

open System
open System.Text
open System.Text.Json
open System.Text.Json.Serialization


[<AutoOpen>]
module private Utils =
    let jsonOptions =
        lazy (JsonFSharpOptions.Default().WithUnionAdjacentTag().WithAllowNullFields(true).ToJsonSerializerOptions())


/// This can be used for component parameters which needs complex data type when using with htmx etc.
/// It will use serialize value to json and encode to base64 for put into query or html. And provide a Parse method to parse it back.
[<Struct>]
type Parsable<'T> =
    | Parsable of value: 'T

    member this.Value =
        let (Parsable value) = this
        value

    override this.ToString() =
        let (Parsable value) = this
        let json = JsonSerializer.Serialize(value, jsonOptions.Value)
        if json.Contains "\"" then
            Convert.ToBase64String(Encoding.UTF8.GetBytes json)
        else
            json

    static member Parse(value: string) =
        try
            let json = Convert.FromBase64String(value)
            Parsable(JsonSerializer.Deserialize<'T>(json, jsonOptions.Value))
        with _ ->
            Parsable(JsonSerializer.Deserialize<'T>(value, jsonOptions.Value))
