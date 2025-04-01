using System.Windows;
using System.Windows.Controls;

namespace M000;

public partial class IntegerCounter : UserControl
{
	public int Counter
	{
		get { return (int) GetValue(CounterProperty); }
		set { SetValue(CounterProperty, value); }
	}

	public static readonly DependencyProperty CounterProperty =
		DependencyProperty.Register(nameof(Counter), typeof(int), typeof(IntegerCounter), new PropertyMetadata(0));

	public IntegerCounter()
	{
		InitializeComponent();
	}

	private void UpClicked(object sender, RoutedEventArgs e)
	{
		Counter++;
	}

	private void DownClicked(object sender, RoutedEventArgs e)
	{
		Counter--;
	}
}
