using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 2114. Maximum Number of Words Found in Sentences
     * 
     * A sentence is a list of words that are separated by a single space with no leading or trailing spaces.
     * You are given an array of strings sentences, where each sentences[i] represents a single sentence.
     * Return the maximum number of words that appear in a single sentence.
     */
    internal class _2114_maximum_number_of_words_found_in_sentences
    {
        public int MostWordsFound(string[] sentences)
        {
            int max = 0;
            int words = 1;
            char c;
            for (int i = 0; i < sentences.Length; i++)
            {
                words = 1;
                for (int j = 0; j < sentences[i].Length; j++)
                {
                    c = sentences[i][j];
                    if (c == ' ') words++;
                }
                if (max < words)
                    max = words;
            }
            return max;
        }
    }
}
