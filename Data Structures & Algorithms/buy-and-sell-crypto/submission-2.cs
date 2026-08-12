public class Solution {
    public int MaxProfit(int[] prices) {
       int minBuy = prices[0], maxP = 0; 

       foreach (int price in prices) {
        maxP = Math.Max(maxP, price - minBuy);
        minBuy = Math.Min(minBuy, price);
       }

       return maxP;
    }
}
