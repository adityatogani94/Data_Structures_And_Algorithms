public class Solution {
        public int MaxCoins(int[] piles) {
        Array.Sort(piles);
        int coins = 0;
        for(int j= 0, i = piles.Length - 2; j < piles.Length / 3; j++, i-=2)
            coins += piles[i];
        return coins;
    }
}