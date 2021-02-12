/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
    if(head == null)
        return null;
        
    var map = new Dictionary<Node, Node>();
    var node = head;
    int count = 0;
    while(node != null && !map.ContainsKey(node)) // cycle check
    {
        count++;
        var newNode = new Node(node.val);
        map.Add(node, newNode);
        node = node.next;
    }
    
    node = head;
    for(int i = 0; i < count; i++) // prevents cycle
    {
        var newNode = map[node];
        if(node.next != null)
            newNode.next = map[node.next];
            
        if(node.random != null)
            newNode.random = map[node.random];
            
        node = node.next;
    }
    
    return map[head];
}
}