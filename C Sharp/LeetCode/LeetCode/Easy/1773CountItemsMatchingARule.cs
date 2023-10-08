using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _1773CountItemsMatchingARule
    {
        /*
         * 1773. Count Items Matching a Rule
         * You are given an array items, where each items[i] = [typei, colori, namei] describes
         * the type, color, and name of the ith item. You are also given a rule
         * represented by two strings, ruleKey and ruleValue.
         * The ith item is said to match the rule if one of the following is true:
         * ruleKey == "type" and ruleValue == typei.
         * ruleKey == "color" and ruleValue == colori.
         * ruleKey == "name" and ruleValue == namei.
         * Return the number of items that match the given rule.
         */
        public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            int itemIndex;
            if (ruleKey.Equals("type"))
                itemIndex = 0;
            else if (ruleKey.Equals("color"))
                itemIndex = 1;
            else
                itemIndex = 2;
            int ans = 0;
            for (int i = 0; i < items.Count; i++)
                if (items[i][itemIndex].Equals(ruleValue))
                    ans++;
            return ans;
        }
    }
}
