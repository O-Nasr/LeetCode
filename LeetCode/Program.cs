using LeetCode.Array;
using System;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            var x = Two_Sum.TwoSum(nums, 9);
            Console.WriteLine(x);
        }
    }
}
