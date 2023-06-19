using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
public class Program {
    static public int Main(string[] args) {
        return 0;
    }
    public List<List<string>> GroupAnagrams(string[] strs) {
        static string SortCharAlphabetically(string s) {
            char[] cBuffer = s.ToArray();
            Array.Sort(cBuffer);
            return new string(cBuffer);
        }
        List<List<string>> ret = new List<List<string>>();
        List<string> listBuffer = new List<string>();
        if (strs.Length == 1) {
            listBuffer.Add(new String(strs[0]));
            ret.Add(listBuffer);
            return ret;
        } else if (strs.Length == 0) {
            return ret;
        }

        Array.Sort(strs);

        /* 
         * data structure of my shit should be something like this:
         * we've got 2 main data sets: the original strings, and the list of
         * string character sorted for referencing it to make later an array
         * the original strings should have a value assigned to them to connect
         * them to the iterator but since HashSet is unordered I need to store
         * the original string to find later to iterate through later to find
         * a group
         */

        //dictStrs = <ogStr, sortedStr
        Dictionary<string, string> dictStrs = new Dictionary<string, string>();
        HashSet<string> setSortedStrs = new HashSet<string>();
        string sTmp;
        int id = 0;
        foreach(string s in strs) {
            id++;
            SortCharAlphabetically(s);
            if (setSortedStrs.TryGetValue(strs[id],out sTmp)) {
                dictStrs.Add(strs[id], sTmp);
                continue;
            } else {
                setSortedStrs.Add(s);
                dictStrs.Add(strs[id], sTmp);
            }
        }
        return ret;
    }
}