using System.IO;
using System.Windows.Input;

namespace M013;

public class WriteFileCommand : ICommand
{
	public event EventHandler? CanExecuteChanged;

	public bool CanExecute(object? parameter)
	{
		return !string.IsNullOrEmpty(parameter?.ToString());
	}

	public void Execute(object? parameter)
	{
		string str = parameter.ToString();
		File.WriteAllText("Output.txt", str);
	}
}
