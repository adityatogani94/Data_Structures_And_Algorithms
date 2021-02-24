public class LRUCache {
    LinkedNode head;
    LinkedNode tail;
    int capacity;
    int size;
    Dictionary<int, LinkedNode> cache = new Dictionary<int, LinkedNode>();
    
    public LRUCache(int capacity) {
        this.size = 0;
        this.capacity = capacity;
        head = new LinkedNode();
        tail = new LinkedNode();
        head.next = tail;
        tail.prev = head;
    }
    
    public int Get(int key) {
        if(!cache.ContainsKey(key)) return -1;
        
        LinkedNode node = cache[key];
        moveTohead(node);
        return node.value;
    }
    
    public void Put(int key, int value) {
        if(!cache.ContainsKey(key)){
            LinkedNode newNode = new LinkedNode();
            newNode.key = key;
            newNode.value = value;
            cache.Add(key, newNode);
            addNode(newNode);
            
            size++;
            
            if(size > capacity)
            {
                //poptail
                LinkedNode tail = popTail();
                cache.Remove(tail.key);
                size--;
            }
        }
        else
        {
            LinkedNode node = cache[key];
            node.value = value;
            moveTohead(node);
        }
    }
    
    //always add new node right after the head
    public void addNode(LinkedNode node){
        LinkedNode temp = head.next;
        head.next = node;
        node.prev = head;
        node.next = temp;
        temp.prev = node;
    }
    
    public void removeNode(LinkedNode node){
        LinkedNode next = node.next;
        LinkedNode prev = node.prev;
        prev.next = next;
        next.prev = prev;
    }
    
    public void moveTohead(LinkedNode node){
        removeNode(node);
        addNode(node);
    }
    
    public LinkedNode popTail(){
        LinkedNode temp = tail.prev;
        removeNode(temp);
        return temp;
    }
}

public class LinkedNode{
    public int key;
    public int value;
    public LinkedNode prev;
    public LinkedNode next;
    
    public LinkedNode(){
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */