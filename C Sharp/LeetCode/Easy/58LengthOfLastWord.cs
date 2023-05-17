using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 58. Length of Last Word
     * Given a string s consisting of words and spaces, return the length of the last word in the string.
     * A word is a maximal substring consisting of non-space characters only.
     */
    internal class _58LengthOfLastWord
    {
        public static int LengthOfLastWord(string s)
        {
            int len = 0;
            for (int i = s.Length - 1; i >= 0 ; i--)
            {
                if (s[i] == ' ')
                {
                    if (len != 0)
                        return len;
                }
                else
                    len++;
            }
            return len;
        }
    }
}
