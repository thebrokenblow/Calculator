using System;
using Calculator.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Calculator.Tests;

[TestClass]
public class CalculatorTests
{
    private MathOperations _calculatorModel;
    [TestInitialize]
    public void Setup()
    {
        _calculatorModel = new MathOperations();
    }

    [TestMethod]
    public void TestSinFunction()
    {
        double result = _calculatorModel.FunctionsByName[MathFunction.Sin].Invoke(Math.PI/2);
        Assert.AreEqual(1, result, 0.0001);
    }

    [TestMethod]
    public void TestCosFunction()
    {
        double result = _calculatorModel.FunctionsByName[MathFunction.Cos].Invoke(0);
        Assert.AreEqual(1, result, 0.0001);
    }

    [TestMethod]
    public void TestSqrtFunction()
    {
        double result = _calculatorModel.FunctionsByName[MathFunction.Sqrt].Invoke(4);
        Assert.AreEqual(2, result, 0.0001);
    }

    [TestMethod]
    public void TestFloorFunction()
    {
        double result = _calculatorModel.FunctionsByName[MathFunction.Floor].Invoke(2.7);
        Assert.AreEqual(2, result, 0.0001);
    }

    [TestMethod]
    public void TestCeilFunction()
    {
        double result = _calculatorModel.FunctionsByName[MathFunction.Ceil].Invoke(2.3);
        Assert.AreEqual(3, result, 0.0001);
    }

    [TestMethod]
    public void TestAddOperation()
    {
        double result = _calculatorModel.Operations[MathOperation.Add].Invoke(2, 3);
        Assert.AreEqual(5, result, 0.0001);
    }

    [TestMethod]
    public void TestSubtractOperation()
    {
        double result = _calculatorModel.Operations[MathOperation.Sub].Invoke(5, 3);
        Assert.AreEqual(2, result, 0.0001);
    }

    [TestMethod]
    public void TestDivOperation()
    {
        double result = _calculatorModel.Operations[MathOperation.Div].Invoke(6, 3);
        Assert.AreEqual(2, result, 0.0001);
    }

    [TestMethod]
    public void TestMulOperation()
    {
        double result = _calculatorModel.Operations[MathOperation.Mul].Invoke(2, 3);
        Assert.AreEqual(6, result, 0.0001);
    }

    [TestMethod]
    public void TestModOperation()
    {
        double result = _calculatorModel.Operations[MathOperation.Mod].Invoke(5, 3);
        Assert.AreEqual(2, result, 0.0001);
    }

    [TestMethod]
    public void TestPowOperation()
    {
        double result = _calculatorModel.Operations[MathOperation.Pow].Invoke(2, 3);
        Assert.AreEqual(8, result, 0.0001);
    }
}