class Solution {
public:
    vector<int> topKFrequent(vector<int>& nums, int k) {
        unordered_map<int, int> numToFrequency;
        vector<int> result;

        for (int num : nums) {
            numToFrequency[num]++;
        }

        priority_queue<
            pair<int, int>,
            vector<pair<int, int>>,
            greater<pair<int, int>>
        > heap;

        for (auto& entry : numToFrequency) {
            heap.push({entry.second, entry.first});
            if ( heap.size() > k) {
               heap.pop(); 
            }
        }

        for (int i = 0; i < k; i++) {
            result.push_back(heap.top().second);
            heap.pop();
        }

        return result;
    }
};
