using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.Model;
using System;

namespace Calculator.Tests
{
    [TestClass]
    public class MathOperationsTests
    {
        private MathOperations _mathOperations;

        [TestInitialize]
        public void Setup()
        {
            _mathOperations = new MathOperations();
        }

        #region MathFunction Tests

        [TestMethod]
        public void TestSinFunction_Positive()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Sin](Math.PI / 2);
            Assert.AreEqual(1.0, result, 0.00001, "Sin function test failed for positive value");
        }

        [TestMethod]
        public void TestSinFunction_Negative()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Sin](-Math.PI / 2);
            Assert.AreEqual(-1.0, result, 0.00001, "Sin function test failed for negative value");
        }

        [TestMethod]
        public void TestSinFunction_Zero()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Sin](0);
            Assert.AreEqual(0.0, result, 0.00001, "Sin function test failed for zero value");
        }

        [TestMethod]
        public void TestCosFunction_Positive()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Cos](0);
            Assert.AreEqual(1.0, result, 0.00001, "Cos function test failed for positive value");
        }

        [TestMethod]
        public void TestCosFunction_Negative()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Cos](Math.PI);
            Assert.AreEqual(-1.0, result, 0.00001, "Cos function test failed for negative value");
        }

        [TestMethod]
        public void TestCosFunction_Zero()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Cos](0);
            Assert.AreEqual(1.0, result, 0.00001, "Cos function test failed for zero value");
        }

        [TestMethod]
        public void TestSqrtFunction_Positive()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Sqrt](4.0);
            Assert.AreEqual(2.0, result, 0.00001, "Sqrt function test failed for positive value");
        }

        [TestMethod]
        public void TestSqrtFunction_Zero()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Sqrt](0.0);
            Assert.AreEqual(0.0, result, 0.00001, "Sqrt function test failed for zero value");
        }

        [TestMethod]
        public void TestFloorFunction_Positive()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Floor](2.9);
            Assert.AreEqual(2.0, result, 0.00001, "Floor function test failed for positive value");
        }

        [TestMethod]
        public void TestFloorFunction_Negative()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Floor](-2.9);
            Assert.AreEqual(-3.0, result, 0.00001, "Floor function test failed for negative value");
        }

        [TestMethod]
        public void TestFloorFunction_Zero()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Floor](0.0);
            Assert.AreEqual(0.0, result, 0.00001, "Floor function test failed for zero value");
        }

        [TestMethod]
        public void TestCeilFunction_Positive()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Ceil](2.1);
            Assert.AreEqual(3.0, result, 0.00001, "Ceil function test failed for positive value");
        }

        [TestMethod]
        public void TestCeilFunction_Negative()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Ceil](-2.1);
            Assert.AreEqual(-2.0, result, 0.00001, "Ceil function test failed for negative value");
        }

        [TestMethod]
        public void TestCeilFunction_Zero()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Ceil](0.0);
            Assert.AreEqual(0.0, result, 0.00001, "Ceil function test failed for zero value");
        }

        #endregion

        #region MathOperation Tests

        [TestMethod]
        public void TestAddOperation_Positive()
        {
            double result = _mathOperations.Operations[MathOperation.Add](2.0, 3.0);
            Assert.AreEqual(5.0, result, 0.00001, "Add operation test failed for positive values");
        }

        [TestMethod]
        public void TestAddOperation_Negative()
        {
            double result = _mathOperations.Operations[MathOperation.Add](-2.0, -3.0);
            Assert.AreEqual(-5.0, result, 0.00001, "Add operation test failed for negative values");
        }

        [TestMethod]
        public void TestAddOperation_Zero()
        {
            double result = _mathOperations.Operations[MathOperation.Add](0.0, 0.0);
            Assert.AreEqual(0.0, result, 0.00001, "Add operation test failed for zero values");
        }

        [TestMethod]
        public void TestSubOperation_Positive()
        {
            double result = _mathOperations.Operations[MathOperation.Sub](5.0, 3.0);
            Assert.AreEqual(2.0, result, 0.00001, "Sub operation test failed for positive values");
        }

        [TestMethod]
        public void TestSubOperation_Negative()
        {
            double result = _mathOperations.Operations[MathOperation.Sub](-5.0, -3.0);
            Assert.AreEqual(-2.0, result, 0.00001, "Sub operation test failed for negative values");
        }

        [TestMethod]
        public void TestSubOperation_Zero()
        {
            double result = _mathOperations.Operations[MathOperation.Sub](0.0, 0.0);
            Assert.AreEqual(0.0, result, 0.00001, "Sub operation test failed for zero values");
        }

        [TestMethod]
        public void TestMulOperation_Positive()
        {
            double result = _mathOperations.Operations[MathOperation.Mul](2.0, 3.0);
            Assert.AreEqual(6.0, result, 0.00001, "Mul operation test failed for positive values");
        }

        [TestMethod]
        public void TestMulOperation_Negative()
        {
            double result = _mathOperations.Operations[MathOperation.Mul](-2.0, -3.0);
            Assert.AreEqual(6.0, result, 0.00001, "Mul operation test failed for negative values");
        }

        [TestMethod]
        public void TestMulOperation_Zero()
        {
            double result = _mathOperations.Operations[MathOperation.Mul](0.0, 3.0);
            Assert.AreEqual(0.0, result, 0.00001, "Mul operation test failed for zero values");
        }

        [TestMethod]
        public void TestDivOperation_Positive()
        {
            double result = _mathOperations.Operations[MathOperation.Div](6.0, 3.0);
            Assert.AreEqual(2.0, result, 0.00001, "Div operation test failed for positive values");
        }

        [TestMethod]
        public void TestDivOperation_Negative()
        {
            double result = _mathOperations.Operations[MathOperation.Div](-6.0, -3.0);
            Assert.AreEqual(2.0, result, 0.00001, "Div operation test failed for negative values");
        }

        [TestMethod]
        public void TestModOperation_Positive()
        {
            double result = _mathOperations.Operations[MathOperation.Mod](5.0, 3.0);
            Assert.AreEqual(2.0, result, 0.00001, "Mod operation test failed for positive values");
        }

        [TestMethod]
        public void TestModOperation_Negative()
        {
            double result = _mathOperations.Operations[MathOperation.Mod](-5.0, -3.0);
            Assert.AreEqual(-2.0, result, 0.00001, "Mod operation test failed for negative values");
        }

        [TestMethod]
        public void TestPowOperation_Positive()
        {
            double result = _mathOperations.Operations[MathOperation.Pow](2.0, 3.0);
            Assert.AreEqual(8.0, result, 0.00001, "Pow operation test failed for positive values");
        }

        [TestMethod]
        public void TestPowOperation_Negative()
        {
            double result = _mathOperations.Operations[MathOperation.Pow](2.0, -2.0);
            Assert.AreEqual(0.25, result, 0.00001, "Pow operation test failed for negative exponent");
        }

        [TestMethod]
        public void TestPowOperation_Zero()
        {
            double result = _mathOperations.Operations[MathOperation.Pow](0.0, 2.0);
            Assert.AreEqual(0.0, result, 0.00001, "Pow operation test failed for zero base");
        }

        #endregion
    }
}
