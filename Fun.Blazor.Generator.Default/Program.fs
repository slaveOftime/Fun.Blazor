open System.IO
open System.Reflection
open Fun.Blazor.Generator


let opens = """open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor"""


let componentTypes = Assembly.LoadFile(__SOURCE_DIRECTORY__ + "/bin/Debug/net5.0/Microsoft.AspNetCore.Components.dll").GetTypes()
let webTypes = Assembly.LoadFile(__SOURCE_DIRECTORY__ + "/bin/Debug/net5.0/Microsoft.AspNetCore.Components.Web.dll").GetTypes()


let componentsDsl = Generator.generateCode "Microsoft.AspNetCore.Components" opens componentTypes
let webDsl = Generator.generateCode "Microsoft.AspNetCore.Components.Web" opens webTypes

let dslPath = __SOURCE_DIRECTORY__ + "\..\Fun.Blazor.Feliz\Dsl.AspNetCore.fs"
let dslCode = 
    $"""{componentsDsl.internalCode}

// ===========================================================================================

{componentsDsl.dslCode}

// ===========================================================================================
// ===========================================================================================

{webDsl.internalCode}

// ===========================================================================================

{webDsl.dslCode}
    """
    
File.WriteAllText(dslPath, dslCode)


let componentsDslCE = CEGenerator.generateCode "Microsoft.AspNetCore.Components" opens componentTypes
let webDslCE = CEGenerator.generateCode "Microsoft.AspNetCore.Components.Web" opens webTypes

let dslCEPath = __SOURCE_DIRECTORY__ + "\..\Fun.Blazor\DslCE.AspNetCore.fs"
let dslCECode = 
    $"""namespace rec Microsoft.AspNetCore.Components.DslInternals
{componentsDslCE.internalCode}

// ===========================================================================================

{componentsDslCE.dslCode}

// ===========================================================================================
// ===========================================================================================
    
{webDslCE.internalCode}
// ===========================================================================================
    
{webDslCE.dslCode}
    """
    
File.WriteAllText(dslCEPath, dslCECode)
