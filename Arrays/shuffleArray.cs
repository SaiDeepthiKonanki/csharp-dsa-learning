/*
Shuffle the Array
Example 1:
Input: nums = [2,5,1,3,4,7], n = 3
Output: [2,3,5,4,1,7] 
Explanation: Since x1=2, x2=5, x3=1, y1=3, y2=4, y3=7 then the answer is [2,3,5,4,1,7].

Example 2:
Input: nums = [1,2,3,4,4,3,2,1], n = 4
Output: [1,4,2,3,3,2,4,1]

Example 3:
Input: nums = [1,1,2,2], n = 2
Output: [1,2,1,2]
*/
public class shuffleArray {
  public int [] shuffledArray(int [] nums, int n) {
    int [] nums1 = new int[n];
    int [] nums2 = new int[n];
    int [] result = new int[nums.Length];
    for(int i = 0; i < n; i++) {
      nums1[i] = nums[i];
      nums2[i] = nums[i+n];
    }
    for(int i = 0; i < n; i++) {
      result[2*i] = nums1[i];
      result[2*i+1] = nums2[i];
    }
    return result;
  }
}
