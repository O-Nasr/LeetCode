using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Array
{
    //https://leetcode.com/problems/contains-duplicate/
    public class Contains_Duplicate
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            if (nums == null) return false;

            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i]))
                {
                    return true;
                }
                else
                {
                    set.Add(nums[i]);
                }
            }
            return false;
        }
    }
}
