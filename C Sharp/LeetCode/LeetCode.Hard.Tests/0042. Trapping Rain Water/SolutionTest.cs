using LeetCode.Hard._0042._Trapping_Rain_Water.src;

namespace LeetCode.Hard.Tests._0042._Trapping_Rain_Water;

public class SolutionTest
{
    [Theory]
    [InlineData(new int[] { 0,1,0,2,1,0,1,3,2,1,2,1 }, 6)]
    [InlineData(new int[] { 4,2,0,3,2,5 }, 9)]
    public void BasicTests(int[] array, int expected)
    {
        var s = new Solution();
        var actual = s.Trap(array);
        Assert.Equal(expected, actual);
    }
}