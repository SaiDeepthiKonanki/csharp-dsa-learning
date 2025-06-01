/*
Running Sum of 1D Array:
Input: nums = [1,2,3,4]
Output: [1,3,6,10]
Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].
*/
public class runningSumof1DArray {
  public int[] runningSum(int [] nums) {
    int sum = 0;
    for(int i = 0; i < nums.Length; i++) {
      sum += nums[i];
      nums[i] = sum;
    }
    return nums;
  }
}
