public class Solution {
    public IList<string> FindItinerary(IList<IList<string>> tickets) {
        int n = tickets.Count;
        Dictionary<string, List<string>> graph = new Dictionary<string, List<string>>();
        List<string> ans = new List<string>();
        for(int i=0; i<= n-1; i++)
        {
            if(!graph.ContainsKey(tickets[i][0]))
            {
                graph[tickets[i][0]] = new List<string>();
            }
            graph[tickets[i][0]].Add(tickets[i][1]);
        }
        
        foreach(List<string> lt in graph.Values)
        {
            lt.Sort();
        }
        
        foreach(string key in graph.Keys)
        {
            Console.WriteLine(key);
            foreach(string curr in graph[key])
            {
                Console.WriteLine(curr);
            }
        }
        
        Stack<string> st = new Stack<string>();
        st.Push("JFK");
        
        while(st.Count!=0)
        {
            var curr = st.Peek();
            //Console.WriteLine(curr);
            if(!graph.ContainsKey(curr))
            {
                ans.Add(curr);
                st.Pop();
                continue;
            }
            else if(graph[curr].Count == 0)
            {
                ans.Add(curr);
                st.Pop();
            }
            else
            {
                string temp = graph[curr].First();
                st.Push(temp);
                graph[curr].Remove(temp);
            }
        }
        ans.Reverse();
        return ans;
    }
}