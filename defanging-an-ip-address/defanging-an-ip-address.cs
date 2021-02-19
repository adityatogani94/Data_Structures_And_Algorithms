public class Solution {
    public string DefangIPaddr(string address) {
        string ans = "";
        char[] addr = address.ToCharArray();
        foreach(char i in addr)
        {
            if(i == '.')
            {
                ans += "[.]";
            }
            else
                ans += i;
        }
        return ans;
    }
}