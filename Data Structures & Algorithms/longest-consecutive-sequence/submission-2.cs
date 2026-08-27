public class Solution {
    public int LongestConsecutive(int[] nums) {
        var numSet = new HashSet<int>(nums);    
        int res = 0;

        foreach (int num in nums) {
            int streak = 0, cur = 0;
            if (!numSet.Contains(num - 1)) {
               cur = num;

                while (numSet.Contains(cur)) {
                    streak++;
                    cur++;
                }
            }

            res = Math.Max(res, streak); 
        }

        return res;
    }
}
