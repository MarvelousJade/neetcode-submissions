public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int l = 0;
        var currentStr = new HashSet<char>();
        int res = 0;

        for (int r = 0; r < s.Length; r++) {
            while (currentStr.Contains(s[r])) {
                currentStr.Remove(s[l]);
                l++;
            }

            currentStr.Add(s[r]);
            res = Math.Max(res, r - l + 1);
        }

        return res;
    }
}
