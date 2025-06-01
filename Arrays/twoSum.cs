/*
Two Sum
Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
*/
public class twoSum {
  public int [] twoSumCalc(int [] nums, int target) {
    for(int i = 0; i < nums.Length; i++) {
      for(int j = i+1; j < nums.Length; j++) {
        if(nums[i] + nums[j] == target) {
          return new int []{i,j};
        }
      }
    }
    return new int []{-1,-1};
  }
}
