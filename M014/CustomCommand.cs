using System.Windows.Input;

namespace M014;

public class CustomCommand : ICommand
{
	/// <summary>
	/// Action und Func sind Delegates
	/// Delegates halten Methodenzeiger
	/// 
	/// Action: Methodenzeiger, welcher immer void zurückgibt und bis zu 16 Parameter hat
	/// Func: Methodenzeiger, welcher einen beliebigen Rückgabetyp hat (letzter Typ ist der Rückgabetyp)
	/// Über Generics werden die Parameter definiert
	/// </summary>
	public Action<object> ExecuteMethod { get; set; }

	public Func<object, bool> CanExecuteMethod { get; set; }

	//////////////////////////////////////////////////////////////////////

	public event EventHandler? CanExecuteChanged;

	public bool CanExecute(object? parameter)
	{
		if (CanExecuteMethod == null)
			return true;

		return CanExecuteMethod.Invoke(parameter);
	}

	public void Execute(object? parameter)
	{
		if (ExecuteMethod == null)
			throw new ArgumentNullException("ExecuteMethod darf nicht null sein");

		ExecuteMethod.Invoke(parameter);
	}
}