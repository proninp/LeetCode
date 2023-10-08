namespace LeetCode.Easy
{
    internal class _1221SplitAStringInBalancedStrings
    {
        /*
         * 1221. Split a String in Balanced Strings
         * Balanced strings are those that have an equal quantity of 'L' and 'R' characters.
         * Given a balanced string s, split it into some number of substrings such that:
         * Each substring is balanced.
         * Return the maximum number of balanced strings you can obtain.
         */
        public int BalancedStringSplit(string s)
        {
            var output = 0;
            var balance = 0;
            foreach (var c in s)
            {
                if (c == 'R')
                    balance++;
                else if (c == 'L')
                    balance--;
                if (balance == 0)
                    output++;
            }
            return output;
        }
    }
}
