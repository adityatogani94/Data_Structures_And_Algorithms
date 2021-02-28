public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] ans = new int[nums.Length];
        
        ans[0] = 1;
        for(int i=1; i<nums.Length; i++)
        {
            ans[i] = ans[i-1] * nums[i-1];
        }
        
        int R = 1;
        for(int i=nums.Length-1; i>=0; i--)
        {
            ans[i] = ans[i] * R;
            R = R * nums[i];
        }
        
        return ans;
    }
}