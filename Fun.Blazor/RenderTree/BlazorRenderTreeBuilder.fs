namespace Fun.Blazor

open Microsoft.AspNetCore.Components.Web
open Microsoft.AspNetCore.Components.Rendering


[<Struct>]
type BlazorRenderTreeBuilder(builder: RenderTreeBuilder) =
    interface IRenderTreeBuilder with
        ///<summary><para>
        ///            Appends a frame representing a bool-valued attribute with value 'true'.
        ///            </para><para>
        ///            The attribute is associated with the most recently added element.
        ///            </para></summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="name">The name of the attribute.</param>
        member _.AddAttribute(sequence: int, name: string) : unit = builder.AddAttribute(sequence, name)

        ///<summary><para>
        ///            Appends a frame representing an attribute.
        ///            </para><para>
        ///            The attribute is associated with the most recently added element.
        ///            </para></summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="frame">A <see cref="T:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame" /> holding the name and value of the attribute.</param>
        member _.AddAttribute(sequence: int, frame: Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame) : unit =
            builder.AddAttribute(sequence, frame)

        ///<summary><para>
        ///            Appends a frame representing a bool-valued attribute.
        ///            </para><para>
        ///            The attribute is associated with the most recently added element. If the value is <c>false</c> and the
        ///            current element is not a component, the frame will be omitted.
        ///            </para></summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="name">The name of the attribute.</param>
        ///<param name="value">The value of the attribute.</param>
        member _.AddAttribute(sequence: int, name: string, value: bool) : unit = builder.AddAttribute(sequence, name, value)

        ///<summary><para>
        ///            Appends a frame representing a string-valued attribute.
        ///            </para><para>
        ///            The attribute is associated with the most recently added element. If the value is <c>null</c> and the
        ///            current element is not a component, the frame will be omitted.
        ///            </para></summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="name">The name of the attribute.</param>
        ///<param name="value">The value of the attribute.</param>
        member _.AddAttribute(sequence: int, name: string, value: string) : unit = builder.AddAttribute(sequence, name, value)

        ///<summary><para>
        ///            Appends a frame representing a delegate-valued attribute.
        ///            </para><para>
        ///            The attribute is associated with the most recently added element. If the value is <c>null</c> and the
        ///            current element is not a component, the frame will be omitted.
        ///            </para></summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="name">The name of the attribute.</param>
        ///<param name="value">The value of the attribute.</param>
        member _.AddAttribute(sequence: int, name: string, value: System.MulticastDelegate) : unit = builder.AddAttribute(sequence, name, value)

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
        member _.AddAttribute(sequence: int, name: string, value: Microsoft.AspNetCore.Components.EventCallback) : unit =
            builder.AddAttribute(sequence, name, value)

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
            builder.AddAttribute<'TArgument>(sequence, name, value)

        ///<summary>
        ///            Appends a frame representing a string-valued attribute.
        ///            The attribute is associated with the most recently added element. If the value is <c>null</c>, or
        ///            the <see cref="T:System.Boolean" /> value <c>false</c> and the current element is not a component, the
        ///            frame will be omitted.
        ///            </summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="name">The name of the attribute.</param>
        ///<param name="value">The value of the attribute.</param>
        member _.AddAttribute(sequence: int, name: string, value: obj) : unit = builder.AddAttribute(sequence, name, value)

        ///<summary>
        ///            Appends a frame representing an instruction to capture a reference to the parent component.
        ///            </summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="componentReferenceCaptureAction">An action to be invoked whenever the reference value changes.</param>
        member _.AddComponentReferenceCapture(sequence: int, componentReferenceCaptureAction: System.Action<obj>) : unit =
            builder.AddComponentReferenceCapture(sequence, componentReferenceCaptureAction)

        ///<summary>
        ///            Appends a frame representing text content.
        ///            </summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="textContent">Content for the new text frame.</param>
        member _.AddContent(sequence: int, textContent: string) : unit = builder.AddContent(sequence, textContent)

        ///<summary>
        ///            Appends frames representing an arbitrary fragment of content.
        ///            </summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="fragment">Content to append.</param>
        member _.AddContent(sequence: int, fragment: Microsoft.AspNetCore.Components.RenderFragment) : unit = builder.AddContent(sequence, fragment)

        ///<summary>
        ///            Appends a frame representing markup content.
        ///            </summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="markupContent">Content for the new markup frame.</param>
        member _.AddContent(sequence: int, markupContent: Microsoft.AspNetCore.Components.MarkupString) : unit =
            builder.AddContent(sequence, markupContent)

        ///<summary>
        ///            Appends a frame representing text content.
        ///            </summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="textContent">Content for the new text frame.</param>
        member _.AddContent(sequence: int, textContent: obj) : unit = builder.AddContent(sequence, textContent)

        ///<summary>
        ///            Appends frames representing an arbitrary fragment of content.
        ///            </summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="fragment">Content to append.</param>
        ///<param name="value">The value used by <paramref name="fragment" />.</param>
        member _.AddContent<'TValue>(sequence: int, fragment: Microsoft.AspNetCore.Components.RenderFragment<'TValue>, value: 'TValue) : unit =
            builder.AddContent<'TValue>(sequence, fragment, value)

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
            builder.AddElementReferenceCapture(sequence, elementReferenceCaptureAction)

        ///<summary>
        ///            Appends a frame representing markup content.
        ///            </summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="markupContent">Content for the new markup frame.</param>
        member _.AddMarkupContent(sequence: int, markupContent: string) : unit = builder.AddMarkupContent(sequence, markupContent)

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
            builder.AddMultipleAttributes(sequence, attributes)

        ///<summary>
        ///            Marks a previously appended component frame as closed. Calls to this method
        ///            must be balanced with calls to <see cref="M:Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder.OpenComponent``1(System.Int32)" />.
        ///            </summary>
        member _.CloseComponent() = builder.CloseComponent()

        ///<summary>
        ///            Marks a previously appended element frame as closed. Calls to this method
        ///            must be balanced with calls to <see cref="M:Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder.OpenElement(System.Int32,System.String)" />.
        ///            </summary>
        member _.CloseElement() = builder.CloseElement()

        ///<summary>
        ///            Marks a previously appended region frame as closed. Calls to this method
        ///            must be balanced with calls to <see cref="M:Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder.OpenRegion(System.Int32)" />.
        ///            </summary>
        member _.CloseRegion() = builder.CloseRegion()

        ///<summary>
        ///            Appends a frame representing a child component.
        ///            </summary>
        ///<typeparam name="TComponent">The type of the child component.</typeparam>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        member _.OpenComponent<'TComponent when 'TComponent :> Microsoft.AspNetCore.Components.IComponent>(sequence: int) : unit =
            builder.OpenComponent<'TComponent>(sequence)

        ///<summary>
        ///            Appends a frame representing a child component.
        ///            </summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="componentType">The type of the child component.</param>
        member _.OpenComponent(sequence: int, componentType: System.Type) : unit = builder.OpenComponent(sequence, componentType)

        ///<summary>
        ///            Appends a frame representing an element, i.e., a container for other frames.
        ///            In order for the <see cref="T:Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder" /> state to be valid, you must
        ///            also call <see cref="M:Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder.CloseElement" /> immediately after appending the
        ///            new element's child frames.
        ///            </summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        ///<param name="elementName">A value representing the type of the element.</param>
        member _.OpenElement(sequence: int, elementName: string) : unit = builder.OpenElement(sequence, elementName)

        ///<summary>
        ///            Appends a frame representing a region of frames.
        ///            </summary>
        ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
        member _.OpenRegion(sequence: int) : unit = builder.OpenRegion(sequence)

        ///<summary>
        ///            Assigns the specified key value to the current element or component.
        ///            </summary>
        ///<param name="value">The value for the key.</param>
        member _.SetKey(value: obj) : unit =  builder.SetKey(value)

        member _.AddEventPreventDefaultAttribute(sequence:int, eventName: string, value: bool) = builder.AddEventPreventDefaultAttribute(sequence, eventName, value)
       
        member _.AddEventStopPropagationAttribute(sequence:int, eventName: string, value: bool) = builder.AddEventStopPropagationAttribute(sequence, eventName, value)
