public class Solution {
    public int FindDuplicate(int[] nums) {
        for(int i = 0; i<nums.Length; i++)
        {
            int index = Math.Abs(nums[i]);
            if(nums[index]>0)
            {
                nums[index] = nums[index] * -1;
            }
            else
            {
                return Math.Abs(nums[i]);
            }
        }
        return -1;
    }
}