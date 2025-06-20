using System.Linq.Expressions;

namespace LeetCode.Medium._0739._Daily_Temperatures.src;

public class Solution
{
    public int[] DailyTemperatures(int[] temperatures) {
        var results = new int[temperatures.Length];
        var stack = new Stack<int>();
        for (var i = 0; i < temperatures.Length; i++)
        {
            while (stack.Count > 0 && temperatures[stack.Peek()] < temperatures[i])
            {
                var idx = stack.Pop();
                results[idx] = i - idx;
            }
            stack.Push(i);
        }
        return results;
    }
}