public class MinStack 
{
    Stack<int> normalStack = new Stack<int>();
    
    Stack<int> minStack = new Stack<int>();

    /** initialize your data structure here. */
    public MinStack() 
    {
        
    }
    
    public void Push(int x) 
    {
        normalStack.Push(x);
        
        if(minStack.Count == 0 || minStack.Peek() >= x)
        {
            minStack.Push(x);
        }
    }
    
    public void Pop() 
    {
        if(normalStack.Count != 0)
        {
            if(minStack.Count != 0 && normalStack.Peek() == minStack.Peek())
            {
                minStack.Pop();
            }
            normalStack.Pop();
        }
    }
    
    public int Top() 
    {
        if(normalStack.Count != 0)
        {
            return normalStack.Peek();
        }
        
        return -1;
        
    }
    
    public int GetMin() 
    {
        if(minStack.Count != 0)
        {
            return minStack.Peek();
        }
        
        return -1;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */