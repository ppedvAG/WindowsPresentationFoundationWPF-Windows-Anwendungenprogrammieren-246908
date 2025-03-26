using System.Globalization;
using System.Windows.Data;

namespace M004;

public class ScoreToGradeConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		int x = (int) (double) value;
		switch (x)
		{
			case <= 50: return "Ungenügend";
			case <= 60: return "Mangelhaft";
			case <= 70: return "Ausreichend";
			case <= 80: return "Befriedigend";
			case <= 90: return "Gut";
			case <= 100: return "Sehr Gut";
			default: return "Fehler";
		}
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}
