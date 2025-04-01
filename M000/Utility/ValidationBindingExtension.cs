﻿using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;

namespace M000.Utility;

public class ValidationBindingExtension : MarkupExtension
{
	/// <summary>
	/// Enthält das Binding ins Backend
	/// </summary>
	public Binding Binding { get; set; }

	public ValidationRuleCollection Rules { get; set; }

	public ValidationRule SingleRule { get; set; }

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		if (SingleRule != null)
		{
			Binding.ValidationRules.Add(SingleRule);
			return Binding.ProvideValue(serviceProvider);
		}

		foreach (ValidationRule rule in Rules)
			Binding.ValidationRules.Add(rule);
		return Binding.ProvideValue(serviceProvider);
	}
}

/// <summary>
/// Wrapper-Klasse, um die Regeln im XAML definieren zu können
/// Grund: Im XAML können keine Generics verwendet werden
/// </summary>
public class ValidationRuleCollection : Collection<ValidationRule>;