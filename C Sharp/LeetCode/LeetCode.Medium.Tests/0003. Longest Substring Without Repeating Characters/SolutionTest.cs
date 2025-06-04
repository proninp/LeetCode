using LeetCode.Medium._0003._Longest_Substring_Without_Repeating_Characters.src;

namespace LeetCode.Medium.Tests._0003._Longest_Substring_Without_Repeating_Characters;

public class SolutionTest
{
    [Theory]
    [InlineData("abba", 2)]
    public void TestExample1(string s, int expected)
    {
        var solution = new Solution();
        var result = solution.LengthOfLongestSubstring(s);

        Assert.Equal(expected, result);
    }
}