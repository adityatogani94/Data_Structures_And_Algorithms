public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> map = new HashSet<int>(nums);
        Console.WriteLine(map.Count);
        return map.Count != nums.Length;
    }
}