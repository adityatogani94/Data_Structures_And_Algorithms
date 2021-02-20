public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        int ans = 0;
        int i = 0;
        int j = 0;
        while(i<nums.Length)
        {
            Console.WriteLine("i=" + nums[i]);
            while(j<nums.Length-1)
            {
                Console.WriteLine("j=" + nums[j+1]);
                if(nums[i] == nums[j+1])
                {
                    Console.WriteLine("plus one");
                    ans++;
                }
                j++;
            }
            Console.WriteLine("-------");
            i++;
            j=i;
        }
        return ans;
    }
}