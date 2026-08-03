class Solution {
public:
    bool isAnagram(string s, string t) {
        if (s.length() != t.length()) return false;

        unordered_map<char, int> countS, countT; 

        for (char c : s) {
            countS[c] += 1;
        }

        for (char c : t) {
            countT[c] += 1;
        }

        return countS == countT;
    }
};
