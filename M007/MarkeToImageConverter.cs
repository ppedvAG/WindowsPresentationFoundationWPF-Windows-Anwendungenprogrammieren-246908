using System.Globalization;
using System.Windows.Data;

namespace M007;

class MarkeToImageConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		FahrzeugMarke marke = (FahrzeugMarke) value;
		switch (marke)
		{
			case FahrzeugMarke.Audi: return "C:/Users/lk3/source/repos/WPF_2025_03_24/M007/Images/audi.png";
			case FahrzeugMarke.BMW: return "C:/Users/lk3/source/repos/WPF_2025_03_24/M007/Images/bmw.png";
			case FahrzeugMarke.VW: return "C:/Users/lk3/source/repos/WPF_2025_03_24/M007/Images/vw.png";
			default: return string.Empty;
		}
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}
