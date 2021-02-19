public class Trie {
    const int ALPHABET_SIZE = 26;
    public Node root;
    /** Initialize your data structure here. */
    public Trie() {
        root = new Node();
    }
    
    /** Inserts a word into the trie. */
    public void Insert(string word) {
        Node curr = root;
        char[] chars = word.ToCharArray();
        for(int i=0; i < chars.Length; i++)
        {
            if(curr.children.ContainsKey(chars[i]))
            {
                if(i==chars.Length-1)
                {
                    curr.children[chars[i]].isCompleteWord = true;
                }
                curr = curr.children[chars[i]];
            }
            else
            {
                curr.children.Add(chars[i],new Node());
                if(i==chars.Length-1)
                {
                    curr.children[chars[i]].isCompleteWord = true;
                }
                curr = curr.children[chars[i]];
            }
        }
    }
    
    /** Returns if the word is in the trie. */
    public bool Search(string word) {
        Node curr = root;
        char[] chars = word.ToCharArray();
        for(int i=0; i < chars.Length; i++)
        {
            if(curr.children.ContainsKey(chars[i]))
            {
                curr = curr.children[chars[i]];
            }
            else
            {
                return false;
            }
        }
        if(curr.isCompleteWord)
        {
            return true;
        }
        return false;
    }
    
    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix) {
        Node curr = root;
        char[] chars = prefix.ToCharArray();
        for(int i=0; i < chars.Length; i++)
        {
            if(curr.children.ContainsKey(chars[i]))
            {
                curr = curr.children[chars[i]];
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}

public class Node{
    public Dictionary<char,Node> children;
    public bool isCompleteWord;
    
    public Node()
    {
        children = new Dictionary<char,Node>();
        isCompleteWord = false;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */