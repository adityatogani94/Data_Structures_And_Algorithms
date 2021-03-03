public class Solution {
    public IList<int> PartitionLabels(string S) {
        int[] last_indices = new int[26];
        for(int i = 0; i < S.Length; i++)
        {
            last_indices[S[i] - 'a'] = i;
        }
        
        List<int> answer = new List<int>();
        int start = 0;
        int end = 0;
        for(int i = 0; i < S.Length; i++)
        {
            end = Math.Max(end, last_indices[S[i] - 'a']);
            if(i == end)
            {
                answer.Add(end - start + 1);
                start = end + 1;
            }
        }
        return answer;
    }
}