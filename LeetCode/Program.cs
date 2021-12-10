using LeetCode.Array;
using System;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            //var x = Two_Sum.TwoSum(nums, 9);
            //var x = Contains_Duplicate.ContainsDuplicate(nums);

            var x = Maximum_Subarray.MaxSubArray(nums);
            Console.WriteLine(x);

            //DisplayCollection(x);
        }

        public static void DisplayCollection(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
