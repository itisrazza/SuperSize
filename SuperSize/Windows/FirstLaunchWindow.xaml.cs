using System.Collections.Immutable;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using MicaWPF.Controls;

namespace SuperSize.Windows;

public partial class FirstLaunchWindow
{
    private readonly ImmutableList<(string Key, string Text)> _pages = ImmutableList.Create(
        new (string Key, string Text)[]
        {
            ("Welcome", "Welcome to SuperSize. Let’s get you up to speed."),
            ("SystemTray",
                "SuperSize runs in the background. You can access it’s settings by right clicking its icon in the system tray."),
            ("KeyboardShortcut",
                "To super-size the active window, use Windows + Esc. You can change the keyboard shortcut in the settings."),
            ("DevBuildWarning",
                "This is an active development build. Please report any issues on GitHub. See ‘Send Feedback’ in the SuperSize tray menu."),
            ("GetMorePlugins",
                "You can add custom logic to SuperSize. Check out the official Python and contributors’ logic from the SuperSize tray menu."),
            ("Finish", "Ka pai. You are ready to go."),
        });

    private int _pageIndex = 0;

    private int PageIndex
    {
        get => _pageIndex;
        set
        {
            _pageIndex = value;
            UpdateInfo();
        }
    }

    public FirstLaunchWindow()
    {
        InitializeComponent();
        PageIndex = 0;
    }

    private void UpdateInfo()
    {
        HeroText.Text = _pages[PageIndex].Text;
        var image = new BitmapImage(new Uri(
            $"pack://application:,,,/Assets/FirstLaunch/{_pages[PageIndex].Key
            }.png"));
        RenderOptions.SetBitmapScalingMode(image, BitmapScalingMode.Fant);

        HeroImage.Source = image;
        
        if (PageIndex == _pages.Count - 1)
        {
            NextButton.Content = "Start using SuperSize";
        }
    }

    private void OnNextButtonClicked(object sender, RoutedEventArgs e)
    {
        if (PageIndex == _pages.Count - 1)
        {
            Close();
            return;
        }
        
        PageIndex++;
    }
}