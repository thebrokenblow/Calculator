namespace Calculator.Model;

public enum MathFunction
{
    Sin,
    Cos,
    Sqrt,
    Floor,
    Ceil
}

public enum MathOperation
{
    Add,
    Sub,
    Div,
    Mul,
    Mod,
    Pow
}

public class MathOperations
{
    public Dictionary<MathFunction, Func<double, double>> FunctionsByName { get; set; } = new()
    {
        { MathFunction.Sin, Math.Sin },
        { MathFunction.Cos, Math.Cos },
        { MathFunction.Sqrt, Math.Sqrt },
        { MathFunction.Floor, Math.Floor },
        { MathFunction.Ceil, Math.Ceiling }
    };

    public Dictionary<MathOperation, Func<double, double, double>> Operations { get; set; } = new()
    {
        { MathOperation.Add, (a, b) => a + b },
        { MathOperation.Sub, (a, b) => a - b },
        { MathOperation.Mul, (a, b) => a * b },
        { MathOperation.Div, (a, b) => a / b },
        { MathOperation.Mod, (a, b) => a % b },
        { MathOperation.Pow, Math.Pow }
    };
}