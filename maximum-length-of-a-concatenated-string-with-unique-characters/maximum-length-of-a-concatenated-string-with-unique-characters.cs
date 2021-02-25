public class Solution {
        //think we need all combnations
    // then we know it is a DP problem 
    // or we need backtracking....
    // or solve it with a dfs approach 
    
    
    //Time O(N)
    //Space O(N)
    public int MaxLength(IList<string> arr) {
        int[] result = new int[1];
        
        
        dfs(arr.ToArray(), 0, "", result);
        
        return result[0];
    }
    
    
    public void dfs(string[] arr, int index, string res, int[] result){
        //base case
        if(!isUnique(res)){
            return;
        }
        
        result[0] = Math.Max(result[0], res.Length);
            
        for(int j = index; j < arr.Length; j++){
            //time O(N) one recursive call for every word inside of arr
            dfs(arr, j+1, res + arr[j], result);
        }
        
        
    }
    
    public bool isUnique(string res){
        //space O(26)
        HashSet<char> list = new HashSet<char>(res);
        return list.Count == res.Length;
    }
}