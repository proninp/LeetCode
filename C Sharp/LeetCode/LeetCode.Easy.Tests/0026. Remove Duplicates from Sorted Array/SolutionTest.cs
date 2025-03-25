using LeetCode.Easy._0026._Remove_Duplicates_from_Sorted_Array;

namespace LeetCode.Easy.Tests._0026._Remove_Duplicates_from_Sorted_Array;

public class SolutionTest
{
    [Theory]
    [InlineData(new[] { 1, 1, 2 }, 2, new int[] { 1, 2 })]
    public void BasicTests(int[] actual, int length, int[] expected)
    {
        var actial = Solution.RemoveDuplicates(actual);
        Assert.Equal(actual.Take(length).ToArray(), expected);
    }
}
