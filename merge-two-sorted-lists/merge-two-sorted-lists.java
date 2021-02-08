/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode mergeTwoLists(ListNode l1, ListNode l2) {
    ListNode tempHead = new ListNode(-1);
    ListNode current = tempHead;

    while(l1 != null && l2 != null){
        if(l1.val <= l2.val){
            current.next = l1;
            l1 = l1.next;
        }else {
            current.next = l2;
            l2 = l2.next;
        }
        current = current.next;


    }
    if(l1 == null){
        current.next = l2;
    }
    if(l2 == null){
        current.next = l1;
    }
    return tempHead.next;
}
}