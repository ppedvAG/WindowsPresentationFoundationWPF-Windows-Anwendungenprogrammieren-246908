using System.Globalization;
using System.Windows.Controls;

namespace M009;

public class LengthValidation : ValidationRule
{
	public int Min { get; set; } = 3;

	public int Max { get; set; } = 15;

	public override ValidationResult Validate(object value, CultureInfo cultureInfo)
	{
		string text = value.ToString()!;
		if (text.Length >= Min && text.Length <= Max)
			return ValidationResult.ValidResult;
		return new ValidationResult(false, $"Eingabe muss zw. {Min} und {Max} Zeichen haben!");
	}
}
