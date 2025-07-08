namespace LeetCode.Medium._0033._Search_in_Rotated_Sorted_Array.src;

public class Solution
{
    public int Search(int[] nums, int target)
    {
        int result = -1, l = 0, r = nums.Length - 1;
        while (l <= r)
        {
            var mid = (l + r) / 2;
            if (target == nums[mid]) return mid;
            if (nums[l] <= nums[mid])
            {
                if (target >= nums[l] && target < nums[mid])
                {
                    r = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }    
            }
            else
            {
                if (target > nums[mid] && target <= nums[r])
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }
        }
        return result;
    }
}
