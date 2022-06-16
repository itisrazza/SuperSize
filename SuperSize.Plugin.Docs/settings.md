# Storing and Retrieving Settings

TBD.

It's a key-value store. \ref SuperSize.Plugin.Settings "Settings" for details.

## The Settings Object

It's basically a IDictionary<string, string> with extras.

```csharp
var got = settings["key"];
settings["key"] = "set";

if (oops) {
    settings.Reload();
} else {
    settings.Save();
}
```

## Retrieving Other Logic's Settings

```csharp
settings.GetLogicSettings(new Guid("E9CAE8C8-02F8-4969-ABCB-28172516A3A4"));
```

### Making Your Logic Retrievable

Add a GUID to your logic class.

```csharp
[Guid("E9CAE8C8-02F8-4969-ABCB-28172516A3A4")]
public class UseAllScreen : Logic
{
```
