public class Solution {
    public int XorOperation(int n, int start) {
        int result = 0; int i =0;
        while (n > 0)
        {
            result = result ^ (start + 2 * i);
            i++; n--;
        }
        return result;
    }
}