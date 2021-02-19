public class Solution {
    public void ReverseString(char[] s) {
        int lo = 0, hi = s.Length-1; // Initialize Two Pointers to start and end of array
        while(lo<=hi){
            var temp = s[lo]; // store into temp variable
            s[lo] = s[hi]; // switch #1
            s[hi] = temp; // switch #2
            lo+=1;
            hi-=1;
        }
    }
}