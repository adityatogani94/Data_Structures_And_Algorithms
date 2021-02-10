public class Solution {
    public int Reverse(int x)
        {
            long reversedInt = 0;
            bool negative = x < 0;
            if (negative)
                x *= -1;
            while (x > 0)
            {
                reversedInt = reversedInt * 10 + x % 10;
                x /= 10;
            }
            if (negative)
                reversedInt *= -1;
            if (reversedInt >= int.MaxValue)
                return 0;
            int intValue = (int)reversedInt;
            if (negative && intValue > 0)
                return 0;
            return (int)reversedInt;
        }
}