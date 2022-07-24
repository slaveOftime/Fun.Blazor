namespace Fun.Blazor

///<summary>
///            Provides methods for building a collection of <see cref="T:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame" /> entries.
///            </summary>
type IRenderTreeBuilder =

    ///<summary><para>
    ///            Appends a frame representing a bool-valued attribute with value 'true'.
    ///            </para><para>
    ///            The attribute is associated with the most recently added element.
    ///            </para></summary>
    ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
    ///<param name="name">The name of the attribute.</param>
    abstract member AddAttribute: sequence: int * name: string -> unit

    ///<summary><para>
    ///            Appends a frame representing an attribute.
    ///            </para><para>
    ///            The attribute is associated with the most recently added element.
    ///            </para></summary>
    ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
    ///<param name="frame">A <see cref="T:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame" /> holding the name and value of the attribute.</param>
    abstract member AddAttribute: sequence: int * frame: Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame -> unit

    ///<summary><para>
    ///            Appends a frame representing a bool-valued attribute.
    ///            </para><para>
    ///            The attribute is associated with the most recently added element. If the value is <c>false</c> and the
    ///            current element is not a component, the frame will be omitted.
    ///            </para></summary>
    ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
    ///<param name="name">The name of the attribute.</param>
    ///<param name="value">The value of the attribute.</param>
    abstract member AddAttribute: sequence: int * name: string * value: bool -> unit

    ///<summary><para>
    ///            Appends a frame representing a string-valued attribute.
    ///            </para><para>
    ///            The attribute is associated with the most recently added element. If the value is <c>null</c> and the
    ///            current element is not a component, the frame will be omitted.
    ///            </para></summary>
    ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
    ///<param name="name">The name of the attribute.</param>
    ///<param name="value">The value of the attribute.</param>
    abstract member AddAttribute: sequence: int * name: string * value: string -> unit

    ///<summary><para>
    ///            Appends a frame representing a delegate-valued attribute.
    ///            </para><para>
    ///            The attribute is associated with the most recently added element. If the value is <c>null</c> and the
    ///            current element is not a component, the frame will be omitted.
    ///            </para></summary>
    ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
    ///<param name="name">The name of the attribute.</param>
    ///<param name="value">The value of the attribute.</param>
    abstract member AddAttribute: sequence: int * name: string * value: System.MulticastDelegate -> unit

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
    abstract member AddAttribute: sequence: int * name: string * value: Microsoft.AspNetCore.Components.EventCallback -> unit

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
    abstract member AddAttribute<'TArgument> : sequence: int * name: string * value: Microsoft.AspNetCore.Components.EventCallback<'TArgument> -> unit

    ///<summary>
    ///            Appends a frame representing a string-valued attribute.
    ///            The attribute is associated with the most recently added element. If the value is <c>null</c>, or
    ///            the <see cref="T:System.Boolean" /> value <c>false</c> and the current element is not a component, the
    ///            frame will be omitted.
    ///            </summary>
    ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
    ///<param name="name">The name of the attribute.</param>
    ///<param name="value">The value of the attribute.</param>
    abstract member AddAttribute: sequence: int * name: string * value: obj -> unit

    ///<summary>
    ///            Appends a frame representing an instruction to capture a reference to the parent component.
    ///            </summary>
    ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
    ///<param name="componentReferenceCaptureAction">An action to be invoked whenever the reference value changes.</param>
    abstract member AddComponentReferenceCapture: sequence: int * componentReferenceCaptureAction: System.Action<obj> -> unit

    ///<summary>
    ///            Appends a frame representing text content.
    ///            </summary>
    ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
    ///<param name="textContent">Content for the new text frame.</param>
    abstract member AddContent: sequence: int * textContent: string -> unit

    ///<summary>
    ///            Appends frames representing an arbitrary fragment of content.
    ///            </summary>
    ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
    ///<param name="fragment">Content to append.</param>
    abstract member AddContent: sequence: int * fragment: Microsoft.AspNetCore.Components.RenderFragment -> unit

    ///<summary>
    ///            Appends a frame representing markup content.
    ///            </summary>
    ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
    ///<param name="markupContent">Content for the new markup frame.</param>
    abstract member AddContent: sequence: int * markupContent: Microsoft.AspNetCore.Components.MarkupString -> unit

    ///<summary>
    ///            Appends a frame representing text content.
    ///            </summary>
    ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
    ///<param name="textContent">Content for the new text frame.</param>
    abstract member AddContent: sequence: int * textContent: obj -> unit

    ///<summary>
    ///            Appends frames representing an arbitrary fragment of content.
    ///            </summary>
    ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
    ///<param name="fragment">Content to append.</param>
    ///<param name="value">The value used by <paramref name="fragment" />.</param>
    abstract member AddContent<'TValue> : sequence: int * fragment: Microsoft.AspNetCore.Components.RenderFragment<'TValue> * value: 'TValue -> unit

    ///<summary>
    ///            Appends a frame representing an instruction to capture a reference to the parent element.
    ///            </summary>
    ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
    ///<param name="elementReferenceCaptureAction">An action to be invoked whenever the reference value changes.</param>
    abstract member AddElementReferenceCapture:
        sequence: int * elementReferenceCaptureAction: System.Action<Microsoft.AspNetCore.Components.ElementReference> -> unit

    ///<summary>
    ///            Appends a frame representing markup content.
    ///            </summary>
    ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
    ///<param name="markupContent">Content for the new markup frame.</param>
    abstract member AddMarkupContent: sequence: int * markupContent: string -> unit

    ///<summary>
    ///            Adds frames representing multiple attributes with the same sequence number.
    ///            </summary>
    ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
    ///<param name="attributes">A collection of key-value pairs representing attributes.</param>
    abstract member AddMultipleAttributes:
        sequence: int * attributes: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, obj>> -> unit

    ///<summary>
    ///            Marks a previously appended component frame as closed. Calls to this method
    ///            must be balanced with calls to <see cref="M:Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder.OpenComponent``1(System.Int32)" />.
    ///            </summary>
    abstract member CloseComponent: unit -> unit

    ///<summary>
    ///            Marks a previously appended element frame as closed. Calls to this method
    ///            must be balanced with calls to <see cref="M:Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder.OpenElement(System.Int32,System.String)" />.
    ///            </summary>
    abstract member CloseElement: unit -> unit

    ///<summary>
    ///            Marks a previously appended region frame as closed. Calls to this method
    ///            must be balanced with calls to <see cref="M:Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder.OpenRegion(System.Int32)" />.
    ///            </summary>
    abstract member CloseRegion: unit -> unit

    ///<summary>
    ///            Appends a frame representing a child component.
    ///            </summary>
    ///<typeparam name="TComponent">The type of the child component.</typeparam>
    ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
    abstract member OpenComponent<'TComponent when 'TComponent :> Microsoft.AspNetCore.Components.IComponent> : sequence: int -> unit

    ///<summary>
    ///            Appends a frame representing a child component.
    ///            </summary>
    ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
    ///<param name="componentType">The type of the child component.</param>
    abstract member OpenComponent: sequence: int * componentType: System.Type -> unit

    ///<summary>
    ///            Appends a frame representing an element, i.e., a container for other frames.
    ///            In order for the <see cref="T:Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder" /> state to be valid, you must
    ///            also call <see cref="M:Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder.CloseElement" /> immediately after appending the
    ///            new element's child frames.
    ///            </summary>
    ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
    ///<param name="elementName">A value representing the type of the element.</param>
    abstract member OpenElement: sequence: int * elementName: string -> unit

    ///<summary>
    ///            Appends a frame representing a region of frames.
    ///            </summary>
    ///<param name="sequence">An integer that represents the position of the instruction in the source code.</param>
    abstract member OpenRegion: sequence: int -> unit

    abstract member SetKey: value: obj -> unit

    abstract member AddEventPreventDefaultAttribute: sequence: int * eventName: string * value: bool -> unit
    abstract member AddEventStopPropagationAttribute: sequence: int * eventName: string * value: bool -> unit
