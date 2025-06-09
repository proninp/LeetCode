namespace LeetCode.Medium._1004._Max_Consecutive_Ones_III.src;

public class Solution
{
    public int LongestOnes(int[] nums, int k) {
        int left = 0, result = 0;
        var zeroes = 0;
        for (var right = 0; right < nums.Length; right++)
        {
            if (nums[right] == 0)
                zeroes++;

            while (zeroes > k)
            {
                if (nums[left] == 0)
                    zeroes--;
                left++;
            }
            result = Math.Max(result, right - left + 1);
        }
        return result;
    }
}