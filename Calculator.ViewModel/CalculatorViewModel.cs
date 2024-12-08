using Calculator.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Calculator.ViewModel;

public partial class CalculatorViewModel : ObservableObject
{
    private readonly MathOperations _mathOperations = new();

    private double _firstNumber;
    private double _secondNumber;
    private string? _operator;
    private bool _isOperationPerformed;


    [ObservableProperty]
    private string _display = "0";

    [RelayCommand]
    private void Number(object parameter)
    {
        if (Display == "0" && Display != null)
        {
            Display = "";
        }

        if (_isOperationPerformed)
        {
            Display = "";
            _isOperationPerformed = false;
        }

        Display += parameter.ToString();
    }

    [RelayCommand]
    private void Operator(object parameter)
    {
        _operator = parameter.ToString();
        _firstNumber = Convert.ToDouble(Display);
        _isOperationPerformed = true;
    }

    [RelayCommand]
    private void Equal(object parameter)
    {
        _secondNumber = Convert.ToDouble(Display);
        double result = 0;

        if (Enum.TryParse(_operator, out MathOperation operation) && _mathOperations.Operations.TryGetValue(operation, out var func))
        {
            result = func(_firstNumber, _secondNumber);
        }

        Display = result.ToString();
    }

    [RelayCommand]
    private void Clear(object parameter)
    {
        Display = "0";
        _firstNumber = 0;
        _secondNumber = 0;
        _operator = "";
    }

    [RelayCommand]
    private void Decimal(object parameter)
    {
        if (!Display.Contains('.'))
        {
            Display += ".";
        }
    }

    [RelayCommand]
    private void Function(object parameter)
    {
        double number = Convert.ToDouble(Display);
        double result = 0;

        if (Enum.TryParse(parameter.ToString(), out MathFunction function) && _mathOperations.FunctionsByName.TryGetValue(function, out var func))
        {
            result = func(number);
        }

        Display = result.ToString();
    }
}