using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace M011;

public partial class ColorPicker : UserControl
{
	public byte R
	{
		get => (byte) GetValue(RProperty); set => SetValue(RProperty, value);
	}

	public static readonly DependencyProperty RProperty =
		DependencyProperty.Register("R", typeof(byte), typeof(ColorPicker), new PropertyMetadata((byte) 0, CalculateColor));


	public byte G
	{
		get => (byte) GetValue(GProperty); set => SetValue(GProperty, value);
	}

	public static readonly DependencyProperty GProperty =
		DependencyProperty.Register("G", typeof(byte), typeof(ColorPicker), new PropertyMetadata((byte) 0, CalculateColor));


	public byte B
	{
		get => (byte) GetValue(BProperty); set => SetValue(BProperty, value);
	}

	public static readonly DependencyProperty BProperty =
		DependencyProperty.Register("B", typeof(byte), typeof(ColorPicker), new PropertyMetadata((byte) 0, CalculateColor));


	public byte A
	{
		get => (byte) GetValue(AProperty); set => SetValue(AProperty, value);
	}

	public static readonly DependencyProperty AProperty =
		DependencyProperty.Register("A", typeof(byte), typeof(ColorPicker), new PropertyMetadata((byte) 0, CalculateColor));

	//////////////////////////////////////////////////////////

	public Color PickedColor
	{
		get { return (Color) GetValue(PickedColorProperty); }
		set { SetValue(PickedColorProperty, value); }
	}

	public static readonly DependencyProperty PickedColorProperty =
		DependencyProperty.Register(nameof(PickedColor), typeof(Color), typeof(ColorPicker), new PropertyMetadata(Colors.Black, CalculateColorValues));

	public ColorPicker()
	{
		InitializeComponent();
	}

	/// <summary>
	/// Delegate
	/// Gibt einen Methodenaufbau vor
	/// Variablen/Parameter von dem Delegatetypen benötigen einen Methodenzeiger mit dem gegebenen Aufbau
	/// </summary>
	public static void CalculateColor(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		//d = ColorPicker
		byte r = (byte) d.GetValue(RProperty);
		byte g = (byte) d.GetValue(GProperty);
		byte b = (byte) d.GetValue(BProperty);
		byte a = (byte) d.GetValue(AProperty);

		Color c = Color.FromArgb(a, r, g, b);
		d.SetValue(PickedColorProperty, c);
	}

	public static void CalculateColorValues(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		Color c = (Color) d.GetValue(PickedColorProperty);

		d.SetValue(RProperty, c.R);
		d.SetValue(GProperty, c.G);
		d.SetValue(BProperty, c.B);
		d.SetValue(AProperty, c.A);
	}
}
