namespace LeetCode.Easy._0643._Maximum_Average_Subarray_I.src;

public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        var maxAvg = Double.MinValue;
        var sum = 0.0;

        var left = 0;

        for (var right = 0; right < nums.Length; right++)
        {
            sum += nums[right];
            if (right - left + 1 == k)
            {
                var avg = sum / (right - left + 1);
                if (avg > maxAvg)
                    maxAvg = avg;
                sum -= nums[left];
                left++;
            }
        }
        return maxAvg;
    }
}