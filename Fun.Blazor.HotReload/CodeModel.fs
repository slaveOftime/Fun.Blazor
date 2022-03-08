// Copyright 2018 Fabulous contributors. See LICENSE.md for license.

module FSharp.Compiler.PortaCode.CodeModel

open MessagePack
open MessagePack.FSharp
open MessagePack.Resolvers


[<MessagePackObject>]
type DRange =
    {
        [<Key(0)>]
        File: string
        [<Key(1)>]
        StartLine: int
        [<Key(2)>]
        StartColumn: int
        [<Key(3)>]
        EndLine: int
        [<Key(4)>]
        EndColumn: int
    }

    override range.ToString() =
        sprintf "%s: (%d,%d)-(%d-%d)" range.File range.StartLine range.StartColumn range.EndLine range.EndColumn

[<MessagePackObject>]
type DDiagnostic =
    {
        [<Key(0)>]
        Severity: int
        [<Key(1)>]
        Number: int
        [<Key(2)>]
        Message: string
        [<Key(3)>]
        LocationStack: DRange []
    }

    [<Key(4)>]
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
[<MessagePackObject>]
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

and [<MessagePackObject>] DType =
    | DNamedType of DEntityRef * DType []
    | DFunctionType of DType * DType
    | DTupleType of bool * DType []
    | DAnonRecdType of bool * string [] * DType []
    | DArrayType of int * DType
    | DByRefType of DType
    | DVariableType of string

and [<MessagePackObject>] DLocalDef =
    {
        [<Key(0)>]
        Name: string
        [<Key(1)>]
        IsMutable: bool
        [<Key(2)>]
        LocalType: DType
        [<Key(3)>]
        Range: DRange option
        [<Key(4)>]
        IsCompilerGenerated: bool
    }

and [<MessagePackObject>] DFieldDef =
    {
        [<Key(0)>]
        Name: string
        [<Key(1)>]
        IsStatic: bool
        [<Key(2)>]
        IsMutable: bool
        [<Key(3)>]
        FieldType: DType
        [<Key(4)>]
        Range: DRange option
        [<Key(5)>]
        IsCompilerGenerated: bool
    }

and [<MessagePackObject>] DSlotRef =
    {
        [<Key 0>]
        Member: DMemberRef
        [<Key 1>]
        DeclaringType: DType
    }
and [<MessagePackObject>] DMemberDef =
    {
        [<Key(0)>]
        EnclosingEntity: DEntityRef
        [<Key(1)>]
        Name: string
        [<Key(2)>]
        GenericParameters: DGenericParameterDef []
        [<Key(3)>]
        ImplementedSlots: DSlotRef []
        [<Key(4)>]
        IsInstance: bool
        [<Key(5)>]
        IsValue: bool
        [<Key(6)>]
        IsCompilerGenerated: bool
        [<Key(7)>]
        CustomAttributes: DCustomAttributeDef []
        [<Key(8)>]
        Parameters: DLocalDef []
        [<Key(9)>]
        ReturnType: DType
        [<Key(10)>]
        Range: DRange option
    }

    [<Key(11)>]
    member x.Ref =
        {
            Entity = x.EnclosingEntity
            Name = x.Name
            GenericArity = x.GenericParameters.Length
            ArgTypes = (x.Parameters |> Array.map (fun p -> p.LocalType))
            ReturnType = x.ReturnType
        }

and [<MessagePackObject>] DGenericParameterDef =
    {
        [<Key(0)>]
        Name: string
        [<Key(1)>]
        InterfaceConstraints: DType []
        [<Key(2)>]
        BaseTypeConstraint: DType option
        [<Key(3)>]
        DefaultConstructorConstraint: bool
        [<Key(4)>]
        NotNullableValueTypeConstraint: bool
        [<Key(5)>]
        ReferenceTypeConstraint: bool
    }

and [<MessagePackObject>] DEntityDef =
    {
        [<Key(0)>]
        QualifiedName: string
        [<Key(1)>]
        Name: string
        [<Key(2)>]
        GenericParameters: DGenericParameterDef []
        [<Key(3)>]
        BaseType: DType option
        [<Key(4)>]
        DeclaredInterfaces: DType []
        [<Key(5)>]
        DeclaredFields: DFieldDef []
        [<Key(6)>]
        DeclaredDispatchSlots: DMemberDef []
        [<Key(7)>]
        IsUnion: bool
        [<Key(8)>]
        IsRecord: bool
        [<Key(9)>]
        IsStruct: bool
        [<Key(10)>]
        IsInterface: bool
        [<Key(11)>]
        CustomAttributes: DCustomAttributeDef []
        //IsAbstractClass: bool
        [<Key(12)>]
        UnionCases: string []
        [<Key(13)>]
        Range: DRange option
    }

    [<Key(14)>]
    member x.Ref = DEntityRef x.QualifiedName

and [<MessagePackObject>] DCustomAttributeDef =
    {
        [<Key(0)>]
        AttributeType: DEntityRef
        [<Key(1)>]
        ConstructorArguments: (DType * obj) []
        [<Key(2)>]
        NamedArguments: (DType * string * bool * obj) []
    }

and [<MessagePackObject>] DEntityRef = | DEntityRef of string

and [<MessagePackObject>] DMemberRef =
    {
        [<Key(0)>]
        Entity: DEntityRef
        [<Key(1)>]
        Name: string
        [<Key(2)>]
        GenericArity: int
        [<Key(3)>]
        ArgTypes: DType []
        [<Key(4)>]
        ReturnType: DType
    }

and [<MessagePackObject>] DLocalRef =
    {
        [<Key(0)>]
        Name: string
        [<Key(1)>]
        IsThisValue: bool
        [<Key(2)>]
        IsMutable: bool
        [<Key(3)>]
        IsCompilerGenerated: bool
        [<Key(4)>]
        Range: DRange option
    }

and [<MessagePackObject>] DFieldRef = | DFieldRef of int * string

and [<MessagePackObject>] DUnionCaseRef = | DUnionCaseRef of string

and [<MessagePackObject>] DObjectExprOverrideDef =
    {
        [<Key(0)>]
        Name: string
        [<Key(1)>]
        Slot: DSlotRef
        [<Key(2)>]
        GenericParameters: DGenericParameterDef []
        [<Key(3)>]
        Parameters: DLocalDef []
        [<Key(4)>]
        Body: DExpr
    }

[<MessagePackObject>]
type DDecl =
    | DDeclEntity of DEntityDef * DDecl []
    | DDeclMember of DMemberDef * DExpr * isLiveCheck: bool
    | InitAction of DExpr * DRange option

[<MessagePackObject>]
type DFile =
    {
        [<Key(0)>]
        Code: DDecl []
    }


let CodeChangesPackOptions =
    MessagePackSerializerOptions.Standard.WithResolver(Resolvers.CompositeResolver.Create(FSharpResolver.Instance, StandardResolver.Instance))


[<MessagePackObject>]
type CodeChangesPack =
    {
        [<Key(0)>]
        Changes: (string * DFile) []
    }

    static member FromBytes (bytes: byte[]) =
        use stream = new System.IO.MemoryStream(bytes)
        MessagePackSerializer.Deserialize<CodeChangesPack>(stream, CodeChangesPackOptions)

    member this.ToBytes () =
        MessagePackSerializer.Serialize(this, CodeChangesPackOptions)
