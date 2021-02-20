public class Solution {
    public int MaximumUnits(int[][] boxTypes, int truckSize) {
        Queue<int[]> priority = new Queue<int[]>();
        Array.Sort(boxTypes, (a,b) => b[1] - a[1]);
        int Units = 0;
        foreach(int[] boxType in boxTypes)
        {
            Console.WriteLine(boxType[0] + " " + boxType[1]);
            priority.Enqueue(boxType);
        }
        
        while(truckSize != 0 && priority.Count != 0)
        {
            int[] curr = priority.Dequeue();
            if(curr[0] <= truckSize)
            {
                truckSize = truckSize - curr[0];
                Units = Units + (curr[0] * curr[1]);
            }
            else if(curr[0] > truckSize)
            {
                Units = Units + (truckSize * curr[1]);
                truckSize = 0;
            }
        }
        return Units;
    }
}