using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Array
{
    public class Max_Profit
    {
		//https://leetcode.com/problems/best-time-to-buy-and-sell-stock/

		public static int MaxProfit(int[] prices)
		{
			if (prices.Length == 0)
			{
				return 0;
			}

			int minPrice = prices[0];
			int maxProfit = 0;

			for (int i = 1; i < prices.Length; i++)
			{
				if (prices[i] < minPrice)
				{
					minPrice = prices[i];
				}
				else if (prices[i] - minPrice >= maxProfit)
				{
					maxProfit = prices[i] - minPrice;
				}
			}

			return maxProfit;
		}
	}
}
