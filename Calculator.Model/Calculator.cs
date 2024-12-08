namespace Calculator.Model;
public enum MathFunction
{
    Sin,
    Cos,
    Sqrt,
    Floor,
    Ceil,
}
public enum MathOperation
{
    Add,
    Subtract,
    Div,
    Mul,
    Mod,
    Pow
}

public static class MathOperations
{
    public static readonly Dictionary<MathOperation, Func<double, double>> Functions = new Dictionary<MathOperation, Func<double, double>>
        {
            { MathFunction.Sin, Math.Sin },
            { MathFunction.Cos, Math.Cos },
            { MathFunction.Sqrt, Math.Sqrt },
            { MathFunction.Floor, Math.Floor },
            { MathFunction.Ceil, Math.Ceiling }
        };
    public static readonly Dictionary<MathOperation, Func<double, double, double>> Operations = new Dictionary<MathOperation, Func<double, double,double>>
        {
            { MathOperation.Add, (a,b) => { a + b; } },
            { MathOperation.Subtract, (a,b) => { a - b; } },
            { MathOperation.Mul, (a,b) => { a * b;} },
            { MathOperation.Div, (a,b) => { a / b; } },
            { MathOperation.Mod, (a,b) => { a % b; } },
            { MathOperation.Pow, (a,b) => { Math.Pow(a,b); } }
        };
}