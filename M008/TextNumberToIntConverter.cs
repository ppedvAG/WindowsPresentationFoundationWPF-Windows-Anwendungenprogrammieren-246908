using System.Globalization;
using System.Windows.Data;

namespace M008;

public class TextNumberToIntConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		string z = value.ToString().ToLower();
		switch (z)
		{
			case "eins": return 1;
			case "zwei": return 2;
			case "drei": return 3;
			default: return -1;
		}
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}
