namespace LeetCode.Easy._0283._Move_Zeroes.src;

public sealed class Solution
{
    public void MoveZeroes(int[] nums)
    {
        for (int l = 0, r = 0; r < nums.Length; r++)
        {
            if (nums[r] != 0)
            {
                (nums[l], nums[r]) = (nums[r], nums[l]);
                l++;
            }
        }
    }
}