/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */

class Solution {
public:
    ListNode* reverseList(ListNode* head) {
        if (head == nullptr) return nullptr;

        stack<ListNode*> nodeStack; 
        ListNode* current = head;

        while(current) {
            nodeStack.push(current);
            current = current->next;
        }

        ListNode* newHead = nodeStack.top();
        nodeStack.pop();
        current = newHead;

        while(!nodeStack.empty()) {
            current->next = nodeStack.top();
            nodeStack.pop(); 

            current = current->next;
        }

        current->next = nullptr;
        
        return newHead; 
    }
};
