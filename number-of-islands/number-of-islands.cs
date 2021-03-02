public class Solution {
    public int NumIslands(char[][] grid) {
        //Solving using BFS
        if(grid==null || grid.Length==0)
        {
            return 0;
        }
        
        int rowSize = grid.Length;
        int colSize = grid[0].Length;
        int noOfIslands = 0;
        
        for(int row=0; row < rowSize; row++)
        {
            for(int col=0; col < colSize; col++)
            {
                if(grid[row][col] == '1')
                {
                    noOfIslands++;
                    grid[row][col] = '0';
                    
                    CallBFS(grid, row, col, rowSize, colSize);
                }
            }
        }
        
        return noOfIslands;
    }
    
    public void CallBFS(char[][] grid, int row, int col, int rowSize, int colSize)
    {
        Queue<(int,int)> queue = new Queue<(int,int)>();
        queue.Enqueue((row,col));
        while(queue.Count != 0)
        {
            var (r,c) = queue.Dequeue();
            
            //Checking up
            if(r-1 >= 0 && grid[r-1][c] == '1'){
                queue.Enqueue((r-1,c));
                grid[r-1][c] = '0';
            }
            //checking down
            if(r+1 < rowSize && grid[r+1][c] == '1'){
                queue.Enqueue((r+1,c));
                grid[r+1][c] = '0';
            }
            //checking left
            if(c-1 >= 0 && grid[r][c-1] == '1'){
                queue.Enqueue((r,c-1));
                grid[r][c-1] = '0';
            }
            // checking right
            if(c+1 < colSize && grid[r][c+1] == '1'){
                queue.Enqueue((r,c+1));
                grid[r][c+1] = '0';
            }
        }
    }
}