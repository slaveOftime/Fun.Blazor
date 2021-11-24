[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.DemoDragDrop.ListDragDropDemo

open System.Collections.Generic
open FSharp.Data.Adaptive
open Fun.Blazor
open MudBlazor
open Blazor.DragDrop

let listDragDropDemo =
    adaptiview(){
        let! items1 = cval(List [1..4])
        let! items2 = cval(List [5..10])
        let! lastDropItem, setLastDropItem = cval(-1).WithSetter()

        MudContainer'(){
            Styles [ style.padding 10 ]
            childContent [
                Dropzone'(){
                    Items items1
                    AllowsDrag (fun x -> x > 2)
                    OnItemDrop setLastDropItem
                    ChildContent (fun item ->
                        div(){
                            styles [
                                style.color "white"; style.cursorGrab
                                if item = lastDropItem then
                                    style.backgroundColor "hotpink"
                                else
                                    style.backgroundColor "blue"
                            ]
                            childContent $"item {item}"
                        }
                    )
                }
                Dropzone'(){
                    Items items2
                    AllowsDrag (fun x -> x < 9)
                    OnItemDrop setLastDropItem
                    ChildContent (fun item ->
                        div(){
                            styles [
                                style.color "white"; style.cursorGrab
                                if item = lastDropItem then
                                    style.backgroundColor "orange"
                                else
                                    style.backgroundColor "green"
                            ]
                            childContent $"item {item}"
                        }
                    )
                }
            ]
        }
    }
