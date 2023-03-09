// leetcode 26

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        HashSet<int> uniqueVals = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!uniqueVals.Contains(nums[i]))
            {
                uniqueVals.Add(nums[i]); 
            }
        }

        int startIdx = 0; 
        foreach (int item in uniqueVals)
        {
            nums[startIdx] = item; 
            startIdx += 1; 
        }
        
        Console.WriteLine("unique chars count: " + (startIdx)); 
        Array.Resize(ref nums, uniqueVals.Count);
        Console.WriteLine("resized nums length: "  + nums.Length); 

        return nums.Length;  
    }
}