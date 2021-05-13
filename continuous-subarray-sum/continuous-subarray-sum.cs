public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
        if (nums == null || nums.Length < 2)
            return false;
                
        var map = new Dictionary<int, int>();        
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if (k != 0)
                sum = sum % k;
            
            if (sum == 0 && i > 0)
                return true;
            
            if (map.ContainsKey(sum))
            {
                if (i - map[sum] > 1)
                    return true;
            }
            else
            {
                map.Add(sum, i);
            }
        }
        
        return false;
    }
}