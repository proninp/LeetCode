namespace LeetCode.Medium._0347._Top_K_Frequent_Elements.src;

public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var map = new Dictionary<int, int>();
        
        foreach (var key in nums)
        {
            if (!map.TryAdd(key, 1))
                map[key]++;
        }
        
        return map
            .OrderByDescending(kvp => kvp.Value)
            .Take(k)
            .Select(kvp => kvp.Key)
            .ToArray();
    }
}