namespace LeetCode.Easy._0242._Valid_Anagram.src;

public sealed class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;
        var alphabet = new short[26];
        for (int i = 0; i < s.Length; i++)
        {
            alphabet[s[i] - 'a']++;
            alphabet[t[i] - 'a']--;
        }
        return alphabet.All(x => x == 0);
    }
}