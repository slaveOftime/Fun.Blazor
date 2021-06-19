open System.IO
open System.Reflection
open Fun.Blazor.Generator


(Assembly.LoadFile(__SOURCE_DIRECTORY__ + "/bin/Debug/net5.0/Microsoft.AspNetCore.Components.dll").GetTypes())
|> Seq.append (Assembly.LoadFile(__SOURCE_DIRECTORY__ + "/bin/Debug/net5.0/Microsoft.AspNetCore.Components.Web.dll").GetTypes())
|> Generator.generateCode 
|> fun codes ->

    let path = __SOURCE_DIRECTORY__ + "\..\Fun.Blazor\Web.fs"
    let code = 
        $"""namespace rec Fun.Blazor.Web.Internal
open Bolero
open Bolero.Html
open Fun.Blazor

{codes.internalCode}

namespace rec Fun.Blazor.Web
{codes.dslCode}
"""
    
    File.WriteAllText(path, code)

