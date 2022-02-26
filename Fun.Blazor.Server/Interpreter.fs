// Copyright 2018 Fabulous contributors. See LICENSE.md for license.
module FSharp.Compiler.PortaCode.Interpreter

open System
open System.Reflection
open System.Reflection.Emit
open System.Collections.Concurrent
open System.Collections.Generic
open FSharp.Compiler.PortaCode.CodeModel
open FSharp.Reflection

type ResolvedEntity =
    | REntity of Type * isDynamic: bool
    | UEntity of DEntityDef

and ResolvedType =
    | RType of Type
    | UNamedType of DEntityDef * Type []

and ResolvedTypes =
    | RTypes of Type []
    | UTypes of ResolvedType []

and ResolvedMember =
    | RPrim_float
    | RPrim_float32
    | RPrim_double
    | RPrim_single
    | RPrim_int32
    | RPrim_int16
    | RPrim_int64
    | RPrim_byte
    | RPrim_uint16
    | RPrim_uint32
    | RPrim_uint64
    | RPrim_decimal
    | RPrim_unativeint
    | RPrim_nativeint
    | RPrim_char
    | RPrim_neg
    | RPrim_pos
    | RPrim_minus
    | RPrim_divide
    | RPrim_mod
    | RPrim_shiftleft
    | RPrim_shiftright
    | RPrim_land
    | RPrim_lor
    | RPrim_lxor
    | RPrim_lneg
    | RPrim_checked_int32
    | RPrim_checked_int
    | RPrim_checked_int16
    | RPrim_checked_int64
    | RPrim_checked_byte
    | RPrim_checked_uint16
    | RPrim_checked_uint32
    | RPrim_checked_uint64
    | RPrim_checked_unativeint
    | RPrim_checked_nativeint
    | RPrim_checked_char
    | RPrim_checked_minus
    | RPrim_checked_mul
    | RPrim_abs
    | RPrim_acos
    | RPrim_asin
    | RPrim_atan
    | RPrim_atan2
    | RPrim_ceil
    | RPrim_exp
    | RPrim_floor
    | RPrim_truncate
    | RPrim_round
    | RPrim_sign
    | RPrim_log
    | RPrim_log10
    | RPrim_sqrt
    | RPrim_cos
    | RPrim_cosh
    | RPrim_sin
    | RPrim_sinh
    | RPrim_tan
    | RPrim_tanh
    //| RPrim_pown
    | RPrim_pow
    | RMethod of System.Reflection.MemberInfo
    | UMethod of (DMemberDef * Value)

and ResolvedUnionCase =
    | RUnionCase of FSharp.Reflection.UnionCaseInfo * (obj -> int) * (obj [] -> obj) * (obj -> obj [])
    | UUnionCase of int * string

and ResolvedField =
    | RField of MemberInfo * DFieldDef option
    | UField of int * ResolvedType * DFieldDef

and Value = { mutable Value: obj }

// TODO: intercept ToString, comparison
and RecordValue = | RecordValue of obj []
and UnionValue = | UnionValue of int * string * obj []
and MethodLambdaValue = | MethodLambdaValue of (Type [] * obj [] -> obj)
and ObjectValue = obj
and ObjectFields = { mutable Fields: Map<string, obj> }

let cwt = System.Runtime.CompilerServices.ConditionalWeakTable<obj, ObjectFields>()

let getFields obj =
    match cwt.TryGetValue(obj) with
    | true, res -> res
    | _ ->
        let fields = { Fields = Map.empty }
        cwt.Add(obj, fields)
        fields

let (|Value|) (v: Value) = v.Value

let Value (v: obj) = { Value = v }

let fail x y = failwith "invalid op"

let getVal (Value v) = v

let bindAll =
    BindingFlags.Public ||| BindingFlags.NonPublic ||| BindingFlags.Instance ||| BindingFlags.Static

/// A sink to observe operation of the interpreter. A little like a debug API.
type Sink =

    /// Called after an enitity declaration is established.  If dynamic emit of types
    /// is enabled then the System.Type for the entity will be available in entityR
    abstract NotifyEstablishEntityDecl : entity: DEntityDef * entityR: ResolvedEntity * memberDecls: (DMemberDef * DExpr) [] -> DDiagnostic []

    /// Called whenever a call is completed, showing caller reference and called method
    abstract NotifyCallAndReturn :
        caller: DMemberRef option
        * callerRange: DRange option
        * callee: Choice<MethodInfo, DMemberDef>
        * typeArgs: Type []
        * args: obj []
        * returnValue: Value ->
        unit

    /// Called whenever a value in a module is computed
    abstract NotifyBindValue : DMemberDef * Value -> unit

    /// Called whenever a class or record field is set
    abstract NotifySetField : DType * DFieldDef * Value -> unit

    /// Called whenever a class or record field is set
    abstract NotifyGetField : DType * DFieldDef * DRange option * Value -> unit

    /// Called whenever a parameter or expression local is bound or a local is computed
    abstract NotifyBindLocal : DLocalDef * Value -> unit

    /// Called whenever a local is used
    abstract NotifyUseLocal : DLocalRef * Value -> unit

let emptySink =
    { new Sink with
        member _.NotifyEstablishEntityDecl(_, _, _) = [||]
        member _.NotifyCallAndReturn(_, _, _, _, _, _) = ()
        member _.NotifyBindValue(_, _) = ()
        member _.NotifySetField(_, _, _) = ()
        member _.NotifyGetField(_, _, _, _) = ()
        member _.NotifyBindLocal(_, _) = ()
        member _.NotifyUseLocal(_, _) = ()
    }

type Env =
    {
        Vals: Map<string, Value>
        Types: Map<string, Type>
        Targets: (DLocalDef [] * DExpr) []
    }

let envEmpty =
    {
        Vals = Map.empty
        Types = Map.empty
        Targets = Array.empty
    }

let bindByName (env: Env) varName value = { env with Vals = env.Vals.Add(varName, value) }

let bind (sink: Sink) (env: Env) (var: DLocalDef) (value: Value) =
    sink.NotifyBindLocal(var, value)
    bindByName env var.Name value

let bindMany sink env vars values = (env, vars, values) |||> Array.fold2 (bind sink)

let bindType (env: Env) (var: DGenericParameterDef) value =
    { env with Types = env.Types.Add(var.Name, value) }

type DMemberDef with

    member membDef.IsValueDef =
        not (membDef.Name = ".ctor")
        && not membDef.IsInstance
        && membDef.IsValue
        && membDef.Parameters.Length = 0
        && membDef.GenericParameters.Length = 0

let rec protectRaise (e: exn) =
    match e with
    | :? TargetInvocationException as e -> protectRaise e.InnerException
    | _ -> raise e

let protectInvoke f =
    try
        f ()
    with
        | exn -> protectRaise exn

let WilFailTraitCallInvoke (traitName, sourceTypeR: Type, isInstance) =
    let bindingFlags =
        (if isInstance then BindingFlags.Instance else BindingFlags.Static)
        ||| BindingFlags.Public
        ||| BindingFlags.NonPublic
        ||| BindingFlags.FlattenHierarchy
    let meths =
        sourceTypeR.GetMethods(bindingFlags) |> Array.filter (fun n -> n.Name = traitName)
    meths.Length = 0

let EvalTraitCallInvoke (traitName, sourceTypeRs: Type list, isInstance, argExprsV: obj []) =
    let sourceTypeR =
        match sourceTypeRs with
        | [ t ] -> t
        | [ t1; t2 ] -> if WilFailTraitCallInvoke(traitName, t1, isInstance) then t2 else t1
        | _ -> failwith "unexpected"

    let objV = if isInstance then argExprsV.[0] else null
    let argsV = if isInstance then argExprsV.[1..] else argExprsV
    let bindingFlags =
        (if isInstance then BindingFlags.Instance else BindingFlags.Static)
        ||| BindingFlags.Public
        ||| BindingFlags.NonPublic
        ||| BindingFlags.InvokeMethod
        ||| BindingFlags.FlattenHierarchy
    //printfn "sourceTypeR = %A, traitName = %s, objV = %A, argsV types = %A" sourceTypeR traitName objV [| for a in argsV -> a.GetType() |]
    let resObj =
        try
            protectInvoke (fun () -> sourceTypeR.InvokeMember(traitName, bindingFlags, null, objV, argsV))
        with
            | e ->
                printfn "failed!"
                reraise ()
    Value resObj

let inline unOp op (argsV: obj []) f32 f64 =
    match argsV.[0] with
    | (:? double as v1) -> Value(box (f64 v1))
    | (:? single as v1) -> Value(box (f32 v1))
    | _ -> EvalTraitCallInvoke(op, [ argsV.[0].GetType() ], false, argsV)

let inline binOp op (argsV: obj []) i8 i16 i32 i64 u8 u16 u32 u64 f32 f64 d =
    match argsV.[0], argsV.[1] with
    | (:? int32 as v1), (:? int32 as v2) -> Value(box (i32 v1 v2))
    | (:? double as v1), (:? double as v2) -> Value(box (f64 v1 v2))
    | (:? single as v1), (:? single as v2) -> Value(box (f32 v1 v2))
    | (:? int64 as v1), (:? int64 as v2) -> Value(box (i64 v1 v2))
    | (:? int16 as v1), (:? int16 as v2) -> Value(box (i16 v1 v2))
    | (:? sbyte as v1), (:? sbyte as v2) -> Value(box (i8 v1 v2))
    | (:? uint32 as v1), (:? uint32 as v2) -> Value(box (u32 v1 v2))
    | (:? uint64 as v1), (:? uint64 as v2) -> Value(box (u64 v1 v2))
    | (:? uint16 as v1), (:? uint16 as v2) -> Value(box (u16 v1 v2))
    | (:? byte as v1), (:? byte as v2) -> Value(box (u8 v1 v2))
    | (:? decimal as v1), (:? decimal as v2) -> Value(box (d v1 v2))
    | _ -> EvalTraitCallInvoke(op, [ argsV.[0].GetType(); argsV.[1].GetType() ], false, argsV)

let inline shiftOp op (argsV: obj []) i8 i16 i32 i64 u8 u16 u32 u64 =
    match argsV.[0], argsV.[1] with
    | (:? int32 as v1), (:? int32 as v2) -> Value(box (i32 v1 v2))
    | (:? int64 as v1), (:? int32 as v2) -> Value(box (i64 v1 v2))
    | (:? int16 as v1), (:? int32 as v2) -> Value(box (i16 v1 v2))
    | (:? sbyte as v1), (:? int32 as v2) -> Value(box (i8 v1 v2))
    | (:? uint32 as v1), (:? int32 as v2) -> Value(box (u32 v1 v2))
    | (:? uint64 as v1), (:? int32 as v2) -> Value(box (u64 v1 v2))
    | (:? uint16 as v1), (:? int32 as v2) -> Value(box (u16 v1 v2))
    | (:? byte as v1), (:? int32 as v2) -> Value(box (u8 v1 v2))
    | _ -> EvalTraitCallInvoke(op, [ argsV.[0].GetType(); argsV.[1].GetType() ], false, argsV)

let inline logicBinOp op (argsV: obj []) i8 i16 i32 i64 u8 u16 u32 u64 =
    match argsV.[0], argsV.[1] with
    | (:? int32 as v1), (:? int32 as v2) -> Value(box (i32 v1 v2))
    | (:? int64 as v1), (:? int64 as v2) -> Value(box (i64 v1 v2))
    | (:? int16 as v1), (:? int16 as v2) -> Value(box (i16 v1 v2))
    | (:? sbyte as v1), (:? sbyte as v2) -> Value(box (i8 v1 v2))
    | (:? uint32 as v1), (:? uint32 as v2) -> Value(box (u32 v1 v2))
    | (:? uint64 as v1), (:? uint64 as v2) -> Value(box (u64 v1 v2))
    | (:? uint16 as v1), (:? uint16 as v2) -> Value(box (u16 v1 v2))
    | (:? byte as v1), (:? byte as v2) -> Value(box (u8 v1 v2))
    | _ -> EvalTraitCallInvoke(op, [ argsV.[0].GetType(); argsV.[1].GetType() ], false, argsV)

let inline logicUnOp op (argsV: obj []) i8 i16 i32 i64 u8 u16 u32 u64 =
    match argsV.[0] with
    | (:? int32 as v1) -> Value(box (i32 v1))
    | (:? int64 as v1) -> Value(box (i64 v1))
    | (:? int16 as v1) -> Value(box (i16 v1))
    | (:? sbyte as v1) -> Value(box (i8 v1))
    | (:? uint32 as v1) -> Value(box (u32 v1))
    | (:? uint64 as v1) -> Value(box (u64 v1))
    | (:? uint16 as v1) -> Value(box (u16 v1))
    | (:? byte as v1) -> Value(box (u8 v1))
    | _ -> EvalTraitCallInvoke(op, [ argsV.[0].GetType() ], false, argsV)

let negOp op (argsV: obj []) =
    match argsV.[0] with
    | (:? int32 as v1) -> Value(box (-v1))
    | (:? single as v1) -> Value(box (-v1))
    | (:? double as v1) -> Value(box (-v1))
    | (:? int64 as v1) -> Value(box (-v1))
    | (:? int16 as v1) -> Value(box (-v1))
    | (:? sbyte as v1) -> Value(box (-v1))
    | (:? decimal as v1) -> Value(box (-v1))
    | _ -> EvalTraitCallInvoke(op, [ argsV.[0].GetType() ], false, argsV)

let minusOp argsV =
    binOp "op_Subtraction" argsV (-) (-) (-) (-) (-) (-) (-) (-) (-) (-) (-)

let divideOp argsV =
    binOp "op_Division" argsV (/) (/) (/) (/) (/) (/) (/) (/) (/) (/) (/)

let modOp argsV =
    binOp "op_Modulus" argsV (%) (%) (%) (%) (%) (%) (%) (%) (%) (%) (%)

