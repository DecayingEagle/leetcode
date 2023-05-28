/*  1. Two Sums
 *
 *  Given an array of integers nums and an integer target,
 *  return indices of the two numbers such that they add up to target.
 *  You may assume that each input would have exactly one solution, and you may not use the same element twice.
 *  You can return the answer in any order.
 *
 *  Example 1:
 *
 *  Input: nums = [2,7,11,15], target = 9
 *  Output: [0,1]
 *  Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
 *
 *  Constraints:
 *  2 <= nums.length <= 10^4
 *  -10^9 <= nums[i] <= 10^9
 *  -10^9 <= target <= 10^9
 *  Only one valid answer exists.
 */

using System;
public class Program {
	static public void Main(string[] args) {
		int[] arr = {3,2,4};
        int[] print = TwoSum(arr, 6);
		System.Console.WriteLine(print[0] + "," + print[1]);
	}
	static public int[] TwoSum(int[] nums, int target) {
		int sum = 0;
		int[] returnValue = {-1, -1};
		for (int i = 0; i < nums.Length; i++)
		{
			for (int j = 1; j < nums.Length; j++)
			{
				sum = nums[i] + nums[j];
				System.Console.WriteLine(sum.ToString());
				System.Console.WriteLine(j.ToString());
				System.Console.WriteLine(i.ToString());
				if ((sum == target)&&(i != j)) { returnValue[1] = j; returnValue[0] = i; break; }
			}
			if (sum == target) { break; }
		}
		return returnValue;
    }
    
}
