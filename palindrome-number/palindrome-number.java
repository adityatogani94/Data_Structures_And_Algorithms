class Solution {
    public boolean isPalindrome(int x) {
    
        boolean answer = false;
        if (x == 0)
            return !answer;
        if (x < 0)
            return answer;
        long number = Math.abs((long) x), sum = 0;
        while (number != 0) {
            sum = sum * 10 + number % 10;
            number = number / 10;
        }
        if(sum == x)
        {
            return !answer;
        }

        return answer;

    }
}