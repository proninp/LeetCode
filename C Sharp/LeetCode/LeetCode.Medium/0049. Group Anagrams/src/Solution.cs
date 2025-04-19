namespace LeetCode.Medium._0049._Group_Anagrams.src;

public sealed class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var map = new Dictionary<string, IList<string>>();
        foreach(var str in strs)
        {
            var alphabet = new char[26];
            foreach (char c in str)
                alphabet[c - 'a']++;

            var key = new string(alphabet);
            if (!map.ContainsKey(key))
                map.Add(key, new List<string>());
            map[key].Add(str);
        }
        return new List<IList<string>>(map.Values);
    }
}