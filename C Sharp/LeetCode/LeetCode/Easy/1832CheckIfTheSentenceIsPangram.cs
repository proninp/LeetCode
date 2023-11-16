namespace LeetCode.Easy
{
    /*
     * 1832. Check if the Sentence Is Pangram
     * A pangram is a sentence where every letter of the English alphabet appears at least once.
     * Given a string sentence containing only lowercase English letters, return true if sentence is a pangram, or false otherwise.
     */
    public class _1832CheckIfTheSentenceIsPangram
    {
        public static bool CheckIfPangram(string sentence)
        {
            if (sentence.Length < 26)
                return false;

            HashSet<char> alphabetSet = new HashSet<char>();
            foreach (char c in sentence)
                alphabetSet.Add(c);
            return alphabetSet.Count == 26;
        }
    }
}
