public class Solution {
    public void Rotate(int[][] matrix) {
        int l = 0, r = matrix.Length - 1;

        while (l < r) {
            int limit = r - l;

            for (int i = 0; i < limit; i++) {
                (int top, int bottom) = (l, r);

                int topLeft = matrix[top][l + i];

                matrix[top][l + i] = matrix[bottom - i][l];
                matrix[bottom - i][l] = matrix[bottom][r - i];
                matrix[bottom][r - i] = matrix[top + i][r];
                matrix[top + i][r] = topLeft;
            }

            l++;
            r--;
        }
    }
}
