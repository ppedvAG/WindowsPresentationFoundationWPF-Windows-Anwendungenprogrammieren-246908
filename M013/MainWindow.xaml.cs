using System.IO;
using System.Windows;

namespace M013;

public partial class MainWindow : Window
{
	public ExitCommand Exit { get; set; } = new();

	public WriteFileCommand WriteFile { get; set; } = new();

	public CustomCommand WriteFileCustom { get; set; } = new();

    public MainWindow()
    {
		WriteFileCustom.ExecuteMethod = WriteFileExecute; //Hier wird der Methodenzeiger angelegt (ohne Klammern)
		WriteFileCustom.CanExecuteMethod = WriteFileCanExecute;
        InitializeComponent();
    }

	private void Button_Click(object sender, RoutedEventArgs e)
	{

	}

	public bool WriteFileCanExecute(object? parameter)
	{
		return !string.IsNullOrEmpty(parameter?.ToString());
	}

	public void WriteFileExecute(object? parameter)
	{
		string str = parameter.ToString();
		File.WriteAllText("Output.txt", str);
	}
}