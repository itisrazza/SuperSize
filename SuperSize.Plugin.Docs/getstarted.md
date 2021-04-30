# Get Started

To get started with creating a plugin, you first need the [.NET SDK] installed.
If you're using [Visual Studio], this comes built-in.

[.net sdk]: https://dotnet.microsoft.com/download/dotnet
[visual studio]: https://visualstudio.microsoft.com/

## Creating a Windows Forms Class Library

The first step is to create a Windows Forms Class Library:

```cmd
> mkdir CoolRandomWindow
> dotnet new winformslib
```

## Get SuperSize.Plugin

The package is not yet available on NuGet. But you can get the DLL from the releases.

## Add Plugin Details

Create a new class and name it `Plugin`, extending the \ref SuperSize.Plugin.PluginBase "PluginBase" abstract class.

```csharp
public class Plugin : PluginBase
{

    public override string Name { get; } = "Cool Random Window";

    public override string Author { get; } = "Samuel Hamilton";
}
```

By default, the plugin searches for classes extending the \ref SuperSize.Plugin.Logic "Logic" class and returns them as a list, but you can also provide a list yourself.

```csharp
public class Plugin : SuperSize.Plugin.Plugin
{

    public override string Name { get; } = "Cool Random Window";

    public override string Author { get; } = "Samuel Hamilton";

    public override IEnumerable<Logic> AvailableLogic { get; } = new List<Logic>
    {
        typeof(CoolRandomWindowLogic)
    };
}
```

## Add Logic
