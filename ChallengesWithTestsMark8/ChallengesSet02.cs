using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberEven(int number)
        {
            if(number % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0)
            {
                return false;
            }
            else
            {

            return true;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null) { return 0; }
            if (!numbers.Any())
            {
                return 0;
            }
            double min = numbers.First();
            double max = numbers.Last();
            foreach (double number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }
            }
                return min + max;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            return str2.Length;
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return 0;
            }

            foreach (int i in numbers)
            { 
                sum += i;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int numSum = 0;
            if (numbers == null)
            {
                return 0;
            }
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    numSum += i;
                }
            }
            return numSum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int listSum = 0;
            if (numbers == null)
            {
                return false;
            }
            foreach (int i in numbers)
            {
                listSum += i;
            }
            return listSum % 2 !=  0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
            }
            long count = 0;
            for (long i = 1; i < number; i += 2)
            {
                count++;
            }
            return count;
        }
    }
}
