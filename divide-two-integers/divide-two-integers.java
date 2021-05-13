class Solution {
    public int divide(int dividend, int divisor) {

    // Special case: overflow.
    if (dividend == Integer.MIN_VALUE && divisor == -1) {
        return Integer.MAX_VALUE;
    }
    
    int divisorminus = 0;
    if(divisor<0)
    {
        divisorminus++;
        divisor = divisor * -1;
    }
    if(dividend<0)
    {
        divisorminus++;
        dividend = dividend * -1;
    }
    

    int quotient = 0;
    while (dividend - divisor >= 0) {
        quotient++;
        dividend -= divisor;
    }

    /* If there was originally one negative sign, then
     * the quotient remains negative. Otherwise, switch
     * it to positive. */
    return (divisorminus == 2) || (divisorminus == 0) ? quotient : quotient * -1;
}
}