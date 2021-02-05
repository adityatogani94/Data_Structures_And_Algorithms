public class ParkingSystem {
    
    int b,m,s;
    public ParkingSystem(int big, int medium, int small) {
        b = big;
        m = medium;
        s = small;
    }
    
    public bool AddCar(int carType) {
        switch(carType)
        {
            case 1: 
                if(b>0)
                {
                    b--;
                    return true;
                }                    
                else
                    return false;
            case 2:    
                if(m>0)
                {
                    m--;
                    return true;
                }                    
                else
                    return false;
            case 3:    
                if(s>0)
                {
                    s--;
                    return true;
                }                    
                else
                    return false;
        }
        return false;
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */