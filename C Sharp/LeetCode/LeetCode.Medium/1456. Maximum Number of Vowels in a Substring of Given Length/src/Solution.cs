namespace LeetCode.Medium._1456._Maximum_Number_of_Vowels_in_a_Substring_of_Given_Length.src;

public class Solution
{
    public int MaxVowels(string s, int k)
    {
        var vowels = new int[128];
        foreach (var c in "aeiou")
            vowels[c] = 1;

        var max = 0;
        for (var i = 0; i < k; i++)
            max += vowels[s[i]];
        var current = max;
        for (var i = k; i < s.Length; i++)
        {
            current += vowels[s[i]];
            current -= vowels[s[i - k]];
            max = Math.Max(current, max);
        }
        return max;
    }
}