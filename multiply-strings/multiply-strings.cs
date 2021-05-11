public class Solution {
    public string Multiply(string num1, string num2) {
    int m = num1.Length;
    int n = num2.Length;
    
    int[] ans = new int[m+n];

    for(int i = m-1; i >= 0; i--){
        for( int j = n-1; j >= 0 ; j--){
            int multiply = (num1[i]-'0')*(num2[j]-'0');
            int sum = multiply + ans[i+j+1];
            ans[i+j+1] = sum%10;
            ans[i+j] += sum/10;
        }
    }
    
    StringBuilder sb = new StringBuilder();
    foreach( var p in ans){
        if(!(p==0 && sb.Length == 0))
        {
            sb.Append(p);
        }
    }
    
    return (sb.Length == 0)?"0":sb.ToString();
    
    }
}