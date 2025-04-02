using M014.Model;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;

namespace M014.ViewModel;

public class DataViewViewModel : ViewModelBase
{
	public ObservableCollection<Person> Personen { get; set; } = new();

	public CustomCommand DeletePerson { get; set; } = new();

	/// <summary>
	/// Wenn eine View erzeugt wird, wird vom DataContext ein Objekt erstellt
	/// Vorteil: Hier kann ein Konstruktor ausgeführt werden
	/// </summary>
	public DataViewViewModel()
	{
		DeletePerson.ExecuteMethod = PersonEntfernen;

		string str = File.ReadAllText("Personen.json");
		List<Person> p = JsonSerializer.Deserialize<List<Person>>(str);
		foreach (Person person in p)
			Personen.Add(person);
	}

	public void PersonEntfernen(object? p)
	{
		Personen.Remove((Person) p);
	}
}