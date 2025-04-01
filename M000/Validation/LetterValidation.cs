using System.Globalization;
using System.Windows.Controls;

namespace M000.Validation;

public class LetterValidation : ValidationRule
{
	public LetterValidation()
	{
		ValidatesOnTargetUpdated = true;
	}

	public override ValidationResult Validate(object value, CultureInfo cultureInfo)
	{
		if (value == null)
			return new ValidationResult(false, "Die Eingabe darf nur aus Buchstaben bestehen!");

		string text = value.ToString()!;
		if (text.All(char.IsLetter))
			return ValidationResult.ValidResult;
		return new ValidationResult(false, "Die Eingabe darf nur aus Buchstaben bestehen!");
	}
}
