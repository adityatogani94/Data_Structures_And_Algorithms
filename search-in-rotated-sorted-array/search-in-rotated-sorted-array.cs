public class Solution {
    public int Search(int[] nums, int target) {
        int minindex = 0;
        int min = nums[0];
        for(int i=1; i<nums.Length; i++)
        {
            if(nums[i]<min)
            {
                min = nums[i];
                minindex = i;
            }
        }
        if((target>=nums[minindex])&&(target<=nums[nums.Length-1]))
        {
            return BinarySearch(nums, target, minindex, nums.Length-1);
        }
        else
        {
            return BinarySearch(nums, target, 0, minindex-1);
        }
    }
    public int BinarySearch(int[] inputArray, int key, int min, int max)
    {
        while (min <=max)  
        {  
           int mid = (min + max) / 2;  
           if (key == inputArray[mid])  
           {  
                return mid;  
           }  
           else if (key < inputArray[mid])  
           {  
               max = mid - 1;  
           }  
           else  
           {  
                min = mid + 1;  
           }  
        }  
        return -1;  
    }
}