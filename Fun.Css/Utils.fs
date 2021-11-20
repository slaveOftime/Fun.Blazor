namespace Fun.Css

open System


type internal Util =
    static member inline asString(x: string): string = x
    static member inline asString(x: int): string = string x
    static member inline asString(x: int option): string =
        match x with Some x -> Util.asString x | None -> ""
    static member inline asString(x: float): string = string x
    static member inline asString(x: Guid): string = string x
    static member inline asString< ^t when ^t : (member AsString: string)> (x: ^t): string =
#if FABLE_COMPILER
        unbox x
#else
        (^t : (member AsString: string) (x))
#endif
    static member inline asString< ^t when ^t : (member AsString: string)> (x: ^t option): string =
        match x with Some x -> Util.asString x | None -> ""

    static member inline newCssUnit(x: string): ICssUnit =
#if FABLE_COMPILER
        unbox x
#else
        { new ICssUnit with member _.AsString = x }
#endif

    static member inline newBorderStyle(x: string): IBorderStyle =
#if FABLE_COMPILER
        unbox x
#else
        { new IBorderStyle with member _.AsString = x }
#endif

    static member inline newGridSpan(x: string): IGridSpan =
#if FABLE_COMPILER
        unbox x
#else
        { new IGridSpan with member _.AsString = x }
#endif

    static member inline newGridTemplateItem(x: string): IGridTemplateItem =
#if FABLE_COMPILER
        unbox x
#else
        { new IGridTemplateItem with member _.AsString = x }
#endif

    static member inline newTextDecorationLine(x: string): ITextDecorationLine =
#if FABLE_COMPILER
        unbox x
#else
        { new ITextDecorationLine with member _.AsString = x }
#endif

    static member inline newTextDecoration(x: string): ITextDecoration =
#if FABLE_COMPILER
        unbox x
#else
        { new ITextDecoration with member _.AsString = x }
#endif

    static member inline newTransformProperty(x: string): ITransformProperty =
#if FABLE_COMPILER
        unbox x
#else
        { new ITransformProperty with member _.AsString = x }
#endif

    static member inline newTransitionProperty(x: string): ITransitionProperty =
#if FABLE_COMPILER
        unbox x
#else
        { new ITransitionProperty with member _.AsString = x }
#endif
