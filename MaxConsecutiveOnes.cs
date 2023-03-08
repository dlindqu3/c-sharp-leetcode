// leetcode 485

public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {

        int maxC = 0;
        int currentC = 0;   

        for (int i = 0; i < nums.Length; i++)
        {         
            if (nums[i] == 1)
            {
                currentC += 1; 
                maxC = Math.Max(currentC, maxC); 
            }
            else if (nums[i] != 1)
            {
                maxC = Math.Max(currentC, maxC);
                currentC = 0; 
            }
            Console.WriteLine("currentC: " + currentC); 
            Console.WriteLine("maxC: " + maxC); 
        }

        return maxC; 
    }
}