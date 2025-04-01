using System.Globalization;
using System.Windows.Controls;

namespace M000.Validation;

public class DateValidation : ValidationRule
{
	public override ValidationResult Validate(object value, CultureInfo cultureInfo)
	{
		DateTime dt = (DateTime) value;
		if (dt > DateTime.Now)
			return new ValidationResult(false, "Das Datum darf nicht in der Zukunft liegen!");

		if (dt.Year < DateTime.Now.Year - 130)
			return new ValidationResult(false, $"Das Datum darf nicht vor {DateTime.Now.Year - 130} liegen!");

		return ValidationResult.ValidResult;
	}
}
