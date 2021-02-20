public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        int[] ans = new int[nums.Length];
        int count = 0;
        int i = 0;
        while(i<nums.Length)
        {
            for(int j = 0; j<nums.Length; j++)
            {
                if(i==j)
                {
                    continue;
                }
                if(nums[j]<nums[i])
                    count++;
            }
            ans[i] = count;
            count = 0;
            i++;
        }
        return ans;
    }
}