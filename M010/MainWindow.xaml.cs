using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace M010;

public partial class MainWindow : Window, INotifyPropertyChanged
{
	public bool Bool4
	{
		get => bool4;
		set
		{
			bool4 = value;
			Notify(nameof(Bool));
		}
	}

	public bool Bool5
	{
		get => bool5;
		set
		{
			bool5 = value;
			Notify(nameof(Bool));
		}
	}

	public bool Bool6
	{
		get => bool6;
		set
		{
			bool6 = value;
			Notify(nameof(Bool));
		}
	}

	private bool bool4;
	private bool bool5;
	private bool bool6;

	public bool Bool => (Bool4 && Bool5) || (Bool4 && Bool6) || (Bool5 && Bool6);

	public event PropertyChangedEventHandler? PropertyChanged;

	public void Notify(string prop)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
	}


	public MainWindow()
	{
		InitializeComponent();
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{

	}
}