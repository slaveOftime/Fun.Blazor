// Copyright 2018 Fabulous contributors. See LICENSE.md for license.

module FSharp.Compiler.PortaCode.CodeModel


type DRange =
    {
        File: string
        StartLine: int
        StartColumn: int
        EndLine: int
        EndColumn: int
    }

    override range.ToString() =
        sprintf "%s: (%d,%d)-(%d-%d)" range.File range.StartLine range.StartColumn range.EndLine range.EndColumn

type DDiagnostic =
    {
        Severity: int
        Number: int
        Message: string
        LocationStack: DRange []
    }

    member diag.Location = Array.last diag.LocationStack
    override diag.ToString() =
        let sev =
            match diag.Severity with
            | 0 -> "info"
            | 1 -> "warning"
            | _ -> "error"
        match List.ofArray (Array.rev diag.LocationStack) with
        | [] -> sprintf "%s LC%d: %O" sev diag.Number diag.Message
        | loc :: t ->
            [
                sprintf "%O: %s LC%d: %O" loc sev diag.Number diag.Message
                for loc in t do
                    sprintf "    stack: %O" loc
            ]
            |> String.concat "\n"

/// A representation of resolved F# expressions that can be serialized
type DExpr =
    | Value of DLocalRef
    | ThisValue of DType
    | BaseValue of DType
    | Application of DExpr * DType [] * DExpr [] * DRange option
    | Lambda of DType * DType * DLocalDef * DExpr
    | TypeLambda of DGenericParameterDef [] * DExpr
    | Quote of DExpr
    | IfThenElse of DExpr * DExpr * DExpr
    | DecisionTree of DExpr * (DLocalDef [] * DExpr) []
    | DecisionTreeSuccess of int * DExpr []
    | Call of DExpr option * DMemberRef * DType [] * DType [] * DExpr [] * DRange option
    | NewObject of DMemberRef * DType [] * DExpr [] * DRange option
    | LetRec of (DLocalDef * DExpr) [] * DExpr
    | Let of (DLocalDef * DExpr) * DExpr
    | NewRecord of DType * DExpr [] * DRange option
    | NewAnonRecord of DFieldRef [] * DExpr [] * DRange option
    | ObjectExpr of DType * DExpr * DObjectExprOverrideDef [] * (DType * DObjectExprOverrideDef []) []
    | AnonRecordGet of DExpr * DFieldRef * DRange option
    | FSharpFieldGet of DExpr option * DType * DFieldRef * DRange option
    | FSharpFieldSet of DExpr option * DType * DFieldRef * DExpr * DRange option
    | NewUnionCase of DType * DUnionCaseRef * DExpr [] * DRange option
    | UnionCaseGet of DExpr * DType * DUnionCaseRef * DFieldRef
    | UnionCaseSet of DExpr * DType * DUnionCaseRef * DFieldRef * DExpr
    | UnionCaseTag of DExpr * DType
    | UnionCaseTest of DExpr * DType * DUnionCaseRef
    | TraitCall of DType [] * string * isInstance: bool * DType [] * DType [] * DExpr [] * DRange option
    | NewTuple of DType * DExpr []
    | TupleGet of DType * int * DExpr
    | Coerce of DType * DExpr
    | NewArray of DType * DExpr []
    | TypeTest of DType * DExpr
    | AddressSet of DExpr * DExpr
    | ValueSet of Choice<DLocalRef, DMemberRef> * DExpr * DRange option
    | Unused
    | DefaultValue of DType
    | Const of obj * DType
    | AddressOf of DExpr
    | Sequential of DExpr * DExpr * DRange option
    | FastIntegerForLoop of DExpr * DExpr * DExpr * bool
    | WhileLoop of DExpr * DExpr
    | TryFinally of DExpr * DExpr
    | TryWith of DExpr * DLocalDef * DExpr * DLocalDef * DExpr
    | NewDelegate of DType * DExpr
    | ILFieldGet of DExpr option * DType * string
    | ILFieldSet of DExpr option * DType * string * DExpr
    | ILAsm of string * DType [] * DExpr []

and DType =
    | DNamedType of DEntityRef * DType []
    | DFunctionType of DType * DType
    | DTupleType of bool * DType []
    | DAnonRecdType of bool * string [] * DType []
    | DArrayType of int * DType
    | DByRefType of DType
    | DVariableType of string

and DLocalDef =
    {
        Name: string
        IsMutable: bool
        LocalType: DType
        Range: DRange option
        IsCompilerGenerated: bool
    }

and DFieldDef =
    {
        Name: string
        IsStatic: bool
        IsMutable: bool
        FieldType: DType
        Range: DRange option
        IsCompilerGenerated: bool
    }

and DSlotRef = { Member: DMemberRef; DeclaringType: DType }
and DMemberDef =
    {
        EnclosingEntity: DEntityRef
        Name: string
        GenericParameters: DGenericParameterDef []
        ImplementedSlots: DSlotRef []
        IsInstance: bool
        IsValue: bool
        IsCompilerGenerated: bool
        CustomAttributes: DCustomAttributeDef []
        Parameters: DLocalDef []
        ReturnType: DType
        Range: DRange option
    }

    member x.Ref =
        {
            Entity = x.EnclosingEntity
            Name = x.Name
            GenericArity = x.GenericParameters.Length
            ArgTypes = (x.Parameters |> Array.map (fun p -> p.LocalType))
            ReturnType = x.ReturnType
        }

and DGenericParameterDef =
    {
        Name: string
        InterfaceConstraints: DType []
        BaseTypeConstraint: DType option
        DefaultConstructorConstraint: bool
        NotNullableValueTypeConstraint: bool
        ReferenceTypeConstraint: bool
    }

and DEntityDef =
    {
        QualifiedName: string
        Name: string
        GenericParameters: DGenericParameterDef []
        BaseType: DType option
        DeclaredInterfaces: DType []
        DeclaredFields: DFieldDef []
        DeclaredDispatchSlots: DMemberDef []
        IsUnion: bool
        IsRecord: bool
        IsStruct: bool
        IsInterface: bool
        CustomAttributes: DCustomAttributeDef []
        //IsAbstractClass: bool
        UnionCases: string []
        Range: DRange option
    }

    member x.Ref = DEntityRef x.QualifiedName

and DCustomAttributeDef =
    {
        AttributeType: DEntityRef
        ConstructorArguments: (DType * obj) []
        NamedArguments: (DType * string * bool * obj) []
    }

and DEntityRef = | DEntityRef of string

and DMemberRef =
    {
        Entity: DEntityRef
        Name: string
        GenericArity: int
        ArgTypes: DType []
        ReturnType: DType
    }

and DLocalRef =
    {
        Name: string
        IsThisValue: bool
        IsMutable: bool
        IsCompilerGenerated: bool
        Range: DRange option
    }

and DFieldRef = | DFieldRef of int * string

and DUnionCaseRef = | DUnionCaseRef of string

and DObjectExprOverrideDef =
    {
        Name: string
        Slot: DSlotRef
        GenericParameters: DGenericParameterDef []
        Parameters: DLocalDef []
        Body: DExpr
    }

type DDecl =
    | DDeclEntity of DEntityDef * DDecl []
    | DDeclMember of DMemberDef * DExpr * isLiveCheck: bool
    | InitAction of DExpr * DRange option

type DFile = { Code: DDecl [] }
