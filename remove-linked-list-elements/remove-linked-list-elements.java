/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode removeElements(ListNode head, int val) {
        // delete from the head, if heads qualifies
        while (head != null && head.val == val)
            head = head.next;

        // return if all deleted, or input empty
        if (head == null)
            return head;

        ListNode temp = head;

        // code hits here means temp not null and not qualify, search from next to the end
        while (temp.next != null) {
            if (temp.next.val == val)
                temp.next = temp.next.next;
            else 
                temp = temp.next;
        }

        return head;
    }
}