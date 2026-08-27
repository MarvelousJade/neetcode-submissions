public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) return 0;
        Array.Sort(nums);

        int i = 0, res = 0;
        int cur = nums[0], streak = 0;

        while (i < nums.Length) {
            if (cur != nums[i]) {
                cur = nums[i];
                streak = 0;
            }

            while (i < nums.Length && cur == nums[i]) {
                i++;
            }

            cur++;
            streak++;

            res = Math.Max(res, streak);
        }

        return res;
    }
}
