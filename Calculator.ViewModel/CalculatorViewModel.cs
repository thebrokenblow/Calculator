using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Calculator.ViewModel;

public class CalculatorViewModel  : INotifyPropertyChanged
{
    private double _firstNumber;
    private double _secondNumber;
    private string _operator;
    private bool _isOperationPerformed;
    private string _display;

    public string Display
    {
        get => _display;
        set
        {
            _display = value;
            OnPropertyChanged();
        }
    }

    public ICommand NumberCommand { get; }
    public ICommand OperatorCommand { get; }
    public ICommand EqualCommand { get; }
    public ICommand ClearCommand { get; }
    public ICommand DecimalCommand { get; }
    public ICommand FunctionCommand { get; }

    public CalculatorViewModel()
    {
        Display = "0";
        NumberCommand = new RelayCommand(NumberButton_Click);
        OperatorCommand = new RelayCommand(OperatorButton_Click);
        EqualCommand = new RelayCommand(EqualButton_Click);
        ClearCommand = new RelayCommand(ClearButton_Click);
        DecimalCommand = new RelayCommand(DecimalButton_Click);
        FunctionCommand = new RelayCommand(FunctionButton_Click);
    }

    private void NumberButton_Click(object parameter)
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

    private void OperatorButton_Click(object parameter)
    {
        _operator = parameter.ToString();
        _firstNumber = Convert.ToDouble(Display);
        _isOperationPerformed = true;
    }

    private void EqualButton_Click(object parameter)
    {
        _secondNumber = Convert.ToDouble(Display);
        double result = 0;

        switch (_operator)
        {
            case "+":
                result = _firstNumber + _secondNumber;
                break;
            case "-":
                result = _firstNumber - _secondNumber;
                break;
            case "*":
                result = _firstNumber * _secondNumber;
                break;
            case "/":
                if (_secondNumber != 0)
                    result = _firstNumber / _secondNumber;
                else
                    Display = "Error";
                break;
            case "%":
                if (_secondNumber != 0)
                    result = _firstNumber % _secondNumber;
                else
                    Display = "Error";
                break;
            case "^":
                result = Math.Pow(_firstNumber, _secondNumber);
                break;
        }

        Display = result.ToString();
    }

    private void ClearButton_Click(object parameter)
    {
        Display = "0";
        _firstNumber = 0;
        _secondNumber = 0;
        _operator = "";
    }

    private void DecimalButton_Click(object parameter)
    {
        if (!Display.Contains('.'))
        {
            Display += ".";
        }
    }

    private void FunctionButton_Click(object parameter)
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

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

public class RelayCommand(Action<object> execute, Func<object, bool> canExecute = null) : ICommand
{
    private readonly Action<object> _execute = execute;
    private readonly Func<object, bool> _canExecute = canExecute;

    public event EventHandler? CanExecuteChanged;

    public bool CanExecute(object parameter)
    {
        return _canExecute == null || _canExecute(parameter);
    }

    public void Execute(object parameter)
    {
        _execute(parameter);
    }

    //public event EventHandler CanExecuteChanged
    //{
    //    add { CommandManager.RequerySuggested += value; }
    //    remove { CommandManager.RequerySuggested -= value; }
    //}
}
