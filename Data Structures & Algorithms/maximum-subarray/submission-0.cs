public class Solution {
    public int MaxSubArray(int[] nums) {
        int n = nums.Length, res = nums[0];    

        for (int i = 0; i < n; i++) {
            int curSum = 0;
            for (int j = i; j < n; j++) {
                curSum += nums[j];
                res = Math.Max(res, curSum);
            }
        }
        return res;
    }
}
