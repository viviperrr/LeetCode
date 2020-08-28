using System;
using System.Collections.Generic;

namespace Find_All_Numbers_Disappeared_in_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };

            IList<int> result = FindDisappearedNumbers(nums);

            foreach (var r in result)
            {
                Console.Write($"{r} -> ");
            }
        }

        /// <summary>
        /// Time Complexity: O(N) - N is length of nums array
        /// Space Complexity: O(1)
        /// </summary>
        static IList<int> FindDisappearedNumbers(int[] nums)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int markIndex = Math.Abs(nums[i]) - 1;

                if (nums[markIndex] > 0)
                {
                    nums[markIndex] = -nums[markIndex];
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    result.Add(i + 1);
                }
            }

            return result;
        }
    }
}
