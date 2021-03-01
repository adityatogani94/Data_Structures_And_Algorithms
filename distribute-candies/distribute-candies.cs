public class Solution {
    public int DistributeCandies(int[] candyType) {
        HashSet<int> set = new HashSet<int>();
        int n = candyType.Length;
        foreach(int candy in candyType)
        {
            set.Add(candy);
        }
        return n/2>set.Count ? set.Count : n/2;
    }
}