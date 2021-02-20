public class Solution
{
    public string MinRemoveToMakeValid(string s)
    {
        var res = new StringBuilder();
        var openPos = new Stack<int>();
        int i = 0;
        foreach (var c in s)
            switch (c)
            {
                case '(':
                    res.Append(c);
                    openPos.Push(i++);
                    break;
                case ')':
                    if (openPos.Any())
                    {
                        res.Append(c);
                        openPos.Pop();
                        i++;
                    }
                    break;
                default:
                    res.Append(c);
                    i++;
                    break;
            }

        while (openPos.Any())
        {
            var pos = openPos.Pop();
            res.Remove(pos, 1);
        }

        return res.ToString();
    }
}