using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Array
{
    public class Find_Minimum_In_Rotated_Sorted_Array
    {
        //https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
        public int FindMin(int[] nums)
        {
            if(nums == null || nums.Length == 0) { return -1; }
            if(nums.Length == 1) { return nums[0]; }

            int left = 0;
            int right = nums.Length - 1;
            int midPoint = 0;

            while (left < right) { 
                midPoint = left + (right - left) / 2;
                if (midPoint > 0 && nums[midPoint] < nums[midPoint - 1])
                {
                    return nums[midPoint];
                }
                if (nums[midPoint] >= nums[left] && nums[midPoint] > nums[right]) //go right, otherwise go left
                {
                    left = midPoint + 1;
                }
                else
                {
                    right = midPoint - 1;
                }
            }

            return nums[left];
        }
    }
}
