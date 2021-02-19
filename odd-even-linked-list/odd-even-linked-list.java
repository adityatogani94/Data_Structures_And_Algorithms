/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode oddEvenList(ListNode head) {
        if(head==null || head.next==null)
        {
            return head;
        }
        ListNode odd = head;
        ListNode fhead = head.next;
        ListNode even = head.next;
        ListNode temp = even.next;
        odd.next = null;
        even.next = null;
        boolean odd1 = true;
        while(temp != null)
        {
            if(odd1 == true)
            {
            odd.next = temp;
            odd = odd.next;
            temp = temp.next;
            odd.next = null;
            odd1 = false;
            }
            else if(odd1 == false)
            {
                even.next = temp;
                even = even.next;
                temp = temp.next;
                even.next=null;
                odd1 = true;
            }
        }
        odd.next = fhead;
        return head;
    }
}