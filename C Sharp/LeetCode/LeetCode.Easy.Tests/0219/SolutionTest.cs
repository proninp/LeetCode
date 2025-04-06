namespace LeetCode.Easy.Tests._0219;

using LeetCode.Easy._0219._Contains_Duplicate_II.src;

public class SolutionTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 1 }, 3, true)]
    [InlineData(new int[] { 1, 0, 1, 1 }, 1, true)]
    [InlineData(new int[] { 1, 2, 3, 1, 2, 3 }, 2, false)]
    public void BasicTests(int[] nums, int k, bool expected)
    {
        var actual = Solution.ContainsNearbyDuplicate(nums, k);
        Assert.Equal(expected, actual);
    }
}

