using LeetCode.Easy._0027._Remove_Element.src;

namespace LeetCode.Easy.Tests._0027._Remove_Element;

public class SolutionTest
{
    [Theory]
    [InlineData(new int[] { 3, 2, 2, 3 }, 3, new int[] { 2, 2 })]
    [InlineData(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, new int[] { 0, 1, 3, 0, 4 })]
    [InlineData(new int[] { 1, 2 }, 3, new int[] { 1, 2 })]
    [InlineData(new int[] { 2 }, 3, new int[] { 2 })]
    public void BasicTests(int[] actual, int val, int[] expected)
    {
        // Arrange

        // Act
        var result = Solution.RemoveElement(actual, val);

        // Assert
        Assert.Equal(expected, actual.Take(result).ToArray());
    }
}

