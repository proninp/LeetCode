namespace LeetCode.Easy
{
    /*
     * 1859. Sorting the Sentence
     */
    public class _1859SortingTheSentence
    {
        public string SortSentence(string s)
        {
            var array = s.Split(' ');
            var res = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                var idx = array[i][array[i].Length - 1] + '0' - 96 - 1;
                res[idx] = array[i].Substring(0, array[i].Length - 1);
            }
            return string.Join(' ', res);
        }
    }
}
