public class Solution {
    public int NumJewelsInStones(string J, string S) {
        int num=0;
        char[] s_char = S.ToCharArray();
        char[] j_char = J.ToCharArray();
        for(int i=0; i<s_char.Length; i++)
        {
            for(int k=0; k<j_char.Length; k++)
            {
                if(s_char[i]==j_char[k])
                {
                    num++;
                }
            }
        }
        return num;
    }
}