module Fun.Blazor.Tests.I18nTests

open Xunit
open Fun.Blazor


let json =
    """
    {
        "Title": "test app",
        "Messages": {
            "Error1": "Error 1: {0}",
            "Error3": "Error 3: {0} {1} {2}",
            "Danger": {
                "Alert": "fail"
            }
        }
    }
    """


[<Fact>]
let ``Normal usecases`` () =
    let i18n = I18n(json)

    Assert.Equal("test app", i18n.tran "Title")
    Assert.Equal("Titl2", i18n.tran "Titl2")

    Assert.Equal(Some "test app", i18n.tryTran "Title")
    Assert.Equal(None, i18n.tryTran "Titl2")
    Assert.Equal(None, i18n.tryTran ("Titl2", 1, 2))

    Assert.Equal("Messages.Error1", i18n.tran ("Messages.Error1"))
    Assert.Equal("Messages.Error3: 1, 2", i18n.tran ("Messages.Error3", 1, 2))
    Assert.Equal(Some "Error 1: 1", i18n.tryTran ("Messages.Error1", 1, 2, 3))
    Assert.Equal(None, i18n.tryTran ("Messages.Error3"))

    Assert.Equal("Error 1: hi", i18n.tran ("Messages.Error1", "hi"))
    Assert.Equal("Error 1: hi", i18n.tran ("Messages.Error1", "hi", 123))
    Assert.Equal("Error 1: hi", i18n.tran ("Messages.Error1", "hi", 123, 456))


[<Fact>]
let ``Multi languages`` () =
    let newLang =
        """
        {
            "Title": "测试应用",
            "Messages": {
                "Danger": {
                    "Alert": "fail"
                }
            }
        }
        """

    let i18n = I18n(json).MergeToNew(newLang)

    Assert.Equal("测试应用", i18n.tran "Title")
    Assert.Equal("Error 1: 123", i18n.tran ("Messages.Error1", "123"))
    Assert.Equal("fail", i18n.tran ("Messages.Danger.Alert"))
