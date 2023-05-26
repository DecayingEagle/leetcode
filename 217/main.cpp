#include <algorithm>
#include <ostream>
#include <vector>
#include <iostream>

class Solution217 {
public:
    bool containsDuplicate(std::vector<int>& nums) {
	if(nums.size()<=1){return false;}
	std::sort(nums.begin(), nums.end());
	//TODO: remove printing check 
	std::cout << "\nNums: ";
	for (auto i : nums) {
		std::cout << i <<" ";
	}
	for (int i = 0; i<nums.size(); i++) {
		std::cout << "\nCompared nums: " << nums[i] << ", " << nums[((i+1)%nums.size())];
		if (nums[i] == nums[((i+1)%nums.size())]) {
			std::cout << "\n\n";
			return true;
		}
	}
	std::cout << "\n\n";
	return false;
    }
};


int main() {
	std::vector<int> v = {10, 20, 30, 10};
	Solution217 s;
	std::cout << s.containsDuplicate(v);
}
