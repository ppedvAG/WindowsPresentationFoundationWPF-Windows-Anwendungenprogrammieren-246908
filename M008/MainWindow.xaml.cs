using System.Windows;

namespace M008;

public partial class MainWindow : Window
{
	public DayOfWeek[] Wochentage { get; } = Enum.GetValues<DayOfWeek>();

	public string Zahl { get; set; } = "Eins";

    public MainWindow()
    {
        InitializeComponent();
    }
}