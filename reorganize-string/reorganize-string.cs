public class Solution {
    public string ReorganizeString(string S)
        {
            // linked list to store our final result (Due to performance reason this should not be a string, StringBuilder or a List<char>)
            LinkedList<char> list = new LinkedList<char>();
            list.AddFirst('~'); // add a dummy node to avoid dealing with prev node being null

            // return if input string is null or empty
            if (string.IsNullOrWhiteSpace(S))
                return list.ToString();

            // hash map to hold each unique chars with their respective counts
            Dictionary<char, int> dict = new Dictionary<char, int>();

            // populate the dictionay/hashmap
            foreach (var ch in S)
            {
                if (!dict.ContainsKey(ch))
                    dict.Add(ch, 1);
                else
                    dict[ch]++;
				
				// return if the count for any char is greater than half of the string
				if(dict[ch] > (S.Length+1)/2)
                    return "";
            }

            // create a clone of the above dictionary (this is because C# doesnt allow modifying the same dictionary that we are iterating thru)
            Dictionary<char, int> dict2 = new Dictionary<char, int>(dict);

            // now iterate until all the chars in the input string are accounted for
            int cnt = S.Length;
            while (cnt > 0)
            {
                // on each iteration append each key (unique char) to the final result (to minimize any dupe/collision)
                foreach (var ch in dict.Keys)
                {
                    // if for a given key (char) there is no more to assign then skip/continue:
                    if (dict2[ch] <= 0)
                        continue;

                    // if the current char is the same as the last inserted char - do the following
                    if (list.Last.Value == ch)
                    {
                        bool found = false;
                        LinkedListNode<char> current = list.Last;

                        // walk up the list (until the dummy first node) and find a spot where both next/prev values are different than the current char
                        while (current.Value != '~')
                        {
                            current = current.Previous;
                            if (current.Value != ch && current.Next.Value != ch)
                            {
                                found = true;
                                list.AddAfter(current, ch);

                                // if found break to avoid further cycles
                                break;
                            }
                        }

                        // if could not find a valid (non-dupe) spot - return immediately
                        if (!found)
                            return "";
                    }
                    else // else if no dupe found keep adding to the last node
                        list.AddLast(ch);

                    // reduce the counter for each char once its accounted for
                    dict2[ch]--;
                    // reduce the cnt value as we are adding new chars to the result
                    cnt--;
                }
            }

            // return the list as a string after removing the first dummy node
            list.RemoveFirst();
            return string.Join("", list.ToList());
        }
}