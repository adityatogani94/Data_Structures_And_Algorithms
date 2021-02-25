public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        
        var result = new List<int>();
        
        if(matrix == null || matrix.Length == 0){
            return result;
        }
        
        int top = 0;
        int left = 0;
        int bottom = matrix.Length - 1;
        int right = matrix[0].Length - 1;

        int resultSize = matrix.Length * matrix[0].Length;
        
        while(result.Count < resultSize) {
            for(int i=left;i<=right && result.Count < resultSize;i++) {
                result.Add(matrix[top][i]);
            }            
            top++;
            for (int i=top;i<=bottom && result.Count < resultSize;i++) {
                result.Add(matrix[i][right]);
            }
            right--;
            for (int i=right;i>=left && result.Count < resultSize;i--) {
                result.Add(matrix[bottom][i]);
            }
            bottom--;
            for (int i=bottom;i>=top && result.Count < resultSize;i--) {
                result.Add(matrix[i][left]);
            }
            left++;
        }
        return result;
    }
}