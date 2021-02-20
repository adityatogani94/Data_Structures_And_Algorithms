public class Solution {
    public string MostCommonWord(string paragraph, string[] banned) {
        //Adding all the banned word in Hashset 
        HashSet<string> hashban = new HashSet<string>();
        Dictionary<string, int> dict = new Dictionary<string, int>();  
        string result = "";
        for(int i = 0; i < banned.Length; i++){
            hashban.Add(banned[i]);
            
        }
        
        paragraph =  paragraph
        .Replace("!", " ")
        .Replace("?"," ")
        .Replace("'"," ")
        .Replace(","," ")
        .Replace("."," ")
        .Replace(";"," ")
        .ToLower();
      
        
        string[] words = paragraph.Split(" ");
        
        for(int i = 0; i <words.Length; i++){
            if((!(hashban.Contains(words[i]))) && (words[i] != "")){
                if(!(dict.ContainsKey(words[i])))
                    dict.Add(words[i], 1);
                else
                     dict[words[i]] += 1;
            }
        }
        
        int max = 0;
        foreach(var item in dict){
            if(item.Value > max){
                max = item.Value;
                result = item.Key;
                
            }          
        }
       
        return result; 
    }
}