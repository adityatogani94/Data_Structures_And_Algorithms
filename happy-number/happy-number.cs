public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> seen = new HashSet<int>();
        while(n != 1) {
            int newN = 0;
            List<int> numList = new List<int>();
            while (n > 0) {
                numList.Add(n % 10);
                n = n / 10;
            }

            foreach(int i in numList) {
                newN = newN + i*i;
            }
            if(seen.Contains(newN)) {
                return false;
            }
            seen.Add(newN);
            n=newN;
        }
        return true;
    }
}