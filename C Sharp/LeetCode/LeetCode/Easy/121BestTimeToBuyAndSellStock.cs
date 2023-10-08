using System;

namespace LeetCode.Easy
{
    /*
     * 121. Best Time to Buy and Sell Stock
     * You are given an array prices where prices[i] is the price of a given stock on the ith day.
     * You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
     * Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
     */
    public class _121BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            int l = 0, r = 1;
            int maxProfit = 0;
            while (r < prices.Length)
            {
                if (prices[l] < prices[r])
                    maxProfit = Math.Max(maxProfit, prices[r] - prices[l]);
                else
                    l = r;
                r++;
            }
            return maxProfit;
        }
    }
}
