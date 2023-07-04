using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 1002. Find Common Characters
     * Given a string array words, return an array of all characters that show up in all strings within the words (including duplicates).
     * You may return the answer in any order.
     */
    internal class _1002FindCommonCharacters
    {
        public IList<string> CommonChars(string[] words)
        {
            var alphabet = new int[26];
            foreach(var c in words[0])
                alphabet[c - 'a'] += 1;

            for (int i = 1; i < words.Length; i++)
            {
                var abc = new int[26];
                foreach (var c in words[i])
                    abc[c - 'a'] += 1;
                for (int j = 0; j < abc.Length; j++)
                    alphabet[j] = Math.Min(alphabet[j], abc[j]);
            }
            var list = new List<string>();
            for (int i = 0; i < alphabet.Length; i++)
            {
                var ch = (char)(i + 'a');
                while (alphabet[i]-- != 0)
                    list.Add(((char)(i + 'a')).ToString());
            }
            return list;
        }
    }
}
