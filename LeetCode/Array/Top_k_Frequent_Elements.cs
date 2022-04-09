using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Array
{
    //https://leetcode.com/problems/top-k-frequent-elements/
    public class Top_k_Frequent_Elements
    {
        public static int[] TopKFrequent(int[] nums, int k)
        {
            int[] result = new int[k];

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for(int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], 1);
                }
                else
                {
                    dict[nums[i]]++;
                }
            }

            for(int i = 0; i < k; i++)
            {
                int maxTemp = 0;
                int key = 0;
                foreach(var item in dict)
                {
                    if(item.Value > maxTemp)
                    {
                        maxTemp = item.Value;
                        key = item.Key;
                    }
                }
                result[i] = key;
                dict.Remove(key);
            }

            return result;
        }
    }
}
