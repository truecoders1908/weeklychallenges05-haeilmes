using System;
using System.Linq;
using System.Collections.Generic;


namespace weeklyChallenges05
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int x = startNumber;
            do
            {
                x++;
            }
            while (x % n != 0);
            return x;
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
            if (numbers != null && numbers.Length != 0)
                return numbers.Zip(numbers.Skip(1), (curr, next) => curr <= next).All(x => x);
            else
                return false;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int x = 0;
            int y = 0;
            if (numbers == null)
            {
                return 0;
            }
            foreach (var item in numbers)
            {
                if (x > 0)
                {
                    y += item;
                    x--;
                }
                if (item % 2 == 0)
                    x++;
            }
            return y;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words is null || words.Length < 1)
            {
                return " ";
            }
            return String.Join(" ", words.Where(word => !string.IsNullOrEmpty(word) || word == " ")) + ".";
        }
            public double[] GetEveryFourthElement(List<double> elements)
        {
            double[] low = new double[0];
            List<double> fourth = new List<double>();
            fourth.Add(4);
            List<double> list2 = new List<double>();
            int x = 0;
            if (elements == null || elements.Count < 4)
                return low;
            else if (elements.Count == 4)
                return fourth.ToArray();
            else
            {
                foreach (double item in elements)
                {
                    x += 1;
                    if (x == 4)
                    {
                        list2.Add(item);
                        x -= 4;
                    }
                }
            }
            return list2.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = nums.Length - 1; j > i; j--)
                {
                    if (nums[i] + nums[j] == targetNumber)
                        return true;
                }
            }
            return false;
        }
    }
}
