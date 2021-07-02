```
dotnet tool install -g Fun.Blazor.Cli
```

Steps:

1. Add any third party blazor components like AntDesign to your application and build in debug mode to pull the nuget packages

    `FunBlazor`
        
        Add this empty attribute to below you will get the default generating settings
        Will generate code in namespace of the package name (AntDesign), with computation style

   ```
    <PackageReference FunBlazor="" Include="AntDesign" Version="0.8.2" />
   ```

   `FunBlazorNamespace`: Give namespace
   
   `FunBlazorStyle`: Feliz | CE, this will override the settings in the commandline
   

2. Run the command

    ```
    fun-blazor generate ./YourApplication.fsproj
    ```

    By default, code will be generated in the `Fun.Blazor.Bindings` folder. All the binding types are in lowercase

    `-o|--outDir`: Customize the generated folder name

    `-s|--style`: Customize the style (Feliz | CE)


3. Enjoy it

    CE style:

    ```fsharp
    open Fun.Blazor
    open MudBlazor

    let alertDemo =
        mudCard [
            mudAlert() {
                icon Icons.Filled.AccessAlarm
                childContentStr "This is the way"
                CAST
            }
        ]
    ```

    Feliz style

    ```fsharp
    open Fun.Blazor
    open MudBlazor

    let alertDemo =
        mudCard.create [
            mudAlert.create [
                mudAlert.icon Icons.Filled.AccessAlarm
                mudAlert.childContent "This is the way"
            ]
        ]
    ```


### Limitations

1. For CE (computation expression) style, F# do not support override CustomOperation, so I have to flat inherited properties which may make the binding files a little bigger.

2. F# cannot infer some interface automatic casting, so sometimes you may need to add CAST at the end of you usage like:

    ```fsharp
    html.watch (openMenu, fun isOpen ->
        mudDrawer() {
            open' isOpen
            elevation 25
            variant DrawerVariant.Persistent
            childContent [
                mudDrawerHeader() {
                    linkToIndex true
                    childContent [
                        mudText() {
                            color Color.Primary
                            typo Typo.h5
                            childContentStr "Have fun ✌"
                        }
                    ]
                }
                navmenu
            ]
            CAST
        }
    )
    ```

    html.watch has multiple overrides, one is aking for return a IFunBlazorNode, even mudDrawer implemented interface IFunBlazorNode, the compiler still give error only if you cast it maunally.

    childContent only asks for `IFunBlazorNode list`, F# can infer that so you do not need add `CAST`
