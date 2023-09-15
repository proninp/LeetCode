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
            int profit, maxProfit = 0;
            while (r < prices.Length)
            {
                if (prices[l] < prices[r])
                {
                    profit = prices[r] - prices[l];
                    maxProfit = Math.Max(maxProfit, profit);
                }
                else
                    l = r;
                r++;
            }
            return maxProfit;
        }
    }
}
