public class Solution : Relation {
    public int FindCelebrity(int n) {
        
        int candidate = 0;
        
        for(int i = 1; i < n; i++)
        {
            // each check will flush out one people who can't be the celebrity.
            // ture: candidate knows i, then candidate can't be celebrity, i could be the celebrity 
            // false: candidate doesn't know i, then i can't the celebrity, candidate could be the celebrity
            if(Knows(candidate, i))
                candidate = i;
        }
        
        for(int j = 0; j < n; j++)
        {
            // The first loop guarantees candidate doesn't know anyone after him/her
            
            // Check people who is before candidate
            if(j < candidate && (Knows(candidate, j) || !Knows(j, candidate)))
                return -1;
            
            // Check people who is after candidate
            if(j > candidate && !Knows(j, candidate))
                return -1;
        }
        
        return candidate;
    }
}