public class Solution {
    public int maxRotateFunction(int[] A) {
        int n = A.length;
        int sum = 0;
        int final_ans = 0;
        for(int i = 1; i <= n; i++)
        {
            sum = 0;
            rotate(A,1);
            for(int j=0;j < A.length; j++)
            {
                sum = sum + (j * A[j]);
            }
            if(i==1)
            {
                final_ans = sum;
            }
            if(sum >= 0 && final_ans >= 0)
            {
                if(sum >= final_ans)
                {
                    final_ans = sum;
                }
            }
            else if(sum > 0 && final_ans < 0)
            {
                final_ans = sum;
            }
            else if(sum < 0 && final_ans >= 0)
            {
                final_ans = final_ans;
            }
            else if(sum < 0 && final_ans < 0)
            {
                if(Math.abs(sum) <= Math.abs(final_ans))
                {
                    final_ans = sum;
                }
            }
            
        }
        return final_ans;
    }
    public void rotate(int[] nums, int k) {
        for(int i=1; i<=k; i++)
        {
            int temp = nums[nums.length-1];
            for(int j=nums.length-1; j>=1; j--)
            {
                nums[j] = nums[j-1]; 
            }
            nums[0] = temp;
        }
    }
}