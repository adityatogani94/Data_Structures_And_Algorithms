public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums);
        int nearestSum = Int32.MaxValue;
        for(int i=0; i<nums.Length-2; i++)
        {
            if(i==0 || (i>0 && nums[i] != nums[i-1]))
            {
                int low = i+1;
                int high = nums.Length-1;

                while(low < high){
                    int sum = nums[i] + nums[low] + nums[high];
                    int diff = target - sum;
                    if(Math.Abs(diff) < Math.Abs(nearestSum))
                    {
                        nearestSum = diff;
                    }
                    if(sum < target)
                    {
                        low++;
                    }
                    else
                    {
                        high--;
                    }
                }
            }
        }
        return target - nearestSum;
    }
}