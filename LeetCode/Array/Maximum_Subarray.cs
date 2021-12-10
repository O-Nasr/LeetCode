namespace LeetCode.Array
{
    public class Maximum_Subarray
    {
        //https://leetcode.com/problems/maximum-subarray/
        public static int MaxSubArray(int[] nums)
        {
            int maxCurrent = nums[0];
            int maxGlobl = maxCurrent;

            for(int i = 1; i < nums.Length; i++)
            {
                maxCurrent = (nums[i] + maxCurrent > nums[i]) ? nums[i] + maxCurrent : nums[i];
                if(maxCurrent > maxGlobl) { maxGlobl = maxCurrent; }
            }
            return maxGlobl;
        }
    }
}
