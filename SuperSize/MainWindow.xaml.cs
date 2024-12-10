using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MicaWPF.Controls;
using SuperSize.Windows;

namespace SuperSize;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : MicaWindow
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnOnlyButtonClicked(object sender, RoutedEventArgs e)
    {
        var firstLaunch = new FirstLaunchWindow();
        firstLaunch.Show();
    }
}