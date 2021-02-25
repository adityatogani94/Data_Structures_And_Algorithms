public class Solution {
    public bool CanAttendMeetings(int[][] intervals) {
        var n = intervals.Length;
        if (n == 0) return true;
        Array.Sort(intervals, (a, b) => a[0] - b[0]);
        for (int i = 1; i < n; i++) {
            if (intervals[i - 1][1] > intervals[i][0]) {
                return false;
            }
        }

        return true;
    }
}