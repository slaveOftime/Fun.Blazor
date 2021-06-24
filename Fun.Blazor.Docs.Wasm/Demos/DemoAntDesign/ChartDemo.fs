[<AutoOpen>]
module rec Fun.Blazor.Docs.Wasm.DemoAntDesign.ChartDemo

open AntDesign.Charts
open AntDesign.Charts


type Item =
    { country: string 
      year: string
      value: int }


let chartDemo =
    percentStackedArea<Item>.create [
        percentStackedArea.config (
            PercentStackedAreaConfig(
                Title = Title(Visible = true, Text = "百分比堆叠面积图"),
                Meta = Meta(Range = [| 0; 1 |]),
                XField = "year",
                YField = "value",
                StackField = "country",
                //Color = OneOf.OneOf( [| "#82d1de"; "#cb302d"; "#e3ca8c" |],
                AreaStyle = GraphicStyle(FillOpacity = 0.7M)))
        percentStackedArea.data items
    ]



let items =
    [
        {
            country = "Asia"
            year = "1750"
            value = 502
        }
        {
            country = "Asia"
            year = "1800"
            value = 635
        }
        {
            country = "Asia"
            year = "1850"
            value = 809
        }
        {
            country = "Asia"
            year = "1900"
            value = 947
        }
        {
            country = "Asia"
            year = "1950"
            value = 1402
        }
        {
            country = "Asia"
            year = "1999"
            value = 3634
        }
        {
            country = "Asia"
            year = "2050"
            value = 5268
        }
        {
            country = "Africa"
            year = "1750"
            value = 106
        }
        {
            country = "Africa"
            year = "1800"
            value = 107
        }
        {
            country = "Africa"
            year = "1850"
            value = 111
        }
        {
            country = "Africa"
            year = "1900"
            value = 133
        }
        {
            country = "Africa"
            year = "1950"
            value = 221
        }
        {
            country = "Africa"
            year = "1999"
            value = 767
        }
        {
            country = "Africa"
            year = "2050"
            value = 1766
        }
        {
            country = "Europe"
            year = "1750"
            value = 163
        }
        {
            country = "Europe"
            year = "1800"
            value = 203
        }
        {
            country = "Europe"
            year = "1850"
            value = 276
        }
        {
            country = "Europe"
            year = "1900"
            value = 408
        }
        {
            country = "Europe"
            year = "1950"
            value = 547
        }
        {
            country = "Europe"
            year = "1999"
            value = 729
        }
        {
            country = "Europe"
            year = "2050"
            value = 628
        }
    ]
