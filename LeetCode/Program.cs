using LeetCode.Array;
using System;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 3, -2, 4 }; //[-2,3,-4] [ 2, 3, -2, 4] [0,2]
            //var x = Two_Sum.TwoSum(nums, 9);
            //var x = Contains_Duplicate.ContainsDuplicate(nums);

            var x = Maximum_Product_Subarray.MaxProduct(nums);
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
