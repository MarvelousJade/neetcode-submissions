class Solution {
public:
    int ROWS, COLS;
    bool exist(vector<vector<char>>& board, string word) {
        ROWS = board.size(), COLS = board[0].size();

        for (int r = 0; r < ROWS; r++) {
            for (int c = 0; c < COLS; c++) {
                if (dfs(board, word, 0, r, c)) {
                    return true;
                };
            }
        }
        return false;
    }

    bool dfs(vector<vector<char>>& board, string& word, int i, int r, int c) {
        if (i == word.size()) return true;

        if (r < 0 || r >= ROWS || c < 0 || c >= COLS || 
            word[i] != board[r][c] || board[r][c] == '#') {
            return false;
        }

        board[r][c] = '#';
        bool res =  dfs(board, word, i + 1, r + 1, c) || 
                    dfs(board, word, i + 1, r - 1, c) || 
                    dfs(board, word, i + 1, r, c + 1) || 
                    dfs(board, word, i + 1, r, c - 1); 
        board[r][c] = word[i];
        
        return res;
    }
};
