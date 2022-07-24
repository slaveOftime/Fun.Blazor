namespace Fun.Blazor

open System.Text
open System.Collections.Generic


type StringRenderTreeBuilder(sb: StringBuilder) =
    let mutable isElementPartialClose = true
    let elementStack = Stack<string>()

    let ensureClose () =
        if not isElementPartialClose then
            sb.AppendLine(">") |> ignore
            isElementPartialClose <- true

    let makeIndent () =
        if elementStack.Count > 0 then
            let mutable deep = elementStack.Count
            while deep > 0 do
                sb.Append("    ") |> ignore
                deep <- deep - 1

    interface IRenderTreeBuilder with
        ///<summary><para>
        ///            Appends a frame representing a bool-valued attribute with value 'true'.
        ///            </para><para>
        ///            The attribute is associated with the most recently added element.
        ///            </para></summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="name">The name of the attribute.</param>
        member _.AddAttribute(sequence: int, name: string) : unit = sb.Append(" ").Append(name) |> ignore

        ///<summary><para>
        ///            Appends a frame representing an attribute.
        ///            </para><para>
        ///            The attribute is associated with the most recently added element.
        ///            </para></summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="frame">A <see cref="T:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame" /> holding the name and value of the attribute.</param>
        member _.AddAttribute(sequence: int, frame: Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame) : unit = failwith "Not implemented"

        ///<summary><para>
        ///            Appends a frame representing a bool-valued attribute.
        ///            </para><para>
        ///            The attribute is associated with the most recently added element. If the value is <c>false</c> and the
        ///            current element is not a component, the frame will be omitted.
        ///            </para></summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="name">The name of the attribute.</param>
        ///<param name="value">The value of the attribute.</param>
        member _.AddAttribute(sequence: int, name: string, value: bool) : unit = if value then sb.Append(" ").Append(name) |> ignore

        ///<summary><para>
        ///            Appends a frame representing a string-valued attribute.
        ///            </para><para>
        ///            The attribute is associated with the most recently added element. If the value is <c>null</c> and the
        ///            current element is not a component, the frame will be omitted.
        ///            </para></summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="name">The name of the attribute.</param>
        ///<param name="value">The value of the attribute.</param>
        member _.AddAttribute(sequence: int, name: string, value: string) : unit =
            sb.Append(" ").Append(name).Append("=\"").Append(value).Append("\"") |> ignore

        ///<summary><para>
        ///            Appends a frame representing a delegate-valued attribute.
        ///            </para><para>
        ///            The attribute is associated with the most recently added element. If the value is <c>null</c> and the
        ///            current element is not a component, the frame will be omitted.
        ///            </para></summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="name">The name of the attribute.</param>
        ///<param name="value">The value of the attribute.</param>
        member _.AddAttribute(sequence: int, name: string, value: System.MulticastDelegate) : unit = failwith "Not implemented"

        ///<summary><para>
        ///            Appends a frame representing an <see cref="T:Microsoft.AspNetCore.Components.EventCallback" /> attribute.
        ///            </para><para>
        ///            The attribute is associated with the most recently added element. If the value is <c>null</c> and the
        ///            current element is not a component, the frame will be omitted.
        ///            </para></summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="name">The name of the attribute.</param>
        ///<param name="value">The value of the attribute.</param>
        ///<remarks>
        ///            This method is provided for infrastructure purposes, and is used to support generated code
        ///            that uses <see cref="T:Microsoft.AspNetCore.Components.EventCallbackFactory" />.
        ///            </remarks>
        member _.AddAttribute(sequence: int, name: string, value: Microsoft.AspNetCore.Components.EventCallback) : unit = failwith "Not implemented"

        ///<summary><para>
        ///            Appends a frame representing an <see cref="T:Microsoft.AspNetCore.Components.EventCallback" /> attribute.
        ///            </para><para>
        ///            The attribute is associated with the most recently added element. If the value is <c>null</c> and the
        ///            current element is not a component, the frame will be omitted.
        ///            </para></summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="name">The name of the attribute.</param>
        ///<param name="value">The value of the attribute.</param>
        ///<remarks>
        ///            This method is provided for infrastructure purposes, and is used to support generated code
        ///            that uses <see cref="T:Microsoft.AspNetCore.Components.EventCallbackFactory" />.
        ///            </remarks>
        member _.AddAttribute<'TArgument>(sequence: int, name: string, value: Microsoft.AspNetCore.Components.EventCallback<'TArgument>) : unit =
            failwith "Not implemented"

        ///<summary>
        ///            Appends a frame representing a string-valued attribute.
        ///            The attribute is associated with the most recently added element. If the value is <c>null</c>, or
        ///            the <see cref="T:System.Boolean" /> value <c>false</c> and the current element is not a component, the
        ///            frame will be omitted.
        ///            </summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="name">The name of the attribute.</param>
        ///<param name="value">The value of the attribute.</param>
        member _.AddAttribute(sequence: int, name: string, value: obj) : unit =
            sb.Append(" ").Append(name).Append("=\"").Append(value).Append("\"") |> ignore

        ///<summary>
        ///            Appends a frame representing an instruction to capture a reference to the parent component.
        ///            </summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="componentReferenceCaptureAction">An action to be invoked whenever the reference value changes.</param>
        member _.AddComponentReferenceCapture(sequence: int, componentReferenceCaptureAction: System.Action<obj>) : unit = failwith "Not implemented"

        ///<summary>
        ///            Appends a frame representing text content.
        ///            </summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="textContent">Content for the new text frame.</param>
        member _.AddContent(sequence: int, textContent: string) : unit =
            ensureClose ()
            makeIndent ()
            sb.AppendLine(textContent) |> ignore

        ///<summary>
        ///            Appends frames representing an arbitrary fragment of content.
        ///            </summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="fragment">Content to append.</param>
        member _.AddContent(sequence: int, fragment: Microsoft.AspNetCore.Components.RenderFragment) : unit = failwith "Not implemented"

        ///<summary>
        ///            Appends a frame representing markup content.
        ///            </summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="markupContent">Content for the new markup frame.</param>
        member _.AddContent(sequence: int, markupContent: Microsoft.AspNetCore.Components.MarkupString) : unit =
            ensureClose ()
            makeIndent ()
            sb.AppendLine(markupContent.Value) |> ignore

        ///<summary>
        ///            Appends a frame representing text content.
        ///            </summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="textContent">Content for the new text frame.</param>
        member _.AddContent(sequence: int, textContent: obj) : unit =
            ensureClose ()
            makeIndent ()
            sb.Append(textContent).AppendLine() |> ignore

        ///<summary>
        ///            Appends frames representing an arbitrary fragment of content.
        ///            </summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="fragment">Content to append.</param>
        ///<param name="value">The value used by <paramref name="fragment" />.</param>
        member _.AddContent<'TValue>(sequence: int, fragment: Microsoft.AspNetCore.Components.RenderFragment<'TValue>, value: 'TValue) : unit =
            failwith "Not implemented"

        ///<summary>
        ///            Appends a frame representing an instruction to capture a reference to the parent element.
        ///            </summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="elementReferenceCaptureAction">An action to be invoked whenever the reference value changes.</param>
        member _.AddElementReferenceCapture
            (
                sequence: int,
                elementReferenceCaptureAction: System.Action<Microsoft.AspNetCore.Components.ElementReference>
            )
            : unit
            =
            failwith "Not implemented"

        ///<summary>
        ///            Appends a frame representing markup content.
        ///            </summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="markupContent">Content for the new markup frame.</param>
        member _.AddMarkupContent(sequence: int, markupContent: string) : unit =
            ensureClose ()
            makeIndent ()
            sb.Append(markupContent) |> ignore

        ///<summary>
        ///            Adds frames representing multiple attributes with the same sequence number.
        ///            </summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="attributes">A collection of key-value pairs representing attributes.</param>
        member _.AddMultipleAttributes
            (
                sequence: int,
                attributes: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, obj>>
            )
            : unit
            =
            failwith "Not implemented"

        ///<summary>
        ///            Marks a previously appended component frame as closed. Calls to this method
        ///            must be balanced with calls to <see cref="M:Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder.OpenComponent``1(System.Int32)" />.
        ///            </summary>
        member _.CloseComponent() = failwith "Not implemented"

        ///<summary>
        ///            Marks a previously appended element frame as closed. Calls to this method
        ///            must be balanced with calls to <see cref="M:Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder.OpenElement(System.Int32,System.String)" />.
        ///            </summary>
        member _.CloseElement() =
            ensureClose()
            let elementName = elementStack.Pop()
            makeIndent ()
            sb.Append("</").Append(elementName).AppendLine(">") |> ignore

        ///<summary>
        ///            Marks a previously appended region frame as closed. Calls to this method
        ///            must be balanced with calls to <see cref="M:Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder.OpenRegion(System.Int32)" />.
        ///            </summary>
        member _.CloseRegion() = failwith "Not implemented"

        ///<summary>
        ///            Appends a frame representing a child component.
        ///            </summary>
        ///<typeparam name="TComponent">The type of the child component.</typeparam>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        member _.OpenComponent<'TComponent when 'TComponent :> Microsoft.AspNetCore.Components.IComponent>(sequence: int) : unit =
            failwith "Not implemented"

        ///<summary>
        ///            Appends a frame representing a child component.
        ///            </summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="componentType">The type of the child component.</param>
        member _.OpenComponent(sequence: int, componentType: System.Type) : unit = failwith "Not implemented"

        ///<summary>
        ///            Appends a frame representing an element, i.e., a container for other frames.
        ///            In order for the <see cref="T:Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder" /> state to be valid, you must
        ///            also call <see cref="M:Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder.CloseElement" /> immediately after appending the
        ///            new element's child frames.
        ///            </summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="elementName">A value representing the type of the element.</param>
        member _.OpenElement(sequence: int, elementName: string) : unit =
            ensureClose ()
            makeIndent ()
            isElementPartialClose <- false
            elementStack.Push(elementName)
            sb.Append("<").Append(elementName) |> ignore

        ///<summary>
        ///            Appends a frame representing a region of frames.
        ///            </summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        member _.OpenRegion(sequence: int) : unit = failwith "Not implemented"

        ///<summary>
        ///            Assigns the specified key value to the current element or component.
        ///            </summary>
        ///<param name="value">The value for the key.</param>
        member _.SetKey(value: obj) : unit = failwith "Not implemnted"

        member _.AddEventPreventDefaultAttribute(sequence: int, eventName: string, value: bool) = failwith "Not implemented"

        member _.AddEventStopPropagationAttribute(sequence: int, eventName: string, value: bool) = failwith "Not implemented"
