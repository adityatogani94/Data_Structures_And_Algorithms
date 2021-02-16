public class Solution {
    public int majorityElement(int[] nums) {
        if(nums.length == 1)
        {
            return nums[0];
        }
        int n = nums.length;
        int counter = 0;
        Arrays.sort(nums);
        int prev = nums[0];
        for(int i = 0; i < nums.length-1; i++)
        {
            if(prev == nums[i+1])
            {
                counter++;
                if(counter >= (n/2))
                {
                    return nums[i+1];
                }
            }
            else
            {
                prev = nums[i+1];
                counter = 0;
            }
        }
        return 0;
    }
}