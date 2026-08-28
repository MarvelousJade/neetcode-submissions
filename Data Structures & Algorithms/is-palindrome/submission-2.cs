public class Solution {
    public bool IsPalindrome(string s) {
        int l = 0, r = s.Length - 1;

        while (l < r) {
            while (l < r && !IsAlphaNum(s[l])) {
                l++;
            }

            while (l < r && !IsAlphaNum(s[r])) {
                r--;
            }
            
            if (Char.ToLower(s[l]) != Char.ToLower(s[r])) {
                return false;
            }

            l++;
            r--;
        }

        return true;
    }

    bool IsAlphaNum(char c) {
        return (c >= 'A' && c <= 'Z' || 
                c >= 'a' && c <= 'z' ||
                c >= '0' && c <= '9');
    }
}

