public class Solution {
    public string RestoreString(string s, int[] indices) {
        char[] chars = s.ToCharArray();
        char[] ans = new char[chars.Length];
        for(int i=0; i<chars.Length; i++)
        {
            ans[indices[i]] = chars[i]; 
        }
        return new string(ans);
    }
}