// F# LiveChecking processing

namespace FSharp.Compiler.PortaCode

open System
open System.IO
open System.Text
open System.Reflection
open System.Collections.Generic
open FSharp.Compiler.Symbols
open FSharp.Compiler.PortaCode.CodeModel
open FSharp.Compiler.PortaCode.Interpreter
open FSharp.Compiler.PortaCode.FromCompilerService


type LiveCheckEvaluation(options: string [], dyntypes, writeinfo, keepRanges, livecheck, tolerateIncompleteExpressions) =

    let mutable assemblyNameId = 0
    let emitInfoFile (sourceFile: string) lines =
        let infoDir = Path.Combine(Path.GetDirectoryName(sourceFile), ".fsharp")
        let infoFile = Path.Combine(infoDir, Path.GetFileName(sourceFile) + ".info")
        let lockFile = Path.Combine(infoDir, Path.GetFileName(sourceFile) + ".info.lock")
        printfn "writing info file %s..." infoFile
        if not (Directory.Exists infoDir) then
            Directory.CreateDirectory infoDir |> ignore
        try
            File.WriteAllLines(infoFile, lines, encoding = Encoding.Unicode)
        finally
            try
                if Directory.Exists infoDir && File.Exists lockFile then File.Delete lockFile
            with
                | _ -> ()

    let LISTLIM = 20

    let (|ConsNil|_|) (v: obj) =
        let ty = v.GetType()
        if Reflection.FSharpType.IsUnion(ty) then
            let uc, vs = Reflection.FSharpValue.GetUnionFields(v, ty)
            if uc.DeclaringType.IsGenericType && uc.DeclaringType.GetGenericTypeDefinition() = typedefof<list<int>> then
                match vs with
                | [| a; b |] -> Some(Some(a, b))
                | [||] -> Some(None)
                | _ -> None
            else
                None
        else
            None

    let rec (|List|_|) n (v: obj) =
        if n > LISTLIM then
            Some []
        else
            match v with
            | ConsNil (Some (a, List ((+) 1 n) b)) -> Some(a :: b)
            | ConsNil None -> Some []
            | _ -> None

    /// Format values resulting from live checking using the interpreter
    let rec formatValue (value: obj) =
        match value with
        | null -> "null/None"
        | :? string as s -> sprintf "%A" s
        | value ->
            let ty = value.GetType()
            match value with
            | _ when ty.Name = "Tensor" || ty.Name = "Shape" ->
                // TODO: this is a hack for DiffSharp, consider how to generalize it
                value.ToString()
            | _ when Reflection.FSharpType.IsTuple(ty) ->
                let vs = Reflection.FSharpValue.GetTupleFields(value)
                "(" + String.concat "," (Array.map formatValue vs) + ")"
            | _ when Reflection.FSharpType.IsFunction(ty) -> "<func>"
            | _ when ty.IsArray ->
                let value = (value :?> Array)
                if ty.GetArrayRank() = 1 then
                    "[| "
                    + String.concat
                        "; "
                        [
                            for i in 0 .. min LISTLIM (value.GetLength(0) - 1) -> formatValue (value.GetValue(i))
                        ]
                    + (if value.GetLength(0) > LISTLIM then "; ..." else "")
                    + " |]"
                elif ty.GetArrayRank() = 2 then
                    "[| "
                    + String.concat
                        ";   \n"
                        [
                            for i in 0 .. min (LISTLIM / 2) (value.GetLength(0) - 1) ->
                                String.concat
                                    ";"
                                    [
                                        for j in 0 .. min (LISTLIM / 2) (value.GetLength(1) - 1) -> formatValue (value.GetValue(i, j))
                                    ]
                                + (if value.GetLength(1) > (LISTLIM / 2) then "; ..." else "")
                        ]
                    + (if value.GetLength(0) > (LISTLIM / 2) then "\n   ...\n" else "\n")
                    + " |]"
                else
                    sprintf "array rank %d" value.Rank
            | _ when Reflection.FSharpType.IsRecord(ty) ->
                let fs = Reflection.FSharpType.GetRecordFields(ty)
                let vs = Reflection.FSharpValue.GetRecordFields(value)
                "{ " + String.concat "; " [| for (f, v) in Array.zip fs vs -> f.Name + "=" + formatValue v |] + " }"
            | List 0 els ->
                "["
                + String.concat "; " [| for v in els -> formatValue v |]
                + (if els.Length >= LISTLIM then "; .." else "")
                + "]"
            | _ when Reflection.FSharpType.IsUnion(ty) ->
                let uc, vs = Reflection.FSharpValue.GetUnionFields(value, ty)
                uc.Name + "(" + String.concat ", " [| for v in vs -> formatValue v |] + ")"
            | _ when (value :? System.Collections.IEnumerable) -> "<seq>"
            | _ -> value.ToString() //"unknown value"

    let MAXTOOLTIP = 100

    /// Write an info file containing extra information to make available to F# tooling.
    /// This is currently experimental and only experimental additions to F# tooling
    /// watch and consume this information.
    let writeInfoFile (tooltips: (DRange * (string * obj) list * bool) []) sourceFile (diags: DDiagnostic []) =

        let lines =
            let ranges = HashSet<DRange>(HashIdentity.Structural)
            let havePreferred =
                tooltips |> Array.choose (fun (m, _, prefer) -> if prefer then Some m else None) |> Set.ofArray
            [|
                for (range, lines, prefer) in tooltips do


                    // Only emit one line for each range. If live checks are performed twice only
                    // the first is currently shown.
                    //
                    // We have a hack here to prefer some entries over others.  FCS returns non-compiler-generated
                    // locals for curried functions like
                    //     a |> ... |> foo1
                    // or
                    //     a |> ... |> foo2 x
                    //
                    // which become
                    //     a |> ... |> (fun input -> foo input)
                    //     a |> ... |> (fun input -> foo2 x input
                    // but here a use is reported for "input" over the range of the application expression "foo1" or "foo2 x"
                    // So we prefer the actual call over these for these ranges.
                    //
                    // TODO: report this FCS problem and fix it.
                    if not (ranges.Contains(range)) && (prefer || not (havePreferred.Contains range)) then
                        ranges.Add(range) |> ignore

                        // Format multiple lines of text into a single line in the output file
                        let valuesText =
                            [
                                for (action, value) in lines do
                                    let action = (if action = "" then "" else action + " ")
                                    let valueText =
                                        try
                                            formatValue value
                                        with
                                            | e -> sprintf "??? (%s)" e.Message
                                    let valueText = valueText.Replace("\n", "\\n").Replace("\r", "").Replace("\t", "")
                                    let valueText =
                                        if valueText.Length > MAXTOOLTIP then
                                            valueText.[0..MAXTOOLTIP - 1] + "..."
                                        else
                                            valueText
                                    yield action + valueText
                            ]
                            |> String.concat "\\n  " // special new-line character known by experimental VS tooling + indent

                        let sep = (if lines.Length = 1 then " " else "\\n")
                        let line =
                            sprintf
                                "ToolTip\t%d\t%d\t%d\t%d\tLiveCheck:%s%s"
                                range.StartLine
                                range.StartColumn
                                range.EndLine
                                range.EndColumn
                                sep
                                valuesText
                        yield line

                for diag in diags do
                    printfn "%s" (diag.ToString())
                    for range in diag.LocationStack do
                        if Path.GetFullPath(range.File) = Path.GetFullPath(sourceFile) then
                            let message =
                                "LiveCheck: "
                                + diag.Message
                                + ([|
                                    for m in Array.rev diag.LocationStack ->
                                        sprintf "\n  stack: (%d,%d)-(%d,%d) %s" m.StartLine m.StartColumn m.EndLine m.EndColumn m.File
                                   |]
                                   |> String.concat "")
                            let message = message.Replace("\t", " ").Replace("\r", "").Replace("\n", "\\n")
                            let sev =
                                match diag.Severity with
                                | 0
                                | 1 -> "warning"
                                | _ -> "error"
                            let line =
                                sprintf
                                    "Error\t%d\t%d\t%d\t%d\t%s\t%s\t%d"
                                    range.StartLine
                                    range.StartColumn
                                    range.EndLine
                                    range.EndColumn
                                    sev
                                    message
                                    diag.Number
                            yield line
            |]

        emitInfoFile sourceFile lines

    let runEntityDeclLiveChecks (entity: DEntityDef, entityR: ResolvedEntity, methDecls: (DMemberDef * DExpr) []) =
        // If a [<LiveCheck>] attribute occurs on a type, then call the Invoke member on
        // the attribute type passing the target type as an attribute.
        //
        // When a live checking attribute is attached to a type
        // we expect the attribute type to implement an Invoke method
        // taking the target type and the location information related
        // to the check for diagnostic production.
        if livecheck then
            match entityR with
            | REntity (targetType, _) ->
                let liveShape =
                    targetType.GetCustomAttributes(true)
                    |> Array.tryFind (fun a -> a.GetType().Name.Contains "CheckAttribute")
                match liveShape with
                | None -> [||]
                | Some attr ->
                    // Grab the source locations of methods to pass to the checker for better error location reporting
                    let methLocs =
                        [|
                            for (membDef, _membBody) in methDecls do
                                match membDef.Range with
                                | None -> ()
                                | Some m -> yield (membDef.Name, m.File, m.StartLine, m.StartColumn, m.EndLine, m.EndColumn)
                        |]

                    let res =
                        try
                            protectEval
                                false
                                entity.Range
                                (fun () ->
                                    let loc =
                                        defaultArg
                                            entity.Range
                                            {
                                                File = ""
                                                StartLine = 0
                                                StartColumn = 0
                                                EndLine = 0
                                                EndColumn = 0
                                            }
                                    let args =
                                        [|
                                            box targetType
                                            box methLocs
                                            box loc.File
                                            box loc.StartLine
                                            box loc.StartColumn
                                            box loc.EndLine
                                            box loc.EndColumn
                                        |]
                                    let res =
                                        protectInvoke (fun () ->
                                            attr
                                                .GetType()
                                                .InvokeMember(
                                                    "Invoke",
                                                    BindingFlags.Public ||| BindingFlags.InvokeMethod ||| BindingFlags.Instance,
                                                    null,
                                                    attr,
                                                    args
                                                )
                                        )
                                    let diags =
                                        match res with
                                        | :? ((int (* number *)  * int * (string * int * int * int * int) [] * string) []) as diags -> diags
                                        | _ -> failwith "incorrect return type from attribute Invoke"
                                    [|
                                        for (severity, number, locstack, msg) in diags do
                                            let stack =
                                                [|
                                                    yield! Option.toList entity.Range
                                                    for (file, sl, sc, el, ec) in locstack do
                                                        {
                                                            File = file
                                                            StartLine = sl
                                                            StartColumn = sc
                                                            EndLine = el
                                                            EndColumn = ec
                                                        }
                                                |]
                                            {
                                                Severity = severity
                                                Number = number
                                                Message = msg
                                                LocationStack = stack
                                            }
                                    |]
                                )
                        with
                            | exn -> [| DiagnosticFromException exn |]
                    res

            | _ -> [||]
        else
            [||]

    /// Evaluate the declarations using the interpreter
    member t.EvaluateDecls(fileContents: seq<FSharpImplementationFileContents>) =
        let assemblyTable =
            dict [|
                for r in options do
                    //printfn "typeof<obj>.Assembly.Location = %s" typeof<obj>.Assembly.Location
                    if
                        r.StartsWith("-r:")
                        && not (r.Contains(".NETFramework"))
                        && not (r.Contains("Microsoft.NETCore.App"))
                        && not (r.Contains "Microsoft.AspNetCore.App")
                    then
                        let assemName = r.[3..]
                        //printfn "Script: pre-loading referenced assembly %s " assemName
                        let asm =
                            try
                                System.Reflection.Assembly.LoadFrom(assemName)
                            with
                                | ex ->
                                    printfn "Load assembly failed: %s" assemName
                                    null

                        match asm with
                        | null -> ()
                        | asm ->
                            let name = asm.GetName()
                            yield (name.Name, asm)

                |]

        let assemblyResolver (nm: Reflection.AssemblyName) =
            match assemblyTable.TryGetValue(nm.Name) with
            | true, res -> res
            | _ -> System.Reflection.Assembly.Load nm

        let tooltips = ResizeArray()
        let sink =
            if writeinfo then
                { new Sink with

                    member _.NotifyEstablishEntityDecl(entity, entityR, entityDecls) =
                        runEntityDeclLiveChecks (entity, entityR, entityDecls)

                    member __.NotifyCallAndReturn(mref, callerRange, mdef, _typeArgs, args, res) =
                        let paramNames =
                            match mdef with
                            | Choice1Of2 minfo -> [| for p in minfo.GetParameters() -> p.Name |]
                            | Choice2Of2 mdef -> [| for p in mdef.Parameters -> p.Name |]
                        let isValue =
                            match mdef with
                            | Choice1Of2 minfo -> false
                            | Choice2Of2 mdef -> mdef.IsValue
                        let lines =
                            [
                                for (p, arg) in Seq.zip paramNames args do
                                    yield (sprintf "%s:" p, arg)
                                if isValue then yield ("value:", res.Value) else yield ("return:", res.Value)
                            ]
                        match mdef with
                        | Choice1Of2 _ -> ()
                        | Choice2Of2 mdef -> mdef.Range |> Option.iter (fun r -> tooltips.Add(r, lines, true))
                        match mref with
                        | None -> ()
                        | Some mref -> callerRange |> Option.iter (fun r -> tooltips.Add(r, lines, true))

                    member __.NotifyBindValue(vdef, value) =
                        printfn "%A: vdef.Name = %s, vdef.IsCompilerGenerated = %b" vdef.Range vdef.Name vdef.IsCompilerGenerated
                        if not vdef.IsCompilerGenerated then
                            vdef.Range |> Option.iter (fun r -> tooltips.Add((r, [ ("", value.Value) ], false)))

                    member __.NotifySetField(typ, fdef, value) =
                        // Class fields for implicit constructors are reported as 'compiler generated'
                        //if not fdef.IsCompilerGenerated then
                        fdef.Range |> Option.iter (fun r -> tooltips.Add((r, [ ("", value.Value) ], false)))

                    member __.NotifyGetField(typ, fdef, m, value) =
                        // Class fields for implicit constructors are reported as 'compiler generated'
                        //if not fdef.IsCompilerGenerated then
                        m |> Option.iter (fun r -> tooltips.Add((r, [ ("", value.Value) ], false)))

                    member __.NotifyBindLocal(vdef, value) =
                        if not vdef.IsCompilerGenerated then
                            vdef.Range |> Option.iter (fun r -> tooltips.Add((r, [ ("", value.Value) ], false)))

                    member __.NotifyUseLocal(vref, value) =
                        if not vref.IsCompilerGenerated then
                            vref.Range |> Option.iter (fun r -> tooltips.Add((r, [ ("", value.Value) ], false)))
                }
                |> Some
            else
                None

        assemblyNameId <- assemblyNameId + 1
        let assemblyName = AssemblyName("Eval" + string assemblyNameId)
        let ctxt = EvalContext(assemblyName, dyntypes, assemblyResolver, ?sink = sink)

        let fileConvContents =
            [|
                for i in fileContents ->
                    let code =
                        {
                            Code = Convert(keepRanges, tolerateIncompleteExpressions).ConvertDecls i.Declarations
                        }
                    i.FileName, code
            |]

        let allDecls =
            [|
                for (_, contents) in fileConvContents do
                    yield! contents.Code
            |]
        ctxt.AddDecls(allDecls)

        let mutable res = Ok()
        for (sourceFile, ds) in fileConvContents do
            printfn "evaluating decls.... "
            let diags = ctxt.TryEvalDecls(envEmpty, ds.Code, evalLiveChecksOnly = livecheck)

            if writeinfo then writeInfoFile (tooltips.ToArray()) sourceFile diags
            for diag in diags do
                printfn "%s" (diag.ToString())
            if diags |> Array.exists (fun diag -> diag.Severity >= 2) then res <- Error()

            printfn "...evaluated decls"
        res
