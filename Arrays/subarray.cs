/* 
Subarray Sum Equals K
Example 1:
Input: nums = [1,1,1], k = 2
Output: 2
  
Example 2:
Input: nums = [1,2,3], k = 3
Output: 2
*/
public class subarray{
  public int subarraySum(int [] nums, int k) {
    int count = 0;
    for(int start = 0; start < nums.Length; start++) {
      int sum = 0;
      for(int end = start; end < nums.Length; end++) {
        sum += nums[j];
        if(sum == k) {
          count++;
        }
      }
    }
    return count;
  }
}
