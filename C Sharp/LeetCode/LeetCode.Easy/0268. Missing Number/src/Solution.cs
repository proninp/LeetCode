namespace LeetCode.Easy._0268._Missing_Number.src;

public sealed class Solution
{
    public int MissingNumber(int[] nums)
    {
        var n = nums.Length;
        var expecedSum = n * (n + 1) / 2;
        return expecedSum - nums.Sum();
    }
}