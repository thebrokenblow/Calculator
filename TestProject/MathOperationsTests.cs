using Calculator.Model;

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

        // Additional tests

        [TestMethod]
        public void TestSinFunctionNegative()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Sin](-Math.PI / 2);
            Assert.AreEqual(-1, result, 0.0001);
        }

        [TestMethod]
        public void TestCosFunctionNegative()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Cos](-Math.PI);
            Assert.AreEqual(-1, result, 0.0001);
        }

        [TestMethod]
        public void TestSqrtFunctionZero()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Sqrt](0);
            Assert.AreEqual(0, result, 0.0001);
        }

        [TestMethod]
        public void TestFloorFunctionNegative()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Floor](-4.5);
            Assert.AreEqual(-5, result, 0.0001);
        }

        [TestMethod]
        public void TestCeilFunctionNegative()
        {
            double result = _mathOperations.FunctionsByName[MathFunction.Ceil](-4.5);
            Assert.AreEqual(-4, result, 0.0001);
        }

        [TestMethod]
        public void TestAddOperationNegative()
        {
            double result = _mathOperations.Operations[MathOperation.Add](-2, -3);
            Assert.AreEqual(-5, result, 0.0001);
        }

        [TestMethod]
        public void TestSubOperationNegative()
        {
            double result = _mathOperations.Operations[MathOperation.Sub](-5, -3);
            Assert.AreEqual(-2, result, 0.0001);
        }

        [TestMethod]
        public void TestMulOperationNegative()
        {
            double result = _mathOperations.Operations[MathOperation.Mul](-2, -3);
            Assert.AreEqual(6, result, 0.0001);
        }

        [TestMethod]
        public void TestDivOperationNegative()
        {
            double result = _mathOperations.Operations[MathOperation.Div](-6, -3);
            Assert.AreEqual(2, result, 0.0001);
        }

        [TestMethod]
        public void TestModOperationNegative()
        {
            double result = _mathOperations.Operations[MathOperation.Mod](-5, -3);
            Assert.AreEqual(-2, result, 0.0001);
        }

        [TestMethod]
        public void TestPowOperationNegative()
        {
            double result = _mathOperations.Operations[MathOperation.Pow](-2, 3);
            Assert.AreEqual(-8, result, 0.0001);
        }

        [TestMethod]
        public void TestLargeNumbersAddition()
        {
            double result = _mathOperations.Operations[MathOperation.Add](1e10, 1e10);
            Assert.AreEqual(2e10, result, 0.0001);
        }

        [TestMethod]
        public void TestLargeNumbersMultiplication()
        {
            double result = _mathOperations.Operations[MathOperation.Mul](1e10, 1e10);
            Assert.AreEqual(1e20, result, 0.0001);
        }

        [TestMethod]
        public void TestLargeNumbersDivision()
        {
            double result = _mathOperations.Operations[MathOperation.Div](1e20, 1e10);
            Assert.AreEqual(1e10, result, 0.0001);
        }

        [TestMethod]
        public void TestLargeNumbersSubtraction()
        {
            double result = _mathOperations.Operations[MathOperation.Sub](1e10, 1e10);
            Assert.AreEqual(0, result, 0.0001);
        }
    }
}
