public class MyStack {
    
    Queue<int> que ;
    Queue<int> que2 ;
    /** Initialize your data structure here. */
    public MyStack() {
        que = new Queue<int>();
        que2 = new Queue<int>();
    }
    
    /** Push element x onto stack. */
    public void Push(int x) {
        this.que.Enqueue(x);
    }
    
    /** Removes the element on top of the stack and returns that element. */
    public int Pop() {
        while(this.que.Count != 1){
            que2.Enqueue(que.Dequeue());
        }
        var value = this.que.Dequeue();
        while(this.que2.Count > 0){
            que.Enqueue(que2.Dequeue());
        }
        return value;
    }
    
    /** Get the top element. */
    public int Top() {
        while(this.que.Count != 1){
            que2.Enqueue(que.Dequeue());
        }
        var value = this.que.Dequeue();
        while(this.que2.Count > 0){
            que.Enqueue(que2.Dequeue());
        }
        que.Enqueue(value);
        return value;
    }
    
    /** Returns whether the stack is empty. */
    public bool Empty() {
        if( this.que.Count == 0)return true;
        return false;
    }
}