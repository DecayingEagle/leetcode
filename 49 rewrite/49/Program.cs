/**
 *  49. Group Anagrams
 *
 * Given an array of strings strs, group the anagrams together. You can return 
 * the answer in any order.
 * An Anagram is a word or phrase formed by rearranging the letters of a 
 * different word or phrase,
 * typically using all the original letters exactly once.
 *
 * Example 1:
 * Input: strs = ["eat","tea","tan","ate","nat","bat"]
 * Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
 *
 * Constraints:
 * 1 <= strs.length <= 10^4
 * 0 <= strs[i].length <= 100
 * strs[i] consists of lowercase English letters.
 */

namespace _49
{
    public class Program
    {
        static public int Main()
        {
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
            IList<IList<string>> ret = GroupAnagrams(strs);

            Console.WriteLine(ret.ToString());
            return 0;
        }
        static public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            static string SortCharAlphabetically(string s)
            {
                char[] cBuffer = s.ToArray();
                Array.Sort(cBuffer);
                return new string(cBuffer);
            }
            IList<IList<string>> ret = new List<IList<string>>();
            IList<string> listBuffer = new List<string>();
            if (strs.Length == 1)
            {
                listBuffer.Add(strs[0]);
                ret.Add(listBuffer);
                return ret;
            }
            else if (strs.Length == 0)
            {
                return ret;
            }

            Array.Sort(strs);

            /** 
             * data structure of my shit should be something like this:
             * we've got 2 main data sets: the original strings, and the list of
             * string character sorted for referencing it to make later an array
             * the original strings should have a value assigned to them to connect
             * them to the iterator but since HashSet is unordered I need to store
             * the original string to find later to iterate through later to find
             * a group
             */

            // * dictStrs = <ogStr, sortedStr>

            Dictionary<string, string> dictStrs = new();
            IList<string> listSortedStrs = new List<string>();
            int id = 0;
            string sortedStr, s_tmp;
            foreach (string s in strs)
            {
                sortedStr = SortCharAlphabetically(s);
                if (!listSortedStrs.Contains(sortedStr))
                {
                    listSortedStrs.Add(sortedStr);
                }
                dictStrs.Add(id.ToString()+strs[id], sortedStr);
                id++;
            }

            foreach (string sorted in listSortedStrs)
            {
                listBuffer = new List<string>();
                foreach (var pair in dictStrs)
                {
                    if (pair.Value.EndsWith(sorted))
                    {
                        listBuffer.Add(pair.Key);
                    }
                }
                ret.Add(listBuffer);
            }
            return ret;
        }
    }
}