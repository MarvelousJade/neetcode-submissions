public class Solution {
    public int NumIslands(char[][] grid) {
        int numOfIslands = 0;

        for (int y = 0; y < grid.Length; y++) {
            for (int x = 0; x <grid[y].Length; x++) {
                if (grid[y][x] == '1') {
                    numOfIslands++;
                    Dfs(grid, y ,x);
                }
            }
        }
        return numOfIslands;
    }

    public void Dfs(char[][] grid, int y, int x) {
        bool isOutOfBoundary = 
            y < 0 || 
            y >= grid.Length || 
            x < 0 || 
            x >= grid[0].Length;

        if (isOutOfBoundary) return;
        if (grid[y][x] != '1') return;

        grid[y][x] = '#';

        Dfs(grid, y + 1, x);
        Dfs(grid, y - 1, x);
        Dfs(grid, y, x + 1);
        Dfs(grid, y, x - 1);
    } 
}
