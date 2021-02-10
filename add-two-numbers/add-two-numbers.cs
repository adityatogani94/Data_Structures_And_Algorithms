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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
		ListNode head = new ListNode(0);
		ListNode aux = head;
		int sum = 0, extra = 0;
		while (l1 != null || l2 != null)
		{
			sum = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + extra;
			aux.next = new ListNode(sum % 10);
			extra = sum / 10;
			aux = aux.next;
			l1 = l1 != null ? l1.next : null;
			l2 = l2 != null ? l2.next : null;
		}

		if (extra != 0)
			aux.next = new ListNode(extra);

		return head.next;
    }
}