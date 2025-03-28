using System.Windows.Markup;

namespace M008;

public class EnumExtension : MarkupExtension
{
	/// <summary>
	/// Durch dieses Property können der MarkupExtension Daten mitgegeben werden über das XAML
	/// EnumType=...
	/// </summary>
	public Type EnumType { get; set; }

	/// <summary>
	/// ProvideValue: Gibt als Rückgabewert einen beliebigen Wert an die GUI weiter
	/// Sobald die ComboBox ihre Items anfordert, wird diese Methode ausgeführt
	/// </summary>
	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		if (!EnumType.IsEnum)
			throw new ArgumentException("Der gegebene Typ ist kein Enum Typ");

		return Enum.GetValues(EnumType);
	}
}
