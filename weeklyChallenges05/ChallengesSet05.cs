using System;
using System.Linq;
using System.Collections.Generic;


namespace weeklyChallenges05
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            throw new NotImplementedException();
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach(var business in businesses)
            {
                if(business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers != null && numbers.Length > 1)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    while (numbers[i] <= numbers[i + 1])
                    {
                        return true;
                    }
                }
            }
            else if (numbers.Length == 1)
            {
                return true;
            }
            return false;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if(words is null || words.Length < 1)
            {
                return "";
            }

            return String.Join(" ", words.Where(word => !string.IsNullOrEmpty(word) || word == " ")) + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            throw new NotImplementedException();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] + nums[i] == targetNumber)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
