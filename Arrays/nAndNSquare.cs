/*
Check if N and its Double Exists
Example 1:
Input: arr = [10,2,5,3]
Output: true
Explanation: For i = 0 and j = 2, arr[i] == 10 == 2 * 5 == 2 * arr[j]

Example 2:
Input: arr = [3,1,7,11]
Output: false
Explanation: There is no i and j that satisfy the conditions.
*/
public class nAndNSquare {
    public bool checkIfExist(int[] arr) {
        for(int i = 0; i < arr.Length; i++) {
            for(int j = 0; j < arr.Length; j++) {
                if(i != j && arr[i] == 2*arr[j]) {
                    return true;
                }
            }
        }
        return false;
    }
}
