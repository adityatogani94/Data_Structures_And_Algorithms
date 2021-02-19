public class Solution {
    public int FirstUniqChar(string s) {
	var set = new HashSet<char>();
	var set2 = new HashSet<char>();
	foreach (var c in s) {
		if (set.Contains(c)) set2.Add(c);
		set.Add(c);
	}
	for (var i = 0; i < s.Length; i++)
		if (!set2.Contains(s[i]))
			return i;
	return -1;
}
}