namespace Fun.Blazor


[<AbstractClass>]
type FunBlazorComponent() =
    inherit Bolero.Component()

    override this.Render() = this.Render().Node().ToBolero()

    abstract member Render: unit -> IFunBlazorNode
        