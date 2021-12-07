using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Array
{
    public class Two_Sum
    {
        //https://leetcode.com/problems/two-sum/
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            IDictionary<int,int> dec = new Dictionary<int, int>();
            int second = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                second = target - nums[i];
                if (dec.ContainsKey(second))
                {
                    result.SetValue(i, 0);
                    result.SetValue(dec[second], 1);
                    break;
                }
                else
                {
                    if (!dec.ContainsKey(nums[i]))
                    {
                        dec.Add(nums[i], i);
                    }
                }
            }

            return result;
        }
    }
}