let shiftleftOp argsV =
    shiftOp "op_LeftShift" argsV (<<<) (<<<) (<<<) (<<<) (<<<) (<<<) (<<<) (<<<)

let shiftrightOp argsV =
    shiftOp "op_RightShift" argsV (>>>) (>>>) (>>>) (>>>) (>>>) (>>>) (>>>) (>>>)

let landOp argsV =
    logicBinOp "op_BitwiseAnd" argsV (&&&) (&&&) (&&&) (&&&) (&&&) (&&&) (&&&) (&&&)

let lorOp argsV =
    logicBinOp "op_BitwiseOr" argsV (|||) (|||) (|||) (|||) (|||) (|||) (|||) (|||)

let lxorOp argsV =
    logicBinOp "op_ExclusiveOr" argsV (^^^) (^^^) (^^^) (^^^) (^^^) (^^^) (^^^) (^^^)

let lnegOp argsV =
    logicUnOp "op_LogicalNot" argsV (~~~) (~~~) (~~~) (~~~) (~~~) (~~~) (~~~) (~~~)

let checked_minusOp argsV =
    binOp
        "op_Subtraction"
        argsV
        Checked.op_Subtraction
        Checked.op_Subtraction
        Checked.op_Subtraction
        Checked.op_Subtraction
        Checked.op_Subtraction
        Checked.op_Subtraction
        Checked.op_Subtraction
        Checked.op_Subtraction
        Checked.op_Subtraction
        Checked.op_Subtraction
        Checked.op_Subtraction

let checked_mulOp argsV =
    binOp
        "op_Multiply"
        argsV
        Checked.op_Multiply
        Checked.op_Multiply
        Checked.op_Multiply
        Checked.op_Multiply
        Checked.op_Multiply
        Checked.op_Multiply
        Checked.op_Multiply
        Checked.op_Multiply
        Checked.op_Multiply
        Checked.op_Multiply
        Checked.op_Multiply

let absOp argsV = unOp "Abs" argsV abs abs
let acosOp argsV = unOp "Acos" argsV acos acos
let asinOp argsV = unOp "Asin" argsV asin asin
let atanOp argsV = unOp "Atan" argsV atan atan

let atan2Op argsV =
    binOp "Atan2" argsV fail fail fail fail fail fail fail fail atan2 atan2 fail

let ceilOp argsV = unOp "Ceil" argsV ceil ceil
let expOp argsV = unOp "Exp" argsV exp exp
let floorOp argsV = unOp "Floor" argsV floor floor
let truncateOp argsV = unOp "Truncate" argsV truncate truncate
let roundOp argsV = unOp "Round" argsV round round
let signOp argsV = unOp "Sign" argsV sign sign
let logOp argsV = unOp "Log" argsV log log
let log10Op argsV = unOp "Log10" argsV log10 log10
let sqrtOp argsV = unOp "Sqrt" argsV sqrt sqrt
let cosOp argsV = unOp "Cos" argsV cos cos
let coshOp argsV = unOp "Cosh" argsV cosh cosh
let sinOp argsV = unOp "Sin" argsV sin sin
let sinhOp argsV = unOp "Sinh" argsV sinh sinh
let tanOp argsV = unOp "Tan" argsV tan tan
let tanhOp argsV = unOp "Tanh" argsV tanh tanh
//let pownOp argsV = unOp "Pown" argsV pown pown
let powOp argsV =
    binOp "Pow" argsV fail fail fail fail fail fail fail fail ( ** ) ( ** ) fail

/// Record a stack of ranges in an exception
type System.Exception with

    member e.EvalLocationStack
        with get () =
            if e.Data.Contains "location" then
                match e.Data.["location"] with
                | :? ((string * int * int * int * int) []) as stack -> stack
                | _ -> [||]
            else
                [||]
        and set (data: (string * int * int * int * int) []) = e.Data.["location"] <- data

let DiagnosticFromException (err: exn) =
    let stack =
        [|
            for (f, sl, sc, el, ec) in err.EvalLocationStack ->
                {
                    File = f
                    StartLine = sl
                    StartColumn = sc
                    EndLine = el
                    EndColumn = ec
                }
        |]
    {
        Severity = 2
        Number = 1001
        Message = err.Message
        LocationStack = stack
    }

/// If an exception happens, record the range in the exception
let protectEval compgen (r: DRange option) f =
    if compgen || r.IsNone then
        f ()
    else
        try
            f ()
        with
            | e ->
                e.EvalLocationStack <-
                    (let m = r.Value
                     [|
                         yield (m.File, m.StartLine, m.StartColumn, m.EndLine, m.EndColumn)
                         yield! e.EvalLocationStack
                     |])
                raise e

