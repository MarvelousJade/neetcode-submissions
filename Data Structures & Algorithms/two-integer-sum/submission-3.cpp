class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
       unordered_map<int, int> numToIndex;

       for (int i = 0; i < nums.size(); i++) {
            int diff = target - nums[i];

            if (numToIndex.count(diff)) {
                return {numToIndex[diff], i};
            }

            numToIndex.insert({nums[i], i});
       } 

       return {};
    }
};
