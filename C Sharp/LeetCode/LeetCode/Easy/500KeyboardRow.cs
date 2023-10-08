using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 500. Keyboard Row
     * Given an array of strings words, return the words that can be typed using letters of the alphabet on only one row of American keyboard like the image below.
     * In the American keyboard:
     * the first row consists of the characters "qwertyuiop",
     * the second row consists of the characters "asdfghjkl", and
     * the third row consists of the characters "zxcvbnm".
     */
    internal class _500KeyboardRow
    {
        public string[] FindWords(string[] words)
        {
            var list = new List<string>();
            var kb = new string[]
            {
                "qwertyuiop",
                "asdfghjkl",
                "zxcvbnm"
            };
            foreach(var word in words)
            {
                int i = kb.Length;
                bool isConsists = false;
                while((i-- > 0) && !isConsists)
                {
                    isConsists = true;
                    foreach (var c in word.ToLowerInvariant())
                    {
                        isConsists = kb[i].Contains(c);
                        if (!isConsists)
                            break;
                    }
                    if (isConsists)
                        list.Add(word);
                }
            }
            return list.ToArray();
        }
    }
}
