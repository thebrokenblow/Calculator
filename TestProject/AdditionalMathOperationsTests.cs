using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.Model;
using System;

namespace Calculator.Tests
{
    [TestClass]
    public class AdditionalMathOperationsTests
    {
        private MathOperations _mathOperations;

        [TestInitialize]
        public void Setup()
        {
            _mathOperations = new MathOperations();
        }

        [TestMethod]
        public void TestSinFunctionZero()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Sin](0);
            Assert.AreEqual(0, result, 0.0001);
        }

        [TestMethod]
        public void TestCosFunctionZero()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Cos](0);
            Assert.AreEqual(1, result, 0.0001);
        }


        [TestMethod]
        public void TestFloorFunctionZero()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Floor](0);
            Assert.AreEqual(0, result, 0.0001);
        }

        [TestMethod]
        public void TestCeilFunctionZero()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Ceil](0);
            Assert.AreEqual(0, result, 0.0001);
        }

        [TestMethod]
        public void TestAddOperationZero()
        {
            double result = _mathOperations.Operations[MathOperation.Add](0, 0);
            Assert.AreEqual(0, result, 0.0001);
        }

        [TestMethod]
        public void TestSubOperationZero()
        {
            double result = _mathOperations.Operations[MathOperation.Sub](0, 0);
            Assert.AreEqual(0, result, 0.0001);
        }

        [TestMethod]
        public void TestMulOperationZero()
        {
            double result = _mathOperations.Operations[MathOperation.Mul](0, 0);
            Assert.AreEqual(0, result, 0.0001);
        }

        [TestMethod]
        public void TestDivOperationZero()
        {
            double result = _mathOperations.Operations[MathOperation.Div](0, 1);
            Assert.AreEqual(0, result, 0.0001);
        }

        [TestMethod]
        public void TestModOperationZero()
        {
            double result = _mathOperations.Operations[MathOperation.Mod](0, 1);
            Assert.AreEqual(0, result, 0.0001);
        }

        [TestMethod]
        public void TestPowOperationZero()
        {
            double result = _mathOperations.Operations[MathOperation.Pow](0, 0);
            Assert.AreEqual(1, result, 0.0001);
        }

        [TestMethod]
        public void TestSinFunctionLargeNumber()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Sin](1e10);
            Assert.AreEqual(Math.Sin(1e10), result, 0.0001);
        }

        [TestMethod]
        public void TestCosFunctionLargeNumber()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Cos](1e10);
            Assert.AreEqual(Math.Cos(1e10), result, 0.0001);
        }

        [TestMethod]
        public void TestSqrtFunctionLargeNumber()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Sqrt](1e20);
            Assert.AreEqual(Math.Sqrt(1e20), result, 0.0001);
        }

        [TestMethod]
        public void TestFloorFunctionLargeNumber()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Floor](1e20);
            Assert.AreEqual(1e20, result, 0.0001);
        }

        [TestMethod]
        public void TestCeilFunctionLargeNumber()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Ceil](1e20);
            Assert.AreEqual(1e20, result, 0.0001);
        }

        [TestMethod]
        public void TestAddOperationLargeNumbers()
        {
            double result = _mathOperations.Operations[MathOperation.Add](1e20, 1e20);
            Assert.AreEqual(2e20, result, 0.0001);
        }

        [TestMethod]
        public void TestSubOperationLargeNumbers()
        {
            double result = _mathOperations.Operations[MathOperation.Sub](1e20, 1e20);
            Assert.AreEqual(0, result, 0.0001);
        }

        [TestMethod]
        public void TestMulOperationLargeNumbers()
        {
            double result = _mathOperations.Operations[MathOperation.Mul](1e20, 1e20);
            Assert.AreEqual(1e40, result, 0.0001);
        }

        [TestMethod]
        public void TestDivOperationLargeNumbers()
        {
            double result = _mathOperations.Operations[MathOperation.Div](1e40, 1e20);
            Assert.AreEqual(1e20, result, 0.0001);
        }

        [TestMethod]
        public void TestModOperationLargeNumbers()
        {
            double result = _mathOperations.Operations[MathOperation.Mod](1e20, 1e20);
            Assert.AreEqual(0, result, 0.0001);
        }

        [TestMethod]
        public void TestPowOperationLargeNumbers()
        {
            double result = _mathOperations.Operations[MathOperation.Pow](1e20, 2);
            Assert.AreEqual(1e40, result, 0.0001);
        }
    }
}
