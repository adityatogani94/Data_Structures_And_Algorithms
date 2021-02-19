public class Solution {
    public string RemoveDuplicates(string s, int k) {
	var stack = new Stack<(char C, int F)>();

	foreach (var c in s.ToCharArray()) {
		if (stack.Count == 0) {
			stack.Push((c, 1));
			continue;
		}

		var peek = stack.Peek();
		if (peek.C != c) {
			stack.Push((c, 1));
			continue;
		}
		stack.Pop();
		if (peek.F < k - 1) {
			stack.Push((peek.C, peek.F + 1));
		}
	}

	var str = new StringBuilder();
	while (stack.Count > 0) {
		var (c, f) = stack.Pop();
		for (var i = 0; i < f; i++) {
			str.Append(c);
		}
	}

	return new string(str.ToString().Reverse().ToArray());
}
}