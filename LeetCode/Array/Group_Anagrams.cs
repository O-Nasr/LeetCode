using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Array
{
    //https://leetcode.com/problems/group-anagrams/
    public class Group_Anagrams
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            List<IList<string>> lists = new List<IList<string>>();

            int arrLength = strs.Length;

            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            if (arrLength > 0)
            {
                for (int i = 0; i < arrLength; i++)
                {
                    string sortString = String.Concat(strs[i].OrderBy(c => c));

                    if (!dict.ContainsKey(sortString))
                    {
                        dict.Add(sortString, new List<string>());
                    }

                    dict[sortString].Add(strs[i]);
                }

                foreach(var item in dict.Values)
                {
                    lists.Add(item);
                }
            }


            return lists;
        }
    }
}
