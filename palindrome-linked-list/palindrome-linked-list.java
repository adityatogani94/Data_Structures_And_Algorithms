/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode reverseNode(ListNode head)
    {
        if(head == null || head.next == null)
        {
            return head;
        }
        ListNode nextNode = head.next;
        ListNode newhead = reverseNode(nextNode);
        nextNode.next = head;
        head.next = null;
        return newhead;
    }
    public boolean isPalindrome(ListNode head) {
        if(head == null || head.next == null)
        {
            return true;
        }
        ListNode fast = head;
        ListNode slow = head;
        while(fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }
        if(fast != null) slow = slow.next;
        ListNode mhead = reverseNode(slow);
        while(mhead != null)
        {
            if(mhead.val == head.val)
            {
                mhead = mhead.next;
                head = head.next;
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}