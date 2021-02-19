public class Solution {
    public string RemoveDuplicateLetters(string s) 
    {
        if(string.IsNullOrEmpty(s))
            return s;
        var count = new int[26];
        for(int i=0; i<s.Length; i++)
        {
            count[s[i]-'a']++;
        }
        var sb = new StringBuilder();
        var hs = new HashSet<char>();
        for(int i = 0; i<s.Length; i++)
        {
            count[s[i]-'a']--;
            if(hs.Contains(s[i]))
                continue;
            while(sb.Length > 0 && sb[sb.Length-1] > s[i] && count[sb[sb.Length-1]-'a'] > 0)
            {
                hs.Remove(sb[sb.Length-1]);
                sb.Length--;
            }
            hs.Add(s[i]);
            sb.Append(s[i]);
        }
        return sb.ToString();
    }
}