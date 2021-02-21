public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
        int[] indegree = new int[numCourses];
        
        foreach(int[] pre in prerequisites)
        {
            if(!map.ContainsKey(pre[1]))
            {
                List<int> tempList = new List<int>();
                tempList.Add(pre[0]);
                map.Add(pre[1],tempList);
            }
            else
            {
                map[pre[1]].Add(pre[0]);
            }
            indegree[pre[0]]++;
        }
        
        Queue<int> bfs = new Queue<int>();
        for(int i = 0; i<numCourses; i++)
        {
            if(indegree[i] == 0)
            {
                bfs.Enqueue(i);
            }
        }
        
        int count = 0;
        while(bfs.Count != 0)
        {
            int temp = bfs.Dequeue();
            if(indegree[temp]==0)
            {
                count++;
            }
            if(!map.ContainsKey(temp))
            {
                continue;
            }
            
            foreach(int course in map[temp])
            {
                indegree[course]--;
                if(indegree[course]==0)
                {
                    bfs.Enqueue(course);
                }
            }
        }
        return count == numCourses;
    }
}