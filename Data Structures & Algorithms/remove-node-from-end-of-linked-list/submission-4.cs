/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if (head == null) return head;

        var nodes = new List<ListNode>();
        var cur = head;

        while (cur != null) {
            nodes.Add(cur);
            cur = cur.next;
        }

        if (nodes.Count == 1) return null;

        if (nodes.Count == n) {
            head = nodes[0].next;
        } else {
            nodes[^(n + 1)].next = nodes[^n].next;
        };

        return head;
    }
}
