// leetcode 121 

public class BuySellStock {
    public int MaxProfit(int[] prices) {
        
        int p1 = 0; 
        int p2 = 1; 
        int maxP = 0; 

        while (p2 < prices.Length)
        {
            if (prices[p1] < prices[p2])
            {
                maxP = Math.Max(maxP, prices[p2] - prices[p1]);
                p2++; 
            }
            else if (prices[p1] == prices[p2])
            {
                p1 = p2; 
                p2 = p1 + 1; 
            }
            else if (prices[p1] > prices[p2])
            {
                p1 = p2; 
                p2 = p1 + 1; 
            }
        // { 8, 0, 9 }
        // { 5, 0, 0, 3, 7 }
        }
        return maxP;
    }
}