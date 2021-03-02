public class Solution {
    public bool IsRobotBounded(string instructions) {
        
        int startX = 0;
        int startY = 0;
        int direction = 0; // 0->N 1->E 2->S 3->W
        
        int[,] directions = new int[,] { {1,0}, {0,1}, {-1,0}, {0,-1} };
        
        foreach(char instruction in instructions)
        {
            if(instruction == 'G')
            {
                startX = startX + directions[direction,0];
                startY = startY + directions[direction,1];
            }
            else if(instruction == 'L')
            {
                direction = (direction == 0) ? 3 : direction - 1;
            }
            else if(instruction == 'R')
            {
                direction = (direction + 1) % 4;
            }
        }
        
        if(startX==0 && startY==0)
        {
            return true;
        }
        else if(direction == 0)
        {
            return false;
        }
        return true;
    }
}