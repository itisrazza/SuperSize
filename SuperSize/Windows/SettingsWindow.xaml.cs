using System.ComponentModel;
using System.Windows;
using MicaWPF.Controls;
using Application = System.Windows.Application;

namespace SuperSize.Windows;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class SettingsWindow : MicaWindow
{
    public SettingsWindow()
    {
        InitializeComponent();
    }

    private void OnOnlyButtonClicked(object sender, RoutedEventArgs e)
    {
        var firstLaunch = new FirstLaunchWindow();
        firstLaunch.Show();
    }

    private void OnWindowClosing(object? sender, CancelEventArgs e)
    {
        Hide();
        e.Cancel = true;
    }
}