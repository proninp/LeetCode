using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace LeetCode.Easy
{
    /*
     * 1189. Maximum Number of Balloons
     * Given a string text, you want to use the characters of text to form as many instances of the word "balloon" as possible.
     * You can use each character in text at most once. Return the maximum number of instances that can be formed.
     */
    internal class _1189MaximumNumberOfBalloons
    {
        public static int MaxNumberOfBalloons(string text)
        {
            var balloonMap = new Dictionary<char, int> { { 'b', 0 }, { 'a', 0 }, { 'l', 0 }, { 'o', 0 }, { 'n', 0 } };
            var freqMap = new Dictionary<char, int> { { 'b', 1 }, { 'a', 1 }, { 'l', 2 }, { 'o', 2 }, { 'n', 1 } };
            char[] chars = text.ToCharArray();
            int len = chars.Length;
            for (int i = 0; i < len; i++)
                if (balloonMap.ContainsKey(chars[i]))
                    balloonMap[chars[i]]++;
            int min = len;
            foreach (var pair in balloonMap)
                min = Math.Min(min, pair.Value / freqMap[pair.Key]);
            return min;
        }
    }
}
