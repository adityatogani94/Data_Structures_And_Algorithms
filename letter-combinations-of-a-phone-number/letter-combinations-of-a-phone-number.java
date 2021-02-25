class Solution {
    public List<String> letterCombinations(String digits) {
        List<String> ans = new ArrayList<String>();
        if(digits==null||digits.length()==0) return ans;
        char[][] map = new char[8][];
        map[0]="abc".toCharArray();
        map[1]="def".toCharArray();
        map[2]="ghi".toCharArray();
        map[3]="jkl".toCharArray();
        map[4]="mno".toCharArray();
        map[5]="pqrs".toCharArray();
        map[6]="tuv".toCharArray();
        map[7]="wxyz".toCharArray();

        char[] input = digits.toCharArray();
        ans.add("");
        for(char c:input)
            ans=expand(ans,map[c-'2']);
        return ans;
    }
    
    private List<String> expand(List<String> l,char[] arr)
    {
        List<String> next = new ArrayList<String>();
        for(String s:l)
            for(char c:arr)
                next.add(s+c);
        return next;
    }
}