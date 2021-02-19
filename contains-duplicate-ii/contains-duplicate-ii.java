public class Solution {
    public boolean containsNearbyDuplicate(int[] nums, int k) {
        HashMap<Integer, Integer> map = new HashMap<Integer,Integer>();
        int j,diff=0;
        if(nums.length==0)
        {
            return false;
        }
        for(int i=0; i<nums.length; i++)
        {
            if(map.containsKey(nums[i]))
            {
                j = map.get(nums[i]);
                diff = (i-j);
                if(k>=diff)
                {
                    return true;
                }
            }
            map.put(nums[i],i);
        }
        return false;
    }
}