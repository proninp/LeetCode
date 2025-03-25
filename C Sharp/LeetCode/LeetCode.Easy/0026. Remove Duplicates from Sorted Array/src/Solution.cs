namespace LeetCode.Easy._0026._Remove_Duplicates_from_Sorted_Array;

public class Solution
{
    public static int RemoveDuplicates(int[] nums)
    {
        int l = 0;
        for (int r = 1; r < nums.Length; r++)
        {
            if (nums[l] != nums[r])
            {
                nums[l + 1] = nums[r];
                l++;
            }
        }
        return l + 1;
    }
}