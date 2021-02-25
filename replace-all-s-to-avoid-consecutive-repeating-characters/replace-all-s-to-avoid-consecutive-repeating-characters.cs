public class Solution {
    public string ModifyString(string s) {
        StringBuilder st = new StringBuilder();
        
        for(int i=0; i< s.Length; i++)
        {
            if (s[i] == '?')
            {
                st.Append(Next((st.Length==0)? 'z': st[st.Length-1],(i+1 == s.Length)?'z': s[i+1]));
            }
            else
            {
                st.Append(s[i]);
            }
        }
        return st.ToString();
    }
    
    private char Next(char prev, char next)
    {
        int result = ((prev-'a')+1) % 26;
        if (next - 'a' == result) { result = (result + 1) % 26; }
        return (char) ('a'+result);
    }

}