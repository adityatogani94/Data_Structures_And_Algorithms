public class Solution {
    public int SearchInsert(int[] nums, int target) {
        if(nums.Contains(target)){
            return Array.IndexOf(nums,target);
        }
        else{
            for(int i = 0;i<nums.Length;i++){
                if(nums[i]>target){
                    return i;
                }
                else if(target>nums[i]&&i==nums.Length-1){
                    return i+1;
                }
            }
        }
        return 0;
    }
}
