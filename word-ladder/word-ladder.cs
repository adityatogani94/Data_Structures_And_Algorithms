public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        if (beginWord == null || endWord == null || wordList == null || wordList.Count == 0)
            {
                return 0;
            }

            var dict = new HashSet<string>(wordList);
            if (!dict.Contains(endWord))
            {
                return 0;
            }

            var queue = new Queue<string>();

            queue.Enqueue(beginWord);

            // mark visit
            dict.Remove(beginWord);

            int depth = 0;

            while (queue.Count > 0)
            {
                int levelCount = queue.Count;
                depth++;
                // Check each adjacent string
                for (int i = 0; i < levelCount; i++)
                {
                    var current = queue.Dequeue();
                    var charArray = current.ToCharArray(); 

                    // base case
                    if(current.CompareTo(endWord) == 0)
                    {
                        return depth; 
                    }

                    // go over each char in the word first                    
                    for (int index = 0; index < charArray.Length; index++)
                    {
                        // replace by all possible neighbors
                        for (char c = 'a'; c <= 'z'; c++)
                        {
                            if (c == current[index])
                            {
                                continue;
                            }

                            var tmp = charArray[index];
                            charArray[index] = c;
                            var next = new string(charArray);                             

                            if (dict.Contains(next))
                            {
                                queue.Enqueue(next);
                                dict.Remove(next);
                            }

                            //backtracking
                            charArray[index] = tmp;
                        }
                    }                    
                }                
            }

            return 0;
    }
}