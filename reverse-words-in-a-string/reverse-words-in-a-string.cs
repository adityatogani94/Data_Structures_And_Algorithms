public class Solution {
    public string ReverseWords(string s) {
        
        string[] arr = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        
        StringBuilder sb = new StringBuilder();
        for(int i = arr.Length - 1; i >= 0; i--)
        {
            sb.Append(arr[i]);
            sb.Append(" ");
        }
        
        return sb.ToString().Trim();
    }
}