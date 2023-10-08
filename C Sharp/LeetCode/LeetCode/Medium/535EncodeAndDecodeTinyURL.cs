using System.Collections.Generic;

namespace LeetCode.Medium
{
    /*
     * 535. Encode and Decode TinyURL
     * TinyURL is a URL shortening service where you enter a URL such as https://leetcode.com/problems/design-tinyurl
     * and it returns a short URL such as http://tinyurl.com/4e9iAk. Design a class to encode a URL and decode a tiny URL.
     * There is no restriction on how your encode/decode algorithm should work.
     * You just need to ensure that a URL can be encoded to a tiny URL and the tiny URL can be decoded to the original URL.
     * Implement the Solution class:
     * Solution() Initializes the object of the system.
     * String encode(String longUrl) Returns a tiny URL for the given longUrl.
     * String decode(String shortUrl) Returns the original long URL for the given shortUrl.
     * It is guaranteed that the given shortUrl was encoded by the same object.
     */
    public class _535EncodeAndDecodeTinyURL
    {

    }
    public class Codec
    {
        private int _id = 0;
        private Dictionary<string, string> _encoded = new Dictionary<string, string>();
        private Dictionary<string, string> _decoded = new Dictionary<string, string>();
        private string _tiny = "http://tinyurl.com/";

        public string Encode(string longUrl)
        {
            if (!_encoded.ContainsKey(longUrl))
            {
                _id++;
                var id = string.Concat(_tiny, _id.ToString());
                _encoded.Add(longUrl, id);
                _decoded.Add(id, longUrl);
            }
            return _encoded[longUrl];
        }

        // Decodes a shortened URL to its original URL.
        public string Decode(string shortUrl)
        {
            if (_decoded.ContainsKey(shortUrl))
                return _decoded[shortUrl];
            return null;
        }
    }
}
