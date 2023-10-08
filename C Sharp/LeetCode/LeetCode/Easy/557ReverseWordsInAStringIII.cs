using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 557. Reverse Words in a String III
     * 
     * Given a string s, reverse the order of characters in each word within a
     * sentence while still preserving whitespace and initial word order.
     */
    public class _557ReverseWordsInAStringIII
    {
        public string ReverseWords(string s)
        {
            var words = s.Split(new char[] { ' ' });
            var reversed = new StringBuilder(s.Length);
            StringBuilder word;
            for (int i = 0; i < words.Length; i++)
            {
                word = new StringBuilder(words[i]);
                int l = 0, r = word.Length - 1;
                while (l < r)
                {
                    (word[l], word[r]) = (word[r], word[l]);
                    l++;
                    r--;
                }
                if (reversed.Length > 0)
                    reversed.Append(' ');
                reversed.Append(word);
            }
            return reversed.ToString();
        }
    }
}
