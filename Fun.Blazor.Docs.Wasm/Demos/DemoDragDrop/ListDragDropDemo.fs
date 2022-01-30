[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.DemoDragDrop.ListDragDropDemo

open System.Collections.Generic
open FSharp.Data.Adaptive
open Fun.Blazor
open MudBlazor
open Blazor.DragDrop


let listDragDropDemo =
    adaptiview () {
        let! items1 = cval (List [ 1 .. 4 ])
        let! items2 = cval (List [ 5 .. 10 ])
        let! lastDropItem, setLastDropItem = cval(-1).WithSetter()

        MudContainer' {
            Styles [ styl.padding 10 ]
            Dropzone' {
                Items items1
                AllowsDrag(fun x -> x > 2)
                OnItemDrop setLastDropItem
                ChildContent(fun item ->
                    div {
                        styles [
                            styl.color "white"
                            styl.cursorGrab
                            if item = lastDropItem then
                                styl.backgroundColor "hotpink"
                            else
                                styl.backgroundColor "blue"
                        ]
                        $"item {item}"
                    }
                )
            }
            Dropzone' {
                Items items2
                AllowsDrag(fun x -> x < 9)
                OnItemDrop setLastDropItem
                ChildContent(fun item ->
                    div {
                        styles [
                            styl.color "white"
                            styl.cursorGrab
                            if item = lastDropItem then
                                styl.backgroundColor "orange"
                            else
                                styl.backgroundColor "green"
                        ]
                        $"item {item}"
                    }
                )
            }
        }
    }
