using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
                return false;

            StringComparison comparisonType;

            if (ignoreCase)
                comparisonType = StringComparison.OrdinalIgnoreCase;
            else
                comparisonType = StringComparison.Ordinal;

            foreach (string item in words)
            {
                if (item != null && item.Equals(word, comparisonType))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num < 2)
            {
                return false;
            }

            if (num == 2)
            {
                return true;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return -1; //no unique letters
            }

            Dictionary<char, int> letterIndex = new Dictionary<char, int>();
            HashSet<char> repeatedChars = new HashSet<char>();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char currentChar = str[i];

                if (repeatedChars.Contains(currentChar))
                {
                    continue;
                }

                if (!letterIndex.ContainsKey(currentChar))
                {
                    letterIndex[currentChar] = i;
                }

                else
                {
                    letterIndex.Remove(currentChar);
                    repeatedChars.Add(currentChar);
                }
            }
            if (letterIndex.Count == 0) 
            { 
                return -1;
            }
            int lastIndex = letterIndex.Values.Max();
            return lastIndex;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int maxCount = 1;
            int currentCount = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                }
                else
                {
                    currentCount = 1;
                }
            }
            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n <= 0)
            {
                return new double[] {};
            }

            List<double> result = new List<double>();
            for (int i = n - 1; i < elements.Count; i += n) 
            {
                result.Add(elements[i]);
            }
            return result.ToArray();
        }
    }
}
