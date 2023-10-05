using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return Enumerable.Range(startNumber + 1, startNumber + n)
                .First(x => x % n == 0);
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var bus in businesses)
            {
                if (bus.TotalRevenue == 0)
                {
                    bus.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int numSum = 0;
            if (numbers == null)
            {
                return 0;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    if ((i + 1) < numbers.Length)
                        numSum += numbers[i + 1];
                }
            }
            return numSum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";

            }

            string sentence = "";
            string word = "";

            for (int i = 0; i < words.Length; i++)
            {

                word = words[i];
                word = word.Trim();
                if (word.Length != 0 && i + 1 < words.Length)
                {
                    sentence += word + " ";
                }
                if (word.Length != 0 && i + 1 == words.Length)
                {
                    sentence += word + ".";
                }
            }
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return new double[] { };
            }
            List<double> result = new List<double>();

            for (int i = 3; i < elements.Count; i += 4)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            HashSet<int> numSet = new HashSet<int>();

            foreach (int num in nums)
            {
                int complement = targetNumber - num;
                if (numSet.Contains(complement))
                {
                    return true;
                }
                numSet.Add(num);
            }
            return false;
        }
    }
}
