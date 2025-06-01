/*
Concatenation of an Array
Input: nums = [1,2,1]
Output: [1,2,1,1,2,1]
Explanation: The array ans is formed as follows:
- ans = [nums[0],nums[1],nums[2],nums[0],nums[1],nums[2]]
- ans = [1,2,1,1,2,1]
*/
public class concatArray {
  public int [] concatenatedArray(int [] nums) {
    int [] ans = new int [2 * nums.Length];
    for(int i = 0; i < nums.Length; i++) {
      ans[i] = nums[i];
      ans[i + nums.Length] = nums[i];
    }
    return ans;
  }
}
