using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    #region Calculator
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
            if (number1 < 0 || number2 < 0) throw new CannotAddNegativeNumberException("System does not add negative numbers");
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
        public int Divide(int number1, int number2)
        {
           // if (number2 == 0) throw new DivideByZeroException("Divisor is zero , cannot divide");
            int result = number1 / number2;
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

    #endregion

    #region CustomException
    /// <summary>
    /// Custon Exception Class
    /// </summary>
    public class CannotAddNegativeNumberException : Exception
    {
        public override string Message { get; }
        public CannotAddNegativeNumberException()
        { 
        }

        public CannotAddNegativeNumberException(String message)
        {
            Message = message;
        }
    }

    #endregion

    #region ThrowandThrowEx
    public class ThrowAndThrowEx
    {
        private void Function2()
        {
            try
            {
                Function3();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ;
            }
        }
        private void Function3()
        {

            throw new ArithmeticException();
        }

       
        public void Function1()
        {
            try
            {
                Function2();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
    #endregion 


    public class CalculatorMain
    {
        public static void Main(String[] args)
        {
            #region ExceptionExample
            MathOperation myCalculator = new MathOperation();
            try
            {
                Console.WriteLine(myCalculator.Divide(10, 0));
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            #endregion

            #region CustomExceptionExample

            try
            {
                myCalculator.Add(5, -1);

            }

            catch (CannotAddNegativeNumberException ex)
            {
                Console.WriteLine(ex);
            }
            #endregion

            //ThrowAndThrowEx Example
            ThrowAndThrowEx throwExample = new ThrowAndThrowEx();
            throwExample.Function1();


        }

    }
}
