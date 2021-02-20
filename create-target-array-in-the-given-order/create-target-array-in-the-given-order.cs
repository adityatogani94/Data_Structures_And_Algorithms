public class Solution 
{
    public int[] CreateTargetArray(int[] nums, int[] index) 
    {
        var result = new List<int>();
        for(int i = 0; i < nums.Length; i++)
            result.Insert(index[i], nums[i]);
        return result.ToArray();
    }
}