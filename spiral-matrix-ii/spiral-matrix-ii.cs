public class Solution {
    public int[][] GenerateMatrix(int n) {
        
        int num = 1, top = 0, bottom = n - 1, left = 0, right = n - 1;
        int[][] matrix = new int[n][];
        for(int i = 0; i < n; i++)
            matrix[i] = new int[n];
        
        while(top <= bottom && left <= right)
        {
            // left -> right
            for(int j = left; j <= right && top <= bottom && left <= right; j++)
            {
                matrix[top][j] = num;
                num++;
            }
            top++;
            
            // top -> bottom
            for(int i = top; i <= bottom && top <= bottom && left <= right; i++)
            {
                matrix[i][right] = num;
                num++;
            }
            right--;
            
            // right ->left
            for(int j = right; j >= left && top <= bottom && left <= right; j--)
            {
                matrix[bottom][j] = num;
                num++;
            }
            bottom--;
            
            // bottom -> top
            for(int i = bottom; i >= top && top <= bottom && left <= right; i--)
            {
                matrix[i][left] = num;
                num++;
            }
            left++;
        }
        
        return matrix;
    }
}