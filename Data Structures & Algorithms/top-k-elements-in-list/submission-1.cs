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

        var arr = new List<int[]>();
        foreach (var pair in numToFrequency) {
            arr.Add(new int[] { pair.Key, pair.Value });
        }

        arr.Sort((a, b) => b[1].CompareTo(a[1]));

        for (int i = 0; i < k; i++) {
            result[i] = arr[i][0];
        }

        return result;
    }
}
