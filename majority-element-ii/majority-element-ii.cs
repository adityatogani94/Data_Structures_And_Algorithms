public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        var n = nums.Length;

        var candidate1 = 0;
        var count1 = 0;

        var candidate2 = 0;
        var count2 = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            if (candidate1 == num)
            {
                count1++;
            }
            else if (candidate2 == num)
            {
                count2++;
            }
            else if (count1 == 0)
            {
                candidate1 = num;
                count1 = 1;
            }
            else if (count2 == 0)
            {
                candidate2 = num;
                count2 = 1;
            }
            else
            {
                count1--;
                count2--;
            }
        }

        // check
        count1 = 0;
        count2 = 0;

        foreach(var num in nums)
        {
            if (candidate1 == num) count1++;
            else if (candidate2 == num) count2++;
        }

        var result = new List<int>();
        
        if (count1 > n / 3) result.Add(candidate1);
        if (count2 > n / 3) result.Add(candidate2);

        return result.ToArray();
    }
}