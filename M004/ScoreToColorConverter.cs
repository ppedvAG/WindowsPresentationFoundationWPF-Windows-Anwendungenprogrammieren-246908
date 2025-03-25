using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace M004;

/// <summary>
/// Diese Klasse benötigt das IValueConverter Interface
/// </summary>
public class ScoreToColorConverter : IValueConverter
{
	/// <summary>
	/// Quelle -> Ziel
	/// Slider -> TextBlock
	/// 
	/// Parameter:
	/// - value: Wert des Bindings (hier Slider Value)
	/// - targetType: Typ des Targets des Bindings (hier Brush)
	/// - parameter: Hier können beim Binding im XAML Daten mitgegeben werden (über ConverterParameter)
	/// - culture: Gibt an, welches Format die Daten der Quelle haben (z.B. Datumswerte)
	/// </summary>
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		int score = (int) (double) value;
		switch (score)
		{
			case <= 50: return new SolidColorBrush(Colors.Red);
			case <= 60: return new SolidColorBrush(Colors.Orange);
			case <= 70: return new SolidColorBrush(Colors.Yellow);
			case <= 80: return new SolidColorBrush(Colors.LightGreen);
			case <= 90: return new SolidColorBrush(Colors.Green);
			case <= 100: return new SolidColorBrush(Colors.LightBlue);
			default: return new SolidColorBrush(Colors.Transparent);
		}
	}

	/// <summary>
	/// Ziel -> Quelle
	/// </summary>
	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}