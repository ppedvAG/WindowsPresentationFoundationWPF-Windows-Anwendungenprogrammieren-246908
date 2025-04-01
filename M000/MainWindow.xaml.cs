using M000.Model;
using System.Windows;

namespace M000;

public partial class MainWindow : Window
{
	public Person DiePerson { get; set; } = new();

    public MainWindow()
    {
        InitializeComponent();
    }

	private void OKClicked(object sender, RoutedEventArgs e)
	{

	}
}