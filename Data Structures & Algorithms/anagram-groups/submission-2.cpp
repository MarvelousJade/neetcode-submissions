class Solution {
public:
    vector<vector<string>> groupAnagrams(vector<string>& strs) {
        unordered_map<string, vector<string>> groups;

        for (const auto& str : strs) {
            string sortedS = str;
            sort(sortedS.begin(), sortedS.end());
            groups[sortedS].push_back(str);
        }

        vector<vector<string>> result;
        for (const auto& pair : groups) result.push_back(pair.second);

        return result;
    }
};
