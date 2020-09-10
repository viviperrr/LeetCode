using System;
using System.Data;

namespace Search_Insert_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 3, 5, 6 };

            Console.WriteLine($"Position: {GetTargetPosition(nums, 5)}");
            Console.WriteLine($"Position: {GetTargetPosition(nums, 2)}");
            Console.WriteLine($"Position: {GetTargetPosition(nums, 7)}");
            Console.WriteLine($"Position: {GetTargetPosition(nums, 0)}");
        }

        static int GetTargetPosition(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;
            int mid = 0;
            while (low <= high)
            {
                mid = (high + low) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] > target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return mid;
        }
    }
}
