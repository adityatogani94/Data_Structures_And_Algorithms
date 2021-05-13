public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        List<int> cache = new List<int>();
        foreach(int num in nums)
        {
            cache.Add(num);
        }
        List<int> largest = cache.OrderByDescending(x => x).Take(k).ToList();
        return largest[largest.Count-1];
    }
}