/*
How Many Numbers Are Smaller Than the Current Number
Example 1:
Input: nums = [8,1,2,2,3]
Output: [4,0,1,1,3]
Explanation: 
For nums[0]=8 there exist four smaller numbers than it (1, 2, 2 and 3). 
For nums[1]=1 does not exist any smaller number than it.
For nums[2]=2 there exist one smaller number than it (1). 
For nums[3]=2 there exist one smaller number than it (1). 
For nums[4]=3 there exist three smaller numbers than it (1, 2 and 2).

Example 2:
Input: nums = [6,5,4,8]
Output: [2,1,0,3]

Example 3:
Input: nums = [7,7,7,7]
Output: [0,0,0,0]
*/
public class countSmallNoArray {
  public int [] countSmallNoCurrentArray(int [] nums) {
    int [] result = new int[nums.Length];
    for(int i = 0; i < nums.Length; i++) {
      int count = 0;
      for(int j = 0; j < nums.Length; j++) {
        if(nums[j] < nums[i]) {
          count++;
        }
      }
      result[i] = count;
    }
    return result;
  }
}
