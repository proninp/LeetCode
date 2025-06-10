namespace LeetCode.Medium._0567._Permutation_in_String.src;

public class Solution
{
    public bool CheckInclusion(string s1, string s2) {
        if (s2.Length < s1.Length)
            return false;
        
        var a1 = new int[26];
        var a2 = new int[26];
        var s1Len = s1.Length;

        for (var i = 0; i < s1Len; i++)
        {
            a1[s1[i] - 'a']++;
        }

        var l = 0;
        for (var r = 0; r < s2.Length; r++)
        {
            a2[s2[r] - 'a']++;
            if (r - l + 1 == s1Len)
            {
                if (AreEqual(a1, a2))
                    return true;
                a2[s2[l] - 'a']--;
                l++;
            }
        }
        return false;
    }
    
    private bool AreEqual(int[] a, int[] b)
    {
        for (int i = 0; i < 26; i++)
            if (a[i] != b[i])
                return false;
        return true;
    }
}