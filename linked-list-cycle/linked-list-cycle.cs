/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head)
	{
		var cache = new HashSet<ListNode>(); // Set for caching ListNodes seen
		while (head != null)
		{
			if (cache.Contains(head)) return true; // Check
			cache.Add(head);
			head = head.next;
		}
		return false;
	}
}