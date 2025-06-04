using LeetCode.Medium._0015._3Sum.src;

namespace LeetCode.Medium.Tests._0015._3Sum;

public class SolutionTest
{
    [Fact]
    public void TestExample1()
    {
        var solution = new Solution();
        var result = solution.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });

        var expected = new List<IList<int>>
        {
            new List<int> { -1, -1, 2 },
            new List<int> { -1, 0, 1 }
        };

        Assert.Equivalent(expected, result);
    }

    [Fact]
    public void TestExample2()
    {
        var solution = new Solution();
        var result = solution.ThreeSum(new int[] { -2, 0, 1, 1, });

        var expected = new List<IList<int>>
        {
            new List<int> { -2, 1, 1 }
        };

        Assert.Equivalent(expected, result);
    }
}