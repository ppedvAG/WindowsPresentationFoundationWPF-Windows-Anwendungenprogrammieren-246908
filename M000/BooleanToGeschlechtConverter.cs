using System.Globalization;
using System.Windows.Data;

namespace M000;

public class BooleanToGeschlechtConverter : IValueConverter
{
	/// <summary>
	/// Backend -> Frontend
	/// Person Objekt -> XAML
	/// Geschlecht -> bool
	/// </summary>
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return (Geschlecht) value == (Geschlecht) parameter;
	}

	/// <summary>
	/// Frontend -> Backend
	/// XAML -> Person Objekt
	/// bool -> Geschlecht
	/// </summary>
	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return (bool) value ? parameter : Binding.DoNothing;
	}
}
