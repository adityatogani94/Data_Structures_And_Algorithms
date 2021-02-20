public class Solution {
     public IList<IList<int>> AllPathsSourceTarget(int[][] graph) {
        var steps =new Queue<List<int>>();        
        steps.Enqueue(new List<int>(){0});       
        var end=new List<IList<int>>();
        while(steps.Count>0){
            var step=steps.Dequeue();
            var start=step[step.Count-1];
            if(start==graph.Length-1){
               end.Add(step);            
            } 
            else{                                                 
                for(int i=0;i<graph[start].Length;i++){
                    var nextpath=new List<int>(step);
                    nextpath.Add(graph[start][i]);
                    steps.Enqueue(nextpath);
                }                
            }        
        }
        return end;
    }
}