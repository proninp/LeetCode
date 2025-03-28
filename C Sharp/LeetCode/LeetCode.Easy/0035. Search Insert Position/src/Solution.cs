namespace LeetCode.Easy._0035._Search_Insert_Position.src;

public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        if (nums[0] > target)
            return 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] >= target)
                return i;
        }
        return nums.Length;
    }
}