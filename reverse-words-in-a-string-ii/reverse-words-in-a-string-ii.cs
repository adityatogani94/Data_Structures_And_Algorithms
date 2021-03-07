public class Solution {
    public void ReverseWords(char[] s) {
        
        int l = 0; 
        int r = s.Length -1;
        
        //reverse the array
        Reverse(s, l, r);
        
        //reverse the words
        l = 0;
        r = 0;
        
        while(r <= s.Length)
        {
            if(r == s.Length || s[r] == ' ' ) //To handle last word
            {
                Reverse(s, l, r-1);
                l = r+1;
            }
            r++;
        }
    }
    
    private void Reverse(char[] s, int l, int r)
    {
        while(l < r)
        {
            char temp = s[l];
            s[l] = s[r];
            s[r] = temp;
            
            l++;
            r--;
        }
    }
}