public class Solution
{
    public int FindLHS(int[] nums)
    {
        int res = 0;
        IDictionary<int, int> val2Count = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (!val2Count.ContainsKey(num))
            {
                val2Count[num] = 0;
            }

            val2Count[num]++;

            if (val2Count.ContainsKey(num - 1))
            {
                res = Math.Max(res, val2Count[num] + val2Count[num - 1]);
            }

            if (val2Count.ContainsKey(num + 1))
            {
                res = Math.Max(res, val2Count[num] + val2Count[num + 1]);
            }
        }

        return res;
    }
}