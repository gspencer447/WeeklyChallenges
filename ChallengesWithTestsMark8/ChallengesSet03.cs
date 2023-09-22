using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals.Contains(false))
            {
                return true;
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return false;
            }
            foreach (int i in numbers)
            {
                sum += i;
            }
            if (sum % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasUpper = false;
            bool hasLower = false;
            bool hasNumber = false;
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUpper = true;
                }
                if (char.IsLower(c))
                {
                    hasLower = true;
                }
                if (char.IsDigit(c))
                {
                    hasNumber = true;
                }
                if (hasUpper && hasLower && hasNumber)
                {
                    break;
                }
            }
            return hasUpper && hasLower && hasNumber;
        }

        public char GetFirstLetterOfString(string val)
        {
            char[] chars = val.ToCharArray();
            return chars[0];
        }

        public char GetLastLetterOfString(string val)
        {
            char[] charArray = val.ToCharArray();
            return charArray[charArray.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (dividend == 0 || divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.LastOrDefault() - nums.FirstOrDefault();
        }

        public int[] GetOddsBelow100()
        {
            return Enumerable.Range(0, 100).Where(i => i % 2 != 0).ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
