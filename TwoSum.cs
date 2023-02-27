// leetcode 1 

public class TwoSum {
    public int[] TwoSum(int[] nums, int target) {
        int[] result = new int[2]; 

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 1; j < nums.Length; j++)
            {
                int currentSum = nums[i] + nums[j]; 
                if (currentSum == target && i != j)
                {
                    result[0] = i;
                    result[1] = j; 
                }
            }
        }
        return result; 
    }
}