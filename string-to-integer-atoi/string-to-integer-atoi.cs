public class Solution {
    public int MyAtoi(string str) {
        if (str == null || str == string.Empty)
            return 0;
        
        int res = 0,
            sign = 1;
        bool findSign = false,
             findDigit = false;        
        
        foreach (var c in str)
            if (!findSign && !findDigit && (c == '+' || c == '-'))
            {
                findSign = true;
                sign = c == '+' ? 1 : -1;
            }
            else if (c >= '0' && c <= '9')
            {
                findDigit = true;
                
                if (res == 0 && c == '0')
                    continue;
                else if (res > Int32.MaxValue / 10 || (res == Int32.MaxValue / 10 && c - '0' > Int32.MaxValue % 10))
                    return sign == 1 ? Int32.MaxValue : Int32.MinValue;
                else
                    res = res * 10 + (c - '0');
            }
            else if (c != ' ' || ((findDigit || findSign) && c == ' ') || (findDigit && c == '.'))
                break;
        
        return res * sign;
    }
}