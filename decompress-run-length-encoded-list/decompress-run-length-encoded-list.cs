public class Solution {
    public int[] DecompressRLElist(int[] nums) {
        List<int> ans = new List<int>();
        for(int i=0; i<nums.Length-1; i++)
        {
            for(int j=0; j<nums[i]; j++)
            {
                ans.Add(nums[i+1]);
            }
            i++;
        }
        return ans.ToArray();
    }
}