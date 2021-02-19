public class Solution {
    public bool RotateString(string A, string B) {
        if(A.Length != B.Length){ return false; }
        string AA = A + A;
        return AA.Contains(B);
    }
}