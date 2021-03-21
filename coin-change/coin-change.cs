public class Solution 
{
    public int CoinChange(int[] coins, int amount) 
    {
        var dp = new int[amount+1];

        for (int i = 1; i <= amount; i++)
        {
            var local = int.MaxValue;
            for (int j = 0; j < coins.Length; j++)
            {
                var curIndex = i - coins[j];
                if (curIndex >= 0 && dp[curIndex] != -1)
                {
                    local = Math.Min(local, dp[curIndex]); 
                }
            }

            dp[i] = local == int.MaxValue ? -1 : local + 1;
        }

        return dp[amount];
    }
}