public class Solution 
{
    public int CalPoints(string[] ops)
    {
        var stack = new Stack<int>();
        foreach (var op in ops)
        {
            if (int.TryParse(op, out int val)) 
                stack.Push(val);
            else if (op == "+") 
            {
                int elem1 = stack.Pop(), elem2 = stack.Pop();
                stack.Push(elem2);
                stack.Push(elem1);
                stack.Push(elem1 + elem2);
            }
            else if (op == "D") 
                stack.Push(stack.Peek() * 2);
            else if (op == "C") 
                stack.Pop();
        }
        
        return stack.Sum();
    }
}