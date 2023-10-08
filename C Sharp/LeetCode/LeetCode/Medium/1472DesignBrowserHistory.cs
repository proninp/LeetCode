using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    /*
     * 1472. Design Browser History
     * You have a browser of one tab where you start on the homepage and you can visit another url,
     * get back in the history number of steps or move forward in the history number of steps.
     * Implement the BrowserHistory class:
     * BrowserHistory(string homepage) Initializes the object with the homepage of the browser.
     * void visit(string url) Visits url from the current page. It clears up all the forward history.
     * string back(int steps) Move steps back in history. If you can only return x steps in the history and steps > x,
     * you will return only x steps. Return the current url after moving back in history at most steps.
     * string forward(int steps) Move steps forward in history.
     * If you can only forward x steps in the history and steps > x, you will forward only x steps.
     * Return the current url after forwarding in history at most steps.
     */
    public class _1472DesignBrowserHistory
    {

    }
    public class BrowserHistory
    {
        private Stack<string> _fwd = new Stack<string>();
        private Stack<string> _bwd = new Stack<string>();
        public BrowserHistory(string homepage)
        {
            _bwd.Push(homepage);
        }

        public void Visit(string url)
        {
            _fwd.Clear();
            _bwd.Push(url);
        }

        public string Back(int steps)
        {
            while(_bwd.Count > 1 && steps > 0)
            {
                _fwd.Push(_bwd.Pop());
                steps--;
            }
            return _bwd.Peek();
        }

        public string Forward(int steps)
        {
            while(_fwd.Count > 0 && steps > 0)
            {
                _bwd.Push(_fwd.Pop());
                steps--;
            }
            return _bwd.Peek();
        }
    }
}
