using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            double difference = minuend - subtrahend;
            return difference;
        }

        public int Add(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if (number1 > number2) 
            {
                return number2;
            }
            else
            {
                return number1;
            }
        }

        public long Multiply(long factor1, long factor2)
        {
            long product = factor1 * factor2;
            return product;
        }

        public string GetGreeting(string nameOfPerson)
        {
            if (nameOfPerson == "") 
            {
                return "Hello!";
            }
            else
            {
            return $"Hello, {nameOfPerson}!";
            }
        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
