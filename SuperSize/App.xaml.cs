using System.Windows;
using SuperSize.Windows;
using Application = System.Windows.Application;

namespace SuperSize;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnActivated(e);

        var trayWindow = new TrayWindow();
    }
}