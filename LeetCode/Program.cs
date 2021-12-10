using LeetCode.Array;
using System;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 1, 0, -3, 3 };
            //var x = Two_Sum.TwoSum(nums, 9);
            //var x = Contains_Duplicate.ContainsDuplicate(nums);

            var x = Product_Except_Self.ProductExceptSelf(nums);
            //Console.WriteLine(x);

            DisplayCollection(x);
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
