using System.Windows.Markup;
using System.Windows.Media;

namespace M000.Utility;

public class ColorsExtension : MarkupExtension
{
	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		//Nur Farben, ohne Namen
		//return typeof(Colors)
		//			.GetProperties()
		//			.Select(e => (Color) e.GetValue(null));

		//Farbe mit Name
		//e.GetValue(null): Die Farbe hinter jedem Property
		//e.Name: Der Name des Properties
		return typeof(Colors)
					.GetProperties()
					//.Select(e => (Brush: new SolidColorBrush((Color) e.GetValue(null)), e.Name));
					.Select(e => new NamedColor()
					{
						TheColor = (Color) e.GetValue(null),
						Name = e.Name
					});
	}
}

public class NamedColor
{
	public Color TheColor { get; set; }

	public string Name { get; set; }

	public SolidColorBrush Brush => new SolidColorBrush(TheColor);

	public string ColorCode => TheColor.ToString();
}