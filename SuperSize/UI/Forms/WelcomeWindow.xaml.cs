using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SuperSize.UI.Forms
{
    /// <summary>
    /// Interaction logic for WelcomeWindow.xaml
    /// </summary>
    public partial class WelcomeWindow : Window
    {
        public static List<(string Image, string Text)> UserIntroduction = new()
        {
            { ("Welcome.png", "Kia ora. Welcome to SuperSize. Let’s get you up to speed.") },
            { ("System Tray.png", "SuperSize runs in the background. You can access it’s settings by right clicking its icon in the system tray.") },
            { ("Keyboard Shortcut.png", "To super-size the active window, use Windows + Esc. You can change the keyboard shortcut in the settings.") },
            { ("Dev Build Warning.png", "This is an active development build. Please report any issues on GitHub. See ‘Send Feedback’ in the SuperSize tray menu.") },
            { ("Get More Plugins.png", "You can add custom logic to SuperSize. Check out the official Python plugin and development kit from the SuperSize tray menu.") },
            { ("Finish.png", "Ka pai. You are ready to go.") }
        };

        private int _introIndex = 0;
        private string CurrentImage => UserIntroduction[_introIndex].Image;
        private string CurrentText => UserIntroduction[_introIndex].Text;

        public WelcomeWindow()
        {
            InitializeComponent();
            UpdateUI();
        }

        public void UpdateUI()
        {
            HeroImage.Source = new BitmapImage(new Uri($"pack://application:,,,/{Assembly.GetExecutingAssembly().GetName().Name};component/Resources/{CurrentImage}", UriKind.Absolute));
            HeroDescription.Text = CurrentText;
        }

        private void SkipButton_Click(object sender, RoutedEventArgs e)
        {
            new ConfigForm().Show();
            Close();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (++_introIndex == UserIntroduction.Count - 1)
            {
                NextButton.Visibility = Visibility.Hidden;
                SkipButton.Visibility = Visibility.Hidden;
                StartButton.Visibility = Visibility.Visible;
            }

            UpdateUI();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var settings = Properties.Settings.Default;
            settings.WasOnboarded = true;
            settings.Save();
        }
    }
}
