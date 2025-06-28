namespace LeetCode.Hard._0084._Largest_Rectangle_In_Histogram.src;

public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        var max = 0;
        var len = heights.Length;
        var stack = new Stack<int>();
        
        for (var i = 0; i <= len; i++)
        {
            while (stack.Count > 0 && (i == len || heights[i] < heights[stack.Peek()]))
            {
                var height = heights[stack.Pop()];
                var width = stack.Count == 0 ? i : i - stack.Peek() - 1;
                max = Math.Max(max, height * width);
            }
            stack.Push(i);
        }
        return max;
    }
}