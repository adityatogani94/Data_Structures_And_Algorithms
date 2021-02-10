/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode removeNthFromEnd(ListNode head, int n) {
        if(head == null){
        return null;
        }
        ListNode first = head;
        ListNode second = head;
        //ListNode prev;
        while(n!=0)
        {
            first = first.next;
            n--;
        }
        if(first == null ){    //if after initial walk fast == null, we know the nth element is the head
        return head.next;
        }
        while (first.next!=null)
        {
            first = first.next;
            second = second.next;
        }
        second.next = second.next.next;
        return head;
    }
}