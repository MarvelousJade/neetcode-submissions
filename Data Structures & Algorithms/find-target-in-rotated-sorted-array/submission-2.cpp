class Solution {
public:
    int search(vector<int>& nums, int target) {
        int l = 0, r = nums.size() - 1;

        while (l < r) {
            int m = l + (r - l) / 2;

            if (nums[m] > nums[r]) {
                l = m + 1;
            } else {
                r = m;
            }
        }

        int pivot = l;

        int result = binarySearch(0, pivot - 1, nums, target);
        if (result != -1) return result;
        
        return binarySearch(pivot, nums.size() - 1, nums, target);
    }

    int binarySearch(int left, int right, vector<int>& nums, int target) {
        while (left <= right) {
            int mid = left + (right - left) / 2;
            
            if (target == nums[mid]) {
                return mid;
            }

            if (target > nums[mid]) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }

        return -1;
    }
};
