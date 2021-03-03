public class Solution {
    public int FindCircleNum(int[][] M) {
        int count=0;
        bool[] visited=new bool[M.Length];
        for(int i=0;i<M.Length;i++)
        {
            if(!visited[i])
            {
                count++;
                var q=new Queue<int>();
                q.Enqueue(i);
                visited[i]=true;
                while(q.Count!=0)
                {
                    int cur=q.Dequeue();
                    for(int j=0;j<M[0].Length;j++)
                    {
                        if(M[cur][j]==1&&!visited[j])
                        {
                            q.Enqueue(j);
                            visited[j]=true;
                        }
                    }
                }
            }
        }
        return count;
    }
}