// leetcode 205

using static System.Text.Json.JsonSerializer;

public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char, char> matches = new Dictionary<char, char>(); 

        char[] chars1 = s.ToCharArray(); 
        char[] chars2 = t.ToCharArray(); 

        if (s.Length != t.Length)
        {
            return false; 
        }

        // Console.WriteLine(chars1[0]); 
        for (int i = 0; i < chars1.Length; i++)
        {
            // badc
            // baba
            if (matches.ContainsValue(chars2[i]) && !matches.ContainsKey(chars1[i]))
            {
                return false;
            }

            else if (matches.ContainsKey(chars1[i]) && !matches.ContainsValue(chars2[i]))
            {
                return false; 
            }
            
            else if (!matches.ContainsKey(chars1[i]) && !matches.ContainsValue(chars2[i]))
            {
                matches.Add(chars1[i], chars2[i]);
            }  
        }

        for (int j = 0; j < chars1.Length; j++)
        {
            char targetChar = chars2[j]; 

            if (matches[chars1[j]] != targetChar)
            { 
                return false; 
            }
        }

        Console.WriteLine( Serialize(matches.ToList() ) );
        return true; 
    }
}