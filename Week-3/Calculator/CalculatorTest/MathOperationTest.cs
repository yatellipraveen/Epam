using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;
using System;

namespace CalculatorTest
{
    [TestClass]
    public class MathOperationTest
    {
        [TestMethod]
        public void AddValidIntegers()
        {
            int number1 = 100;
            int number2 = 50;
            int expected = 150;
            MathOperation operation = new MathOperation();
            int actual = operation.Add(number1, number2);
            Assert.AreEqual(expected, actual, "Add method produced incorrect result");
        }

        [TestMethod]
        public void DivideByZero()
        {
            double number1 = 120;
            double number2 = 0;
            MathOperation operation = new MathOperation();
            Assert.ThrowsException<DivideByZeroException>(() => operation.Divide(number1, number2));

        }

        [TestMethod]
        public void DivideValidNumber() {
            double number1 = 100;
            double number2 = 10;
            double expected = 10;
            MathOperation operation = new MathOperation();
            double actual = operation.Divide(number1,number2);
            Assert.AreEqual(expected, actual, "Divide method produced incorrect result");
        }

        [TestMethod]
        public void SubtractNumber() 
        {
            int number1 = 50;
            int number2 = 25;
            int expected = 25;
            MathOperation operation = new MathOperation();
            int actual = operation.Subtract(number1,number2);
            Assert.AreEqual(expected, actual, "Subtract method produced incorrect result");

        }
        [TestMethod]
        public void MultiplyNumber()
        {
            int number1 = 20;
            int number2 = 10;
            int expected = 200;
            MathOperation operation = new MathOperation();
            int actual = operation.Multiply(number1, number2);
            Assert.AreEqual(expected, actual, "Multiply method produced incorrect result");

        }
    }
}
