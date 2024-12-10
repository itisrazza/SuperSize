using System.Diagnostics;
using WPFApp = System.Windows.Application;
using SuperSize;

namespace SuperSize.Windows;

public class TrayWindow : Form
{
    private NotifyIcon _trayIcon = new NotifyIcon();

    public TrayWindow()
    {
        _trayIcon.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        _trayIcon.Visible = true;
        _trayIcon.Text = "SuperSize";

        _trayIcon.ContextMenuStrip = CreateContextMenu();

        _trayIcon.DoubleClick += OnIconClick;
    }

    private static void OnIconClick(object? sender, EventArgs e)
    {
        WPFApp.Current?.MainWindow?.Show();
    }

    private static ContextMenuStrip CreateContextMenu()
    {
        var menu = new ContextMenuStrip();
        
        var feedback = new ToolStripMenuItem("Send &Feedback");
        feedback.Click += OnSendFeedbackClicked;
        menu.Items.Add(feedback);
        
        menu.Items.Add(new ToolStripSeparator());

        var settings = new ToolStripMenuItem("&Settings...");
        settings.Click += OnSettingsClicked;
        menu.Items.Add(settings);
        
        var quit = new ToolStripMenuItem("&Quit");
        quit.Click += OnQuitClicked;
        menu.Items.Add(quit);

        return menu;
    }

    private static void OnQuitClicked(object? sender, EventArgs e)
        => WPFApp.Current?.Shutdown();

    private static void OnSettingsClicked(object? sender, EventArgs e)
        => WPFApp.Current?.MainWindow?.Show();

    private static void OnSendFeedbackClicked(object? sender, EventArgs e)
        => Process.Start(new ProcessStartInfo("https://github.com/itisrazza/SuperSize/issues/new") { UseShellExecute = true });
}