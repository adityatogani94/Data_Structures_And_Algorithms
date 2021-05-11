public class Solution {
    public string AddBinary(string a, string b) {
        int i = a.Length -1;
        int j = b.Length -1;
        var result = new StringBuilder();

        int carryover = 0;

        while(i >=0 || j>=0 || carryover==1)
        {    
            var achar =  0;
            var bchar =  0;
                
            if(i>=0)
                achar =  a[i] - '0';
            if(j>=0)
                bchar =  b[j] - '0';

            var bitSum = achar + bchar +carryover;
            if (bitSum >= 2)
            {
                carryover = 1;
                result.Insert(0, bitSum - 2);
            }
            else
            {
                carryover =  0;
                result.Insert(0, bitSum);
            }
            i--;
            j--;
        }       
        return result.ToString();        
    }
}