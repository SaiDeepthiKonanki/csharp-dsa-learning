/*
Intersection of Two Arrays
Example 1:
Input: nums1 = [1,2,2,1], nums2 = [2,2]
Output: [2]

Example 2:
Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
Output: [9,4]
Explanation: [4,9] is also accepted.
*/
public class intersectionArray {
  public int [] intersectedArray(int [] nums1, int [] nums2) {
    int [] ans = new int [Math.Min(nums1.Length, nums2.Length)];
    int index;
    for(int i = 0; i < nums1.Length; i++) {
      int current = nums1[i];
      for(int j = 0; j < nums2.Length; j++) {
        if(current == nums2[j]) {
          bool alreadyExists = false;
          for(int k = 0; k < index; k++) {
            if(ans[k] == current) {
              alreadyExists = true;
              break;
            }
          }
          if(!alreadyExists) {
            ans[index] = current;
            index++;
          }
          break;
        }
      }
    }
    int result [] = new int[index];
    for(int i = 0; i < index; i++) {
      result[i] = ans[i];
    }
  }
}
