public class Solution {
    public int CountComponents(int n, int[][] edges) {
        int count = 0;
        List<int>[] graph = null;
        bool[] visited = new bool[n];
        Queue<int> queue = null;
        
        graph = BuildGraph(n, edges);
        
        for (int i  = 0; i <= n - 1; i++)
            if (!visited[i])
            {
                queue = new Queue<int>();
                queue.Enqueue(i);
                Traversal(graph, visited, queue);
                count++;
            }
        
        return count;
    }
    
    private List<int>[] BuildGraph(int nodesVol, int[][] edges)
    {
        List<int>[] graph = new List<int>[nodesVol];
        
        for (int i = 0; i <= edges.GetLength(0) - 1; i++)
        {
            if (graph[edges[i][0]] == null)
                graph[edges[i][0]] = new List<int>();
            
            graph[edges[i][0]].Add(edges[i][1]);
            
            if (graph[edges[i][1]] == null)
                graph[edges[i][1]] = new List<int>();

            graph[edges[i][1]].Add(edges[i][0]);
        }
        
        return graph;
    }
    
    private void Traversal(List<int>[] graph, bool[] visited, Queue<int> queue)
    {
        int count = 0,
            currentNode = 0;
        
        while (queue.Count != 0)
        {
            count = queue.Count();
            
            while (count > 0)
            {
                currentNode = queue.Dequeue();
                
                visited[currentNode] = true;
                
                if (graph[currentNode] != null)
                    foreach (var node in graph[currentNode])
                        if (!visited[node])
                            queue.Enqueue(node);
                        
                count--;
            }
        }
    }
}