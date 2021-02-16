public class Solution {
    public int SingleNumber(int[] nums) {
        
        Array.Sort(nums);
        for(int i=0; i<nums.Length-1; i=i+2)
        {
            if(nums[i]!=nums[i+1])
                return nums[i];
        }        
       return nums[nums.Length-1];
    }
}