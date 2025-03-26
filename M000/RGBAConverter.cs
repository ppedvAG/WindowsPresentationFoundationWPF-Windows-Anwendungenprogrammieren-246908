using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace M000;

class RGBAConverter : IMultiValueConverter
{
	public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
	{
		//double[] d = new double[values.Length];
		//for (int i = 0; i < values.Length; i++)
		//	d[i] = (double) values[i];

		byte[] d = values
			.OfType<double>()
			.Select(e => (byte) e)
			.ToArray();
		return new SolidColorBrush(Color.FromArgb(d[3], d[0], d[1], d[2]));
	}

	public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}
