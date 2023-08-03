using System.Text;

namespace LeetCode.Easy
{
    /*
     * 1108. Defanging an IP Address
     * Given a valid (IPv4) IP address, return a defanged version of that IP address.
     * A defanged IP address replaces every period "." with "[.]".
     */
    public class _1108DefangingAnIPAddress
    {
        public string DefangIPaddr(string address)
        {
            var sb = new StringBuilder(address.Length);
            foreach (var c in address)
            {
                if (c.Equals('.'))
                    sb.Append("[.]");
                else
                    sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
