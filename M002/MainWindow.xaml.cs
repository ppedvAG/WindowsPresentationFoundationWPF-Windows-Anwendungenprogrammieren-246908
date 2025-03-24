using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace M002;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
		Dropdown.ItemsSource = Enumerable.Range(1, 20);
		Test.ItemsSource = Enumerable.Range(1, 20);
		LB.ItemsSource = Enumerable.Range(1, 20);
    }

	private void HalloWeltClicked(object sender, RoutedEventArgs e)
	{
		//Ausgabe.Text = Eingabe.Text;
		Ausgabe.Text = Dropdown.SelectedItem.ToString();

		MainWindow mw = new MainWindow();
		mw.ShowDialog();
	}

	private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		Ausgabe.Text = e.NewValue.ToString();
	}

	private void LB_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		Ausgabe.Text = string.Join(',', LB.SelectedItems.OfType<int>());
	}

	private void BeendenClicked(object sender, RoutedEventArgs e)
	{
		MessageBoxResult result = MessageBox.Show("Wirklich beenden?", "Beenden", MessageBoxButton.YesNo, MessageBoxImage.Question);
		if (result == MessageBoxResult.Yes)
			Close();
	}
}