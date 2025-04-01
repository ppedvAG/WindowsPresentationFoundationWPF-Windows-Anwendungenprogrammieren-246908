using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace M011;

class RGBAConverter : IMultiValueConverter
{
	public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
	{
		//byte[] d = new byte[values.Length];
		//for (int i = 0; i < values.Length; i++)
		//	d[i] = (byte) values[i];

		byte[] d = values
			.OfType<byte>()
			.ToArray();
		return new SolidColorBrush(Color.FromArgb(d[3], d[0], d[1], d[2]));
	}

	public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}
