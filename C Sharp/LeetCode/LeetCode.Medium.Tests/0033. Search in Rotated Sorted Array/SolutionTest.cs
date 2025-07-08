using LeetCode.Medium._0033._Search_in_Rotated_Sorted_Array.src;

namespace LeetCode.Medium.Tests._0033._Search_in_Rotated_Sorted_Array;

public class SolutionTest
{
    [Theory]
    [InlineData(new int[] { 3, 1 }, 1, 1)]
    [InlineData(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4)]
    public void TestExample1(int[] nums, int target, int expected)
    {
        var solution = new Solution();
        var result = solution.Search(nums, target);

        Assert.Equivalent(expected, result);
    }
}
