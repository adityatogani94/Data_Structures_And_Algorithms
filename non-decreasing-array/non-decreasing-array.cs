public class Solution {
    public bool CheckPossibility(int[] nums) {
        int count = 0;
        for(int i=0; i<nums.Length-1; i++)
        {
            if(nums[i] > nums[i+1])
            {
                if(i>0) 
                {
                    if(nums[i-1]<=nums[i+1]) nums[i]=nums[i-1];
                    else nums[i+1]=nums[i];
                }
                count++;
                if(count>1)
                {
                    return false;
                }
            }
        }
        return true;
    }
}