using LeetCode.Easy._0088._Merge_Sorted_Array.src;

namespace LeetCode.Easy.Tests._0088._Merge_Sorted_Array;

public class SolutionTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3, new int[] { 1, 2, 2, 3, 5, 6 })]
    [InlineData(new int[] { 1 }, 1, new int[] { }, 0, new int[] { 1 })]
    [InlineData(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 1, 2, 3 }, 3, new int[] { 1, 1, 2, 2, 3, 3 })]
    [InlineData(new int[] { 0, 0, 0, 0, 0, 0 }, 0, new int[] { 1, 2, 3, 4, 5, 6 }, 6, new int[] { 1, 2, 3, 4, 5, 6 })]
    public void BasicTests(int[] nums1, int m, int[] nums2, int n, int[] expected)
    {
        // Arrange

        // Act
        Solution.Merge(nums1, m, nums2, n);

        // Assert
        Assert.Equal(expected, nums1);
    }
}