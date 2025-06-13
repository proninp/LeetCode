namespace LeetCode.Hard._0076._Minimum_Window_Substring.src;

public class Solution
{
    public string MinWindow(string s, string t)
    {
        if (s.Length == t.Length && s.Equals(t))
            return t;
        
        var sourceMap = new Dictionary<char, int>(t.Length);
        foreach (var c in t)
            if (!sourceMap.TryAdd(c, 1))
                sourceMap[c]++;

        var minLen = int.MaxValue;
        var minLeft = -1;
        var minRight = -1;
        var need = sourceMap.Keys.Count;
        var have = 0;
        
        var left = 0;
        while (left < s.Length && !sourceMap.ContainsKey(s[left]))
            left++;

        if (left == s.Length) return string.Empty;

        var windowMap = new Dictionary<char, int>(t.Length);
        
        for (var right = left; right < s.Length; right++)
        {
            if (sourceMap.ContainsKey(s[right]))
            {
                if (!windowMap.TryAdd(s[right], 1))
                    windowMap[s[right]]++;
                if (windowMap[s[right]] == sourceMap[s[right]])
                    have++;
            }

            while (have >= need)
            {
                if (right - left + 1 < minLen)
                {
                    minLen = right - left + 1;
                    minLeft = left;
                    minRight = right;
                }
            
                windowMap[s[left]]--;
                if (windowMap[s[left]] < sourceMap[s[left]])
                    have--;
                do
                {
                    left++;
                } while (left < right && !sourceMap.ContainsKey(s[left]));
            }
        }

        return minLen == int.MaxValue ? string.Empty : s.Substring(minLeft, minRight - minLeft + 1);
    }
}