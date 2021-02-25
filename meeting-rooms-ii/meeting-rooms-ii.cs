//without priority queue
public class Solution {
    public int MinMeetingRooms(int[][] intervals) {
        
        int[] starts = new int[intervals.Length];
        int[] ends = new int[intervals.Length];
        
        for(int m = 0; m < intervals.Length; m++)
        {
            starts[m] = intervals[m][0];
            ends[m] = intervals[m][1];
        }
        
        Array.Sort(starts);
        Array.Sort(ends);
        
        int room = 0, end = 0;
        for(int i = 0; i < intervals.Length; i++)
        {
            if(starts[i] < ends[end])
                room++;
            else
                end++;
        }
        
        return room;        
    }
}