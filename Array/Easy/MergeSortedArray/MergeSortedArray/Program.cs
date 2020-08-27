using System;

namespace MergeSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = new int[] { 2, 5, 6 };

            int m = 3, n = 3;

            Merge(nums1, m, nums2, n);

            foreach (var num in nums1)
            {
                Console.Write("{0} -> ", num);
            }
        }
        /// <summary>
        /// Time Complexity: O(M + N)
        /// Space Complexity: O(1)
        /// </summary>
        static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1;
            int j = n - 1;
            int lastIndex = m + n - 1;

            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[lastIndex--] = nums1[i--];
                }
                else
                {
                    nums1[lastIndex--] = nums2[j--];
                }
            }

            while (j >= 0)
            {
                nums1[lastIndex--] = nums2[j--];
            }
        }
    }
}
