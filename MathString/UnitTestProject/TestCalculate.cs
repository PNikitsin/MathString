using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLibrary;

namespace UnitTestProject
{
    [TestClass]
    public class TestCalculate
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expression = "2+3";
            int result = Calculator.Calculate(expression);

            Assert.AreEqual(result, 5);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string expression = "(2+3)*6";
            int result = Calculator.Calculate(expression);

            Assert.AreEqual(result, 30);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string expression = "2+-6";
            int result = Calculator.Calculate(expression);

            Assert.AreEqual(result, -4);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string expression = "-(33*11)/(-11)";
            int result = Calculator.Calculate(expression);

            Assert.AreEqual(result, 33);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string expression = "-2";
            int result = Calculator.Calculate(expression);

            Assert.AreEqual(result, -2);
        }

        [TestMethod]
        public void TestMethod6()
        {
            string expression = "2+3*5";
            int result = Calculator.Calculate(expression);

            Assert.AreEqual(result, 17);
        }

        [TestMethod]
        public void TestMethod7()
        {
            string expression = "(-(+2-1))";
            int result = Calculator.Calculate(expression);

            Assert.AreEqual(result, -1);
        }

        [TestMethod]
        public void TestMethod8()
        {
            string expression = "2+2*(222-125)+32/2*1";
            int result = Calculator.Calculate(expression);

            Assert.AreEqual(result, 212);
        }

        [TestMethod]
        [ExpectedException(typeof(CalculateExceptionDivideByZero))]
        public void DivisionByZero()
        {
            string expression = "2 / 0";
            int result = Calculator.Calculate(expression);
        }

        [TestMethod]
        [ExpectedException(typeof(CalculateExceptionStringIsEmpty))]
        public void StringIsEmpty()
        {
            string expression = "";
            int result = Calculator.Calculate(expression);
        }

        [TestMethod]
        [ExpectedException(typeof(CalculateExceptionInvalidExpression))]
        public void InvalidInput()
        {
            string expression = "shshshshs";
            int result = Calculator.Calculate(expression);
        }
    }
}