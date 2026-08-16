/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode() : val(0), left(nullptr), right(nullptr) {}
 *     TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
 *     TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
 * };
 */

class Solution {
public:
    vector<vector<int>> levelOrder(TreeNode* root) {
        vector<vector<int>> result;
        if(!root) return result;

        queue<TreeNode*> nodes;    
        nodes.push(root);
        
        while(!nodes.empty()) {
            vector<int> level;
            int levelSize = nodes.size();

            for (int i = 0; i < levelSize; i++) {
                TreeNode* node = nodes.front();
                nodes.pop();

                level.push_back(node->val);
                if (node->left) nodes.push(node->left);
                if (node->right) nodes.push(node->right);
            }

            result.push_back(level);
        }

        return result;
    }
};
