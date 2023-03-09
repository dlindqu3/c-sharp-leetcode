// leetcode 28 

public class Solution {
    public int StrStr(string haystack, string needle) {
        
        if (haystack == needle)
        {
            return 0;
        }

        if (needle.Length > haystack.Length)
        {
            return -1; 
        }

        haystack.ToCharArray();
        needle.ToCharArray(); 

        String needle2 = ""; 
        for (int i = 0; i < needle.Length; i++)
        {
            needle2 += needle[i];
        }

        // if haystack length = 6, like [0, 1, 2, 3, 4, 5]
        // and needle length =  2, like [0, 1] 
        // then the last possible start index in haystack is haystack.Length - needle.Length, which in this example is 6 - 2 = 4
        String comparison = "";
        int p1 = 0; 
        int startIdx = 0;
        int lastPossibleStart = haystack.Length - needle.Length; 

        for (int i = 0; i < haystack.Length; i++)
        {
            p1 = 0; 
            comparison = ""; 
            startIdx = 0; 

            if (haystack[i] == needle[0] && i <= lastPossibleStart)
            {
                startIdx = i; 
                Console.WriteLine("idx of haystack with start of needle: " + i);;
                while (p1 < needle2.Length)
                {
                    comparison += haystack[i + p1]; 
                    Console.WriteLine(haystack[i + p1] + " " + needle2[p1]); 
                    if (comparison == needle)
                    {
                        return startIdx; 
                    }
                    p1 += 1; 
                }
            }
        } 
        
        return -1;
    }
}