public class Solution {
    public int NumberOfSteps (int num) {
        int steps = 0;
        while(num > 0)
        {
            if(num%2 == 0)
            {
                num = num/2;
                Console.WriteLine(num);
                steps++;
            }
            else
            {
                Console.WriteLine(num);
                num = num-1;
                steps++;
            }
        }
        return steps;
            
    }
}