// Copyright 2018 Fabulous contributors. See LICENSE.md for license.
module FSharp.Compiler.PortaCode.FromCompilerService

open FSharp.Compiler.Symbols
open FSharp.Compiler.Syntax
open FSharp.Compiler.Text
open FSharp.Compiler.Text.Range
open FSharp.Compiler.Text.Position
open FSharp.Compiler.PortaCode.CodeModel


let map2 f g (a, b) = (f a, g b)

module List =
    let mapToArray f arr = arr |> Array.ofList |> Array.map f

module Seq =
    let mapToArray f arr = arr |> Array.ofSeq |> Array.map f

exception IncompleteExpr

type Convert(includeRanges: bool, tolerateIncomplete: bool) =

    let rec convExpr (expr: FSharpExpr) : DExpr =

        match expr with
        | FSharpExprPatterns.AddressOf (lvalueExpr) -> DExpr.AddressOf(convExpr lvalueExpr)

        | FSharpExprPatterns.AddressSet (lvalueExpr, rvalueExpr) -> DExpr.AddressSet(convExpr lvalueExpr, convExpr rvalueExpr)

        // FCS TODO: fix FCS quirk with IsNone and IsSome on the option type
        | FSharpExprPatterns.Application (FSharpExprPatterns.Call (Some obj, memberOrFunc, tyargs1, tyargs2, []), typeArgs, [ arg ]) when
            memberOrFunc.CompiledName = "get_IsNone" || memberOrFunc.CompiledName = "get_IsSome"
            ->
            let objExprR = convExpr obj
            let mrefR = convMemberRef memberOrFunc
            let typeArgs1R = convTypes tyargs1
            let typeArgs2R = convTypes tyargs2
            let rangeR = convRange expr.Range
            DExpr.Call(None, mrefR, typeArgs1R, typeArgs2R, [| objExprR |], rangeR)

        | FSharpExprPatterns.Application (funcExpr, typeArgs, argExprs) ->
            let rangeR = convRange (expr.Range |> trimRanges (argExprs |> List.map (fun e -> e.Range)))
            DExpr.Application(convExpr funcExpr, convTypes typeArgs, convExprs argExprs, rangeR)

        // The F# Compiler Service inserts "raise 1" for expressions that don't check
        | FSharpExprPatterns.Call (_, memberOrFunc, _, _, [ FSharpExprPatterns.Const ((:? int as c), _) ]) when
            c = 1 && memberOrFunc.CompiledName = "Raise"
            ->
            raise IncompleteExpr

        | FSharpExprPatterns.Call (objExprOpt, memberOrFunc, typeArgs1, typeArgs2, argExprs) ->
            let objExprOptR = convExprOpt objExprOpt
            let mrefR = convMemberRef memberOrFunc
            let typeArgs1R = convTypes typeArgs1
            let typeArgs2R = convTypes typeArgs2
            let argExprsR = convArgExprs memberOrFunc argExprs
            let rangeR =
                convRange (expr.Range |> trimRanges ((Option.toList objExprOpt @ argExprs) |> List.map (fun e -> e.Range)))
            match objExprOptR with
            // FCS TODO: Fix quirk with extension members so this isn't needed
            | Some objExprR when memberOrFunc.IsExtensionMember || not memberOrFunc.IsInstanceMemberInCompiledCode ->
                DExpr.Call(None, mrefR, typeArgs1R, typeArgs2R, Array.append [| objExprR |] argExprsR, rangeR)
            | _ -> DExpr.Call(objExprOptR, mrefR, typeArgs1R, typeArgs2R, argExprsR, rangeR)

        | FSharpExprPatterns.Coerce (targetType, inpExpr) -> DExpr.Coerce(convType targetType, convExpr inpExpr)

        | FSharpExprPatterns.FastIntegerForLoop (startExpr, limitExpr, consumeExpr, isUp) ->
            DExpr.FastIntegerForLoop(convExpr startExpr, convExpr limitExpr, convExpr consumeExpr, isUp)

        | FSharpExprPatterns.ILAsm (asmCode, typeArgs, argExprs) -> DExpr.ILAsm(asmCode, convTypes typeArgs, convExprs argExprs)

        | FSharpExprPatterns.ILFieldGet (objExprOpt, fieldType, fieldName) -> DExpr.ILFieldGet(convExprOpt objExprOpt, convType fieldType, fieldName)

        | FSharpExprPatterns.ILFieldSet (objExprOpt, fieldType, fieldName, valueExpr) ->
            DExpr.ILFieldSet(convExprOpt objExprOpt, convType fieldType, fieldName, convExpr valueExpr)

        | FSharpExprPatterns.IfThenElse (guardExpr, thenExpr, elseExpr) -> DExpr.IfThenElse(convExpr guardExpr, convExpr thenExpr, convExpr elseExpr)

        | FSharpExprPatterns.Lambda (lambdaVar, bodyExpr) ->
            DExpr.Lambda(convType lambdaVar.FullType, convType bodyExpr.Type, convLocalDef lambdaVar, convExpr bodyExpr)

        | FSharpExprPatterns.Let ((bindingVar, bindingExpr), bodyExpr) ->
            DExpr.Let((convLocalDef bindingVar, convExpr bindingExpr), convExpr bodyExpr)

        | FSharpExprPatterns.LetRec (recursiveBindings, bodyExpr) ->
            DExpr.LetRec(List.mapToArray (map2 convLocalDef convExpr) recursiveBindings, convExpr bodyExpr)

        | FSharpExprPatterns.NewArray (arrayType, argExprs) -> DExpr.NewArray(convType arrayType, convExprs argExprs)

        | FSharpExprPatterns.NewDelegate (delegateType, delegateBodyExpr) -> DExpr.NewDelegate(convType delegateType, convExpr delegateBodyExpr)

        | FSharpExprPatterns.NewObject (objCtor, typeArgs, argExprs: FSharpExpr list) ->
            let rangeR = convRange (expr.Range |> trimRanges (argExprs |> List.map (fun e -> e.Range)))
            DExpr.NewObject(convMemberRef objCtor, convTypes typeArgs, convArgExprs objCtor argExprs, rangeR)

        | FSharpExprPatterns.NewRecord (recordType, argExprs) ->
            let rangeR = convRange (expr.Range |> trimRanges (argExprs |> List.map (fun e -> e.Range)))
            DExpr.NewRecord(convType recordType, convExprs argExprs, rangeR)

        | FSharpExprPatterns.NewAnonRecord (recordType, argExprs) ->
            let rangeR = convRange (expr.Range |> trimRanges (argExprs |> List.map (fun e -> e.Range)))
            let fieldRefs =
                (stripTypeAbbreviations recordType).AnonRecordTypeDetails.SortedFieldNames
                |> Array.mapi (fun i nm -> DFieldRef(i, nm))
            DExpr.NewAnonRecord(fieldRefs, convExprs argExprs, rangeR)

        | FSharpExprPatterns.NewTuple (tupleType, argExprs) -> DExpr.NewTuple(convType tupleType, convExprs argExprs)

        | FSharpExprPatterns.NewUnionCase (unionType, unionCase, argExprs) ->
            let rangeR = convRange (expr.Range |> trimRanges (argExprs |> List.map (fun e -> e.Range)))
            DExpr.NewUnionCase(convType unionType, convUnionCase unionCase, convExprs argExprs, rangeR)

        | FSharpExprPatterns.Quote (quotedExpr) -> DExpr.Quote(convExpr quotedExpr)

        | FSharpExprPatterns.FSharpFieldGet (objExprOpt, recordOrClassType, fieldInfo) ->
            let rangeR =
                convRange (expr.Range |> trimRanges ((Option.toList objExprOpt) |> List.map (fun e -> e.Range)))
            DExpr.FSharpFieldGet(convExprOpt objExprOpt, convType recordOrClassType, convFieldRef fieldInfo, rangeR)

        | FSharpExprPatterns.FSharpFieldSet (objExprOpt, recordOrClassType, fieldInfo, argExpr) ->
            let rangeR =
                convRange (expr.Range |> trimRanges ((Option.toList objExprOpt @ [ argExpr ]) |> List.map (fun e -> e.Range)))
            DExpr.FSharpFieldSet(convExprOpt objExprOpt, convType recordOrClassType, convFieldRef fieldInfo, convExpr argExpr, rangeR)

        | FSharpExprPatterns.Sequential (firstExpr, secondExpr) ->
            let rangeR = convRange expr.Range
            DExpr.Sequential(convExpr firstExpr, convExpr secondExpr, rangeR)

        | FSharpExprPatterns.TryFinally (bodyExpr, finalizeExpr) -> DExpr.TryFinally(convExpr bodyExpr, convExpr finalizeExpr)

        | FSharpExprPatterns.TryWith (bodyExpr, filterVar, filterExpr, catchVar, catchExpr) ->
            DExpr.TryWith(convExpr bodyExpr, convLocalDef filterVar, convExpr filterExpr, convLocalDef catchVar, convExpr catchExpr)

        | FSharpExprPatterns.TupleGet (tupleType, tupleElemIndex, tupleExpr) -> DExpr.TupleGet(convType tupleType, tupleElemIndex, convExpr tupleExpr)

        | FSharpExprPatterns.DecisionTree (decisionExpr, decisionTargets) ->
            DExpr.DecisionTree(convExpr decisionExpr, List.mapToArray (map2 (List.mapToArray convLocalDef) convExpr) decisionTargets)

        | FSharpExprPatterns.DecisionTreeSuccess (decisionTargetIdx, decisionTargetExprs) ->
            DExpr.DecisionTreeSuccess(decisionTargetIdx, convExprs decisionTargetExprs)

        | FSharpExprPatterns.TypeLambda (genericParams, bodyExpr) ->
            DExpr.TypeLambda(Array.map convGenericParamDef (Array.ofList genericParams), convExpr bodyExpr)

        | FSharpExprPatterns.TypeTest (ty, inpExpr) -> DExpr.TypeTest(convType ty, convExpr inpExpr)

        | FSharpExprPatterns.AnonRecordGet (objExpr, anonRecdType, n) ->
            let rangeR = expr.Range |> trimRanges [ objExpr.Range ] |> convRange
            let fieldRef = DFieldRef(n, anonRecdType.AnonRecordTypeDetails.SortedFieldNames.[n])
            DExpr.AnonRecordGet(convExpr objExpr, fieldRef, rangeR)

        | FSharpExprPatterns.UnionCaseSet (unionExpr, unionType, unionCase, unionCaseField, valueExpr) ->
            DExpr.UnionCaseSet(
                convExpr unionExpr,
                convType unionType,
                convUnionCase unionCase,
                convUnionCaseField unionCase unionCaseField,
                convExpr valueExpr
            )

        | FSharpExprPatterns.UnionCaseGet (unionExpr, unionType, unionCase, unionCaseField) ->
            DExpr.UnionCaseGet(convExpr unionExpr, convType unionType, convUnionCase unionCase, convUnionCaseField unionCase unionCaseField)

        | FSharpExprPatterns.UnionCaseTest (unionExpr, unionType, unionCase) ->
            DExpr.UnionCaseTest(convExpr unionExpr, convType unionType, convUnionCase unionCase)

        | FSharpExprPatterns.UnionCaseTag (unionExpr, unionType) -> DExpr.UnionCaseTag(convExpr unionExpr, convType unionType)

        | FSharpExprPatterns.ObjectExpr (objType, baseCallExpr, overrides, interfaceImplementations) ->
            DExpr.ObjectExpr(
                convType objType,
                convExpr baseCallExpr,
                Array.map convObjMemberDef (Array.ofList overrides),
                Array.map (map2 convType (Array.ofList >> Array.map convObjMemberDef)) (Array.ofList interfaceImplementations)
            )

        | FSharpExprPatterns.TraitCall (sourceTypes, traitName, memberFlags, typeInstantiation, argTypes, argExprs) ->
            DExpr.TraitCall(
                convTypes sourceTypes,
                traitName,
                memberFlags.IsInstance,
                convTypes typeInstantiation,
                convTypes argTypes,
                convExprs argExprs,
                convRange expr.Range
            )

        | FSharpExprPatterns.ValueSet (valToSet, valueExpr) ->
            let valToSetR =
                if valToSet.IsModuleValueOrMember then
                    Choice2Of2(convMemberRef valToSet)
                else
                    Choice1Of2(convLocalRef expr.Range valToSet)
            let rangeR = convRange expr.Range
            DExpr.ValueSet(valToSetR, convExpr valueExpr, rangeR)

        | FSharpExprPatterns.WhileLoop (guardExpr, bodyExpr) -> DExpr.WhileLoop(convExpr guardExpr, convExpr bodyExpr)

        | FSharpExprPatterns.BaseValue baseType -> DExpr.BaseValue(convType baseType)

        | FSharpExprPatterns.DefaultValue defaultType -> DExpr.DefaultValue(convType defaultType)

        | FSharpExprPatterns.ThisValue thisType -> DExpr.ThisValue(convType thisType)

        | FSharpExprPatterns.Const (constValueObj, constType) -> DExpr.Const(constValueObj, convType constType)

        | FSharpExprPatterns.Value (valueToGet) -> DExpr.Value(convLocalRef expr.Range valueToGet)

        | _ -> failwith (sprintf "unrecognized %+A at %A" expr expr.Range)

    and convExprs exprs = Array.map convExpr (Array.ofList exprs)

    // Trim out the ranges of argument expressions
    and trimRanges (rangesToRemove: range list) (range: range) =
        // Optional arguments inserted by the F# compiler get ranges identical to
        // the whole expression.  Don't remove these
        //printfn "trimRanges --> "
        let rangesToRemove = rangesToRemove |> List.filter (fun m -> not (m = range))
        (range, rangesToRemove) ||> List.fold trimRange

    // Exclude range m2 from m
    and trimRange (m1: range) (m2: range) =
        let posLeq p1 p2 = not (posGt p1 p2)
        let posGeq p1 p2 = not (posLt p1 p2)
        let posMin p1 p2 = if posLt p1 p2 then p1 else p2
        let posMax p1 p2 = if posLt p1 p2 then p2 else p1
        let posPlusOne (p: pos) = mkPos p.Line (p.Column + 1)
        let posMinusOne (p: pos) = mkPos p.Line (max 0 (p.Column - 1))
        let p1, p2 =
            // Trim from start
            if posLeq m2.Start m1.Start then
                posMax m1.Start (posPlusOne m2.End), m1.End
            // Trim from end
            elif posGeq m2.End m1.End then
                m1.Start, posMin m1.End (posMinusOne m2.Start)
            // Trim from middle, treated as trim from end, this is an argument "x.foo(y)"
            else
                m1.Start, posMin m1.End (posMinusOne m2.Start)

        let res = mkRange m1.FileName p1 p2
        //printfn "m1 = %A, m2 = %A, res = %A" m1 m2 res
        res

    and convExprOpt exprs = Option.map convExpr exprs

    and convSlot (memb: FSharpAbstractSignature) : DSlotRef =
        {
            Member =
                {
                    Entity = convEntityRef (stripTypeAbbreviations memb.DeclaringType).TypeDefinition
                    Name = memb.Name
                    GenericArity = memb.MethodGenericParameters.Count
                    ArgTypes = [| for a in Seq.concat memb.AbstractArguments -> convType a.Type |]
                    ReturnType = convType memb.AbstractReturnType
                }
            DeclaringType = convType memb.DeclaringType
        }

    and convObjMemberDef (memb: FSharpObjectExprOverride) : DObjectExprOverrideDef =
        {
            Slot = convSlot memb.Signature
            GenericParameters = convGenericParamDefs memb.GenericParameters
            Name = memb.Signature.Name
            Parameters = memb.CurriedParameterGroups |> convParamDefs2
            Body = convExpr memb.Body
        }

    and convFieldRef (field: FSharpField) : DFieldRef =
        match field.DeclaringEntity with
        | None -> failwithf "couldn't find declaring entity of field %s" field.Name
        | Some e ->
            match e.FSharpFields |> Seq.tryFindIndex (fun field2 -> field2.Name = field.Name) with
            | Some index -> DFieldRef(index, field.Name)
            | None -> failwithf "couldn't find field %s in type %A" field.Name field.DeclaringEntity

    and convUnionCase (ucase: FSharpUnionCase) : DUnionCaseRef = DUnionCaseRef(ucase.CompiledName)

    and convUnionCaseField (ucase: FSharpUnionCase) (field: FSharpField) : DFieldRef =
        match ucase.Fields |> Seq.tryFindIndex (fun field2 -> field2.Name = field.Name) with
        | Some index -> DFieldRef(index, field.Name)
        | None -> failwithf "couldn't find field %s in type %A" field.Name field.DeclaringEntity

    and convRange (range: range) : DRange option =
        if includeRanges then
            Some
                {
                    File = range.FileName
                    StartLine = range.StartLine
                    StartColumn = range.StartColumn
                    EndLine = range.EndLine
                    EndColumn = range.EndColumn
                }
        else
            None

    and convLocalDef (value: FSharpMemberOrFunctionOrValue) : DLocalDef =
        {
            Name = value.CompiledName
            IsMutable = value.IsMutable
            LocalType = convType value.FullType
            Range = convRange value.DeclarationLocation
            IsCompilerGenerated = value.IsCompilerGenerated
        }

    and convLocalRef range (value: FSharpMemberOrFunctionOrValue) : DLocalRef =
        {
            Name = value.CompiledName
            IsThisValue = (value.IsMemberThisValue || value.IsConstructorThisValue || value.IsBaseValue)
            IsMutable = value.IsMutable
            IsCompilerGenerated = value.IsCompilerGenerated
            Range = convRange range
        }

    and convMemberDef (memb: FSharpMemberOrFunctionOrValue) : DMemberDef =
        assert (memb.IsMember || memb.IsModuleValueOrMember)
        {
            EnclosingEntity = convEntityRef memb.DeclaringEntity.Value
            ImplementedSlots = memb.ImplementedAbstractSignatures |> Seq.toArray |> Array.map convSlot
            CustomAttributes = memb.Attributes |> Seq.toArray |> Array.map convCustomAttribute
            Name = memb.CompiledName
            GenericParameters = convGenericParamDefs memb.GenericParameters
            Parameters = convParamDefs memb
            ReturnType = convReturnType memb
            IsInstance = memb.IsInstanceMemberInCompiledCode
            IsValue = memb.IsValue
            Range = convRange memb.DeclarationLocation
            IsCompilerGenerated = memb.IsCompilerGenerated
        }

    and convMemberRef (memb: FSharpMemberOrFunctionOrValue) =
        if not (memb.IsMember || memb.IsModuleValueOrMember) then
            failwith "can't convert non-member ref"
        let paramTypesR = convParamTypes memb

        // TODO: extensions of generic type
        //if
        //    memb.IsExtensionMember && memb.ApparentEnclosingEntity.GenericParameters.Count > 0
        //    && not
        //        (
        //            memb.CompiledName = "ProgramRunner`2.EnableLiveUpdate"
        //            || memb.CompiledName = "ProgramRunner`3.EnableLiveUpdate"
        //        )
        //then
        //    failwithf "NYI: extension of generic type, needs FCS support: %A::%A" memb.ApparentEnclosingEntity memb

        {
            Entity = convEntityRef memb.DeclaringEntity.Value
            Name = memb.CompiledName
            GenericArity = memb.GenericParameters.Count
            ArgTypes = paramTypesR
            ReturnType = convReturnType memb
        }

    and convParamTypes (memb: FSharpMemberOrFunctionOrValue) =
        let parameters = memb.CurriedParameterGroups
        let paramTypesR = parameters |> Seq.concat |> Array.ofSeq |> Array.map (fun p -> p.Type)
        // TODO: FCS should do this unit arg elimination for us
        let paramTypesR =
            match paramTypesR with
            | [| pty |] when memb.IsModuleValueOrMember && pty.HasTypeDefinition && pty.TypeDefinition.LogicalName = "unit" -> [||]
            | _ -> paramTypesR |> convTypes
        // TODO: FCS should do this instance --> static transformation for us
        if memb.IsInstanceMember && not memb.IsInstanceMemberInCompiledCode then
            if memb.IsExtensionMember then
                Array.append [| DNamedType(convEntityRef memb.ApparentEnclosingEntity, [||]) |] paramTypesR
            else
                let instanceType = memb.FullType.GenericArguments.[0]
                Array.append [| convType instanceType |] paramTypesR
        else
            paramTypesR

    and convArgExprs (memb: FSharpMemberOrFunctionOrValue) exprs =
        let parameters = memb.CurriedParameterGroups
        let paramTypes = parameters |> Seq.concat |> Array.ofSeq |> Array.map (fun p -> p.Type)
        // TODO: FCS should do this unit arg elimination for us
        match paramTypes, exprs with
        | [| pty |], [ _expr ] when memb.IsModuleValueOrMember && pty.HasTypeDefinition && pty.TypeDefinition.LogicalName = "unit" -> [||]
        | _ -> convExprs exprs

    and convParamDefs (memb: FSharpMemberOrFunctionOrValue) =
        let parameters = memb.CurriedParameterGroups
        // TODO: FCS should do this unit arg elimination for us
        let parameters =
            match parameters |> Seq.concat |> Seq.toArray with
            | [| p |] when p.Type.HasTypeDefinition && p.Type.TypeDefinition.LogicalName = "unit" -> [||]
            | ps -> ps
        let parametersR =
            parameters
            |> Array.map (fun p ->
                {
                    Name = p.DisplayName
                    IsMutable = false
                    LocalType = convType p.Type
                    Range = convRange p.DeclarationLocation
                    IsCompilerGenerated = false
                }
            )
        if memb.IsInstanceMember && not memb.IsInstanceMemberInCompiledCode then
            if memb.IsExtensionMember then
                let instanceTypeR = DNamedType(convEntityRef memb.ApparentEnclosingEntity, [||])
                let thisParam =
                    {
                        Name = "$this"
                        IsMutable = false
                        LocalType = instanceTypeR
                        Range = convRange memb.DeclarationLocation
                        IsCompilerGenerated = true
                    }
                Array.append [| thisParam |] parametersR
            else
                let instanceType = memb.FullType.GenericArguments.[0]
                let thisParam =
                    {
                        Name = "$this"
                        IsMutable = false
                        LocalType = convType instanceType
                        Range = convRange memb.DeclarationLocation
                        IsCompilerGenerated = true
                    }
                Array.append [| thisParam |] parametersR
        else
            parametersR

    and convParamDefs2 (parameters: FSharpMemberOrFunctionOrValue list list) =
        // TODO: FCS should do this unit arg elimination for us
        let parameters =
            match parameters |> Seq.concat |> Seq.toArray with
            | [| p |] when p.FullType.HasTypeDefinition && p.FullType.TypeDefinition.LogicalName = "unit" -> [||]
            | ps -> ps
        parameters
        |> Array.map (fun p ->
            {
                Name = p.DisplayName
                IsMutable = false
                LocalType = convType p.FullType
                Range = convRange p.DeclarationLocation
                IsCompilerGenerated = false
            }
        )

    and convReturnType (memb: FSharpMemberOrFunctionOrValue) = convType memb.ReturnParameter.Type

    and convCustomAttribute (cattr: FSharpAttribute) =
        {
            AttributeType = convEntityRef cattr.AttributeType
            ConstructorArguments = cattr.ConstructorArguments |> Seq.toArray |> Array.map (fun (ty, v) -> convType ty, v)
            NamedArguments = cattr.NamedArguments |> Seq.toArray |> Array.map (fun (ty, v1, v2, v3) -> convType ty, v1, v2, v3)
        //Range = cattr
        }
    and convEntityDef (entity: FSharpEntity) : DEntityDef =
        if entity.IsNamespace then failwith "convEntityDef: can't convert a namespace"
        if entity.IsArrayType then failwith "convEntityDef: can't convert an array"
        if entity.IsFSharpAbbreviation then
            failwith "convEntityDef: can't convert a type abbreviation"
        {
            QualifiedName = entity.QualifiedName
            Name = entity.CompiledName
            BaseType = entity.BaseType |> Option.map convType
            DeclaredInterfaces = entity.DeclaredInterfaces |> Seq.toArray |> Array.map convType
            DeclaredFields = entity.FSharpFields |> Seq.toArray |> Array.map convField
            DeclaredDispatchSlots =
                entity.MembersFunctionsAndValues
                |> Seq.toArray
                |> Array.filter (fun v -> v.IsDispatchSlot)
                |> Array.map convMemberDef
            GenericParameters = convGenericParamDefs entity.GenericParameters
            UnionCases = entity.UnionCases |> Seq.mapToArray (fun uc -> uc.Name)
            IsUnion = entity.IsFSharpUnion
            IsRecord = entity.IsFSharpRecord
            IsStruct = entity.IsValueType
            IsInterface = entity.IsInterface
            CustomAttributes = entity.Attributes |> Seq.toArray |> Array.map convCustomAttribute
            Range = convRange entity.DeclarationLocation
        }

    and convEntityRef (entity: FSharpEntity) : DEntityRef =
        if entity.IsNamespace then failwith "convEntityRef: can't convert a namespace"
        if entity.IsArrayType then failwith "convEntityRef: can't convert an array"
        if entity.IsFSharpAbbreviation then
            failwith "convEntityRef: can't convert a type abbreviation"
        DEntityRef entity.QualifiedName

    and stripTypeAbbreviations (typ: FSharpType) : FSharpType =
        if typ.IsAbbreviation then stripTypeAbbreviations typ.AbbreviatedType else typ

    and isInterfaceType (typ: FSharpType) =
        if typ.IsAbbreviation then
            isInterfaceType typ.AbbreviatedType
        else
            typ.HasTypeDefinition && typ.TypeDefinition.IsInterface

    and convType (typ: FSharpType) =
        if typ.IsAbbreviation then
            convType typ.AbbreviatedType
        elif typ.IsFunctionType then
            DFunctionType(convType typ.GenericArguments.[0], convType typ.GenericArguments.[1])
        elif typ.IsTupleType then
            DTupleType(false, convTypes typ.GenericArguments)
        elif typ.IsStructTupleType then
            DTupleType(true, convTypes typ.GenericArguments)
        elif typ.IsAnonRecordType then
            DAnonRecdType(false, typ.AnonRecordTypeDetails.SortedFieldNames, convTypes typ.GenericArguments)
        elif typ.IsGenericParameter then
            DVariableType typ.GenericParameter.Name
        elif typ.TypeDefinition.IsArrayType then
            DArrayType(typ.TypeDefinition.ArrayRank, convType typ.GenericArguments.[0])
        elif typ.TypeDefinition.IsByRef then
            DByRefType(convType typ.GenericArguments.[0])
        else
            DNamedType(convEntityRef typ.TypeDefinition, convTypes typ.GenericArguments)

    and convTypes (typs: seq<FSharpType>) = typs |> Seq.toArray |> Array.map convType

    and convGenericParamDef (gp: FSharpGenericParameter) : DGenericParameterDef =
        {
            Name = gp.Name
            InterfaceConstraints =
                gp.Constraints
                |> Seq.toArray
                |> Array.choose (fun c ->
                    if c.IsCoercesToConstraint then
                        if isInterfaceType c.CoercesToTarget then
                            Some(convType c.CoercesToTarget)
                        else
                            None
                    else
                        None
                )
            BaseTypeConstraint =
                gp.Constraints
                |> Seq.tryPick (fun c ->
                    if c.IsCoercesToConstraint then
                        if not (isInterfaceType c.CoercesToTarget) then
                            Some(convType c.CoercesToTarget)
                        else
                            None
                    else
                        None
                )
            DefaultConstructorConstraint = gp.Constraints |> Seq.exists (fun c -> c.IsRequiresDefaultConstructorConstraint)
            ReferenceTypeConstraint = gp.Constraints |> Seq.exists (fun c -> c.IsReferenceTypeConstraint)
            NotNullableValueTypeConstraint = gp.Constraints |> Seq.exists (fun c -> c.IsNonNullableValueTypeConstraint)
        }
    and convField (f: FSharpField) : DFieldDef =
        {
            Name = f.Name
            IsStatic = f.IsStatic
            IsMutable = f.IsMutable
            FieldType = convType f.FieldType
            Range = convRange f.DeclarationLocation
            IsCompilerGenerated = f.IsCompilerGenerated
        }
    and convGenericParamDefs (gps: seq<FSharpGenericParameter>) =
        gps |> Seq.toArray |> Array.map convGenericParamDef

    let rec convDecl d =
        [|
            match d with
            | FSharpImplementationFileDeclaration.Entity (e, subDecls) ->
                if e.IsFSharpAbbreviation then
                    ()
                elif e.IsNamespace then
                    yield! convDecls subDecls
                elif e.IsArrayType then
                    ()
                else
                    let eR =
                        try
                            convEntityDef e
                        with
                            | exn -> failwithf "error converting entity %s\n%A" e.CompiledName exn
                    let declsR = convDecls subDecls
                    yield DDeclEntity(eR, declsR)

            | FSharpImplementationFileDeclaration.MemberOrFunctionOrValue (v, vs, e) ->
                let isLiveCheck =
                    v.Attributes |> Seq.exists (fun attr -> attr.AttributeType.LogicalName.Contains "CheckAttribute")
                if isLiveCheck then printfn "member %s is a LiveCheck!" v.LogicalName
                // Skip Equals, GetHashCode, CompareTo compiler-generated methods
                //if v.IsValCompiledAsMethod || not v.IsMember then
                let vR =
                    try
                        convMemberDef v
                    with
                        | exn -> failwithf "error converting defn of %s\n%A" v.CompiledName exn
                let eR =
                    try
                        Ok(convExpr e)
                    with
                        | exn -> Error exn
                match eR with
                | Ok eR -> yield DDeclMember(vR, eR, isLiveCheck)
                | Error exn ->
                    match exn with
                    | IncompleteExpr when tolerateIncomplete -> ()
                    | _ -> failwithf "error converting rhs of %s\n%A" v.CompiledName exn

            | FSharpImplementationFileDeclaration.InitAction (e) ->
                let eR =
                    try
                        Ok(convExpr e)
                    with
                        | exn -> Error exn
                match eR with
                | Ok eR -> yield DDecl.InitAction(eR, convRange e.Range)
                | Error exn ->
                    match exn with
                    | IncompleteExpr when tolerateIncomplete -> ()
                    | _ -> failwithf "error converting expression\n%A" exn
        |]

    and convDecls decls = decls |> Array.ofList |> Array.collect convDecl

    member __.ConvertDecls(decls) = convDecls decls
