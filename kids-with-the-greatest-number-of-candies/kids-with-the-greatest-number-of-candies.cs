public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        List<bool> ans = new List<bool>();
        int max = 0;
        
        int[] sortedCandies = new int[candies.Length];
        Array.Copy(candies, sortedCandies, candies.Length);
        Array.Sort(sortedCandies);
        max = sortedCandies[candies.Length - 1];
        
        foreach(int candy in candies)
        {
            if((candy + extraCandies) >= max)
            {
                ans.Add(true);
            }                
            else
            {
                ans.Add(false);
            }       
        }
        return ans;
    }
}