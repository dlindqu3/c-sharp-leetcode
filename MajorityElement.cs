// leetcode 169

public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary <int, int> counts = new Dictionary <int, int>(); 


        for (int i = 0; i < nums.Length; i++)
        {
            if (!counts.ContainsKey(nums[i]))
            {
                counts[nums[i]] = 1; 
            }
            else 
            {
                counts[nums[i]] += 1; 
            }
        }

        int majorityNum = 0; 
        int majorityCount = 0; 

        foreach (var key in counts.Keys)
        {
            if (counts[key] > majorityCount)
            {
                majorityNum = key; 
                majorityCount = counts[key]; 
            }
            // Console.WriteLine(majorityNum + " " + key + " " + counts[key]); 
        }

        return majorityNum; 
    }
}