// leetcode 387

public class Solution {
    public int FirstUniqChar(string s) {
        Dictionary <String, int> counts = new Dictionary <String, int>(); 
        
        char[] chars = s.ToCharArray(); 

        for (int i = 0; i < chars.Length; i++)
        {
            if (!counts.ContainsKey(chars[i].ToString()))
            {
                counts[chars[i].ToString()] = 1; 
            }
            else if (counts.ContainsKey(chars[i].ToString())) 
            {
                counts[chars[i].ToString()] += 1; 
            }
        }
        
        for (int i = 0; i < chars.Length; i++)
        {
            if (counts[chars[i].ToString()] == 1)
            {
                return i;
            }
        }
        // foreach (var (key,value) in counts)
        // {
        //     Console.WriteLine($"{key}: {value}");   
        // }
        return -1; 
    }
}