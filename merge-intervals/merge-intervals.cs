public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (x,y) => x[0].CompareTo(y[0]));
        List<int[]> merged = new List<int[]>();
        
        foreach (int[] interval in intervals) {
            // if the list of merged intervals is empty or if the current
            // interval does not overlap with the previous, simply append it.
            if (merged.Count == 0 || merged[merged.Count - 1][1] < interval[0])
                merged.Add(interval);
            // otherwise, there is overlap, so we merge the current and previous
            // intervals.
            else
                merged[merged.Count - 1][1] = Math.Max(merged[merged.Count - 1][1], interval[1]);
        }
        
        return merged.ToArray();
    }
}