using System.Globalization;
using System.Windows.Data;

namespace M012;

public class HobbiesUnpackConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		List<string> hobbies = (List<string>) value;
		return string.Join(", ", hobbies);
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}
