using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace M011;

public partial class ColorSlider : UserControl
{
	/// <summary>
	/// Hier wird nicht ein private Feld im Hintergrund verwendet, sondern GetValue/SetValue
	/// Diese Methoden werden im Bindingsystem verwendet, um Bindings zu machen
	/// </summary>
	public string Text
	{
		get => (string) GetValue(TextProperty);
		set => SetValue(TextProperty, value);
	}

	/// <summary>
	/// Dieses Feld registriert das unterliegende Property für Bindings
	/// </summary>
	public static readonly DependencyProperty TextProperty =
		DependencyProperty.Register
		(
			nameof(Text), //Name des unterliegenden Feldes 
			typeof(string), //Typ des unterliegenden Feldes
			typeof(ColorSlider) //Typ der Klasse, in dem sich das DP befindet
		);

	////////////////////////////////////////////////////////////////////////////////////////////////

	public Brush TextColor
	{
		get => (Brush) GetValue(TextColorProperty);
		set => SetValue(TextColorProperty, value);
	}

	public static readonly DependencyProperty TextColorProperty =
		DependencyProperty.Register
		(
			nameof(TextColor),
			typeof(Brush),
			typeof(ColorSlider),
			new PropertyMetadata(new SolidColorBrush(Colors.Black)) //Standardwert eintragen
		);

	////////////////////////////////////////////////////////////////////////////////////////////////

	public byte SliderValue
	{
		get => (byte) GetValue(SliderValueProperty);
		set => SetValue(SliderValueProperty, value);
	}
	
	public static readonly DependencyProperty SliderValueProperty =
		DependencyProperty.Register
		(
			nameof(SliderValue),
			typeof(byte),
			typeof(ColorSlider),
			new PropertyMetadata((byte) 0)
		);

	////////////////////////////////////////////////////////////////////////////////////////////////

	public ColorSlider()
	{
		InitializeComponent();
	}
}
