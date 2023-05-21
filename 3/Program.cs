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