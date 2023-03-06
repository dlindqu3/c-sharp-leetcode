// leetcode 392

public class Solution {
    public bool IsSubsequence(string s, string t) {
        
        if (s.Length == 0)
        {
            return true;
        }

        if (t.Length == 0)
        {
            return false; 
        }

        char[] chars1 = s.ToCharArray(); 
        char[] chars2 = t.ToCharArray(); 
 
        String strB = "";  
        int p1 = 0;

        while (p1 < chars2.Length)
        {
            // Console.WriteLine("currentLetter: " + chars2[p1]);

            if (s == strB)
            {
                return true; 
            }
            
            if (chars2[p1] == chars1[strB.Length])
            {
                strB += chars2[p1]; 
            }

            p1 += 1; 
        }
        
        // Console.WriteLine( "strB " + strB); 
        return s == strB; 

    }
}