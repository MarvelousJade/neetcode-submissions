public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> indices = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int diff = target - nums[i];

            if (indices.TryGetValue(diff, out int j)) 
                return new int[]{j, i};

            indices[nums[i]] = i;
        }

        return new int[0];
    }
}
