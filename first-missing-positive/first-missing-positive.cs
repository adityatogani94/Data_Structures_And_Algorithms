public class Solution {
    public int FirstMissingPositive(int[] nums) {
        
        HashSet<int> set = new HashSet<int>(nums);
        
        int i = 1;
        while(true)
        {
            if(!set.Contains(i))
                return i;
            
            i++;
        }
        
        return -1;
    }
}