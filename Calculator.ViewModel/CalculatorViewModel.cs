using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Calculator.ViewModel;

public partial class CalculatorViewModel : ObservableObject
{
    private bool _isOperationPerformed;

    [ObservableProperty]
    private string _display = "0";

    [RelayCommand]
    private void NumberCommand(object parameter)
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
    private void OperatorCommand(object parameter)
    {
        if (parameter is null)
        {
            throw new Exception();
        }

        var _operator = parameter.ToString();
        var firstNumber = Convert.ToDouble(Display);
        _isOperationPerformed = true;
    }

    [RelayCommand]
    private void EqualCommand(object parameter)
    {
        var secondNumber = Convert.ToDouble(Display);
        double result = 0; //Получить значение с модели

        Display = result.ToString();
    }

    [RelayCommand]
    private void ClearCommand(object parameter)
    {
        Display = "0";
    }

    [RelayCommand]
    private void DecimalCommand(object parameter)
    {
        if (!Display.Contains('.'))
        {
            Display += ".";
        }
    }

    [RelayCommand]
    private void FunctionCommand(object parameter)
    {
        double number = Convert.ToDouble(Display);
        double result = 0;

        //Получение данных
        //if (Enum.TryParse(parameter.ToString(), out MathOperation operation) && MathOperations.Operations.TryGetValue(operation, out var func))
        //{
        //    result = func(number);
        //}

        Display = result.ToString();
    }
}