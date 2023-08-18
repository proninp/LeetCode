using System.Text;

namespace LeetCode.Easy
{
    /*
     * 1678. Goal Parser Interpretation
     * You own a Goal Parser that can interpret a string command.
     * The command consists of an alphabet of "G", "()" and/or "(al)" in some order.
     * The Goal Parser will interpret "G" as the string "G", "()" as the string "o", and "(al)" as the string "al".
     * The interpreted strings are then concatenated in the original order.
     * Given the string command, return the Goal Parser's interpretation of command.
     */
    internal class _1678GoalParserInterpretation
    {
        public string Interpret(string command)
        {
            var sb = new StringBuilder(command.Length);
            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] == '(')
                {
                    if (command[i + 1] == ')')
                        sb.Append('o');
                    else if (command[i + 1] == 'a')
                        sb.Append("al");
                }
                else if (command[i] == 'G')
                    sb.Append('G');
            }
            return sb.ToString();
        }
    }
}
