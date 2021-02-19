public class Solution {
        public int[] Intersect(int[] nums1, int[] nums2) {
        //Edge cases
        if(nums1 == null || nums2 == null){
            return new int[0];
        }

        //Index all entries from shorter array in a map
        Dictionary<int, int> map = new Dictionary<int, int>();
        for(int i = 0; i < nums1.Length; i++){
            if(map.ContainsKey(nums1[i])){
                map[nums1[i]]++;
            }else{
                map.Add(nums1[i], 1);
            }
        }
        
        //Find intersection between map and second array
        int count = 0;
        List<int> result = new List<int>();
        for(int j = 0; j < nums2.Length; j++){
            map.TryGetValue(nums2[j], out count);
            if(count > 0){
                    map[nums2[j]]--;
                    result.Add(nums2[j]);    
            }
        }
        
        return result.ToArray();
    }
}