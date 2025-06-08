namespace LeetCode.Medium._0424._Longest_Repeating_Character_Replacement.src;

public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        var array = new int[26];
        int left = 0, result = 0, maxCount = 0;

        for (var right = 0; right < s.Length; right++)
        {
            array[s[right] - 'A']++;
            maxCount = Math.Max(maxCount, array[s[right] - 'A']);
            while (right - left + 1 - maxCount > k)
            {
                array[s[left] - 'A']--;
                left++;
            }
            result = Math.Max(right - left + 1, result);
        }
        return result;
    }
    
    public int CharacterReplacement2(string s, int k) {
        var array = new int[26];
        int left = 0, result = 0;

        for (var right = 0; right < s.Length; right++)
        {
            array[s[right] - 'A']++;
            
            while (right - left + 1 - array.Max() > k)
            {
                array[s[left] - 'A']--;
                left++;
            }            
            result = Math.Max(right - left + 1, result);
        }
            
        return result;
    }
}