/* 242. Valid Anagram
 *
 * Given two strings s and t, return true if t is an anagram of s, and false otherwise.
 * An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
 *
 * Example 1:
 * Input: s = "anagram", t = "nagaram"
 * Output: true
 *
 * Constraints:
 * 1 <= s.length, t.length <= 5 * 10^4
 * s and t consist of lowercase English letters.
 */ 

#include <iostream>
#include <algorithm>

class Solution242 {
public:

    bool isAnagram(std::string s, std::string t) {
        std::sort(s.begin(), s.end());
        std::sort(t.begin(), t.end());
        return s==t;
    }
};

int main() {
	std::string input1[] = {"anagram", "nagaram"};
	std::string input2[] = {"car", "rat"};
	Solution242 s;
	std::cout << s.isAnagram(input1[0], input1[1]) << ": this should be 1" << std::endl;
	std::cout << s.isAnagram(input2[0], input2[1]) << ": this should be 0" << std::endl;
}
