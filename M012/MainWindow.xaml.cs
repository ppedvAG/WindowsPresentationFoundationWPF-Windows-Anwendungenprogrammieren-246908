using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Windows;

namespace M012;

public partial class MainWindow : Window
{
	public ObservableCollection<Person> Personen { get; set; } = new();

    public MainWindow()
    {
        InitializeComponent();

		string str = File.ReadAllText("Personen.json");
		List<Person> p = JsonSerializer.Deserialize<List<Person>>(str);
		foreach (Person person in p)
			Personen.Add(person);
		//Personen = JsonSerializer.Deserialize<ObservableCollection<Person>>(str);
	}
}

///////////////////////////////////////////////////////////////////////////////

[DebuggerDisplay("Person - ID: {ID}, Vorname: {Vorname}, Nachname: {Nachname}, GebDat: {Geburtsdatum.ToString(\"yyyy.MM.dd\")}, Alter: {Alter}, " +
	"Jobtitel: {Job.Titel}, Gehalt: {Job.Gehalt}, Einstellungsdatum: {Job.Einstellungsdatum.ToString(\"yyyy.MM.dd\")}")]
public record Person(int ID, string Vorname, string Nachname, DateTime Geburtsdatum, int Alter, Beruf Job, List<string> Hobbies);

public record Beruf(string Titel, int Gehalt, DateTime Einstellungsdatum);

///////////////////////////////////////////////////////////////////////////////