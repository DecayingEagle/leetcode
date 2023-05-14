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