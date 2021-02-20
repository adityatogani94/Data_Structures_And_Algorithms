public class Solution {
    public IList<string> BuildArray(int[] target, int n) {
        List<string> result = new List<string>();
        int index = 1;
        for(int i = 0; i < target.Length; i++)
        {
            if(index == target[i])
            {
                result.Add("Push");
                index++;
            }
            else
            {
               while(index != target[i])
               {
                   result.Add("Push");
                   result.Add("Pop");
                   index++;
               }
               result.Add("Push");
               index++;
            }
        }
        return result;
    }
}