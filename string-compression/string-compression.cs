public class Solution {
    public int Compress(char[] chars) {
        
        if(chars.Length == 0 || chars.Length == 1) return chars.Length;
        
        int cnt = 1;
        StringBuilder sb = new StringBuilder();
        
        for(int i = 0; i<chars.Length - 1; i++) { 
            if(chars[i] == chars[i+1]) cnt += 1;
            else 
            {
                sb.Append(chars[i]);
                if(cnt > 1) sb.Append(cnt);
                cnt = 1;
            }
        }
        
        sb.Append(chars[chars.Length - 1]);
        if(cnt>1) sb.Append(cnt);
        
        char[] newChar = sb.ToString().ToCharArray();
        for(int i = 0; i<newChar.Length; i++)
            chars[i] = newChar[i];
        
        return newChar.Length;
    }
}