using System.Windows.Data;
using System.Windows.Markup;

namespace M008;

public class ConverterExtension : MarkupExtension
{
	public Type ConverterType { get; set; }

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		object converter = Activator.CreateInstance(ConverterType);
		if (converter is IValueConverter || converter is IMultiValueConverter)
			return converter;
		throw new ArgumentException("...");
	}
}
