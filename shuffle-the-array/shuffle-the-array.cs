public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int i=0;
        int j=n;
        int k=0;
        int[] ans = new int[nums.Length];
        while(j<(2*n))
        {
            ans[k] = nums[i];
            ans[k+1] = nums[j];
            i++;
            j++;
            k = k+2;
        }
        return ans;
    }
}