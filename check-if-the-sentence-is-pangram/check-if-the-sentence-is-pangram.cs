public class Solution {
    public bool CheckIfPangram(string sentence) {
        int[] map = new int[26];
        foreach(char a in sentence)
        {
            map[a - 'a']++;
        }
        
        foreach(int i in map)
        {
            if(i==0)
            {
                return false;
            }
        }
        return true;
    }
}