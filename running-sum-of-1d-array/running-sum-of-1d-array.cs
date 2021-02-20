public class Solution {
    public int[] RunningSum(int[] nums) {
        int[] ans = new int[nums.Length];
        
        if(nums.Length==1)
        {
            ans[0] = nums[0];
            return ans;
        }
        
        
        for(int i=0; i<nums.Length; i++)
        {
            if (i == 0)
                ans[0] = nums[0];
            else
                ans[i] = ans[i-1] + nums[i];
        }
        
        return ans;
    }
}