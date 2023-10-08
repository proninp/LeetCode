using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 804. Unique Morse Code Words
     * International Morse Code defines a standard encoding where each letter is mapped to a series of dots and dashes, as follows:
     * 'a' maps to ".-",
     * 'b' maps to "-...",
     * 'c' maps to "-.-.", and so on.
     * For convenience, the full table for the 26 letters of the English alphabet is given below:
     * [".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."]
     * Given an array of strings words where each word can be written as a concatenation of the Morse code of each letter.
     * For example, "cab" can be written as "-.-..--...", which is the concatenation of "-.-.", ".-", and "-...".
     * We will call such a concatenation the transformation of a word.
     * Return the number of different transformations among all words we have.
     */
    internal class _804UniqueMorseCodeWords
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            var map = new Dictionary<char, string>()
            {
                { 'a', ".-" }, { 'b', "-..." },
                { 'c', "-.-." }, { 'd', "-.." },
                { 'e', "." }, { 'f', "..-." },
                { 'g', "--." }, { 'h', "...." },
                { 'i', ".." }, { 'j', ".---" },
                { 'k', "-.-" }, { 'l', ".-.." },
                { 'm', "--" }, { 'n', "-." },
                { 'o', "---" }, { 'p', ".--." },
                { 'q', "--.-" }, { 'r', ".-." },
                { 's', "..." }, { 't', "-" },
                { 'u', "..-" }, { 'v', "...-" },
                { 'w', ".--" }, { 'x', "-..-" },
                { 'y', "-.--" }, { 'z', "--.." }
            };
            HashSet<string> uniqueMorse = new HashSet<string>();
            var sb = new StringBuilder();
            int wLen = 0;
            foreach (var w in words)
            {
                wLen = w.Length;
                for (int i = 0; i < wLen; i++)
                    sb.Append(map[w[i]]);
                uniqueMorse.Add(sb.ToString());
                sb.Clear();
            }
            return uniqueMorse.Count;
        }
    }
}
