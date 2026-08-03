class Solution {
public:
    int numIslands(vector<vector<char>>& grid) {
        int rows = grid.size();
        int cols = grid[0].size();
        int islands = 0;

       for (int row = 0; row < rows; row++) {
           for (int col = 0; col < cols; col++) {
               if (grid[row][col] == '1') {
                   islands++;
                   bfs(grid, row, col);
               }
           }
       } 

       return islands;
    }

    void bfs(vector<vector<char>>& grid, int startRow, int startCol) {
        int rows = grid.size();
        int cols = grid[0].size();

        int direction[4][2] = {
            {1, 0}, {-1, 0}, {0, 1}, {0, -1}
        };

        queue<pair<int, int>> q;
        q.push({startRow, startCol});
        grid[startRow][startCol] = '0';

        while(!q.empty()) {
            auto [row, col] = q.front();
            q.pop();

            for(int i = 0; i < 4; i++) {
                int nextRow = row + direction[i][0];
                int nextCol = col + direction[i][1];

                if(nextRow >=0 && nextRow < rows && 
                    nextCol >= 0 && nextCol < cols && 
                    grid[nextRow][nextCol] == '1') {

                        grid[nextRow][nextCol] = '0';
                        q.push({nextRow, nextCol});
                    } 
            }
        }
        
    }
};
