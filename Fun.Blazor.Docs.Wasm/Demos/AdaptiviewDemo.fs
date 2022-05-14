// hot-reload
module Fun.Blazor.Docs.Wasm.Demos.AdaptiviewDemo

open FSharp.Data.Adaptive
open MudBlazor
open Fun.Blazor

let entry =
    let number1 = cval 1

    adaptiview () {
        let! n1, setN1 = number1.WithSetter()
        MudButton'() {
            OnClick(fun _ -> setN1 (n1 + 1))
            childContent "Number1"
        }
        adaptiview () {
            let! n2, setN2 = cval(2).WithSetter()
            div { $"Number1: {n1}. (Will change when click Number1 and Number2)" }
            div { $"Number2: {n2}. (Will change when click Number2. And will be reset when click Number1)" }
            MudButton'() {
                OnClick(fun _ -> setN2 (n2 + 1))
                childContent "Number2"
            }
        }
        adaptiview (isStatic = true) {
            let! n3, setN3 = cval(3).WithSetter()
            div { $"Number1: {n1}. (Will change when click Number1 and Number3" }
            div { $"Number1.Value: {number1.Value}. (Will change when click Number3.)" }
            div { $"Number3: {n3}. (Will change when click Number3" }
            MudButton'() {
                OnClick(fun _ -> setN3 (n3 + 1))
                childContent "Number3"
            }
        }
    }
