﻿using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace M007;

public partial class MainWindow : Window
{
	public ObservableCollection<Fahrzeug> Fahrzeuge { get; set; } = new ObservableCollection<Fahrzeug>
	{
		new Fahrzeug(251, FahrzeugMarke.BMW),
		new Fahrzeug(274, FahrzeugMarke.BMW),
		new Fahrzeug(146, FahrzeugMarke.BMW),
		new Fahrzeug(208, FahrzeugMarke.Audi),
		new Fahrzeug(189, FahrzeugMarke.Audi),
		new Fahrzeug(133, FahrzeugMarke.VW),
		new Fahrzeug(253, FahrzeugMarke.VW),
		new Fahrzeug(304, FahrzeugMarke.BMW),
		new Fahrzeug(151, FahrzeugMarke.VW),
		new Fahrzeug(250, FahrzeugMarke.VW),
		new Fahrzeug(217, FahrzeugMarke.Audi),
		new Fahrzeug(125, FahrzeugMarke.Audi)
	};

	public MainWindow()
    {
        InitializeComponent();
    }
}