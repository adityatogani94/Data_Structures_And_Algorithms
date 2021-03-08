public class Solution {
    public bool IsStrobogrammatic(string num) {
        Stack<char> stack1 = new Stack<char>();
        foreach(char digit in num)
        {
            stack1.Push(digit);
        }
        
        StringBuilder reversedNum = new StringBuilder();
        while(stack1.Count != 0)
        {
            char currDigit = stack1.Pop();
            if(currDigit == '1' || currDigit == '8' || currDigit == '0')
            {
                reversedNum.Append(currDigit);
            }
            else if(currDigit == '6')
            {
                reversedNum.Append('9');
            }
            else if(currDigit == '9')
            {
                reversedNum.Append('6');
            }
            else
            {
                return false;
            }
        }
        //Console.WriteLine(reversedNum);
        return num.Equals(reversedNum.ToString());
    }
}