/// Context for evaluation/interpretation
type EvalContext(assemblyName: AssemblyName, ?dyntypes: bool, ?assemblyResolver: (AssemblyName -> Assembly), ?sink: Sink) =
    let assemblyResolver = defaultArg assemblyResolver System.Reflection.Assembly.Load
    let dyntypes = defaultArg dyntypes false
    let sink = defaultArg sink emptySink
    let entityResolutions = ConcurrentDictionary<DEntityRef, ResolvedEntity>(HashIdentity.Structural)
    let methodThunks =
        ConcurrentDictionary<(ResolvedEntity * string * ResolvedTypes), (DMemberDef * Value)>(HashIdentity.Structural)
    let dispatchSlots =
        ConcurrentDictionary<(ResolvedEntity * string * ResolvedTypes), bool>(HashIdentity.Structural)
    let fieldDefMap = ConcurrentDictionary<(string * string), DFieldDef>(HashIdentity.Structural)

    // For emitting shell types
    let mutable shellTypeThunkCount = 0
    let shellTypeThunks = ConcurrentDictionary<int, MethodLambdaValue>(HashIdentity.Structural)

    // TODO: add these resolution tables
    //let unionCaseResolutions = ConcurrentDictionary<(DType * DUnionCaseRef),ResolvedUnionCase>(HashIdentity.Structural)
    //let fieldResolutions = ConcurrentDictionary<(DType * DFieldRef),ResolvedField>(HashIdentity.Structural)
    //let methodResolutions = ConcurrentDictionary<...,ResolvedMember>(HashIdentity.Structural)

    let methinfoof q =
        match q with
        | Quotations.DerivedPatterns.Lambdas (_, Quotations.Patterns.Call (_, minfo, _)) -> minfo.GetGenericMethodDefinition()
        | _ -> failwith "unexpected"
    let op_double = methinfoof <@ double @>
    let op_single = methinfoof <@ single @>
    let op_float = methinfoof <@ float @>
    let op_float32 = methinfoof <@ float32 @>
    let op_int32 = methinfoof <@ int32 @>
    let op_int = methinfoof <@ int @>
    let op_int16 = methinfoof <@ int16 @>
    let op_int64 = methinfoof <@ int64 @>
    let op_byte = methinfoof <@ byte @>
    let op_uint16 = methinfoof <@ uint16 @>
    let op_uint32 = methinfoof <@ uint32 @>
    let op_uint64 = methinfoof <@ uint64 @>
    let op_decimal = methinfoof <@ decimal @>
    let op_unativeint = methinfoof <@ unativeint @>
    let op_nativeint = methinfoof <@ nativeint @>
    let op_char = methinfoof <@ char @>
    let op_neg = methinfoof <@ (~-) @>
    let op_pos = methinfoof <@ (~+) @>
    let op_minus = methinfoof <@ (-) @>
    let op_divide = methinfoof <@ (/) @>
    let op_mod = methinfoof <@ (%) @>
    let op_shiftleft = methinfoof <@ (<<<) @>
    let op_shiftright = methinfoof <@ (>>>) @>
    let op_land = methinfoof <@ (&&&) @>
    let op_lor = methinfoof <@ (|||) @>
    let op_lxor = methinfoof <@ (^^^) @>
    let op_lneg = methinfoof <@ (~~~) @>

    let op_checked_int32 = methinfoof <@ Operators.Checked.int32 @>
    let op_checked_int = methinfoof <@ Operators.Checked.int @>
    let op_checked_int16 = methinfoof <@ Operators.Checked.int16 @>
    let op_checked_int64 = methinfoof <@ Operators.Checked.int64 @>
    let op_checked_byte = methinfoof <@ Operators.Checked.byte @>
    let op_checked_uint16 = methinfoof <@ Operators.Checked.uint16 @>
    let op_checked_uint32 = methinfoof <@ Operators.Checked.uint32 @>
    let op_checked_uint64 = methinfoof <@ Operators.Checked.uint64 @>
    let op_checked_unativeint = methinfoof <@ Operators.Checked.unativeint @>
    let op_checked_nativeint = methinfoof <@ Operators.Checked.nativeint @>
    let op_checked_char = methinfoof <@ Operators.Checked.char @>
    let op_checked_minus = methinfoof <@ Operators.Checked.op_Subtraction @>
    let op_checked_mul = methinfoof <@ Operators.Checked.op_Multiply @>
    let op_abs = methinfoof <@ Operators.abs @>
    let op_acos = methinfoof <@ Operators.acos @>
    let op_asin = methinfoof <@ Operators.asin @>
    let op_atan = methinfoof <@ Operators.atan @>
    let op_atan2 = methinfoof <@ Operators.atan2 @>
    let op_ceil = methinfoof <@ Operators.ceil @>
    let op_exp = methinfoof <@ Operators.exp @>
    let op_floor = methinfoof <@ Operators.floor @>
    let op_truncate = methinfoof <@ Operators.truncate @>
    let op_round = methinfoof <@ Operators.round @>
    let op_sign = methinfoof <@ Operators.sign @>
    let op_log = methinfoof <@ Operators.log @>
    let op_log10 = methinfoof <@ Operators.log10 @>
    let op_sqrt = methinfoof <@ Operators.sqrt @>
    let op_cos = methinfoof <@ Operators.cos @>
    let op_cosh = methinfoof <@ Operators.cosh @>
    let op_sin = methinfoof <@ Operators.sin @>
    let op_sinh = methinfoof <@ Operators.sinh @>
    let op_tan = methinfoof <@ Operators.tan @>
    let op_tanh = methinfoof <@ Operators.tanh @>
    //let op_pown = methinfoof <@ Operators.pown @>
    let op_pow = methinfoof <@ Operators.op_Exponentiation @>

    /// Resolve an F# entity (type or module)
    let resolveEntity entityRef =
        match entityResolutions.TryGetValue(entityRef) with
        | true, v -> v
        | _ ->
            let (DEntityRef typeName) = entityRef
            let res =
                match System.Type.GetType(typeName, assemblyResolver = Func<_, _>(assemblyResolver), typeResolver = null) with
                | null ->
                    let try2 =
                        if typeName.Contains("netstandard") then
                            let otherTypeName =
                                typeName
                                    .Replace("netstandard", "mscorlib")
                                    .Replace("cc7b13ffcd2ddd51", "b77a5c561934e089")
                                    .Replace("2.0.0.0", "4.0.0.0")
                            match System.Type.GetType(otherTypeName, assemblyResolver = Func<_, _>(assemblyResolver), typeResolver = null) with
                            | null -> None
                            | t -> Some t
                        else
                            System.Reflection.Assembly.GetEntryAssembly().GetType(typeName)
                            |> Option.ofObj
                    match try2 with
                    //| Some t -> REntity t
                    //| None ->
                    //let try3 =
                    //    match dynAssembly with
                    //    | None -> None
                    //    | Some thisAssembly ->
                    //        //for t in thisAssembly.GetTypes() do
                    //        //    printfn "Available: %s" t.FullName
                    //        thisAssembly.GetType(typeName) |> Option.ofObj
                    //match try3 with
                    | Some t -> REntity(t, false)
                    | None -> failwithf "couldn't resolve type %A" typeName
                | t -> REntity(t, false)
            entityResolutions.[entityRef] <- res
            res

    /// Resolve an array of F# types
    let rec resolveTypes (env, tys: DType []) =
        let res = tys |> Array.map (fun ty -> resolveType (env, ty))
        if res
           |> Array.forall (
               function
               | RType _ -> true
               | _ -> false
           ) then
            RTypes(
                res
                |> Array.map (
                    function
                    | RType x -> x
                    | _ -> failwith "unreachable"
                )
            )
        else
            UTypes res

    /// Resolve an F# type
    and resolveType (env, ty: DType) =
        match ty with
        | DByRefType (elemType) ->
            match resolveType (env, elemType) with
            | RTypeErased env t -> RType(t.MakeByRefType())
        | DArrayType (1, elemType) ->
            match resolveType (env, elemType) with
            | RTypeErased env t -> RType(t.MakeArrayType())
        | DArrayType (n, elemType) ->
            match resolveType (env, elemType) with
            | RTypeErased env t -> RType(t.MakeArrayType(n))
        | DNamedType ((DEntityRef nm as n), argTypes) ->
            // FCS TODO: FCS quirk this is a hack to do with the fact that float<1> is being reported as a type by FCS and PortaCode
            if nm.StartsWith "Microsoft.FSharp.Core.float`1" then
                RType typeof<float>
            elif nm.StartsWith "Microsoft.FSharp.Core.decimal`1" then
                RType typeof<decimal>
            elif nm.StartsWith "Microsoft.FSharp.Core.float32`1" then
                RType typeof<float32>
            elif nm.StartsWith "Microsoft.FSharp.Core.int32`1" then
                RType typeof<int32>
            else
                let (RTypesErased env argTypesR) = resolveTypes (env, argTypes)
                match resolveEntity n, argTypesR with
                | REntity (e, _), [||] -> RType e
                | REntity (e, _), tys -> RType(e.MakeGenericType(tys))
                | UEntity u1, u2 -> UNamedType(u1, u2)
        | DFunctionType (t1, t2) ->
            let (RTypeErased env t1R) = resolveType (env, t1)
            let (RTypeErased env t2R) = resolveType (env, t2)
            RType(typedefof<int -> int>.MakeGenericType (t1R, t2R))
        | DTupleType (isStruct, argTypes) ->
            let (RTypesErased env tys) = resolveTypes (env, argTypes)
            RType(
                if isStruct then
                    failwith "struct tuple NYI" (* FSharp.Reflection.FSharpType.MakeStructTupleType(Array.ofList tys) *)
                else
                    FSharp.Reflection.FSharpType.MakeTupleType(tys)
            )
        | DAnonRecdType (_isStruct, _names, argTypes) ->
            //let (RTypesErased env tys) = resolveTypes (env, argTypes)
            RType(typeof<obj>)
        | DVariableType v ->
            match env.Types.TryGetValue v with
            | true, res -> RType res
            | _ ->
                printfn "variable type %s not found" v
                RType typeof<obj>

    /// Resolve an F# union case
    and resolveBaseType (env, typ: ResolvedType) =
        match typ with
        | RType ty ->
            match ty.BaseType with
            | null -> None
            | bt -> Some(RType bt)
        | UNamedType (tdef, typArgs) ->
            match tdef.BaseType with
            | None -> None
            | Some bt ->
                let env = (env, tdef.GenericParameters, typArgs) |||> Array.fold2 bindType
                Some(resolveType (env, bt))

    and firstCompiledBaseType (env, typ: ResolvedType) =
        match typ with
        | RType ty -> ty
        | UNamedType (tdef, typArgs) ->
            match resolveBaseType (env, typ) with
            | None -> failwith "where is obj()"
            | Some bt -> firstCompiledBaseType (env, bt)

    //and (|RTypeOrFail|) xR : Type =
    //    match xR with
    //    | RType xV -> xV
    //    | _ -> failwithf "didn't resolve %A" xR

    //and (|RTypesOrFail|) xR : Type[] =
    //    match xR with
    //    | RTypes xV -> xV
    //    | UTypes us -> Array.map (|RTypeOrFail|) us

    and (|TypeBuilderOrFail|) xR : TypeBuilder =
        match xR with
        | REntity (:? TypeBuilder as t, _) -> t
        | _ -> failwithf "not a type builder %A" xR

    and (|RTypeErased|) env xR : Type =
        match xR with
        | RType xV -> xV
        | _ -> firstCompiledBaseType (env, xR)

    and (|RTypesErased|) env xR : Type [] =
        match xR with
        | RTypes xV -> xV
        | UTypes us -> Array.map ((|RTypeErased|) env) us

    /// Resolve an F# union case
    let resolveUnionCase (env, unionType, unionCaseRef) =
        let (DUnionCaseRef unionCaseName) = unionCaseRef
        let unionTypeR = resolveType (env, unionType)

        match unionTypeR with
        | RType unionTypeV ->
            let ucases = Reflection.FSharpType.GetUnionCases(unionTypeV, bindAll)
            let ucase = ucases |> Array.find (fun uc -> uc.Name = unionCaseName)
            let make = FSharpValue.PreComputeUnionConstructor(ucase, bindAll)
            let tag = FSharpValue.PreComputeUnionTagReader(unionTypeV, bindAll)
            let get = FSharpValue.PreComputeUnionReader(ucase, bindAll)
            RUnionCase(ucase, tag, make, get)
        | UNamedType (unionTypeDef, _) ->
            match unionTypeDef.UnionCases |> Array.tryFindIndex (fun x -> x = unionCaseName) with
            | None -> failwithf "couldn't resolve union case '%s'" unionCaseName
            | Some tag -> UUnionCase(tag, unionCaseName)

    /// Resolve an F# class or record field
    let resolveField (env, classOrRecordType, fieldRef) =
        let (DFieldRef (index, fieldName)) = fieldRef
        let classOrRecordTypeR = resolveType (env, classOrRecordType)

        match classOrRecordTypeR with
        | RType classOrRecordTypeV ->
            let fdefOption =
                match classOrRecordType with
                | DNamedType ((DEntityRef nm as n), _argTypes) ->
                    match fieldDefMap.TryGetValue((nm, fieldName)) with
                    | false, _ -> None
                    | true, res -> Some res
                | _ -> None
            match classOrRecordTypeV.GetField(fieldName, bindAll) with
            | null ->
                match classOrRecordTypeV.GetProperty(fieldName, bindAll) with
                | null -> failwithf "couldn't find field or property %s in type %A" fieldName classOrRecordType
                | pinfo -> RField(pinfo, fdefOption)
            | finfo -> RField(finfo, fdefOption)
        | UNamedType (typeDef, _) as ty ->
            match typeDef.DeclaredFields |> Array.tryFind (fun x -> x.Name = fieldName) with
            | None -> failwithf "couldn't resolve field '%s'" fieldName
            | Some fdef -> UField(index, ty, fdef)

    /// Resolve a .NET field
    let resolveILField (env, fieldType, fieldName) =
        let fieldTypeR = resolveType (env, fieldType)

        match fieldTypeR with
        | RType classOrRecordTypeV ->
            let field = classOrRecordTypeV.GetField(fieldName, bindAll)
            RField(field, None)
        | _ty -> failwithf "unexpected resolve of ILField %s in interpreted type %A" fieldName fieldType

    /// Make a resolved method value for a method info
    let makeRMethod (m: MethodInfo) =
        if m = op_float then RPrim_float
        elif m = op_float32 then RPrim_float32
        elif m = op_double then RPrim_double
        elif m = op_single then RPrim_single
        elif m = op_int32 then RPrim_int32
        elif m = op_int then RPrim_int32
        elif m = op_byte then RPrim_byte
        elif m = op_int16 then RPrim_int16
        elif m = op_int64 then RPrim_int64
        elif m = op_uint16 then RPrim_uint16
        elif m = op_uint32 then RPrim_uint32
        elif m = op_uint64 then RPrim_uint64
        elif m = op_decimal then RPrim_decimal
        elif m = op_unativeint then RPrim_unativeint
        elif m = op_nativeint then RPrim_nativeint
        elif m = op_char then RPrim_char
        elif m = op_neg then RPrim_neg
        elif m = op_pos then RPrim_pos
        elif m = op_minus then RPrim_minus
        elif m = op_divide then RPrim_divide
        elif m = op_mod then RPrim_mod
        elif m = op_shiftleft then RPrim_shiftleft
        elif m = op_shiftright then RPrim_shiftright
        elif m = op_land then RPrim_land
        elif m = op_lor then RPrim_lor
        elif m = op_lxor then RPrim_lxor
        elif m = op_lneg then RPrim_lneg
        elif m = op_checked_int32 then RPrim_checked_int32
        elif m = op_checked_int then RPrim_checked_int
        elif m = op_checked_int16 then RPrim_checked_int16
        elif m = op_checked_int64 then RPrim_checked_int64
        elif m = op_checked_byte then RPrim_checked_byte
        elif m = op_checked_uint16 then RPrim_checked_uint16
        elif m = op_checked_uint32 then RPrim_checked_uint32
        elif m = op_checked_uint64 then RPrim_checked_uint64
        elif m = op_checked_unativeint then RPrim_checked_unativeint
        elif m = op_checked_nativeint then RPrim_checked_nativeint
        elif m = op_checked_char then RPrim_checked_char
        elif m = op_checked_minus then RPrim_checked_minus
        elif m = op_checked_mul then RPrim_checked_mul
        elif m = op_abs then RPrim_abs
        elif m = op_acos then RPrim_acos
        elif m = op_asin then RPrim_asin
        elif m = op_atan then RPrim_atan
        elif m = op_atan2 then RPrim_atan2
        elif m = op_ceil then RPrim_ceil
        elif m = op_exp then RPrim_exp
        elif m = op_floor then RPrim_floor
        elif m = op_truncate then RPrim_truncate
        elif m = op_round then RPrim_round
        elif m = op_sign then RPrim_sign
        elif m = op_log then RPrim_log
        elif m = op_log10 then RPrim_log10
        elif m = op_sqrt then RPrim_sqrt
        elif m = op_cos then RPrim_cos
        elif m = op_cosh then RPrim_cosh
        elif m = op_sin then RPrim_sin
        elif m = op_sinh then RPrim_sinh
        elif m = op_tan then RPrim_tan
        elif m = op_tanh then RPrim_tanh
        elif m = op_pow then RPrim_pow
        else RMethod m

    /// Get the lambda value for the method
    let isAbstractSlot (formalEnv, entityR, v: DMemberRef) =
        let paramTysR = resolveTypes (formalEnv, v.ArgTypes)
        let key = (entityR, v.Name, paramTysR)
        dispatchSlots.ContainsKey(key)

    /// Get the lambda value for the method
    let interpMethod (formalEnv, entityR, methodName, paramTys, range: DRange option) =
        let paramTysR = resolveTypes (formalEnv, paramTys)
        let key = (entityR, methodName, paramTysR)
        if not (methodThunks.ContainsKey(key)) then
            match range with
            | None -> failwithf "No member found for key %A" key
            | Some range -> failwithf "No member found for key %A at %A" key range
        let membDef, minfo = methodThunks.[key]
        UMethod(membDef, minfo)

    /// Resolve a method name to a lambda value
    let resolveMethod (v: DMemberRef) (range: DRange option) =
        // TODO: create formal type environment to help resolve overloading by type
        let formalEnv = envEmpty

        match resolveEntity v.Entity with
        // We call the actual method when the thing is a compiled type or we're calling a shell type constructor
        | (REntity (entityType, isShell) as entityR) when not isShell || v.Name = ".ctor" || isAbstractSlot (formalEnv, entityR, v) ->
            let n = v.ArgTypes.Length
            if v.Name = ".ctor" || v.Name = ".cctor" then
                match
                    entityType.GetConstructors(bindAll)
                    |> Array.filter (fun m -> m.Name = v.Name && m.GetParameters().Length = n)
                    with
                | [| cinfo |] -> RMethod cinfo
                | _res ->
                    let (RTypesErased formalEnv paramTysV) = resolveTypes (formalEnv, v.ArgTypes)
                    match entityType.GetConstructor(bindAll, null, paramTysV, null) with
                    | null -> failwithf "couldn't bind constructor %A for %A" v entityType //ctxt.InterpMethod(formalEnv, eR, nm, paramTys)
                    | cinfo -> RMethod cinfo

            else
                match
                    entityType.GetMethods(bindAll)
                    |> Array.filter (fun m -> m.Name = v.Name && m.GetParameters().Length = n)
                    with
                | [| minfo |] -> makeRMethod minfo

                // Handle 
                | [||] when v.Name = "Yield" ->
                    let ms =
                        entityType.GetMethods(bindAll)
                        |> Array.filter (fun m ->
                            let ps = m.GetParameters()
                            m.Name = v.Name && ps.Length = 1 && ps.[0].ParameterType = typeof<unit>
                        )

                    makeRMethod ms.[0]

                | [||] when n = 0 && v.GenericArity = 0 ->
                    // FCS QUIRK TODO: cleanup FCS and portacode so names of properties are never used
                    match entityType.GetProperty(v.Name, bindAll) with
                    | null -> failwithf "couldn't bind method %A for %A" v entityType //ctxt.InterpMethod(formalEnv, eR, nm, paramTys)
                    //| null -> ctxt.InterpMethod(formalEnv, eR, nm, paramTys)
                    | pinfo -> makeRMethod pinfo.GetMethod
                | _res ->
                    let (RTypesErased formalEnv paramTysV) = resolveTypes (formalEnv, v.ArgTypes)
                    match entityType.GetMethod(v.Name, bindAll, null, paramTysV, null) with
                    | null -> failwithf "couldn't bind property %A for %A" v entityType //ctxt.InterpMethod(formalEnv, eR, nm, paramTys)
                    //| null -> ctxt.InterpMethod(formalEnv, eR, nm, paramTys)
                    | minfo -> RMethod minfo

        | entityR -> interpMethod (formalEnv, entityR, v.Name, v.ArgTypes, range)

    let instantiateMethod (minfo: MethodInfo) typeArgs1V typeArgs2V =
        if minfo.DeclaringType.IsGenericType then
            let iminfo = minfo.DeclaringType.MakeGenericType(typeArgs1V)
            match iminfo.GetMethods(bindAll) |> Array.tryFind (fun m -> m.MetadataToken = minfo.MetadataToken) with
            | Some minfo2 -> if minfo.IsGenericMethod then minfo2.MakeGenericMethod(typeArgs1V) else minfo2
            | None -> failwithf "didn't find a matching method for %A with the right token" minfo
        elif minfo.IsGenericMethod then
            minfo.MakeGenericMethod(typeArgs2V)
        else
            minfo

    let rec instantiateType (typeArgs: Type []) (ty: Type) =
        if ty.IsGenericType then
            ty.GetGenericTypeDefinition().MakeGenericType(Array.map (instantiateType typeArgs) (ty.GetGenericArguments()))
        elif ty.IsArray then
            (instantiateType typeArgs (ty.GetElementType())).MakeArrayType(ty.GetArrayRank())
        elif ty.IsByRef then
            (instantiateType typeArgs (ty.GetElementType())).MakeByRefType()
        elif ty.IsPointer then
            (instantiateType typeArgs (ty.GetElementType())).MakePointerType()
        elif ty.IsGenericParameter then
            typeArgs.[ty.GenericParameterPosition]
        else
            ty

    // This is gross. TypeBuilderInstantiation should really be a public type, since we
    // have to use alternative means for various Method/Field/Constructor lookups. However since
    // it isn't we resort to this technique...
    let TypeBuilderInstantiationT =
        let ty = Type.GetType("System.Reflection.Emit.TypeBuilderInstantiation")

        assert (not (isNull ty))
        ty

    let typeIsNotQueryable (ty: Type) =
        (ty :? TypeBuilder) || ((ty.GetType()).Equals(TypeBuilderInstantiationT))

    let getGenericTypeDefinition (ty: Type) =
        if ty.IsGenericType then ty.GetGenericTypeDefinition() else ty

    let instantiateConstructor typeArgsT (cinfo: ConstructorInfo) =
        let parentT = getGenericTypeDefinition cinfo.DeclaringType
        if parentT.IsGenericType then
            let parentTI = parentT.MakeGenericType(typeArgsT)
            if typeIsNotQueryable parentTI then
                let ctorG =
                    parentT.GetConstructors(bindAll)
                    |> Array.find (fun cinfo2 -> cinfo2.MetadataToken = cinfo.MetadataToken)
                TypeBuilder.GetConstructor(parentTI, ctorG)
            else
                parentTI.GetConstructors(bindAll)
                |> Array.find (fun cinfo2 -> cinfo2.MetadataToken = cinfo.MetadataToken)
        else
            cinfo

    member _.InterpretExpressionThunk(thunkId: int, typeArgsV: Type [], argsV: obj []) : obj =
        let fM = shellTypeThunks.[thunkId]
        //if membDef.Name <> "ToString" then
        //   printfn "InterpretExpressionThunk: memberId = %d, typeArgsV=%A, args = %A" memberId typeArgsV argsV
        let (MethodLambdaValue f) = fM
        let res = f (typeArgsV, argsV)
        //if membDef.Name <> "ToString" then
        //   printfn "InterpretExpressionThunk:res = %A" res
        //if membDef.Name <> "ToString" then
        //    sink.NotifyCallAndReturn(None (* no caller references available for these invokes *), Choice2Of2 membDef, typeArgsV, argsV, Value res)
        res


    /// Dynamically emit "shell" .NET type definitions for types with include thunks for any
    /// virtual methods and interface implementations, and constructors to actually make an object of the
    /// correct type.
    member ctxt.EmitShellTypes(decls: DDecl []) =
        let asmB = AssemblyBuilder.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run)
        let modB = asmB.DefineDynamicModule("Module")

        let shellTypeConstructorBuilders = Dictionary<DMemberRef, (ConstructorBuilder * Type [])>(HashIdentity.Structural)
        let shellTypeMethodBuilders =
            Dictionary<DMemberRef, (MethodBuilder * Type [] * Type)>(HashIdentity.Structural)
        let shellTypeEntityInfo = Dictionary<DEntityRef, DEntityDef>(HashIdentity.Structural)

        // Store the returning context in a static field of each generated type
        let ctxtTypB = modB.DefineType("$ctxt")
        let ctxtFld =
            ctxtTypB.DefineField("$ctxt", typeof<EvalContext>, FieldAttributes.Static ||| FieldAttributes.Public)
        let ctxtTypeInfo = ctxtTypB.CreateTypeInfo()
        ctxtTypeInfo.GetField("$ctxt").SetValue(null, ctxt)

        // TODO: emitting shell types for union and record types requires us to add all the
        // attributes generated by the F# compiler for those kinds of types.
        // These are not reported to us by FCS
        let canEmitShellType (entityDef: DEntityDef) =
            not (entityDef.IsUnion || entityDef.IsRecord || entityDef.IsStruct)

        let canEmitShellMethod (membDef: DMemberDef) =
            shellTypeEntityInfo.ContainsKey(membDef.EnclosingEntity)

        let defineGenericParamaterConstraints env (gpBs: Type []) (gps: DGenericParameterDef []) =
            let gpBs = [| for p in gpBs -> p :?> GenericTypeParameterBuilder |]
            for (gp, gpB) in Array.zip gps gpBs do
                let attrs =
                    (if gp.NotNullableValueTypeConstraint then
                         GenericParameterAttributes.NotNullableValueTypeConstraint
                     else
                         enum 0)
                    ||| (if gp.ReferenceTypeConstraint then
                             GenericParameterAttributes.ReferenceTypeConstraint
                         else
                             enum 0)
                    ||| (if gp.DefaultConstructorConstraint then
                             GenericParameterAttributes.DefaultConstructorConstraint
                         else
                             enum 0)
                gpB.SetGenericParameterAttributes(attrs)
                gpB.SetInterfaceConstraints [|
                    for ty in gp.InterfaceConstraints -> let (RTypeErased env t) = resolveType (env, ty) in t
                |]
                match gp.BaseTypeConstraint with
                | None -> ()
                | Some ty -> gpB.SetBaseTypeConstraint(let (RTypeErased env t) = resolveType (env, ty) in t)

        //printfn "defining types..."
        let rec phase1 emit (decls, encTypB: TypeBuilder option) =
            for decl in decls do
                match decl with
                | DDeclEntity (entityDef, subDecls) ->
                    if emit && canEmitShellType entityDef then
                        let attr =
                            (if entityDef.IsInterface then
                                 TypeAttributes.Interface ||| TypeAttributes.Abstract
                             else
                                 enum<_> (0))
                            ||| (if encTypB.IsNone then TypeAttributes.Public else TypeAttributes.NestedPublic)
                            ||| (TypeAttributes.AutoClass)
                            ||| (TypeAttributes.AnsiClass)
                            ||| (TypeAttributes.Serializable)
                            ||| (if entityDef.CustomAttributes
                                    |> Array.exists (fun ca ->
                                        let (DEntityRef (typeName)) = ca.AttributeType
                                        typeName.Contains("Microsoft.FSharp.Core.AbstractClassAttribute")
                                    ) then
                                     TypeAttributes.Abstract
                                 else
                                     enum<_> (0))
                        let typB =
                            match encTypB with
                            | None -> modB.DefineType(entityDef.Name, attr)
                            | Some tB -> tB.DefineNestedType(entityDef.Name, attr)
                        let entityRef = entityDef.Ref
                        shellTypeEntityInfo.[entityRef] <- entityDef
                        entityResolutions.[entityRef] <- REntity(typB, true)
                        if entityDef.GenericParameters.Length > 0 then
                            typB.DefineGenericParameters [|
                                for gp in entityDef.GenericParameters -> gp.Name
                            |]
                            |> ignore

                        phase1 emit (subDecls, Some typB)
                    else
                        entityResolutions.[entityDef.Ref] <- UEntity entityDef
                        phase1 false (subDecls, None)
                | _ -> ()
        phase1 true (decls, None)

        let enterTypeDef (entityDef: DEntityDef) =
            let (TypeBuilderOrFail typB) = entityResolutions.[entityDef.Ref]
            let env =
                (envEmpty, entityDef.GenericParameters, (if typB.IsGenericTypeDefinition then typB.GetGenericArguments() else [||]))
                |||> Array.fold2 bindType
            typB, env

        //printfn "defining generic parameters..."
        let rec phase1b decls =
            for decl in decls do
                match decl with
                | DDeclEntity (entityDef, subDecls) ->
                    if canEmitShellType entityDef then
                        let (TypeBuilderOrFail typB) = entityResolutions.[entityDef.Ref]
                        let typB, env = enterTypeDef entityDef
                        if entityDef.GenericParameters.Length > 0 then
                            defineGenericParamaterConstraints env (typB.GetGenericArguments()) entityDef.GenericParameters
                        phase1b (subDecls)
                | _ -> ()
        phase1b decls

        let buildCustomAttribute range (attr: DCustomAttributeDef) =
            let ctorRef =
                {
                    Entity = attr.AttributeType
                    Name = ".ctor"
                    GenericArity = 0
                    ArgTypes = Array.map fst attr.ConstructorArguments
                    ReturnType = DType.DNamedType(attr.AttributeType, [||])
                }
            let ctor =
                match shellTypeConstructorBuilders.TryGetValue(ctorRef) with
                | true, (v, _) -> (v :> ConstructorInfo)
                | _ ->
                    match resolveMethod ctorRef range with
                    | RMethod (:? ConstructorInfo as ctor) -> ctor
                    | _ -> failwith "unexpected: couldn't resolve ctor"

            let ctorArgs = Array.map snd attr.ConstructorArguments
            let props =
                attr.NamedArguments
                |> Array.filter (fun (_, _, isProp, _) -> isProp)
                |> Array.map (fun (_, nm, _, _) -> ctor.DeclaringType.GetProperty(nm))
            let propVals =
                attr.NamedArguments
                |> Array.filter (fun (_, _, isProp, _) -> isProp)
                |> Array.map (fun (_, _, _, v) -> v)
            let flds =
                attr.NamedArguments
                |> Array.filter (fun (_, _, isProp, _) -> not isProp)
                |> Array.map (fun (_, nm, _, _) -> ctor.DeclaringType.GetField(nm))
            let fldVals =
                attr.NamedArguments
                |> Array.filter (fun (_, _, isProp, _) -> not isProp)
                |> Array.map (fun (_, _, _, v) -> v)
            let cb = CustomAttributeBuilder(ctor, ctorArgs, props, propVals, flds, fldVals)
            cb

        let buildCustomAttributes range (attrs: DCustomAttributeDef []) f =
            Array.iter (buildCustomAttribute range >> f) attrs

        //printfn "defining base type and define the interfaces..."
        /// Set the base type and define the interfaces
        let rec phase2 (decls: DDecl []) =
            for decl in decls do
                match decl with
                | DDeclEntity (entityDef, subDecls) when canEmitShellType entityDef ->
                    let typB, env = enterTypeDef entityDef
                    if not entityDef.IsInterface then
                        match entityDef.BaseType with
                        | None -> ()
                        | Some b ->
                            let (RTypeErased env t) = resolveType (env, b)
                            typB.SetParent(t)

                    for i in entityDef.DeclaredInterfaces do
                        let (RTypeErased env t) = resolveType (env, i)
                        typB.AddInterfaceImplementation(t)

                    buildCustomAttributes entityDef.Range entityDef.CustomAttributes typB.SetCustomAttribute
                    phase2 (subDecls)
                | _ -> ()
        phase2 (decls)


        //printfn "defining define the virtual methods and fields..."

        /// Define the methods
        let rec phase3 (decls: DDecl []) =
            for decl in decls do
                match decl with
                | DDeclEntity (entityDef, subDecls) when canEmitShellType entityDef ->
                    let typB, env = enterTypeDef entityDef
                    for f in entityDef.DeclaredFields do
                        let (RTypeErased env ft) = resolveType (env, f.FieldType)
                        let attrs =
                            (FieldAttributes.Public ||| (if f.IsStatic then FieldAttributes.Static else enum 0))
                        typB.DefineField(f.Name, ft, attrs) |> ignore
                        // Record the DFieldDef so we can report get/sets of it to the sink
                        fieldDefMap.[(entityDef.QualifiedName, f.Name)] <- f

                    for membDef in entityDef.DeclaredDispatchSlots do
                        let cconv = CallingConventions.HasThis
                        let attrs =
                            MethodAttributes.Public
                            ||| MethodAttributes.Virtual
                            ||| MethodAttributes.Abstract
                            ||| MethodAttributes.HideBySig

                        let membRef = membDef.Ref
                        let paramTypes = membDef.Parameters |> Array.map (fun p -> p.LocalType)
                        let paramTypesR = resolveTypes (env, paramTypes)
                        let (RTypesErased env paramTypesT) = paramTypesR
                        let (RTypeErased env returnTypeT) = resolveType (env, membDef.ReturnType)
                        let mB = typB.DefineMethod(membDef.Name, attrs, cconv, returnTypeT, paramTypesT)

                        // Define the generic parameters on the method
                        if membDef.GenericParameters.Length > 0 then
                            mB.DefineGenericParameters [|
                                for gp in membDef.GenericParameters -> gp.Name
                            |]
                            |> ignore

                            let env =
                                (env, membDef.GenericParameters, mB.GetGenericArguments()) |||> Array.fold2 bindType
                            defineGenericParamaterConstraints env (mB.GetGenericArguments()) membDef.GenericParameters

                        for (i, pn) in Array.indexed membDef.Parameters do
                            mB.DefineParameter(i + 1, ParameterAttributes.None, pn.Name) |> ignore

                        shellTypeMethodBuilders.[membRef] <- (mB, paramTypesT, returnTypeT)

                    //// Inject the compilation of the union type
                    //if entityDef.IsUnion then
                    //    let c = typeof<CompilationMappingAttribute>.GetConstructor([| typeof<SourceConstructFlags> |])
                    //    let cattr = CustomAttributeBuilder(c, [| SourceConstructFlags.SumType|])
                    //    typB.SetCustomAttribute(cattr)
                    //if entityDef.IsRecord then
                    //    let c = typeof<CompilationMappingAttribute>.GetConstructor([| typeof<SourceConstructFlags> |])
                    //    let cattr = CustomAttributeBuilder(c, [| SourceConstructFlags.RecordType|])
                    //    typB.SetCustomAttribute(cattr)
                    phase3 (subDecls)
                | DDeclMember (membDef, _body, _isLiveCheck) when canEmitShellMethod membDef ->
                    let membRef = membDef.Ref
                    let entityDef = shellTypeEntityInfo.[membDef.EnclosingEntity]
                    let typB, env = enterTypeDef entityDef
                    let paramTypes = membDef.Parameters |> Array.map (fun p -> p.LocalType)
                    let paramTypesR = resolveTypes (env, paramTypes)
                    let (RTypesErased env paramTypesT) = paramTypesR
                    let (RTypeErased env returnTypeT) = resolveType (env, membDef.ReturnType)
                    let returnTypeT = (if returnTypeT = typeof<unit> then typeof<Void> else returnTypeT)
                    if membDef.Name = ".ctor" then

                        // Strip off the call to the base class constructor and emit it in compiled code
                        // since we can't interpret that
                        //
                        // TODO : base ctor calls must currently take no arguments (since we
                        // don't have an expression compiler - we could interpret these)
                        let attrs = MethodAttributes.Public
                        let cB = typB.DefineConstructor(attrs, CallingConventions.Standard, paramTypesT)
                        for (i, pn) in Array.indexed membDef.Parameters do
                            cB.DefineParameter(i + 1, ParameterAttributes.None, pn.Name) |> ignore
                        shellTypeConstructorBuilders.[membRef] <- (cB, paramTypesT)
                    else

                        let cconv =
                            (if membDef.IsInstance then
                                 CallingConventions.HasThis
                             else
                                 CallingConventions.Standard)
                        let isIntfImpl =
                            membDef.ImplementedSlots
                            |> Array.exists (fun slot ->
                                let (RTypeErased env slotDeclType) = resolveType (env, slot.DeclaringType)
                                slotDeclType.IsInterface
                            )
                        let isVirtualSlot = membDef.ImplementedSlots.Length > 0 && not isIntfImpl

                        let attrs =
                            if isIntfImpl then
                                MethodAttributes.Private
                                ||| MethodAttributes.Virtual
                                ||| MethodAttributes.HideBySig
                                ||| MethodAttributes.NewSlot
                                ||| MethodAttributes.Final
                            elif isVirtualSlot then
                                MethodAttributes.Public ||| MethodAttributes.Virtual ||| MethodAttributes.HideBySig
                            else
                                MethodAttributes.Public
                                ||| MethodAttributes.HideBySig
                                ||| (if membDef.IsInstance then enum 0 else MethodAttributes.Static)

                        let mB = typB.DefineMethod(membDef.Name, attrs, cconv, returnTypeT, paramTypesT)

                        // Define the generic parameters on the method
                        if membDef.GenericParameters.Length > 0 then
                            mB.DefineGenericParameters [|
                                for gp in membDef.GenericParameters -> gp.Name
                            |]
                            |> ignore

                            let env =
                                (env, membDef.GenericParameters, mB.GetGenericArguments()) |||> Array.fold2 bindType
                            defineGenericParamaterConstraints env (mB.GetGenericArguments()) membDef.GenericParameters

                        for (i, pn) in Array.indexed membDef.Parameters do
                            mB.DefineParameter(i + 1, ParameterAttributes.None, pn.Name) |> ignore

                        shellTypeMethodBuilders.[membRef] <- (mB, paramTypesT, returnTypeT)
                | _ -> ()
        phase3 (decls)

        let EmitInterpretExpression
            (
                ilg: ILGenerator,
                gps: DGenericParameterDef [],
                gpTys: Type [],
                isCaptureThis,
                isInstanceCtxt,
                ps: DLocalDef [],
                paramTypesT: Type [],
                thisTypeB: Type,
                exprT: Type,
                body: DExpr
            )
            =
            shellTypeThunkCount <- shellTypeThunkCount + 1
            let thunkId = shellTypeThunkCount
            ilg.Emit(OpCodes.Ldsfld, ctxtFld)
            ilg.Emit(OpCodes.Ldc_I4, thunkId)

            assert (gps.Length = gpTys.Length)
            // Create the array of type arguments
            ilg.Emit(OpCodes.Ldc_I4, gpTys.Length)
            ilg.Emit(OpCodes.Newarr, typeof<obj>)
            for i in 0 .. gpTys.Length - 1 do
                ilg.Emit(OpCodes.Dup)
                ilg.Emit(OpCodes.Ldc_I4, i)
                ilg.Emit(OpCodes.Ldtoken, gpTys.[i])
                let meth = typeof<System.Type>.GetMethod ("GetTypeFromHandle")
                ilg.Emit(OpCodes.Call, meth)
                ilg.Emit(OpCodes.Stelem_Ref)

            // Create the array of 'this' plus arguments
            let argAdjust = (if isInstanceCtxt then 1 else 0)
            let arrAdjust = (if isCaptureThis then 1 else 0)
            ilg.Emit(OpCodes.Ldc_I4, paramTypesT.Length + arrAdjust)
            ilg.Emit(OpCodes.Newarr, typeof<obj>)

            // Capture the this
            if isCaptureThis then
                ilg.Emit(OpCodes.Dup)
                ilg.Emit(OpCodes.Ldc_I4, 0)
                ilg.Emit(OpCodes.Ldarg, 0)
                if thisTypeB.IsValueType then ilg.Emit(OpCodes.Box, thisTypeB)
                ilg.Emit(OpCodes.Stelem_Ref)
            for i in 0 .. paramTypesT.Length - 1 do
                ilg.Emit(OpCodes.Dup)
                ilg.Emit(OpCodes.Ldc_I4, i + arrAdjust)
                ilg.Emit(OpCodes.Ldarg, i + argAdjust)
                if paramTypesT.[i].IsValueType || paramTypesT.[i].IsGenericParameter then
                    ilg.Emit(OpCodes.Box, paramTypesT.[i])
                ilg.Emit(OpCodes.Stelem_Ref)

            // call the interpreter
            ilg.Emit(OpCodes.Call, typeof<EvalContext>.GetMethod ("InterpretExpressionThunk"))
            if exprT = typeof<Void> then
                ilg.Emit(OpCodes.Pop)
            elif exprT.IsValueType || exprT.IsGenericParameter then
                ilg.Emit(OpCodes.Unbox_Any, exprT)

            let thunk = ctxt.EvalMethodLambda(envEmpty, false, isCaptureThis, gps, ps, body)
            shellTypeThunks.[thunkId] <- thunk

        /// Fill in the body of the constructors and virtual/interface method stubs
        let rec phase4 (decls: DDecl []) =
            for decl in decls do
                match decl with
                | DDeclEntity (_entityDef, subDecls) -> phase4 (subDecls)
                | DDeclMember (membDef, body, _isLiveCheck) when canEmitShellMethod membDef ->
                    let membRef = membDef.Ref
                    let entityDef = shellTypeEntityInfo.[membDef.EnclosingEntity]
                    let typB, env = enterTypeDef entityDef
                    if membDef.Name = ".ctor" then
                        let mB, paramTypesT = shellTypeConstructorBuilders.[membRef]
                        let gpTys = typB.GetGenericArguments()

                        // Strip off the call to the base class constructor and emit it in compiled code
                        let ilg = mB.GetILGenerator()

                        // Check if this ctor has a base class constructor or self constructor
                        let baseCtor, baseCtorTypeArgs, baseCtorArgs, initCode =
                            match body with
                            // base calls without arguments
                            | DExpr.Sequential (DExpr.Call (None, baseCtor, baseCtorTypeArgs, [||], baseCtorArgs, _), initCode, _) ->
                                baseCtor, baseCtorTypeArgs, baseCtorArgs, initCode
                            | DExpr.Sequential (DExpr.NewObject (baseCtor, baseCtorTypeArgs, baseCtorArgs, _), initCode, _) ->
                                baseCtor, baseCtorTypeArgs, baseCtorArgs, initCode
                            // self-init calls
                            | DExpr.Call (None, baseCtor, baseCtorTypeArgs, [||], baseCtorArgs, _) -> baseCtor, baseCtorTypeArgs, baseCtorArgs, body
                            | _ -> failwithf "TODO: unknown constructor body %A" body

                        let baseCtorInfo, baseCtorParamTypes =
                            match shellTypeConstructorBuilders.TryGetValue(baseCtor) with
                            | true, (v, baseCtorParamTypes) -> ((v :> ConstructorInfo), baseCtorParamTypes)
                            | _ ->
                                match resolveMethod baseCtor membDef.Range with
                                | RMethod (:? ConstructorInfo as baseCtorInfo) ->
                                    baseCtorInfo, (baseCtorInfo.GetParameters() |> Array.map (fun p -> p.ParameterType))
                                | _ -> failwith "unexpected: couldn't resolve ctor"
                        let (RTypesErased env baseCtorTypeArgsT) = resolveTypes (env, baseCtorTypeArgs)
                        let ibaseCtorInfo = instantiateConstructor baseCtorTypeArgsT baseCtorInfo
                        let ibaseCtorParamTypes = baseCtorParamTypes |> Array.map (instantiateType baseCtorTypeArgsT)

                        ilg.Emit(OpCodes.Ldarg, 0)
                        // The arguments to the constructor are evaluated in the interpreter
                        for (baseCtorArg, baseCtorParamType) in Array.zip baseCtorArgs ibaseCtorParamTypes do
                            EmitInterpretExpression(
                                ilg,
                                entityDef.GenericParameters,
                                gpTys,
                                false,
                                true,
                                membDef.Parameters,
                                paramTypesT,
                                typB,
                                baseCtorParamType,
                                baseCtorArg
                            )

                        ilg.Emit(OpCodes.Call, ibaseCtorInfo)

                        EmitInterpretExpression(
                            ilg,
                            entityDef.GenericParameters,
                            gpTys,
                            true,
                            true,
                            membDef.Parameters,
                            paramTypesT,
                            typB,
                            typeof<Void>,
                            initCode
                        )

                        ilg.Emit(OpCodes.Ret)

                        buildCustomAttributes membDef.Range membDef.CustomAttributes mB.SetCustomAttribute

                    else
                        let mB, paramTypesT, returnTypeT = shellTypeMethodBuilders.[membRef]
                        let gpTys = Array.append (typB.GetGenericArguments()) (mB.GetGenericArguments())
                        let env =
                            (env, membDef.GenericParameters, mB.GetGenericArguments()) |||> Array.fold2 bindType
                        let ilg = mB.GetILGenerator()
                        EmitInterpretExpression(
                            ilg,
                            Array.append entityDef.GenericParameters membDef.GenericParameters,
                            gpTys,
                            membDef.IsInstance,
                            membDef.IsInstance,
                            membDef.Parameters,
                            paramTypesT,
                            typB,
                            returnTypeT,
                            body
                        )
                        ilg.Emit(OpCodes.Ret)

                        // Emit the method overrides
                        for slot in membDef.ImplementedSlots do
                            let slotR =
                                match shellTypeMethodBuilders.TryGetValue(slot.Member) with
                                | true, (v, _, _) -> (v :> MethodInfo)
                                | _ ->
                                    match resolveMethod slot.Member membDef.Range with
                                    | RMethod (:? MethodInfo as minfo) -> minfo
                                    | _ -> failwith "unexpected: couldn't resolve slot"
                            let (RTypeErased env slotDeclType) = resolveType (env, slot.DeclaringType)
                            if slotDeclType.IsInterface then
                                let methArgs = if slotR.IsGenericMethod then slotR.GetGenericArguments() else [||]
                                let slotV = instantiateMethod slotR slotDeclType.GenericTypeArguments methArgs
                                //let slotV2 = typeof<obj>.GetMethod("ToString")
                                //printfn "\nslot.Name = %s, mB = %A, slotV = %A, returnTypeT = %A\n\n" slot.Member.Name mB slotV returnTypeT
                                //printfn "\nslotV2 = %A, (slotV = slotV2) = %b\n\n" slotV2 (slotV = slotV2)
                                typB.DefineMethodOverride(mB, slotV)

                        buildCustomAttributes membDef.Range membDef.CustomAttributes mB.SetCustomAttribute

                | _ -> ()
        phase4 (decls)
        let rec phaseFinal (decls) =
            for decl in decls do
                match decl with
                | DDeclEntity (entityDef, subDecls) when canEmitShellType entityDef ->
                    let typB, _env = enterTypeDef entityDef
                    let typInfo = typB.CreateTypeInfo()
                    entityResolutions.[entityDef.Ref] <- REntity(typInfo.AsType(), true)

                    phaseFinal (subDecls)
                | _ -> ()
        phaseFinal (decls)

    /// Add the declarations for the types and methods
    member ctxt.AddDecls(decls: DDecl []) =

        if dyntypes then ctxt.EmitShellTypes(decls)

        let env = envEmpty
        let rec loop decls =
            for decl in decls do
                match decl with
                | DDeclEntity (entityDef, subDecls) ->
                    // Add any types not emitted as shell types
                    if not (entityResolutions.ContainsKey(entityDef.Ref)) then
                        entityResolutions.[entityDef.Ref] <- UEntity entityDef

                    for membDef in entityDef.DeclaredDispatchSlots do
                        let ty = resolveEntity (membDef.EnclosingEntity)
                        let paramTypes = membDef.Parameters |> Array.map (fun p -> p.LocalType)
                        let paramTypesR = resolveTypes (env, paramTypes)
                        dispatchSlots.[(ty, membDef.Name, paramTypesR)] <- true
                    loop subDecls

                | DDeclMember (membDef, body, _isLiveCheck) ->
                    let ty = resolveEntity (membDef.EnclosingEntity)
                    let paramTypes = membDef.Parameters |> Array.map (fun p -> p.LocalType)
                    let paramTypesR = resolveTypes (env, paramTypes)
                    let body2 =
                        if membDef.IsValueDef then
                            // augment lazy init of values with a ValueSet saving their result
                            let loc =
                                {
                                    Name = "tmp3245"
                                    IsMutable = false
                                    LocalType = DType.DVariableType "?"
                                    Range = None
                                    IsCompilerGenerated = true
                                }
                            let locRef =
                                {
                                    Name = "tmp3245"
                                    IsMutable = false
                                    IsThisValue = false
                                    IsCompilerGenerated = true
                                    Range = None
                                }
                            DExpr.Let(
                                (loc, body),
                                DExpr.Sequential(DExpr.ValueSet(Choice2Of2 membDef.Ref, DExpr.Value locRef, None), DExpr.Value locRef, membDef.Range)
                            )
                        else
                            body
                    let thunk =
                        ctxt.EvalMethodLambda(
                            envEmpty,
                            (membDef.Name = ".ctor"),
                            membDef.IsInstance,
                            membDef.GenericParameters,
                            membDef.Parameters,
                            body2
                        )
                    methodThunks.[(ty, membDef.Name, paramTypesR)] <- (membDef, Value thunk)

                | _ -> ()
        loop decls

    member ctxt.EvalMethodLambda(env, isCtor, isInstance, gps: DGenericParameterDef [], parameters: DLocalDef [], bodyExpr) =
        MethodLambdaValue(
            FuncConvert.FromFunc<Type [] * obj [], obj>(fun (tyargs, args) ->
                assert (gps.Length = tyargs.Length)
                let adjustedArgs = (if isInstance then args.[1..] else args)
                assert (parameters.Length = adjustedArgs.Length)
                if parameters.Length + (if isInstance then 1 else 0) <> args.Length then
                    failwithf "arg/parameter mismatch for method with arguments %A" parameters
                let env = if isInstance then bindByName env "$this" (Value args.[0]) else env
                let env =
                    (env, parameters, adjustedArgs) |||> Array.fold2 (fun env p a -> bind sink env p (Value a))
                let env = (env, gps, tyargs) |||> Array.fold2 bindType
                if isCtor then
                    let objV = Value null
                    let env = bindByName env "$this" objV
                    ctxt.EvalExpr(env, bodyExpr) |> ignore
                    box objV.Value
                else
                    let retV = ctxt.EvalExpr(env, bodyExpr) |> getVal
                    box retV
            )
        )

    member ctxt.TryEvalExpr(env, expr, range) =
        try
            protectEval false range (fun () -> ctxt.EvalExpr(env, expr)) |> Ok
        with
            | exn -> exn |> Error

    /// Try to evaluate the declarations, collecting errors and optimisitically continuing
    /// as we go.  Optionally evaluate only the ones marked with the [<LiveCheck>] attribute,
    /// in which case execution is done on-demand.
    member ctxt.TryEvalDecls(env, decls: DDecl [], ?evalLiveChecksOnly: bool) =
        let evalLiveChecksOnly = defaultArg evalLiveChecksOnly false
        let rec loop decls =
            [|
                for d in decls do
                    match d with
                    | DDeclEntity (entity, subDecls) ->
                        let entityR = resolveEntity (entity.Ref)
                        match entityR with
                        | REntity (targetType, _) ->
                            let entityDecls =
                                [|
                                    for meth in decls do
                                        match meth with
                                        | DDeclMember (membDef, _body, _isLiveCheck) ->
                                            match meth with
                                            | DDeclMember (membDef, body, isLiveCheck) ->
                                                let methParent = resolveEntity (membDef.EnclosingEntity)
                                                match methParent with
                                                | REntity (targetType2, _) when targetType = targetType2 -> yield membDef, body
                                                | _ -> ()
                                            | _ -> ()
                                        | _ -> ()

                                |]
                            yield! sink.NotifyEstablishEntityDecl(entity, entityR, entityDecls)
                        | _ -> ()
                        yield! loop subDecls

                    | DDeclMember (membDef, body, isLiveCheck) ->
                        if (membDef.IsValueDef && not evalLiveChecksOnly)
                           || (isLiveCheck && (membDef.IsValueDef || membDef.Parameters.Length = 0)) then
                            let ty = resolveEntity (membDef.EnclosingEntity)
                            let res = ctxt.TryEvalExpr(env, body, membDef.Range)
                            match res with
                            | Ok res ->
                                sink.NotifyBindValue(membDef, res)
                                methodThunks.[(ty, membDef.Name, RTypes [||])] <- (membDef, res)
                            | Error err -> yield DiagnosticFromException err

                    | DDecl.InitAction (expr, range) ->
                        if not evalLiveChecksOnly then
                            let res = ctxt.TryEvalExpr(env, expr, range)
                            match res with
                            | Ok res -> ()
                            | Error err -> yield DiagnosticFromException err
            |]
        loop decls

    /// Evalaute all the declarations using regular F# semantics
    member ctxt.EvalDecls(env, decls: DDecl []) =
        for d in decls do
            match d with
            | DDeclEntity (_e, subDecls) -> ctxt.EvalDecls(env, subDecls)
            | DDeclMember (membDef, body, _isLiveCheck) ->
                if membDef.IsValueDef then
                    let ty = resolveEntity (membDef.EnclosingEntity)
                    let res = ctxt.EvalExpr(env, body)
                    methodThunks.[(ty, membDef.Name, RTypes [||])] <- (membDef, res)
            | DDecl.InitAction (expr, range) -> ctxt.EvalExpr(env, expr) |> ignore

    member _.GetExprDeclResult(ty, memberName) = methodThunks.[(ty, memberName, RTypes [||])]

    member ctxt.EvalExpr(env, expr: DExpr) : Value =
        match expr with
        | DExpr.Application (funcExpr, typeArgs, argExprs, range) ->
            protectEval false range (fun () -> ctxt.EvalApplication(env, funcExpr, typeArgs, argExprs))

        | DExpr.Call (objExprOpt, memberOrFunc, typeArgs1, typeArgs2, argExprs, range) ->
            // don't add stack frams for 'a |> f'
            // TODO: think how to generalize this
            let noProtect = memberOrFunc.Name.Contains("op_PipeRight")
            protectEval noProtect range (fun () -> ctxt.EvalCall(env, objExprOpt, memberOrFunc, typeArgs1, typeArgs2, argExprs, range))

        | DExpr.Coerce (targetType, inpExpr) -> ctxt.EvalExpr(env, inpExpr)

        | DExpr.Lambda (domainTy, rangeTy, lambdaVar, bodyExpr) -> ctxt.EvalLambda(env, domainTy, rangeTy, lambdaVar, bodyExpr)

        | DExpr.TypeLambda (genericParams, bodyExpr) -> ctxt.EvalTypeLambda(env, genericParams, bodyExpr)

        | DExpr.Let ((bindingVar, bindingExpr), bodyExpr) -> ctxt.EvalLet(env, (bindingVar, bindingExpr), bodyExpr)

        | DExpr.LetRec (recursiveBindings, bodyExpr) -> ctxt.EvalLetRec(env, recursiveBindings, bodyExpr)

        | DExpr.NewObject (objCtor, typeArgs, argExprs, range) -> ctxt.EvalNewObject(env, objCtor, typeArgs, argExprs, range)

        | DExpr.NewDelegate (ty, expr) -> ctxt.EvalNewDelegate(env, ty, expr)

        | DExpr.NewRecord (recordType, argExprs, range) -> ctxt.EvalNewRecord(env, recordType, argExprs, range)

        | DExpr.NewAnonRecord (fieldRefs, argExprs, range) -> ctxt.EvalNewAnonRecord(env, fieldRefs, argExprs, range)

        | DExpr.NewUnionCase (unionType, unionCase, argExprs, range) -> ctxt.EvalNewUnionCase(env, unionType, unionCase, argExprs, range)

        | DExpr.FSharpFieldGet (objExprOpt, recordOrClassType, fieldInfo, range) ->
            ctxt.EvalFieldGet(env, objExprOpt, recordOrClassType, fieldInfo, range)

        | DExpr.AnonRecordGet (objExpr, fieldRef, range) -> ctxt.EvalAnonRecordGet(env, objExpr, fieldRef, range)

        | DExpr.FSharpFieldSet (objExprOpt, recordOrClassType, fieldInfo, argExpr, _range) ->
            ctxt.EvalFieldSet(env, objExprOpt, recordOrClassType, fieldInfo, argExpr)

        | DExpr.ILFieldGet (objExprOpt, fieldType, fieldName) -> ctxt.EvalILFieldGet(env, objExprOpt, fieldType, fieldName)

        | DExpr.NewTuple (tupleType, argExprs) -> ctxt.EvalNewTuple(env, tupleType, argExprs)

        | DExpr.DecisionTree (decisionExpr, decisionTargets) -> ctxt.EvalDecisionTree(env, decisionExpr, decisionTargets)

        | DExpr.DecisionTreeSuccess (decisionTargetIdx, decisionTargetExprs) ->
            ctxt.EvalDecisionTreeSuccess(env, decisionTargetIdx, decisionTargetExprs)

        | DExpr.Sequential (firstExpr, secondExpr, range) -> ctxt.EvalSequential(env, firstExpr, secondExpr, range)

        | DExpr.NewArray (arrayType, argExprs) -> ctxt.EvalNewArray(env, arrayType, argExprs)

        | DExpr.IfThenElse (guardExpr, thenExpr, elseExpr) -> ctxt.EvalIfThenElse(env, guardExpr, thenExpr, elseExpr)

        | DExpr.TryFinally (bodyExpr, finallyExpr) -> ctxt.EvalTryFinally(env, bodyExpr, finallyExpr)

        | DExpr.TupleGet (_tupleType, tupleElemIndex, tupleExpr) -> ctxt.EvalTupleGet(env, tupleElemIndex, tupleExpr)

        | DExpr.TryWith (bodyExpr, filterVar, filterExpr, catchVar, catchExpr) ->
            ctxt.EvalTryWith(env, bodyExpr, filterVar, filterExpr, catchVar, catchExpr)

        | DExpr.WhileLoop (guardExpr, bodyExpr) -> ctxt.EvalWhileLoop(env, guardExpr, bodyExpr)

        | DExpr.UnionCaseTest (unionExpr, unionType, unionCase) -> ctxt.EvalUnionCaseTest(env, unionExpr, unionType, unionCase)

        | DExpr.UnionCaseGet (unionExpr, unionType, unionCase, unionCaseField) ->
            ctxt.EvalUnionCaseGet(env, unionExpr, unionType, unionCase, unionCaseField)

        | DExpr.UnionCaseTag (unionExpr, unionType) -> ctxt.EvalUnionCaseTag(env, unionExpr, unionType)

        | DExpr.TypeTest (ty, inpExpr) -> ctxt.EvalTypeTest(env, ty, inpExpr)

        | DExpr.DefaultValue defaultType -> ctxt.EvalDefaultValue(env, defaultType)

        | DExpr.AddressOf (lvalueExpr) ->
            // Note, we use copy-in, copy-oput for byref arguments
            ctxt.EvalExpr(env, lvalueExpr)

        | DExpr.FastIntegerForLoop (startExpr, limitExpr, consumeExpr, isUp) ->
            let start = ctxt.EvalExpr(env, startExpr).Value :?> int
            let limi = ctxt.EvalExpr(env, limitExpr).Value :?> int
            let bodyf = ctxt.EvalExpr(env, consumeExpr).Value
            for i in start .. limi do
                bodyf.GetType().GetMethod("Invoke").Invoke(bodyf, [| box i |]) |> ignore
            Value null
        (*
// TODO:
        // Need more work:
        | DExpr.Quote(quotedExpr) -> ctxt.EvalQuote(convExpr quotedExpr)

        // Not really possible:
        | DExpr.AddressSet(lvalueExpr, rvalueExpr) -> ctxt.EvalAddressSet(convExpr lvalueExpr, convExpr rvalueExpr)
        | DExpr.ObjectExpr(objType, baseCallExpr, overrides, interfaceImplementations) -> ctxt.EvalObjectExpr(convType objType, convExpr baseCallExpr, List.map convObjMember overrides, List.map (map2 convType (List.map convObjMember)) interfaceImplementations)

        // Library only:
        | DExpr.UnionCaseSet(unionExpr, unionType, unionCase, unionCaseField, valueExpr) -> ctxt.EvalUnionCaseSet(convExpr unionExpr, convType unionType, convUnionCase unionCase, convField unionCaseField, convExpr valueExpr)
        | DExpr.ILAsm(asmCode, typeArgs, argExprs) -> ctxt.EvalILAsm(asmCode, convTypes typeArgs, convExprs argExprs)

        // Very rare:
        | DExpr.ILFieldSet (objExprOpt, fieldType, fieldName, valueExpr) -> ctxt.EvalILFieldSet (convExprOpt objExprOpt, convType fieldType, fieldName, convExpr valueExpr)
*)

        | DExpr.TraitCall (sourceTypes, traitName, isInstance, _typeInstantiation, argTypes, argExprs, range) ->
            protectEval false range (fun () -> ctxt.EvalTraitCall(env, traitName, sourceTypes, isInstance, argTypes, argExprs))

        | DExpr.BaseValue thisType

        | DExpr.ThisValue thisType ->
            match env.Vals.TryGetValue "$this" with
            | true, (Value null as res) when
                (match thisType with
                 | DType.DByRefType _ -> true
                 | _ -> false)
                ->
                // Structs don't call the System.Object() base constructor
                res.Value <- new System.Object()
                res
            | true, res -> res
            | _ -> failwithf "didn't find this value in the environment"

        | DExpr.Value (vref) ->
            let res =
                if vref.IsThisValue then
                    match env.Vals.TryGetValue "$this" with
                    | true, res -> res
                    | _ -> failwithf "didn't find this value in the environment at %A" vref.Range
                elif vref.IsMutable then
                    match env.Vals.TryGetValue vref.Name with
                    | true, rv -> Value rv.Value
                    | _ -> failwithf "didn't find mutable value in the environment to read at %A" vref.Range
                else
                    match env.Vals.TryGetValue vref.Name with
                    | true, res -> res
                    | _ -> failwithf "didn't find value '%s' in the environment at %A" vref.Name vref.Range
            sink.NotifyUseLocal(vref, res)
            res

        | DExpr.ValueSet (vref, valueExpr, m) ->
            let valueExprV: obj = ctxt.EvalExpr(env, valueExpr) |> getVal

            match vref with
            | Choice1Of2 vref ->
                match env.Vals.TryGetValue vref.Name with
                | true, rv -> rv.Value <- valueExprV
                | _ -> failwithf "didn't find mutable value in the environment to write"

            | Choice2Of2 mref ->
                let entityR = resolveEntity mref.Entity
                let key = (entityR, mref.Name, RTypes [||])
                if not (methodThunks.ContainsKey(key)) then
                    failwithf "No member found for key %A at %A" key m
                let membDef, _ = methodThunks.[key]
                methodThunks.[key] <- (membDef, Value valueExprV)

            Value null

        | DExpr.Const (constValueObj, constType) ->
            let (RTypeErased env constTypeR) = resolveType (env, constType)
            match constTypeR with
            | ty when ty = typeof<byte> -> Value(Convert.ToByte(constValueObj))
            | ty when ty = typeof<uint16> -> Value(Convert.ToUInt16(constValueObj))
            | ty when ty = typeof<uint32> -> Value(Convert.ToUInt32(constValueObj))
            | ty when ty = typeof<uint64> -> Value(Convert.ToUInt64(constValueObj))
            | ty when ty = typeof<sbyte> -> Value(Convert.ToSByte(constValueObj))
            | ty when ty = typeof<int16> -> Value(Convert.ToInt16(constValueObj))
            | ty when ty = typeof<int32> -> Value(Convert.ToInt32(constValueObj))
            | ty when ty = typeof<int64> -> Value(Convert.ToInt64(constValueObj))
            | ty when ty = typeof<single> -> Value(Convert.ToSingle(constValueObj))
            | ty when ty = typeof<double> -> Value(Convert.ToDouble(constValueObj))
            | ty when ty = typeof<decimal> -> Value(Convert.ToDecimal(constValueObj))
            | ty when ty = typeof<char> -> Value(Convert.ToChar(constValueObj))
            | ty when ty.IsEnum -> Value(Enum.ToObject(ty, constValueObj))
            | _ -> Value(Convert.ChangeType(constValueObj, constTypeR))
        //| _ -> Value constValueObj
        | _ -> failwithf "unrecognized %+A" expr

    member ctxt.EvalTraitCall(env, traitName, sourceTypes, isInstance, argTypes, argExprs) =
        let (RTypesErased env sourceTypesR) = resolveTypes (env, sourceTypes)
        let (RTypesErased env argTypesR) = resolveTypes (env, argTypes)
        let argExprsV: obj [] = ctxt.EvalExprs(env, argExprs)
        match sourceTypesR with
        | [| sourceTypeR |] -> EvalTraitCallInvoke(traitName, [ sourceTypeR ], isInstance, argExprsV)
        | [| sourceTypeR; sourceTypeR2 |] -> EvalTraitCallInvoke(traitName, [ sourceTypeR; sourceTypeR2 ], isInstance, argExprsV)
        | _ -> failwithf "trait/operator call on '%s' NYI in interpreter - multiple different source types with ambiguity" traitName

    member ctxt.EvalExprs(env, argExprs) =
        let argsV = argExprs |> Array.map (fun argExpr -> ctxt.EvalExpr(env, argExpr))
        argsV |> Array.map getVal

    member ctxt.EvalExprOpt(env, objExprOpt) =
        let objValOpt = objExprOpt |> Option.map (fun objExpr -> ctxt.EvalExpr(env, objExpr))
        objValOpt |> Option.map getVal |> Option.toObj

    member _.EvalDefaultValue(env, defaultType) =
        let defaultTypeR = resolveType (env, defaultType)
        let v =
            match defaultTypeR with
            | RType ty -> if ty.IsValueType then Activator.CreateInstance(ty) else null
            | UNamedType _ -> null
        Value v

    member ctxt.EvalNewObject(env, objCtor, typeArgs, argExprs, range) =
        let argsV = ctxt.EvalExprs(env, argExprs)
        let typeArgsR = resolveTypes (env, typeArgs)
        let methR = resolveMethod objCtor range

        match methR, typeArgsR with
        | RMethod (:? ConstructorInfo as cinfo), RTypesErased env typeArgsV ->
            let (RTypesErased env typeArgsT) = resolveTypes (env, typeArgs)
            let icinfo = instantiateConstructor typeArgsT cinfo
            protectInvoke (fun () -> icinfo.Invoke(argsV)) |> Value

        | UMethod (membDef, Value (:? MethodLambdaValue as fM)), RTypesErased env typeArgsV ->
            let (MethodLambdaValue f) = fM
            let res = f (typeArgsV, argsV) |> Value
            sink.NotifyCallAndReturn(Some objCtor, range, Choice2Of2 membDef, typeArgsV, argsV, res)
            res
        | _ -> failwithf "unexpected constructor %A at types %A" methR typeArgsR

    member ctxt.EvalNewDelegate(env, elementType, argExpr: DExpr) =
        let elementTypeR = resolveType (env, elementType)
        match elementTypeR with
        | RType ty ->
            let fn = ctxt.EvalExpr(env, argExpr).Value
            protectInvoke (fun () -> Delegate.CreateDelegate(ty, fn, "Invoke")) |> Value
        | _ -> failwithf "Unhandled NewDelegate %A" elementType

    member ctxt.EvalApplication(env, funcExpr, typeArgs, argExprs) =
        let funcV = ctxt.EvalExpr(env, funcExpr)
        let funcV =
            if typeArgs.Length > 0 then
                let (RTypesErased env typeArgsR) = resolveTypes (env, typeArgs)
                match getVal funcV with
                | :? (Type [] -> obj) as f -> Value(f typeArgsR)
                | t -> failwithf "unexpected value '%A' of type '%A' when evaluating type application" t (t.GetType())
            else
                funcV
        if argExprs.Length = 0 then
            funcV
        else
            let argsV = ctxt.EvalExprs(env, argExprs)
            ctxt.EvalApplicationOfArg(env, funcV, argsV)

    member ctxt.EvalApplicationOfArg(env, funcV, argsV) =
        match getVal funcV, argsV with
        | :? (obj -> obj) as f, [| obj |] -> f obj |> Value
        | f, _ ->
            if argsV.Length = 0 then
                failwithf "unexpected empty arguments in application of %A" f
            else
                let t = f.GetType()
                let i =
                    match t.GetMethods(bindAll) |> Array.tryFind (fun m -> m.Name = "Invoke" && m.GetParameters().Length = 1) with
                    | None -> failwithf "failed to find 'Invoke' method taking one argument on type %A" t
                    | Some res -> res
                let res = protectInvoke (fun () -> i.Invoke(f, [| argsV.[0] |])) |> Value
                if argsV.Length > 1 then
                    ctxt.EvalApplicationOfArg(env, res, argsV.[1..])
                else
                    res

    member ctxt.EvalLet(env, (bindingVar, bindingExpr), bodyExpr) =
        let bindingExprV = ctxt.EvalExpr(env, bindingExpr)
        let env = bind sink env bindingVar bindingExprV
        ctxt.EvalExpr(env, bodyExpr)

    member ctxt.EvalLetRec(env, recursiveBindings, bodyExpr) =
        let valueThunks = recursiveBindings |> Array.map (fun _ -> { Value = null })
        let envInner = bindMany sink env (Array.map fst recursiveBindings) valueThunks
        (valueThunks, recursiveBindings)
        ||> Array.iter2 (fun valueThunk (recursiveBindingVar, recursiveBindingExpr) ->
            let v = ctxt.EvalExpr(envInner, recursiveBindingExpr) |> getVal
            valueThunk.Value <- v
        )
        ctxt.EvalExpr(envInner, bodyExpr)

    member ctxt.EvalCall(env, objExprOpt, membRef, typeArgs1, typeArgs2, argExprs, range) =
        let objOptV = ctxt.EvalExprOpt(env, objExprOpt)
        let argsV = ctxt.EvalExprs(env, argExprs)
        let methR = resolveMethod membRef range

        // These primitives don't have dynamic invocation implementations
        match methR with
        | RPrim_float -> Value(Convert.ToDouble argsV.[0])
        | RPrim_double -> Value(Convert.ToDouble argsV.[0])
        | RPrim_single -> Value(Convert.ToSingle argsV.[0])
        | RPrim_float32 -> Value(Convert.ToSingle argsV.[0])
        | RPrim_int32 -> Value(Convert.ToInt32 argsV.[0])
        | RPrim_int16 -> Value(Convert.ToInt16 argsV.[0])
        | RPrim_int64 -> Value(Convert.ToInt64 argsV.[0])
        | RPrim_byte -> Value(Convert.ToByte argsV.[0])
        | RPrim_uint16 -> Value(Convert.ToUInt16 argsV.[0])
        | RPrim_uint32 -> Value(Convert.ToUInt32 argsV.[0])
        | RPrim_uint64 -> Value(Convert.ToUInt64 argsV.[0])
        | RPrim_decimal -> Value(Convert.ToDecimal argsV.[0])
        //| RPrim_unativeint -> Value (Convert.ToUIntPtr argsV.[0])
        //| RPrim_nativeint -> Value (Convert.ToIntPtr argsV.[0])
        | RPrim_char -> Value(Convert.ToChar argsV.[0])
        | RPrim_neg -> negOp "op_UnaryNegation" argsV
        | RPrim_pos -> Value argsV.[0]
        | RPrim_minus -> minusOp argsV
        | RPrim_divide -> divideOp argsV
        | RPrim_mod -> modOp argsV
        | RPrim_shiftleft -> shiftleftOp argsV
        | RPrim_shiftright -> shiftrightOp argsV
        | RPrim_land -> landOp argsV
        | RPrim_lor -> lorOp argsV
        | RPrim_lxor -> lxorOp argsV
        | RPrim_lneg -> lnegOp argsV
        | RPrim_checked_int32 -> Value(Convert.ToInt32 argsV.[0])
        | RPrim_checked_int -> Value(Convert.ToInt32 argsV.[0])
        | RPrim_checked_int16 -> Value(Convert.ToInt16 argsV.[0])
        | RPrim_checked_int64 -> Value(Convert.ToInt64 argsV.[0])
        | RPrim_checked_byte -> Value(Convert.ToByte argsV.[0])
        | RPrim_checked_uint16 -> Value(Convert.ToUInt16 argsV.[0])
        | RPrim_checked_uint32 -> Value(Convert.ToUInt32 argsV.[0])
        | RPrim_checked_uint64 -> Value(Convert.ToUInt64 argsV.[0])
        //| RPrim_checked_unativeint -> Value (Convert.ToUIntPtr argsV.[0])
        //| RPrim_checked_nativeint -> Value (Convert.ToIntPtr argsV.[0])
        | RPrim_checked_char -> Value(Convert.ToChar argsV.[0])
        | RPrim_checked_minus -> checked_minusOp argsV
        | RPrim_checked_mul -> checked_mulOp argsV
        | RPrim_abs -> absOp argsV
        | RPrim_acos -> acosOp argsV
        | RPrim_asin -> asinOp argsV
        | RPrim_atan -> atanOp argsV
        | RPrim_atan2 -> atan2Op argsV
        | RPrim_ceil -> ceilOp argsV
        | RPrim_exp -> expOp argsV
        | RPrim_floor -> floorOp argsV
        | RPrim_truncate -> truncateOp argsV
        | RPrim_round -> roundOp argsV
        | RPrim_sign -> signOp argsV
        | RPrim_log -> logOp argsV
        | RPrim_log10 -> log10Op argsV
        | RPrim_sqrt -> sqrtOp argsV
        | RPrim_cos -> cosOp argsV
        | RPrim_cosh -> coshOp argsV
        | RPrim_sin -> sinOp argsV
        | RPrim_sinh -> sinhOp argsV
        | RPrim_tan -> tanOp argsV
        | RPrim_tanh -> tanhOp argsV
        //| RPrim_pown -> unOp "Pown" argsV pown pown
        | RPrim_pow -> powOp argsV
        | _ ->

            let typeArgs1R = resolveTypes (env, typeArgs1)
            let typeArgs2R = resolveTypes (env, typeArgs2)

            match methR, typeArgs1R, typeArgs2R with
            | RMethod (:? MethodInfo as minfo), RTypesErased env typeArgs1V, RTypesErased env typeArgs2V ->
                let iminfo = instantiateMethod minfo typeArgs1V typeArgs2V
                let argsV = if iminfo.Name = "Yield" && argsV.Length = 0 then [| box () |] else argsV

                let res = protectInvoke (fun () -> iminfo.Invoke(objOptV, argsV)) |> Value

                sink.NotifyCallAndReturn(Some membRef, range, Choice1Of2 minfo, Array.append typeArgs1V typeArgs2V, argsV, res)

                // Copy back the out parameters - note that argsV will have been mutates
                let parameters = minfo.GetParameters()
                for i in 0 .. parameters.Length - 1 do
                    if parameters.[i].ParameterType.IsByRef then
                        match argExprs.[i] with
                        | DExpr.AddressOf (DExpr.Value vref) when not vref.IsThisValue && vref.IsMutable ->
                            match env.Vals.TryGetValue vref.Name with
                            | true, rv -> rv.Value <- argsV.[i]
                            | _ -> failwithf "didn't find mutable value in the environment at %A" range
                        | _ -> failwithf "can't yet interpret passing fields byref"

                res

            | RMethod (:? ConstructorInfo as cinfo), RTypesErased env _typeArgs1V, RTypesErased env _typeArgs2V ->
                protectInvoke (fun () -> cinfo.Invoke(argsV)) |> Value

            | UMethod (membDef, Value (:? MethodLambdaValue as fM)), RTypesErased env typeArgs1V, RTypesErased env typeArgs2V ->
                let (MethodLambdaValue f) = fM
                let callArgsV =
                    (match objOptV with
                     | null -> argsV
                     | objV -> Array.append [| objV |] argsV)
                let callTypeArgsV = Array.append typeArgs1V typeArgs2V
                let res = f (callTypeArgsV, callArgsV) |> Value
                sink.NotifyCallAndReturn(Some membRef, range, Choice2Of2 membDef, callTypeArgsV, argsV, res)
                res

            | UMethod (_membDef, Value v), RTypes [||], RTypes [||] when argExprs.Length = 0 -> v |> Value

            | _ -> failwithf "unexpected member %A at types %A %A" methR typeArgs1R typeArgs2R

    member ctxt.EvalAnonRecordGet(env, objExpr, fieldInfo, m) =
        let (DFieldRef (fieldIndex, fieldName)) = fieldInfo
        let (Value objV) = ctxt.EvalExpr(env, objExpr)
        let value =
            match objV with
            | :? RecordValue as recdV ->
                let (RecordValue argsV) = recdV
                argsV.[fieldIndex] |> Value

            | null ->
                //System.Runtime.Serialization.FormatterServices.GetUninitializedObject(ty)
                // TODO: for struct records this should return the default value
                raise (NullReferenceException("EvalFieldGet: The object was null"))

            | objV ->
                let fields = getFields objV
                match fields.Fields.TryGetValue fieldName with
                | true, v -> v |> Value
                | _ -> failwithf "field not found: %s" fieldName
        //sink.NotifyGetField(recordOrClassType, fdef, m, value)
        value

    member ctxt.EvalFieldGet(env, objExprOpt, recordOrClassType, fieldInfo, m) =
        let objOptV = ctxt.EvalExprOpt(env, objExprOpt)
        let fieldR = resolveField (env, recordOrClassType, fieldInfo)

        match fieldR with
        | RField ((:? FieldInfo as finfo), fdefOpt) ->
            let value = finfo.GetValue(objOptV) |> Value
            match fdefOpt with
            | Some fdef -> sink.NotifyGetField(recordOrClassType, fdef, m, value)
            | _ -> ()
            value
        | RField ((:? PropertyInfo as pinfo), fdefOpt) ->
            let value = pinfo.GetValue(objOptV) |> Value
            match fdefOpt with
            | Some fdef -> sink.NotifyGetField(recordOrClassType, fdef, m, value)
            | _ -> ()
            value
        | RField _ -> failwith "unexpected field resolution"
        | UField (i, _ty, fdef) ->
            let value =
                match objOptV with

                | :? RecordValue as recdV ->
                    let (RecordValue argsV) = recdV
                    argsV.[i] |> Value

                | null ->
                    //System.Runtime.Serialization.FormatterServices.GetUninitializedObject(ty)
                    // TODO: for struct records this should return the default value
                    raise (NullReferenceException("EvalFieldGet: The object was null"))

                | objV ->
                    let fields = getFields objV
                    match fields.Fields.TryGetValue fdef.Name with
                    | true, v -> v |> Value
                    | _ -> failwithf "field not found: %s" fdef.Name
            sink.NotifyGetField(recordOrClassType, fdef, m, value)
            value

    // Note: FieldSet is used even for immutable fields in the case of the compiled form of F# constructors
    member ctxt.EvalFieldSet(env, objExprOpt, recordOrClassType, fieldInfo, argExpr) =
        let objOptV = ctxt.EvalExprOpt(env, objExprOpt)
        let fieldR = resolveField (env, recordOrClassType, fieldInfo)
        let argExprE = ctxt.EvalExpr(env, argExpr)

        let argExprV = argExprE |> getVal
        match fieldR with
        | RField ((:? FieldInfo as finfo), fdefOpt) ->
            match fdefOpt with
            | Some fdef -> sink.NotifySetField(recordOrClassType, fdef, argExprE)
            | _ -> ()
            finfo.SetValue(objOptV, argExprV)
        | RField ((:? PropertyInfo as pinfo), fdefOpt) ->
            match fdefOpt with
            | Some fdef -> sink.NotifySetField(recordOrClassType, fdef, argExprE)
            | _ -> ()
            pinfo.SetValue(objOptV, argExprV)
        | RField _ -> failwith "unexpected field resolution"
        | UField (i, ty, fld) ->
            sink.NotifySetField(recordOrClassType, fld, argExprE)
            match objOptV with

            | :? RecordValue as recdV ->
                let (RecordValue argsV) = recdV
                argsV.[i] <- argExprV

            | null ->
                // TODO: for struct records this should return the default value
                raise (NullReferenceException("EvalFieldSet: The record value was null"))

            | objV ->
                let fields = getFields objV
                fields.Fields <- fields.Fields.Add(fld.Name, argExprV)

        Value null

    member ctxt.EvalILFieldGet(env, objExprOpt, recordOrClassType, fieldInfo) =
        let objOptV = ctxt.EvalExprOpt(env, objExprOpt)
        let fieldR = resolveILField (env, recordOrClassType, fieldInfo)

        match fieldR with
        | RField ((:? FieldInfo as finfo), _) -> finfo.GetValue(objOptV) |> Value
        | RField ((:? PropertyInfo as pinfo), _) -> pinfo.GetValue(objOptV) |> Value
        | RField _ -> failwith "unexpected field resolution"
        | UField (_i, _ty, fld) -> failwithf "unexpected ILFieldGet %s in interpreted type %A" fld.Name recordOrClassType

    member ctxt.EvalLambda(env, domainType, rangeType, lambdaVar, bodyExpr) =
        let domainTypeR = resolveType (env, domainType)
        let rangeTypeR = resolveType (env, rangeType)
        match domainTypeR, rangeTypeR with
        | RTypeErased env domainTypeV, RTypeErased env rangeTypeV ->
            let funcTypeV = typedefof<int -> int>.MakeGenericType (domainTypeV, rangeTypeV)
            FSharp.Reflection.FSharpValue.MakeFunction(
                funcTypeV,
                (fun (arg: obj) ->
                    let env = bind sink env lambdaVar (Value arg)
                    ctxt.EvalExpr(env, bodyExpr) |> getVal
            )
            )
            |> box
            |> Value

    member ctxt.EvalTypeLambda(env, genericParams, bodyExpr) =
        (fun (typeArgs: Type []) ->
            let env = (env, genericParams, typeArgs) |||> Array.fold2 bindType
            ctxt.EvalExpr(env, bodyExpr) |> getVal
        )
        |> box
        |> Value

    member ctxt.EvalNewArray(env, elementType, argExprs) =
        let elementTypeR = resolveType (env, elementType)
        let argsV = ctxt.EvalExprs(env, argExprs)

        let elementTypeV =
            match elementTypeR with
            | RType elementTypeV -> elementTypeV
            | _ -> firstCompiledBaseType (env, elementTypeR)
        let arr = Array.CreateInstance(elementTypeV, argsV.Length)
        argsV |> Array.iteri (fun i argV -> arr.SetValue(argV, i))
        Value arr

    member ctxt.EvalNewRecord(env, recordType, argExprs, _range) =
        let recordTypeR = resolveType (env, recordType)
        let argsV = ctxt.EvalExprs(env, argExprs)

        match recordTypeR with
        | RType recordTypeV -> Reflection.FSharpValue.MakeRecord(recordTypeV, argsV, bindAll) |> Value
        | _ ->
            let recdV = RecordValue argsV
            Value recdV

    member ctxt.EvalNewAnonRecord(env, fieldRefs, argExprs, _range) =
        let argsV = ctxt.EvalExprs(env, argExprs)
        let recdV = RecordValue argsV
        Value recdV

    member ctxt.EvalNewUnionCase(env, unionType, unionCase, argExprs, _range) =
        let unionCaseR = resolveUnionCase (env, unionType, unionCase)
        let argsV = ctxt.EvalExprs(env, argExprs)

        match unionCaseR with
        | RUnionCase (_ucase, _tag, make, _get) -> make argsV |> Value
        | UUnionCase (tag, unionCaseName) ->
            let unionV = UnionValue(tag, unionCaseName, argsV)
            unionV |> box |> Value

    member ctxt.EvalNewTuple(env, tupleType, argExprs) =
        let tupleTypeR = resolveType (env, tupleType)
        let argsV = ctxt.EvalExprs(env, argExprs)

        match tupleTypeR with
        | RType t -> Reflection.FSharpValue.MakeTuple(argsV, t) |> Value
        | _ -> failwith "unresolve tuple type"

    member ctxt.EvalDecisionTree(env, decisionExpr, decisionTargets) =
        let env = { env with Targets = decisionTargets }
        ctxt.EvalExpr(env, decisionExpr)

    member ctxt.EvalDecisionTreeSuccess(env, decisionTargetIdx, decisionTargetExprs) =
        let (locals, expr) = env.Targets.[decisionTargetIdx]
        let decisionTargetExprsV = ctxt.EvalExprs(env, decisionTargetExprs)
        let env =
            (env, locals, decisionTargetExprsV) |||> Array.fold2 (fun env p a -> bind sink env p (Value a))
        ctxt.EvalExpr(env, expr)

    member ctxt.EvalSequential(env, firstExpr, secondExpr, range) =
        let res = ctxt.EvalExpr(env, firstExpr)
        if not dyntypes then
            // inherits calls record the object
            match firstExpr with
            | DExpr.Call (_, memberOrFunc, _, _, _, _)
            | DExpr.NewObject (memberOrFunc, _, _, _) ->
                let methR = resolveMethod memberOrFunc range
                match methR with
                | RMethod (:? ConstructorInfo) ->
                    match env.Vals.TryGetValue "$this" with
                    | true, v -> v.Value <- res.Value
                    | _ -> ()
                | _ -> ()
            | _ -> ()
        ctxt.EvalExpr(env, secondExpr)

    member ctxt.EvalIfThenElse(env, guardExpr, thenExpr, elseExpr) =
        if ctxt.EvalBool(env, guardExpr) then
            ctxt.EvalExpr(env, thenExpr)
        else
            ctxt.EvalExpr(env, elseExpr)

    member ctxt.EvalBool(env, expr) =
        match ctxt.EvalExpr(env, expr) |> getVal with
        | :? bool as v -> v
        | :? int as v -> (v <> 0) // these are returned by filterExpr in EvalTryWith
        | t -> failwithf "unexpected result '%A' of type '%A' from bool expr" t (t.GetType())

    member ctxt.EvalTryFinally(env, bodyExpr, finallyExpr) =
        try
            ctxt.EvalExpr(env, bodyExpr)
        finally
            ctxt.EvalExpr(env, finallyExpr) |> ignore

    member ctxt.EvalTryWith(env, bodyExpr, filterVar, filterExpr, catchVar, catchExpr) =
        try
            ctxt.EvalExpr(env, bodyExpr)
        with
            | e when ctxt.EvalBool(bind sink env filterVar (Value e), filterExpr) -> ctxt.EvalExpr(bind sink env catchVar (Value e), catchExpr)

    member ctxt.EvalTupleGet(env, tupleElemIndex, tupleExpr) =
        let tupleExprV = ctxt.EvalExpr(env, tupleExpr) |> getVal
        Reflection.FSharpValue.GetTupleField(tupleExprV, tupleElemIndex) |> Value

    member ctxt.EvalWhileLoop(env, guardExpr, bodyExpr) =
        if ctxt.EvalBool(env, guardExpr) then
            ctxt.EvalExpr(env, bodyExpr) |> ignore
            ctxt.EvalWhileLoop(env, guardExpr, bodyExpr)
        else
            Value(box ())

    member ctxt.EvalUnionCaseTest(env, unionExpr, unionType, unionCase) =
        let unionCaseR = resolveUnionCase (env, unionType, unionCase)
        let unionV: obj = ctxt.EvalExpr(env, unionExpr) |> getVal

        let res =
            match unionCaseR with
            | RUnionCase (ucase, tag, _make, _get) -> (tag unionV = ucase.Tag)
            | UUnionCase (tag, _unionCaseName) ->
                match unionV with
                | :? UnionValue as p ->
                    let (UnionValue (tag2, _nm, _fields)) = p
                    tag = tag2

                | null ->
                    // TODO: for struct unions this should return the default value
                    raise (NullReferenceException("EvalUnionCaseTest: The union case value was null"))

                | _ -> failwithf "unexpected value '%A' in EvalUnionCaseTest" unionV
        Value(box res)

    member ctxt.EvalUnionCaseGet(env, unionExpr, unionType, unionCase, unionCaseField) =
        let unionCaseR = resolveUnionCase (env, unionType, unionCase)
        let unionCaseFieldR = resolveField (env, unionType, unionCaseField)
        let unionV: obj = ctxt.EvalExpr(env, unionExpr) |> getVal

        let res =
            match unionCaseR with
            | RUnionCase _ ->
                match unionCaseFieldR with
                | RField ((:? FieldInfo as finfo), _) -> finfo.GetValue(unionV)
                | RField ((:? PropertyInfo as pinfo), _) -> pinfo.GetValue(unionV)
                | _ -> failwithf "unexpected field resolution %A in EvalUnionCaseGet" unionCaseFieldR
            | UUnionCase (_tag, _unionCaseName) ->
                match unionV with
                | :? UnionValue as unionV ->
                    let (UnionValue (_tag, _unionCaseName, fields)) = unionV
                    match unionCaseFieldR with
                    | UField (index, _, _) -> fields.[index]
                    | RField _ -> failwithf "unexpected field resolution %A in EvalUnionCaseGet" unionCaseFieldR
                | _ -> failwithf "unexpected value '%A' in EvalUnionCaseGet" unionV
        Value(box res)

    member ctxt.EvalUnionCaseTag(env, unionExpr, unionType) =
        let unionTypeR = resolveType (env, unionType)
        let unionV: obj = ctxt.EvalExpr(env, unionExpr) |> getVal

        let res =
            match unionTypeR with
            | RType unionTypeV ->
                let tag = Reflection.FSharpValue.PreComputeUnionTagReader(unionTypeV, bindAll)
                tag unionV
            | _ ->
                match unionV with
                | :? (int * string * obj []) as p ->
                    let (tag, _nm, _fields) = p
                    tag
                | _ -> failwithf "unexpected value '%A' in EvalUnionCaseTag" unionV
        Value(box res)

    member ctxt.EvalTypeTest(env, ty, inpExpr) =
        let tyR = resolveType (env, ty)
        let inpExprV = ctxt.EvalExpr(env, inpExpr) |> getVal
        let res =
            match inpExprV with
            | null -> false
            | obj ->
                match tyR with
                | RType tyT -> tyT.IsAssignableFrom(obj.GetType())
                | _ -> failwith "can't do type tests on intepreted types"
        Value res

    /// Resolve an F# entity (type or module)
    member _.ResolveEntity entityRef = resolveEntity entityRef

    /// Resolve a method name to a lambda value
    member _.ResolveMethod(v: DMemberRef) = resolveMethod v
