public class Solution {
    public string RemoveDuplicates(string S) {
	var stack = new Stack<char>();
	var chars = S.ToCharArray();

	foreach (var c in chars) {
		if (stack.Count == 0) {
			stack.Push(c);
			continue;
		}

		if (stack.Peek() == c)
			stack.Pop();
		else
			stack.Push(c);
	}

	var result = new char[stack.Count];
	for (var i = stack.Count - 1; i >= 0; i--)
		result[i] = stack.Pop();

	return new string(result);
    }
}