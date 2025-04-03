namespace LeetCode.Easy._136._Single_Number.src;

public sealed class Solution
{
    public int SingleNumber(int[] nums)
    {
        var result = 0;
        foreach (var item in nums)
        {
            result ^= item;
        }
        return result;
    }
}

