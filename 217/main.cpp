/* 217. Contains Duplicate
 *
 * Given an integer array nums, return true if any value appears at least twice in the array,
 * and return false if every element is distinct.
 *
 * Example 1:
 * Input: nums = [1,2,3,1]
 * Output: true
 *
 * Constraints:
 * 1 <= nums.length <= 10^5
 * -10^9 <= nums[i] <= 10^9
 */

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
