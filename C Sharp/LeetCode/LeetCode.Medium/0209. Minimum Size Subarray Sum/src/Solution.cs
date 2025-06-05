namespace LeetCode.Medium._0209._Minimum_Size_Subarray_Sum.src;

public class Solution
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        var minimumLength = int.MaxValue;
        var sum = 0;
        var l = 0;
        
        for (int r = 0; r < nums.Length; r++)
        {
            sum += nums[r];
            while (sum >= target)
            {
                if (r - l + 1 < minimumLength)
                    minimumLength = r - l + 1;
                sum -= nums[l];
                l++;
            }
        }
        return minimumLength == int.MaxValue ?  0 : minimumLength;
    }
}