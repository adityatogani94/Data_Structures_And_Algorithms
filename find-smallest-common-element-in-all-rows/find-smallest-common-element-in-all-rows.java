class Solution {
    public int smallestCommonElement(int[][] mat) {
    int count[] = new int[10001];
    int n = mat.length, m = mat[0].length;
    for (int i = 0; i < n; ++i) {
        for (int j = 0; j < m; ++j) {
            ++count[mat[i][j]];
        }
    }
    for (int k = 1; k <= 10000; ++k) {
        if (count[k] == n) {
            return k;
        }
    } 
    return -1;
}
}