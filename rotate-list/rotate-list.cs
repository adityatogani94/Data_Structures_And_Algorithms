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
    public ListNode RotateRight(ListNode head, int k) {
        
        if(head == null)
            return head;
        
        ListNode fast = head;
        ListNode slow = head;  
        int n = 0;
        
        // count the length of the list
        while(fast != null)
        {
            fast = fast.next;
            n++;
        }
        fast = head; // reset fast point to the head
        
        k = k % n;
        while(k > 0)
        {               
            fast = fast.next;
            k--;
        }
        
        while(fast != null && fast.next != null)
        {
            fast = fast.next;
            slow = slow.next;
        }
            
        fast.next = head; // link the tail to the head to form the circle
        ListNode newHead = slow.next; // set the new head
        slow.next = null; //set the new tail
        
        return newHead;
    }
}