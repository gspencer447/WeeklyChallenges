using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            int difference = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
                else if (number % 2 == 1)
                {
                    difference += number;
                }
            }
               return sum - difference;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var strArray = new string[] { str1, str2, str3, str4 };
            return strArray.Min(l => l.Length);
        }
        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numberArray = new int[] { number1, number2, number3, number4 };
            return numberArray.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders"; 
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 < sideLength2 + sideLength3 &&
                sideLength2 < sideLength3 + sideLength1 &&
                sideLength3 < sideLength1 + sideLength2;
        }

        public bool IsStringANumber(string input)
        {
            if (input == null)
            {
                return false;
            }

            if (double.TryParse(input, out var number))
            {
                return true;
            }
            return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;
            foreach (object obj in objs)
            {
                if (obj == null)
                {
                    nullCount++;
                }
            }
            return nullCount > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            int sumEvens = 0;
            int countEvens = 0;

            if (numbers == null)
            {
                return 0;
            }

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sumEvens += number; //adding up the evens
                    countEvens++; //counting the number of evens
                }
            }
            if (countEvens == 0)
                return 0;

         return (double)sumEvens / countEvens;
        }

        public int Factorial(int number)
        {
            if (number == 0) return 1;
            return Enumerable.Range(1, number).Aggregate((accumulator, next) => accumulator*next);
        }
    }
}
