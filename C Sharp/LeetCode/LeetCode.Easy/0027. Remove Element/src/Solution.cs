namespace LeetCode.Easy._0027._Remove_Element.src;

public class Solution
{
    public static int RemoveElement(int[] nums, int val)
    {
        int l = 0;
        for (int r = 0; r < nums.Length; r++)
        {
            if (nums[r] != val)
            {
                nums[l] = nums[r];
                l++;
            }
        }
        return l;
    }
}
