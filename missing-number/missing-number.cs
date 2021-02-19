public class Solution {
    public int MissingNumber(int[] nums) {
        Array.Sort(nums);
        int count = 0;
        foreach(int i in nums)
        {
            if(i != count)
            {
                return count;
            }
            count++;
        }
        return count;
    }
}