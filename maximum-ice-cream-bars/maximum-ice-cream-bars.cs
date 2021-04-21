public class Solution {
    public int MaxIceCream(int[] costs, int coins) {
        Array.Sort(costs);
        
        int noOfIcecreams = 0;
        foreach(int i in costs)
        {
            Console.WriteLine(i);
            if(coins != 0 && i<=coins)
            {
                coins = coins - i;
                noOfIcecreams++;
            }
            
        }
        return noOfIcecreams;
    }
}