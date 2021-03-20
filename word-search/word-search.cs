/*
    Time: O(m*n*4^l) where l = word.Length
    Space: O(m*n + l)
*/

public class Solution {
    public bool Exist(char[][] board, string word) {
        
        if(board == null || board[0].Length == 0)
            return false;
        if(word == "")
            return true;
        
        for(int i = 0; i < board.Length; i++)
        {
            for(int j = 0; j < board[0].Length; j++)
            {
                if(WordSearch(board, word, i, j, 0))
                    return true;
            }        
        }
        
        return false;
    }
    
    private bool WordSearch(char[][] board, string word, int i, int j, int idx)
    {
        if(idx == word.Length)
            return true;
        if(i < 0 || i >= board.Length || j < 0 || j >= board[0].Length || word[idx] != board[i][j])
            return false;
        
        board[i][j] = '#'; // visted
        
        bool find = WordSearch(board, word, i - 1, j, idx + 1)
            || WordSearch(board, word, i + 1, j, idx + 1)
            || WordSearch(board, word, i, j - 1, idx + 1)
            || WordSearch(board, word, i, j + 1, idx + 1);
        
        board[i][j] = word[idx]; // recover
        
        return find;
    }
}