using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.Model;
using System;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

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

        [TestMethod]
        public void TestSinFunction()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Sin](Math.PI / 2);
            Assert.AreEqual(1, result, 0.0001);
        }

        [TestMethod]
        public void TestCosFunction()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Cos](Math.PI);
            Assert.AreEqual(-1, result, 0.0001);
        }

        [TestMethod]
        public void TestSqrtFunction()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Sqrt](4);
            Assert.AreEqual(2, result, 0.0001);
        }

        [TestMethod]
        public void TestFloorFunction()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Floor](4.5);
            Assert.AreEqual(4, result, 0.0001);
        }

        [TestMethod]
        public void TestCeilFunction()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Ceil](4.5);
            Assert.AreEqual(5, result, 0.0001);
        }

        [TestMethod]
        public void TestAddOperation()
        {
            double result = _mathOperations.Operations[MathOperation.Add](2, 3);
            Assert.AreEqual(5, result, 0.0001);
        }

        [TestMethod]
        public void TestSubOperation()
        {
            double result = _mathOperations.Operations[MathOperation.Sub](5, 3);
            Assert.AreEqual(2, result, 0.0001);
        }

        [TestMethod]
        public void TestMulOperation()
        {
            double result = _mathOperations.Operations[MathOperation.Mul](2, 3);
            Assert.AreEqual(6, result, 0.0001);
        }

        [TestMethod]
        public void TestDivOperation()
        {
            double result = _mathOperations.Operations[MathOperation.Div](6, 3);
            Assert.AreEqual(2, result, 0.0001);
        }

        [TestMethod]
        public void TestModOperation()
        {
            double result = _mathOperations.Operations[MathOperation.Mod](5, 3);
            Assert.AreEqual(2, result, 0.0001);
        }

        [TestMethod]
        public void TestPowOperation()
        {
            double result = _mathOperations.Operations[MathOperation.Pow](2, 3);
            Assert.AreEqual(8, result, 0.0001);
        }
    }
}
