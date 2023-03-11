// leetcode 136

public class Solution {
    public int SingleNumber(int[] nums) {
        Dictionary<int, int> d1 = new Dictionary<int, int>(); 

        for (int i = 0; i < nums.Length; i++)
        {
            if (d1.ContainsKey(nums[i]))
            {
                d1[nums[i]] += 1; 
            }
            else 
            {
                 d1[nums[i]] = 1; 
            }
        }

        foreach (int key in d1.Keys)
        {
            if (d1[key] == 1)
            {
                return key;
            }
        }
        return -1; 
    }
}