using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium._0271._Encode_and_Decode_Strings
{
    public class Solution
    {
        public string Encode(IList<string> strs)
        {
            return string.Join("", strs.Select(s => $"{s.Length}#{s}"));
        }

        public List<string> Decode(string s)
        {
            var encoded = new List<string>();
            var lenStr = new StringBuilder();
            var i = 0;
            while (i < s.Length)
            {
                while (s[i] != '#')
                {
                    lenStr.Append(s[i]);
                    i++;
                }
                // Нахдимся на #
                i++;
                // Встли на первый символ для копирования
                var len = int.Parse(lenStr.ToString());
                encoded.Add(s.Substring(i, len));
                lenStr.Clear();
                i += len;
            }
            return encoded;
        }
    }
}