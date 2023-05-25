#include <iostream>
#include <vector>

class Solution {
public:
    bool isAnagram(std::string s, std::string t) {
        
    }
};

int main() {
	std::string input1[] = {"anagram", "nagaram"};
	std::string input2[] = {"car", "rat"};
	Solution s;
	std::cout << s.isAnagram(input1[0], input1[1]) << ": this should be 1" << std::endl;
	std::cout << s.isAnagram(input2[0], input2[1]) << ": this should be 0" << std::endl;
}
