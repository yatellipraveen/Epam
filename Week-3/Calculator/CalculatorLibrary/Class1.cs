using System;

namespace CalculatorLibrary
{
    public class MathOperation
    {
        public MathOperation()
        {
        }

        public int Add(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }

        public int Subtract(int number1, int number2)
        {
            int result = number1 - number2;
            return result;
        }

        public double Divide(double number1, double number2)
        {
            if (number2 == 0) throw new DivideByZeroException("Number2 is zero , cannot divide");
            double result = number1 / number2;
            return result;
        }

        public int Multiply(int number1, int number2)
        {

            int result = number1 * number2;
            return result;
        }

     
    }
}
