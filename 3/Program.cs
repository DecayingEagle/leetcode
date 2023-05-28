/* 3. Longest Substring Without Repeating Characters
 *
 * Given a string s, find the length of the longest substring without repeating characters.
 * 
 * Example 1:
 * Input: s = "abcabcbb"
 * Output: 3
 * Explanation: The answer is "abc", with the length of 3.
 *
 * Constraints:
 * 0 <= s.length <= 5 * 10^4
 * s consists of English letters, digits, symbols and spaces.
 */

using System;
public class Program {
	static public void Main(string[] args) {
		String s1 = "abcabcbb";
		String s2 = "bbbbb";
		String s3 = "pwwkew";
        System.Console.WriteLine(LengthOfLongestSubstring(s1));
        System.Console.WriteLine(LengthOfLongestSubstring(s2));
        System.Console.WriteLine(LengthOfLongestSubstring(s3));
	}
	static public int LengthOfLongestSubstring(string s) {
        char[] sArr = s.ToCharArray(0, s.Length);
        String lastChrs = "";
        int longest = -1;
        for (int i = 0; i < sArr.Length; i++)
        { 
            if(lastChrs.EndsWith(sArr[i])) {
                char[] buffer = lastChrs.ToCharArray;
                //!bro fix later
                longest = lastChrs.Length;
                lastChrs = sArr[i].ToString();
            } else {
                lastChrs = String.Concat(lastChrs, sArr[i].ToString());
            }

            System.Console.WriteLine("lstChrs: " + lastChrs);
            System.Console.WriteLine("sArr[i]: " + sArr[i].ToString());
        }
        return longest;
    }
    
}
