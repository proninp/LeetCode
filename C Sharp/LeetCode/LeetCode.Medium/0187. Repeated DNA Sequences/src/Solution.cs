namespace LeetCode.Medium._0187._Repeated_DNA_Sequences.src;

public class Solution
{
    public IList<string> FindRepeatedDnaSequences(string s) {
        var set = new HashSet<string>();
        var repeated = new HashSet<string>(s.Length / 10);

        for (var i = 0; i <= s.Length - 10; i++)
        {
            var key = s.Substring(i, 10);
            if (!set.Add(key))
                repeated.Add(key);
        }
        return new List<string>(repeated);
    }
}