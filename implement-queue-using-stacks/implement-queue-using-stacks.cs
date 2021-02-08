public class MyQueue {
    Stack<int> newest;
    Stack<int> oldest;
    /** Initialize your data structure here. */
    public MyQueue() {
        newest = new Stack<int>();
        oldest = new Stack<int>();
    }
    
    /** Push element x to the back of queue. */
    public void Push(int x) {
        newest.Push(x);
    }
    
    public void ShiftStacks()
    {
        if(oldest.Count()==0)
        {
            while(newest.Count()!=0)
            {
                oldest.Push(newest.Pop());
            }
        }
    }
    /** Removes the element from in front of queue and returns that element. */
    public int Pop() {
        ShiftStacks();
        return oldest.Pop();
    }
    
    /** Get the front element. */
    public int Peek() {
        ShiftStacks();
        return oldest.Peek();
        
    }
    
    /** Returns whether the queue is empty. */
    public bool Empty() {
        ShiftStacks();
        if(oldest.Count()==0)
        {
            return true;
        }
        return false;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */