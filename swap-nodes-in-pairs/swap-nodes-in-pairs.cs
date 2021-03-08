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
    public ListNode SwapPairs(ListNode head) {
        ListNode psuedo = new ListNode(-1);
        psuedo.next = head;
        ListNode prev = psuedo;
        
        while(head != null && head.next != null)
        {
            ListNode firstNode = head;
            ListNode secondNode = head.next;
            
            prev.next = secondNode;
            firstNode.next = secondNode.next;
            secondNode.next = firstNode;
            
            prev = firstNode;
            head = firstNode.next;
        }
        
        return psuedo.next;
    }
}