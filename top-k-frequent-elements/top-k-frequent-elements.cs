public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> queue = new Dictionary<int, int>();
        foreach(int num in nums)
        {
            if(queue.ContainsKey(num))
            {
                queue[num]++;
            }
            else
            {
                queue.Add(num, 1);
            }
        }
        return queue.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToArray();
    }
}