// leetcode 242

public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length)
        {
            return false;
        }
        
        char[] a1 = s.ToCharArray(); 
        char[] a2 = t.ToCharArray();

        Dictionary <String, int> counts1 = new Dictionary<String, int>();
        Dictionary <String, int> counts2 = new Dictionary <String, int>();

        for (int i = 0; i < a1.Length; i++)
        {
            if (counts1.ContainsKey(a1[i].ToString()))
            {
                counts1[a1[i].ToString()] += 1; 
            }
            else 
            {
                counts1[a1[i].ToString()] = 1; 
            }
        }

        String kv1 = ""; 
        String kv2 = ""; 

        for (int j = 0; j < a2.Length; j++)
        {
            if (counts2.ContainsKey(a2[j].ToString()))
            {
               counts2[a2[j].ToString()] += 1; 
            }
            else 
            {
                counts2[a2[j].ToString()] = 1; 
            }
        }

        foreach (String key  in counts1.Keys)
        {
            if (counts2.ContainsKey(key) == false)
            {
                Console.WriteLine("a key doesn't match");
                return false;
            }
            kv1 += key; 
            kv1 += ": ";
            kv1 += counts1[key];  
            kv1 += " ";
            
            kv2 += key; 
            kv2 += ": ";
            kv2 += counts2[key];  
            kv2 += " ";
        }

        Console.WriteLine(kv1); 
        Console.WriteLine(kv2); 
        return kv1 == kv2; 
    }
}