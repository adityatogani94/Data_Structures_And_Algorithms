public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        bool[] roomsVisited = new bool[rooms.Count];
        roomsVisited[0] = true;
        Stack<int> st = new Stack<int>();
        st.Push(0);
        
        while(st.Count != 0)
        {
            int currNode = st.Pop();
            List<int> currList = (List<int>)rooms[currNode];
            foreach(int room in currList)
            {
                if(!roomsVisited[room])
                {
                    roomsVisited[room] = true;
                    st.Push(room);
                }
            }
        }
        
        foreach(bool roomVisited in roomsVisited)
        {
            if(!roomVisited)
            {
                return false;
            }
        }
        return true;
    }
}