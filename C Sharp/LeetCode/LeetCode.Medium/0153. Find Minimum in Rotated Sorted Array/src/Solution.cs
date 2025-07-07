namespace LeetCode.Medium._0153._Find_Minimum_in_Rotated_Sorted_Array.src;

public class Solution
{
    public int FindMin(int[] nums) {
        var min = nums[0];
        int l = 0, r = nums.Length - 1;
        while (l <= r)
        {
            if (nums[l] < nums[r])
            {
                min = Math.Min(min, nums[l]);
                break;
            }

            var mid = (r + l) / 2;
            min = Math.Min(min, nums[mid]);
            if (nums[l] <= nums[mid])
            {
                l = mid + 1;
            }
            else
            {
                r = mid - 1;
            }
        }
        return min;
    }
}