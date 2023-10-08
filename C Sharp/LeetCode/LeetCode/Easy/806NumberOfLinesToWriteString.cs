using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 806. Number of Lines To Write String
     * You are given a string s of lowercase English letters and an array widths denoting how many pixels wide each lowercase English letter is.
     * Specifically, widths[0] is the width of 'a', widths[1] is the width of 'b', and so on.
     * You are trying to write s across several lines, where each line is no longer than 100 pixels.
     * Starting at the beginning of s, write as many letters on the first line such that the total width does not exceed 100 pixels.
     * Then, from where you stopped in s, continue writing as many letters as you can on the second line.
     * Continue this process until you have written all of s.
     */
    internal class _806NumberOfLinesToWriteString
    {
        public int[] NumberOfLines(int[] widths, string s)
        {
            int lines = 1;
            int pixelsInLine = 0;
            foreach(var c in s)
            {
                pixelsInLine += widths[c - 'a'];
                if (pixelsInLine > 100)
                {
                    pixelsInLine = widths[c - 'a'];
                    lines++;
                }
            }
            return new int[] {lines, pixelsInLine };
        }
    }
}
