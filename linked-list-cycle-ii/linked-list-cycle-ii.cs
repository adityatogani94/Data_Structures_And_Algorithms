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
    public ListNode DetectCycle(ListNode head) {
    
    if(head == null) return head;
    
    HashSet<ListNode> set = new HashSet<ListNode>();
    
    while(head != null){
        
        if(set.Contains(head.next)){
            return head.next;
        }
        
        else
            set.Add(head);
        
        head = head.next;
        
    }
    
    return null;
    }
}