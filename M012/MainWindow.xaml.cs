using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;
using System.Windows;

namespace M012;

public partial class MainWindow : Window
{
	public ObservableCollection<Person> Personen { get; set; } = new();

	public Person SelectedElement { get; set; }

	public MainWindow()
	{
		InitializeComponent();

		string str = File.ReadAllText("Personen.json");
		List<Person> p = JsonSerializer.Deserialize<List<Person>>(str);
		foreach (Person person in p)
			Personen.Add(person);
		//Personen = JsonSerializer.Deserialize<ObservableCollection<Person>>(str);
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		//Hier ist der DataContext vom sender (Button) die ausgewählte Person

		//Button b = (Button) sender;
		//Person p = b.DataContext as Person;
		//Personen.Remove(p);

		Personen.Remove(SelectedElement);
	}
}