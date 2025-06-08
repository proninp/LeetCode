using LeetCode.Medium._0424._Longest_Repeating_Character_Replacement.src;

namespace LeetCode.Medium.Tests._0424._Longest_Repeating_Character_Replacement;

public class SolutionTest
{
    [Theory]
    [InlineData("KRSCDCSONAJNHLBMDQGIFCPEKPOHQIHLTDIQGEKLRLCQNBOHNDQGHJPNDQPERNFSSSRDEQLFPCCCARFMDLHADJADAGNNSBNCJQOF",
        4, 7)]
    public void BasicTests(string s, int k, int expected)
    {
        var solution = new Solution();
        var actual = solution.CharacterReplacement(s, k);
        Assert.Equal(actual, expected);
    }
}