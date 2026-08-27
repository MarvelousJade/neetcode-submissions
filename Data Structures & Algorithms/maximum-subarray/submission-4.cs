public class Solution {
    public int MaxSubArray(int[] nums) {
        int curSum = 0, maxSub = nums[0];

        foreach (int num in nums) {
            if(curSum < 0 ) curSum = 0;

            curSum += num;
            maxSub = Math.Max(maxSub, curSum);
        }

        return maxSub;
    }
}
