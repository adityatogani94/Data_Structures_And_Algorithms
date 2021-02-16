class Solution
{
    public int RemoveDuplicates(int[] nums) {
        // slow pointer fast pointer concept 
        int pointer = 0;
        int currentNum = int.MinValue;
        // for atmost twice 
        int count = 0;
        for(int i =0 ; i < nums.Length; i++){
            if(currentNum != nums[i]){
                count = 0;
                nums[pointer] = nums[i];
                pointer++;
                count++;
                currentNum = nums[i];
            }else if(currentNum == nums[i]){
                if(count < 2){
                     nums[pointer] = nums[i];
                     pointer++;
                     count++;
                    
                }
                
            }      
        }
        return pointer;
    }
}
