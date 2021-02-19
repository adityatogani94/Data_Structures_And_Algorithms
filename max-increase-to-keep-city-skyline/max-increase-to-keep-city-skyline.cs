public class Solution {
    public int MaxIncreaseKeepingSkyline(int[][] grid) {
        int top = 0;
        int left = 0;
        int bottom = grid.Length;
        //Console.WriteLine(bottom);
        int right = grid[0].Length;
        //Console.WriteLine(bottom);
        int[] rowmax = new int[grid.Length];
        int[] colmax = new int[grid[0].Length];
        
        for(int i=0; i<colmax.Length; i++)
        {
            colmax[i] = 0;
        } 
        
        for(int i=0; i<colmax.Length; i++)
        {
            rowmax[i] = 0;
        } 
        
        while(top<bottom)
        {
            while(left<right)
            {
                
                if(rowmax[top]<grid[top][left])
                {
                    rowmax[top] = grid[top][left];
                }
                
                if(colmax[left]<grid[top][left])
                {
                    colmax[left] = grid[top][left];
                }
                
                left++;
            }
            left = 0;
            top++;
        }
        
        top = 0;
        left=0;
        int sum = 0;
        int temp = 0;
        while(top<bottom)
        {
            while(left<right)
            {
                //if(grid[top][left] != rowmax[top] && grid[top][left] != colmax[top])
                Console.WriteLine(grid[top][left]);
                if(colmax[left]>=rowmax[top])
                {
                    temp = rowmax[top] - grid[top][left];
                    grid[top][left] = grid[top][left] + Math.Abs(temp);
                    sum += Math.Abs(temp);
                    //Console.WriteLine(temp);
                    //Console.WriteLine(Math.Abs(rowmax[top] - grid[top][left]));
                }
                else if(rowmax[top]>colmax[left])
                {
                    temp = colmax[left] - grid[top][left];
                    grid[top][left] = grid[top][left] + Math.Abs(temp);
                    sum += Math.Abs(temp);
                    //Console.WriteLine(colmax[top]);
                    //Console.WriteLine(Math.Abs(colmax[top] - grid[top][left]));
                }
                left++;
            }
            left=0;
            top++;
        }
        
        return sum;
    }
}