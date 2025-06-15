/*
Set Zeros
Example 1:
Input: matrix = [[1,1,1],[1,0,1],[1,1,1]]
Output: [[1,0,1],[0,0,0],[1,0,1]]

Example 2:
Input: matrix = [[0,1,2,0],[3,4,5,2],[1,3,1,5]]
Output: [[0,0,0,0],[0,4,5,0],[0,3,1,0]]
*/
public class setZero {
    public void setZeroes(int[][] matrix) {
        int row = matrix.Length;
        int col = matrix[0].Length;
        int [][] newMatrix = new int[row][];
        for(int i = 0; i < row; i++) {
            newMatrix[i] = new int[col];
            for(int j = 0 ; j < col; j++) {
                newMatrix[i][j] = matrix[i][j];
            }
        }
        for(int i = 0; i < row; i++) {
            for(int j = 0; j < col; j++) {
                if(matrix[i][j] == 0) {
                    for(int k = 0; k < row; k++) {
                        newMatrix[k][j] = 0;
                    }
                    for(int l = 0; l < col; l++) {
                        newMatrix[i][l] = 0;
                    }
                }
            }
        }
        for(int i = 0; i < row; i++) {
            for(int j = 0; j < col; j++) {
                matrix[i][j] = newMatrix[i][j];
            }
        }
    }
}
