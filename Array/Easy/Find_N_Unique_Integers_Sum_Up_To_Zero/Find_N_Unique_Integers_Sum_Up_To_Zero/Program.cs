using System;

namespace Find_N_Unique_Integers_Sum_Up_To_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[] result = SumZero(n);

            Console.Write("[");
            foreach (var r in result)
            {
                Console.Write("{0}, ", r);
            }
            Console.Write("]");
        }

        /// <summary>
        /// Time Complexity: O(N) input: n
        /// Space Comlexity: O(N) input: n
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>

        static int[] SumZero(int n)
        {
            int[] result = new int[n];
            int index = n / 2;

            if (n == 1)
            {
                result[0] = 0;
                return result;
            }

            while (n > index)
            {
                result[n - 1] = n;
                result[result.Length - n] = -n;
                n--;
            }

            if (result.Length % 2 == 0)
            {
                result[n - 1] = n;
                result[result.Length - n] = -n;
            }
            else
            {
                result[n] = 0;
            }

            return result;
        }
    }
}
