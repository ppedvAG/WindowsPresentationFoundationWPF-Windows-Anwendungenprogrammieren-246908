using System.Windows;

namespace M006;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

	private void TestClicked(object sender, RoutedEventArgs e)
	{
		//((TextBlock) Resources["TestOutput"]).Foreground = new SolidColorBrush(Colors.Green);
		Resources["DefaultFontSize"] = ((double) Resources["DefaultFontSize"]) + 1;
    }
}