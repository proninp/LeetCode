using LeetCode.Easy._0121._Best_Time_to_Buy_and_Sell_Stock.src;

namespace LeetCode.Easy.Tests._0121._Best_Time_to_Buy_and_Sell_Stock;

public class SolutionTest
{
    [Theory]
    [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
    [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
    [InlineData(new int[] { 1 }, 0)]
    public void BasicTests(int[] prices, int expected)
    {
        var actual = Solution.MaxProfit(prices);

        Assert.Equal(expected, actual);
    }
}

