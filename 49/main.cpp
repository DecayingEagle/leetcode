/* 49. Group Anagrams
 *
 * Given an array of strings strs, group the anagrams together. You can return the answer in any order.
 * An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase,
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
#include <algorithm>
#include <iostream>
#include <string>
#include <vector>

class Solution49 {
public:
    std::vector<std::vector<std::string>> groupAnagrams(std::vector<std::string>& strs) {
        std::vector<std::vector<std::string>> ret;
        if (strs.size() == 1) {
            ret.push_back(std::vector({strs[0]}));
            return ret;
        } else if (strs.size() == 0) {
            return ret;
        }
        for(int i; i <= strs.size(); i++) {
            std::sort(strs[i].begin(), strs[i].end());
        }
        std::sort(strs.begin(), strs.end());
        std::vector<std::string> buffer;
        for (int i = 1; i <= strs.size(); i++) {
            buffer.push_back(strs[i-1]);
            if (strs[i-1] != strs[i]) {
                ret.push_back(buffer);
                buffer.clear();
            }
        }
        buffer.push_back(strs[strs.size()-1]);
        ret.push_back(buffer);
        return ret;
    }
};

int main() {
    Solution49 s;
    std::vector<std::string> str = {"eat","tea","tan","ate","nat","bat"};
    std::vector<std::vector<std::string>> res = s.groupAnagrams(str);
    //std::cout << "[";
    for (int i; i <= res.size(); i++) {
        std::cout << "----------------------------" << std::endl;
        //std::cout << "[";
        for (int j; j <= res[i].size(); j++) {
            std::cout << res[j][i] << std::endl;
            //std::cout << res[j][i] << (j<=res[i].size() ? "," : "]");
        }
        //std::cout << (i<=res.size() ? "]," : "]");
    }
}
