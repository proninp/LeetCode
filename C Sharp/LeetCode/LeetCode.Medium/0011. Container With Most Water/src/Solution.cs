namespace LeetCode.Medium._0011._Container_With_Most_Water.src;

public class Solution
{
    public int MaxArea(int[] height) {
        var maxArea = 0;
        var left = 0;
        var right = height.Length - 1;
        while (left < right)
        {
            maxArea = Math.Max(Math.Min(height[left], height[right]) * (right - left), maxArea);
            if (height[left] > height[right])
            {
                right--;
            }
            else
            {
                left++;
            }
        }
        return maxArea;
    }
}