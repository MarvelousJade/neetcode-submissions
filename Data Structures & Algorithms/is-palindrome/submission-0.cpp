class Solution {
public:
    bool isPalindrome(string s) {
       // Two pointers, one start at the begining, another one start at the end
       // Iterate through the string and compare each character they are pointing too
       for (int i = 0; i < s.size(); i++) {

       } 

       int l = 0;
       int r = s.size() - 1;

       while (l < r) {
            while (l < r && !isalnum(s[l])) {
                l++;
            }

            while (l < r && !isalnum(s[r])) {
                r--;
            }

            if(tolower(s[l]) != tolower(s[r])) {
                return false;
            }
            
            l++;
            r--;
       }
       return true;
    }
};
