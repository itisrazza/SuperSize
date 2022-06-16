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

To add logic, create a new class and extend the \ref SuperSize.Plugin.Logic "Logic" class, then override \ref SuperSize.Plugin.Logic.DisplayName "DisplayName", \ref SuperSize.Plugin.Logic.CalculateWindowSize "CalculateWindowSize" and \ref SuperSize.Plugin.Logic.ShowSettings "ShowSettings".

```csharp
public class UseAllScreen : Logic
{
  public override string DisplayName { get; } = "Use all the screen real estate";

  public override Task<Rectangle> CalculateWindowSize(Screen[] screens, Settings config)
  {
    var left = int.MaxValue;
    var top = int.MaxValue;
    var right = int.MinValue;
    var bottom = int.MinValue;
    foreach (var screen in screens)
    {
      var bounds = screen.Bounds;
      left = Math.Min(left, bounds.Left);
      top = Math.Min(top, bounds.Top);
      right = Math.Max(right, bounds.Right);
      bottom = Math.Max(bottom, bounds.Bottom);
    }
    return Task.FromResult(Rectangle.FromLTRB(left, top, right, bottom));
  }

  public override void ShowSettings(Settings settings) => DisplayNoSettingsMessage();
}
```

\ref SuperSize.Plugin.Logic.CalculateWindowSize "CalculateWindowSize" receives a list of screens and the settings object to help with calculating the size for the window. For details on settings, see [Storing and Retrieving Settings](settings.md).
