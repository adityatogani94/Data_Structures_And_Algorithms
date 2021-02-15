public class Solution {
    public int[] plusOne(int[] digits) {
        int i = digits.length -1;
        if(digits[i] < 9)
        {
            digits[i] = digits[i]+1;
        }
        else
        {
            for(i = digits.length -1; i>=0 && digits[i] == 9; i--)
            {
                digits[i] = 0; 
            }
            if(digits[0] == 0)
            {
                digits = new int[digits.length+1];
                digits[0] = 1;
            }
            else
            {
                digits[i] = digits[i]+1;
            }
        }
        return digits;
    }
}