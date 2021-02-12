public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length == t.Length){
            char[] sortedS = s.ToArray();
            Array.Sort(sortedS);
            char[] sortedT = t.ToArray();
            Array.Sort(sortedT);
            for(int i = 0; i<s.Length; i++){
                if(sortedS[i] != sortedT[i])
                    return false;
            }
            return true;
        }
        return false;
    }
}