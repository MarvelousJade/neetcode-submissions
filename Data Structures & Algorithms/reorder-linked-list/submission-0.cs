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
    public void ReorderList(ListNode head) {
        if( head == null) return;

        var nodeStack = new Stack<ListNode>();
        var cur = head;

        while(cur != null) {
            nodeStack.Push(cur);
            cur = cur.next; 
        }

        int count = nodeStack.Count;
        var l = head; 

        for (int i = 0; i < count / 2; i++) {
            var r = nodeStack.Pop();
   
            var temp = l.next;

            l.next = r;
            r.next = temp;

            l = temp;
        }

        l.next = null;
    }
}
