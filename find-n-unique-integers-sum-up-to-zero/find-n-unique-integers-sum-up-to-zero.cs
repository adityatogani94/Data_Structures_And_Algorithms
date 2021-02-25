public class Solution
    {
        public int[] SumZero(int n)
        {
            IList<int> res = new List<int>(n);
            if (n % 2 == 1)
            {
                res.Add(0);
                n--;
            }

            for (int i = 1; i <= n /2; i++)
            {
                res.Add(i);
                res.Add(-i);
            }

            return res.ToArray();
        }
    }