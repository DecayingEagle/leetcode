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
#include <cstdlib>
#include <iostream>
#include <iterator>
#include <string>
#include <unordered_map>
#include <unordered_set>
#include <utility>
#include <vector>

class Solution49 {
public:
    //TODO: Delete this function
    std::vector<std::string> debugShit() {
        std::vector<std::string> testVar;
        testVar.push_back("test");
        return testVar;
    }

    std::vector<std::vector<std::string>> groupAnagrams(std::vector<std::string>& strs) {
        std::vector<std::vector<std::string>> ret;
        if (strs.size() == 1) {
            ret.push_back(std::vector({strs[0]}));
            return ret;
        } else if (strs.size() == 0) {
            return ret;
        }
        
        //sort strings in the og array for later
        std::sort(strs.begin(), strs.end());

        std::unordered_map<int, std::string> umapStrs;
        std::unordered_set<std::string> usetSortedStrs;
        std::vector<std::string> vecBuffer;
        std::string s;
        int id = 0;

        for(int i; i <= strs.size(); i++) {
            s = strs[i];
            std::sort(s.begin(), s.end());
            auto it = usetSortedStrs.find(s);
            int id = std::distance(usetSortedStrs.begin(), it);
            if (it != usetSortedStrs.end()) {
                /* String :already exists, skip adding it to the sorted map but 
                 * find in set and assign id to from the iterator of 
                 */
                umapStrs.insert({id, strs[i]});
                continue;
            }
            umapStrs.insert({id, strs[i]});
            usetSortedStrs.insert(s);
        }
        for (const auto& pair : umapStrs) {
            ret[pair.first].push_back(pair.second);
        }
        //ret.push_back(debugShit());
        return ret;
    }
};

int main() {
    Solution49 s;
    
    std::vector<std::string> strs = {"eat", "tea", "tan", "ate", "nat", "bat"};
    std::vector<std::vector<std::string>> ret = s.groupAnagrams(strs);
    std::vector<std::vector<std::string>> test;
    
    if (ret == test) {
        std::cout << "Nothing in ret var";
        return EXIT_FAILURE;
    }

    // Print the ret
    for (const auto& group : ret) {
        std::cout << "[";
        for (const auto& str : group) {
            std::cout << "\"" << str << "\", ";
        }
        std::cout << "]" << std::endl;
    }
    return EXIT_SUCCESS;
}
