using System.Globalization;
using System.Windows.Controls;

namespace M009;

public class LetterValidation : ValidationRule
{
	public LetterValidation()
	{
		ValidatesOnTargetUpdated = true;
	}

	public override ValidationResult Validate(object value, CultureInfo cultureInfo)
	{
		string text = value.ToString()!;
		if (text.All(char.IsLetter))
			return ValidationResult.ValidResult;
		return new ValidationResult(false, "Die Eingabe darf nur aus Buchstaben bestehen!");
	}
}
