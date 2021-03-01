public class Solution {
    public int CalculateTime(string keyboard, string word) {
        int currIndex = 0;
        int prevIndex = 0;
        int totalTime = 0;
        foreach(char s in word)
        {
            currIndex = keyboard.IndexOf(s);
            totalTime = totalTime + Math.Abs(currIndex - prevIndex);
            prevIndex = currIndex;
        }
        
        return totalTime;
    }
}