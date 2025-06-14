/*
VALID MOUNTAIN ARRAY
arr.length >= 3
There exists some i with 0 < i < arr.length - 1 such that:
arr[0] < arr[1] < ... < arr[i - 1] < arr[i] 
arr[i] > arr[i + 1] > ... > arr[arr.length - 1]
Example 1:
Input: arr = [2,1]
Output: false

Example 2:
Input: arr = [3,5,5]
Output: false

Example 3:
Input: arr = [0,3,2,1]
Output: true
*/
public class mountainArray {
    public bool validMountainArray(int[] arr) {
        if(arr.Length < 3) return false;
        int i = 0;
        while(i+1 < arr.Length && arr[i] < arr[i+1]) {
            i++;
        }
        while(i == 0 || i == arr.Length - 1) return false;
        while(i+1 < arr.Length && arr[i] > arr[i+1]) {
            i++;
        }
        return i == arr.Length-1;
    }
}
