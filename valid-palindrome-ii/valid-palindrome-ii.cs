public class Solution {
    public bool ValidPalindrome(string s) {
        int i = 0, j = s.Length-1;
        while(i < j) {
            if(s[i] != s[j])
                return (isPalin(s, i+1, j) || isPalin(s, i, j-1));
        
            i++;
            j--;
        }
        return true;
    }
    public bool isPalin(string s, int i, int j) {
        while(i < j) {
            if(s[i++] != s[j--])
                return false;
        }
        return true;
    }
}