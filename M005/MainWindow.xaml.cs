using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace M005;

public partial class MainWindow : Window, INotifyPropertyChanged
{
	private int counter = 0;

	/// <summary>
	/// Jede Variable aus dem Backend die gebunden werden soll, MUSS ein Property sein
	/// </summary>
	public int Counter
	{
		get => counter;
		set
		{
			counter = value;
			//Notify(nameof(Counter));
			Notify(); //Jedes mal, wenn sich das Property ändert, wird sofort eine Benachrichtigung gesendet
		}
	}

	public ObservableCollection<int> Zahlen { get; set; } = [.. Enumerable.Range(1, 10)];

	public MainWindow()
    {
        InitializeComponent();
		//DataContext = this;
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		Counter++;
		//PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Counter))); //Mit dem Event kann an die GUI eine Benachrichtigung geschickt werden
	}

	private void Button_Click_1(object sender, RoutedEventArgs e)
	{
		Zahlen.Add(Zahlen[^1] + 1);
	}


	/// <summary>
	/// INotifyPropertyChanged
	/// Benachrichtigungsmechanismus, welcher Änderungen an die GUI senden kann
	/// Wenn die GUI eine Benachrichtigung erhält, wird der Wert aus dem Property in die GUI übernommen
	/// </summary>
	public event PropertyChangedEventHandler? PropertyChanged;

	public void Notify([CallerMemberName] string prop = "") //CallerMemberName: Fügt automatisch den Namen des Properties hier ein
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
	}
}