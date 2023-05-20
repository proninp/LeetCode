using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 929. Unique Email Addresses
     * Every valid email consists of a local name and a domain name, separated by the '@' sign.
     * Besides lowercase letters, the email may contain one or more '.' or '+'.
     * For example, in "alice@leetcode.com", "alice" is the local name, and "leetcode.com" is the domain name.
     * If you add periods '.' between some characters in the local name part of an email address,
     * mail sent there will be forwarded to the same address without dots in the local name. Note that this rule does not apply to domain names.
     * For example, "alice.z@leetcode.com" and "alicez@leetcode.com" forward to the same email address.
     * If you add a plus '+' in the local name, everything after the first plus sign will be ignored.
     * This allows certain emails to be filtered. Note that this rule does not apply to domain names.
     * For example, "m.y+name@email.com" will be forwarded to "my@email.com".
     * It is possible to use both of these rules at the same time.
     * Given an array of strings emails where we send one email to each emails[i],
     * return the number of different addresses that actually receive mails.
     */
    internal class _929_unique_email_addresses
    {
        public static int NumUniqueEmails(string[] emails)
        {
            char separator = '@';
            char plus = '+';
            StringBuilder uniqEmail;
            HashSet<string> uniqueEmails = new HashSet<string>(emails.Length);
            foreach(var email in emails)
            {
                string[] parts = email.Split(separator);
                int plusIndex = parts[0].IndexOf(plus);
                if (plusIndex > -1)
                    parts[0] = parts[0].Substring(0, plusIndex);
                parts[0] = parts[0].Replace(".", "");
                uniqEmail = new StringBuilder();
                uniqEmail.Append(parts[0]).Append(separator).Append(parts[1]);
                uniqueEmails.Add(uniqEmail.ToString());
            }
            return uniqueEmails.Count;
        }
    }
}
