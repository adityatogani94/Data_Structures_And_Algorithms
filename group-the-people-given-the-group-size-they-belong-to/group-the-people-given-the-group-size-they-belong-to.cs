public class Solution {
    public IList<IList<int>> GroupThePeople(int[] groupSizes) 
    {
        var sizeToGroup = new Dictionary<int, IList<IList<int>>>();
        for(int i = 0; i < groupSizes.Length; i++)
        {
            var size = groupSizes[i];
            if(!sizeToGroup.ContainsKey(size)) 
                sizeToGroup[size] = new List<IList<int>>();
            
            var count = sizeToGroup[size].Count;
            for(int j = 0; j <= count; j++)
            {
                if(j == count)
                {
                    sizeToGroup[size].Add(new List<int>() {i});
                }
                else
                {
                    if(sizeToGroup[size][j].Count < size)
                    {
                        sizeToGroup[size][j].Add(i);
                        break;
                    }
                }
            }
        }
        
        var result = new List<IList<int>>();
        foreach(var list in sizeToGroup.Values)
            result.AddRange(list);
        
        return result;
    }
}