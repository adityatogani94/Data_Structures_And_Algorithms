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
        ListNode middleNode = findMiddle(head);
        ListNode second = reverseSecond(middleNode);
        ListNode first = head;
        ListNode tmp = new ListNode();
        while (second.next != null) {
            tmp = first.next;
            first.next = second;
            first = tmp;

            tmp = second.next;
            second.next = first;
            second = tmp;
        }
    }
    
    public ListNode findMiddle(ListNode head){
        ListNode slow = head, fast = head;
        while (fast != null && fast.next != null) {
          slow = slow.next;
          fast = fast.next.next;
        }
        return slow;
    }
    
    public ListNode reverseSecond(ListNode node){
        ListNode psuedo = null;
        while(node != null)
        {
            ListNode temp = node.next;
            node.next = psuedo;
            psuedo = node;
            node = temp;
        }
        return psuedo;
    }
}