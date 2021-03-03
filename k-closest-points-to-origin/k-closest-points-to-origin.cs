public class Solution {
    public int[][] KClosest(int[][] points, int K) {
        
        var sortedList = new SortedList<double, List<int[]>>();
        foreach(var point in points)
        {
            var distance = GetEuclideanDistance(point);
            if(sortedList.ContainsKey(distance))
            {
                sortedList[distance].Add(point); 
            }
            else
            {
                sortedList.Add(distance, new List<int[]> { point });
            }
        }

        var result = new int[K][];
        var sortedValues = sortedList.Values;
        for(int i=0; i<K; i++)
        {
            if(sortedValues[i].Count == 1)
            {
                result[i] = sortedValues[i][0];
            }
            else
            {
                foreach(var p in sortedValues[i])
                {
                    result[i] = p;
                    i++;
                }
            }
        }
        return result;
    }

    //calulate distance to origin
    //dist((x, y), (a, b)) = √(x - a)² + (y - b)²
    private double GetEuclideanDistance(int[] a)
    {
        var d = (a[0] * a[0]) + (a[1] * a[1]);
        return Math.Sqrt(d);
    }
}