public class Solution {
    public IList<string> TopKFrequent(string[] words, int k) {
        Dictionary<string,int> dict = new Dictionary<string,int>();

        foreach(string item in words){
            if(!dict.ContainsKey(item)){
                dict.Add(item,1);
            }
          else  dict[item]++;
        }
            // dictionary in C# has inbuilt method for sorting both key and value 
            // Sort first by frequency and then by key in case of tie like same frequency 

        return dict.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key).Select(x=>x.Key).Take(k).ToList();
    }
}