﻿using Calculator.ViewModel;
using System.Windows;

namespace Calculator.View;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new CalculatorViewModel();
    }
}
