// leetcode 283

public class Solution {
    public void MoveZeroes(int[] nums) {

        int zeroCount = 0; 
        int nonZeroCount = 0;

        foreach (int num in nums)
        {
            if (num == 0)
            {
                zeroCount += 1; 
            }
            else if (num != 0)
            {
                nonZeroCount += 1; 
            }
        }

        if (zeroCount == nums.Length)
        {
            return; 
        }

        if (nonZeroCount == nums.Length)
        {
            return; 
        }

        List<int> zeros = new List<int>(); 
        List<int> nonZeros = new List<int>(); 

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                zeros.Add(nums[i]);
            }
            else if (nums[i] != 0)
            {
                nonZeros.Add(nums[i]); 
            }
        }

        for (int i = 0; i < nonZeros.Count; i++)
        {
            nums[i] = nonZeros[i]; 
        }
        
        for (int i = 0; i < nums.Length; i++)
        {
           if (i > nonZeros.Count -1)
           {
               nums[i] = 0; 
           }
           
        }
    
    }
}