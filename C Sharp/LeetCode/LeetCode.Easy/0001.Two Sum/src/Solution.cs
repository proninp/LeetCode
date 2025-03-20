namespace LeetCode.Easy._0001.Two_Sum.src;

public sealed class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            var seek = target - nums[i];
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] == seek)
                    return [i, j];
            }
        }
        return [-1, -1];
    }
}