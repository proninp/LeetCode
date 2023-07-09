using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 748. Shortest Completing Word
     * Given a string licensePlate and an array of strings words, find the shortest completing word in words.
     * A completing word is a word that contains all the letters in licensePlate.
     * Ignore numbers and spaces in licensePlate, and treat letters as case insensitive.
     * If a letter appears more than once in licensePlate, then it must appear in the word the same number of times or more.
     * For example, if licensePlate = "aBc 12c", then it contains letters 'a', 'b' (ignoring case), and 'c' twice.
     * Possible completing words are "abccdef", "caaacab", and "cbca".
     * Return the shortest completing word in words. It is guaranteed an answer exists.
     * If there are multiple shortest completing words, return the first one that occurs in words.
     */
    internal class _748ShortestCompletingWord
    {
        public string ShortestCompletingWord(string licensePlate, string[] words)
        {
            var map = new int[26];
            string minWord = "";
            int minLen = int.MaxValue;
            foreach(var c in licensePlate)
            {
                if (char.IsLetter(c))
                    map[char.ToLower(c) - 'a']++;
            }
            bool isComplete;
            int[] wMap;
            foreach (var word in words)
            {
                wMap = new int[26];
                foreach (char c in word)
                    wMap[c - 'a']++;
                isComplete = true;
                for (int i = 0; i < 26; i++)
                {
                    if (map[i] > wMap[i])
                    {
                        isComplete = false;
                        break;
                    }
                }
                if (isComplete && word.Length < minLen)
                {
                    minLen = word.Length;
                    minWord = word;
                }    
            }
            return minWord;
        }
    }
}
