using LeetCode.Hard._0076._Minimum_Window_Substring.src;

namespace LeetCode.Hard.Tests._0076._Minimum_Window_Substring;

public class SolutionTests
{
    [Theory]
    [InlineData("ADOBECODEBANC", "ABC", "BANC")]
    [InlineData("ab", "b", "b")]
    [InlineData("bba", "ab", "ba")]
    public void BasicTests(string s, string t, string expected)
    {
        var solution = new Solution();
        var actual = solution.MinWindow(s, t);
        Assert.Equal(expected, actual);
    }
}