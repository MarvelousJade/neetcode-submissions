public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var numToFrequency = new Dictionary<int, int>(); 
        int[] result = new int[k];

        foreach (int num in nums) {
            if (!numToFrequency.ContainsKey(num)) {
                numToFrequency[num] = 0;
            }
            numToFrequency[num] += 1;
        }

        for (int i = 0; i < k; i++) {
            int maxKey = 0;
            int maxFrequency = 0;

            foreach(var pair in numToFrequency) {
                if (pair.Value > maxFrequency) {
                    maxFrequency = pair.Value;
                    maxKey = pair.Key;
                }
            }

            result[i] = maxKey;
            numToFrequency.Remove(maxKey);
        } 

        return result;
    }
}
