public class UndergroundSystem 
{
    Dictionary<string, List<int>> result;
    Dictionary<int, CheckIn> checkIns;

    public UndergroundSystem()
    {
        result = new Dictionary<string, List<int>>();
        checkIns = new Dictionary<int, CheckIn>();
    }
    
    public void CheckIn(int id, string stationName, int t) 
    {
        checkIns[id] = new CheckIn() {stationName = stationName, time = t};
    }
    
    public void CheckOut(int id, string stationName, int t) 
    {
        var checkInInfo = checkIns[id];
        string key = checkInInfo.stationName + ":" + stationName;
        int duration = t - checkInInfo.time;
        if(!result.ContainsKey(key))
            result[key] = new List<int>();
        result[key].Add(duration);
        checkIns.Remove(id);
    }
    
    public double GetAverageTime(string startStation, string endStation) 
    {
        string key = startStation + ":" + endStation;
        return (double) (result[key].Sum()) / (double) (result[key].Count); 
        
    }
}

public class CheckIn
{
    public string stationName;
    public int time;
}

/**
 * Your UndergroundSystem object will be instantiated and called as such:
 * UndergroundSystem obj = new UndergroundSystem();
 * obj.CheckIn(id,stationName,t);
 * obj.CheckOut(id,stationName,t);
 * double param_3 = obj.GetAverageTime(startStation,endStation);
 */