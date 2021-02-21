public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        //This question is solved using Top order Topological sort
        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
        int[] indegree = new int[numCourses];
        
        //Fill the adjacency list map and indegree array
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
        
        //put all the courses with indegree(dependencies)==0 into the queue
        Queue<int> bfs = new Queue<int>();
        for(int i = 0; i<numCourses; i++)
        {
            if(indegree[i] == 0)
            {
                bfs.Enqueue(i);
            }
        }
        
        //increase the count if you pop a course with indegree==0 from the queue
        //Add any course from the adjacency list of that course to the queue if they have indegree == 0
        List<int> ans = new List<int>();
        int count = 0;
        while(bfs.Count != 0)
        {
            int temp = bfs.Dequeue();
            if(indegree[temp]==0)
            {
                ans.Add(temp);
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
        if(count == numCourses)
        {
            return ans.ToArray();
        }
        else
        {
            return new int[]{};
        }
    }
}

