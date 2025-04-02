namespace LeetCode.Easy._0121._Best_Time_to_Buy_and_Sell_Stock.src;

public class Solution
{
    public static int MaxProfit(int[] prices)
    {
        var lowerPrice = prices[0];
        var maxProfit = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            var profit = prices[i] - lowerPrice;
            if (profit > maxProfit)
                maxProfit = profit;
            if (prices[i] < lowerPrice)
                lowerPrice = prices[i];
        }
        return maxProfit;
    }
}