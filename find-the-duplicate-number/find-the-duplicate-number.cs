public class Solution {
    public int FindDuplicate(int[] nums) {
        HashSet<int> map = new HashSet<int>();
        foreach(int num in nums)
        {
            if(map.Contains(num))
                return num;
            else
                map.Add(num);
        }
        return -1;
    }
}