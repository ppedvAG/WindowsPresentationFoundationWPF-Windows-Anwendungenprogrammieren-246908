using System.Globalization;
using System.Windows.Controls;

namespace M000.Validation;

class CounterValidation : ValidationRule
{
	public override ValidationResult Validate(object value, CultureInfo cultureInfo)
	{
		int x = (int) value;
		if (x < 0)
			return new ValidationResult(false, "Anzahl Kinder darf nicht unter 0 sein!");
		return ValidationResult.ValidResult;
	}
}
