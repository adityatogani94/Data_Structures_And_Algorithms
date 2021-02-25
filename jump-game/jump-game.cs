public class Solution {
    public bool CanJump(int[] nums) {
        int maxLength = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == 0 && maxLength == 0)
            {
                return false;
            }
            if (nums[i] >= maxLength)
            {
                maxLength = nums[i];
            }
            maxLength--;
        }
        return true;
    }
}