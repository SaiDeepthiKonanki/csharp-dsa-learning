/*
Reshape the Matrix
Example 1:
Input: mat = [[1,2],[3,4]], r = 1, c = 4
Output: [[1,2,3,4]]

Example 2:
Input: mat = [[1,2],[3,4]], r = 2, c = 4
Output: [[1,2],[3,4]]
*/
public class reshapeMatrix {
  public int [][] matrixReshape(int [][] mat, int r, int c) {
    if(mat.Length * mat[0].Length != r * c) {
      return mat;
    }
    int [][] result = new int[r][];
    for(int i = 0; i < r; i++) {
      result[i] = new int[c];
    }
    int row = 0, col = 0;
    for(int i = 0; i < mat.Length; i++) {
      for(int j = 0; j < mat[0].Length; j++) {
        result[row][col] = mat[i][j];
        col++;
        if(col == c) {
          col = 0;
          row++;
        }
      }
    }
    return result;
  }
}
