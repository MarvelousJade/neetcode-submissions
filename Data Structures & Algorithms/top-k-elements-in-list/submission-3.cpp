class Solution {
public:
    vector<int> topKFrequent(vector<int>& nums, int k) {
        unordered_map<int, int> numToFrequency;
        vector<int> result;
        vector<pair<int, int>> arr;

        for (int num : nums) {
            numToFrequency[num]++;
        }

        for (const auto& pair : numToFrequency) {
            arr.push_back({pair.second, pair.first});
        }

        sort(arr.begin(), arr.end(), greater<>());

        for (int i = 0; i < k; i++) {
            result.push_back(arr[i].second);
        }

        return result;
    }
};
