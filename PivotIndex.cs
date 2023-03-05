// leetcode 724
// find pivot index

public class Solution {
    public int PivotIndex(int[] nums) {
        int[] preSums = new int[nums.Length]; 
        int[] postSums = new int[nums.Length];  

        for (int i = 0; i < nums.Length; i++)
        {
            if (i ==0)
            {
                preSums[i] = 0;
            }
            else if (i == 1) 
            {
                preSums[i] = nums[i - 1]; 
            }
            else 
            {
                preSums[i] = preSums[i - 1] + nums[i - 1]; 
            }
        }

        for (int j = nums.Length - 1; j >= 0; j--)
        {
            if (j == nums.Length - 1)
            {
                postSums[j] = 0; 
            }
            else if (j == nums.Length - 2)
            {
                postSums[j] = nums[j + 1];
            }
            else 
            {
                postSums[j] = postSums[j + 1] + nums[j + 1]; 
            }
        }

        // return preSums.Last(); 
        // return postSums[0]; 
        for (int k = 0; k < nums.Length; k++)
        {
            if (preSums[k] == postSums[k])
            {
                return k;
            }
        }
    
        return -1; 
    }
}