public class Solution {
    private List<List<int>> res = new();

    public List<List<int>> CombinationSum(int[] nums, int target) {
        dfs(0, nums, 0, new List<int>(), target);

        return res;
    }

    private void dfs(int i, int[] nums, int sum, List<int> cur, int target) {
        if (sum == target) {
            res.Add(cur.ToList());
            return;
        }

        if (i >= nums.Length || sum > target) {
           return; 
        }
        
        cur.Add(nums[i]);
        dfs(i, nums, sum + nums[i], cur, target);
        cur.Remove(nums[i]);
        dfs(i + 1, nums, sum, cur, target);
    }
}
