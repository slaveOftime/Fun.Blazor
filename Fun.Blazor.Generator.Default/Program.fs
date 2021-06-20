open System.IO
open System.Reflection
open Fun.Blazor.Generator


let opens = """open Bolero.Html
open Fun.Blazor"""

(Assembly.LoadFile(__SOURCE_DIRECTORY__ + "/bin/Debug/net5.0/Microsoft.AspNetCore.Components.dll").GetTypes())
|> Seq.append (Assembly.LoadFile(__SOURCE_DIRECTORY__ + "/bin/Debug/net5.0/Microsoft.AspNetCore.Components.Web.dll").GetTypes())
|> Generator.generateCode "Fun.Blazor.Web" opens
|> fun codes ->

    let path = __SOURCE_DIRECTORY__ + "\..\Fun.Blazor\Web.fs"
    let code = 
        $"""{codes.internalCode}

// ===========================================================================================

{codes.dslCode}"""
    
    File.WriteAllText(path, code)
