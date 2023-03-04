// leetcode 1480
// running sum of 1d array 

 public class Solution {
    public int[] RunningSum(int[] nums) {
        int[] sums = new int[nums.Length];; 

        for (int i = 0; i < nums.Length; i++)
        {
            if (i == 0)
                {
                    sums[i] = nums[i]; 
                }
            else 
                {
                    int newSum = sums[i - 1] + nums[i]; 
                    sums[i] = newSum; 
                }
        }
        return sums; 
    }
}