/*
Find Max Consecutive Ones
Example 1:
Input: nums = [1,1,0,1,1,1]
Output: 3
Explanation: The first two digits or the last three digits are consecutive 1s. The maximum number of consecutive 1s is 3.

Example 2:
Input: nums = [1,0,1,1,0,1]
Output: 2
*/
public class maxOccOne {
  public int findMaxConsecutiveOne(int [] nums) {
    int currentCount = 0;
    int maxCount = 0;
    for(int i = 0; i < nums.Length; i++) {
      if(nums[i] == 1) {
        currentCount++;
        maxCount = Math.Max(maxCount, currentCount);
      }
      else {
        currentCount = 0;
      }
    }
    return maxCount;
  }
}
