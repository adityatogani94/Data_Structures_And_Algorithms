public class Solution {
    public int SubtractProductAndSum(int n) {
        List<int> a = new List<int>();
        int b = 0;
        while(n!=0)
        {
            b = n%10;
            n = n-b;
            n = n/10;
            a.Add(b);
            Console.WriteLine(n);
        }
        int prod = 1;
        int sum = 0;
        for(int i=0; i<=a.Count()-1; i++)
        {
            Console.WriteLine(a[i]);
            prod = a[i]*prod;
            sum = a[i]+sum;
        }
        return prod-sum;
    }
}