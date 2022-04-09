using System.Collections.Generic;

namespace LeetCode.Array
{
    //https://leetcode.com/problems/longest-consecutive-sequence/
    public class Longest_Consecutive_Sequence
    {
        public static int LongestConsecutive(int[] nums)
        {
            int result = 0;

            HashSet<int> set = new HashSet<int>(nums);

            for(int i = 0; i < nums.Length; i++)
            {
                if (!set.Contains(nums[i]-1))
                {
                    int counter = 1;
                    int next = nums[i]+1;
                    while (set.Contains(next))
                    {
                        counter++;
                        next++;
                    }

                    if(result < counter)
                    {
                        result = counter;
                    }
                }
            }

            return result;
        }
    }
}
