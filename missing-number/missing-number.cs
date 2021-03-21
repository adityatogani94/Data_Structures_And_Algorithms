public class Solution {
    public int MissingNumber(int[] nums) {
        bool hasZero = false;
        int indexThatHasZero = 0;
        for(int i=0; i<nums.Length; i++)
        {
            if(nums[i]==0)
            {
                indexThatHasZero = i;
                hasZero = true;
            }
            if(Math.Abs(nums[i]) <= nums.Length-1)
            {
                nums[Math.Abs(nums[i])] *= -1;
            }
        }
        
        if(!hasZero)
        {
            return 0;
        }
        
        bool hasIndexThatHasZero = false;
        
        for(int i=0; i<nums.Length; i++)
        {
            if(Math.Abs(nums[i])==indexThatHasZero)
            {
                hasIndexThatHasZero = true;
            }
        }
        
        if(!hasIndexThatHasZero)
        {
            return indexThatHasZero;
        }
        
        for(int i=0; i<nums.Length; i++)
        {
            if(nums[i]==0)
            {
                continue;
            }
            else if(nums[i] > 0)
            {
                return i;
            }
        }
        
        return nums.Length;
    }
}