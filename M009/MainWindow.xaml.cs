using System.ComponentModel;
using System.Text;
using System.Windows;

namespace M009;

public partial class MainWindow : Window, IDataErrorInfo
{
	public string Eingabe { get; set; }

	private string eingabe2;

	public string Eingabe2
	{
		get => eingabe2;
		set
		{
			if (value.All(char.IsLetter) && value.Length >= 3 && value.Length <= 15)
				eingabe2 = value;
			else
				throw new Exception("Fehler bei Validierung");
		}
	}

	public string Eingabe3 { get; set; }

	public MainWindow()
    {
        InitializeComponent();
    }

	private void Button_Click(object sender, RoutedEventArgs e)
	{

	}

	///////////////////////////////////////////////////////////////////////

	/// <summary>
	/// Die Fehlermeldung, kann ignoriert werden
	/// </summary>
	public string Error => throw new NotImplementedException();

	/// <summary>
	/// Indexer
	/// Ermöglicht, auf Objekte der Klasse mit [] zuzugreifen
	/// Wird verwendet in Listentypen (Array, List, Dictionary, ...)
	/// Ist ein Property mit get und oder set
	/// </summary>
	public string this[string propName]
	{
		get
		{
			//object current = this.GetType().GetProperty(propName).GetValue(this);

			//propName: Property, welches validiert wird
			//Wenn hier ein string zurückgegeben wird, handelt es sich um eine Fehlermeldung
			//Wenn hier null zurückgegeben wird, ist die Validierung erfolgreich
			switch (propName)
			{
				case nameof(Eingabe) or nameof(Eingabe2):
					//...
					break;

				case nameof(Eingabe3):
					StringBuilder sb = new StringBuilder();
					if (!Eingabe3.All(char.IsLetter))
						sb.AppendLine("Die Eingabe darf nur aus Buchstaben bestehen!");
					if (Eingabe3.Length < 3 || Eingabe3.Length > 15)
						sb.AppendLine("Die Eingabe muss zw. 3 und 15 Zeichen haben!");
					return sb.Length == 0 ? null : sb.ToString(); //Kein Fehler
			}
			return null;
		}
	}
}