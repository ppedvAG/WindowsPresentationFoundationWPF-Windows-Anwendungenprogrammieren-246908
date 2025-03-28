using System.Windows.Markup;

namespace M008;

public class RangeExtension : MarkupExtension
{
	public int Start { get; set; }

	public int End { get; set; }

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		return Enumerable.Range(Start, End - Start + 1);
	}
}