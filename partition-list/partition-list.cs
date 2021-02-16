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
    public ListNode Partition(ListNode head, int x) {
        if (head == null)
            return head;
        
        ListNode lessDummy = new ListNode(-1),
                 lessCurrent = lessDummy,
                 greaterDummy = new ListNode(-1),
                 greaterCurrent = greaterDummy;
        
        while (head != null)
        {
            if (head.val < x)
            {
                lessCurrent.next = head;
                head = head.next;
                lessCurrent = lessCurrent.next;
                lessCurrent.next = null;
            }
            else
            {
                greaterCurrent.next = head;
                head = head.next;
                greaterCurrent = greaterCurrent.next;
                greaterCurrent.next = null;
            }
        }

        lessCurrent.next = greaterDummy.next;
        
        return lessDummy.next;
    }
}