public class Solution {
    public void SortColors(int[] nums) {
        int start = 0;
        int end = nums.Length-1;
        int index = 0;
        while(index<=end)
        {
            if(nums[index] == 0)
            {
                int temp = nums[index];
                nums[index] = nums[start];
                nums[start] = temp;
                start++;
                index++;
            }
            else if(nums[index] == 2)
            {
                int temp = nums[index];
                nums[index] = nums[end];
                nums[end] = temp;
                end--;
            }
            else if(nums[index] == 1)
            {
                index++;
            }
        }
    }
}