public class RandomizedSet {

    private Dictionary<int,int> dic;
    private List<int> list;
    private Random random;
    /** Initialize your data structure here. */
    public RandomizedSet() {
        
        dic = new Dictionary<int,int>();
        list = new List<int>();
        random = new Random();
    }
    
    /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
    public bool Insert(int val) {
        
        if(dic.ContainsKey(val))
            return false;
        
        list.Add(val);
        dic.Add(val, list.Count - 1);
        return true;
    }
    
    /** Removes a value from the set. Returns true if the set contained the specified element. */
    public bool Remove(int val) {
        
        if(!dic.ContainsKey(val))
            return false;
        
        //copy the last element to the position where its number will be removed
        int last = list[list.Count - 1];
        int index = dic[val];
        list[index] = last;
        
        // update index for the original last element
        dic[last] = index;
        
        // remove val
        dic.Remove(val);
        list.RemoveAt(list.Count - 1);
        
        return true;
    }
    
    /** Get a random element from the set. */
    public int GetRandom() {
        
        int index = random.Next(0, list.Count);
        return list[index];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */