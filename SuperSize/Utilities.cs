using System;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.System;

namespace SuperSize;

public static class Utilities
{
    public static Task OpenLink(string link) => _ = OpenLink(new Uri(link));

    public static async Task OpenLink(Uri uri) => await Launcher.LaunchUriAsync(uri);

    public static async Task ShowInExplorer(string path)
    {
        var file = await StorageFile.GetFileFromPathAsync(path);
        var folder = await file.GetParentAsync();

        var options = new FolderLauncherOptions();
        options.ItemsToSelect.Add(file);

        await Launcher.LaunchFolderAsync(folder, options);
    }
}
