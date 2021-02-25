public class Solution {
    public int[][] FlipAndInvertImage(int[][] A) 
    {
        for (int i = 0; i < A.GetLength(0); i++)
        {
            int cols = A[i].Length-1;
            int mid = A[i].Length % 2 == 0? A[i].Length/2: (A[i].Length+1)/2; 
            for (int j = 0; j < mid; j++)
            {
                int temp = A[i][cols];
                A[i][cols] = A[i][j] == 1 ? 0 : 1;
                A[i][j] = temp == 1 ? 0 : 1;
                cols -= 1;
            }
        }
        return A;
    }
}