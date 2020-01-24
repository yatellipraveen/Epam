using System;

namespace CalculatorLibrary
{
    public class MathOperation
    {
        #region operations
        public MathOperation()
        {
        }
        /// <summary>
        /// performs addition operation on two integers and returns the sum
        /// </summary>
        /// <param name="number1">first number to add</param>
        /// <param name="number2">second number to add</param>
        /// <returns>
        /// returns the sum of two numbers
        /// </returns>
        public int Add(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }
        /// <summary>
        /// performs subtraction of two integers
        /// </summary>
        /// <param name="number1">first number</param>
        /// <param name="number2">second number</param>
        /// <returns>returns the subtraction of two integers</returns>
        public int Subtract(int number1, int number2)
        {
            int result = number1 - number2;
            return result;
        }
        /// <summary>
        /// performs division of two integers
        /// </summary>
        /// <param name="number1">Divident</param>
        /// <param name="number2">Divisor</param>
        /// <returns> returns the quotient after division</returns>
        public double Divide(double number1, double number2)
        {
            if (number2 == 0) throw new DivideByZeroException("Number2 is zero , cannot divide");
            double result = number1 / number2;
            return result;
        }
        /// <summary>
        /// peforms multiplication of two numbers and returns the result
        /// </summary>
        /// <param name="number1">first number</param>
        /// <param name="number2">second number</param>
        /// <returns>returns the result of multiplication of two numbers</returns>
        public int Multiply(int number1, int number2)
        {

            int result = number1 * number2;
            return result;
        }
        #endregion


    }
}
