using System;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }

        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public double Divide(int number1, int number2)
        {
            if(number2 == 0)
            {
                throw new Exception("Não existe divisão por 0");  // Não existe divisão por 0
            }
            return number1 / number2;
        }
    }
}
