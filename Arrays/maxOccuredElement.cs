/*
Majority Element
The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

Example 1:
Input: nums = [3,2,3]
Output: 3

Example 2:
Input: nums = [2,2,1,1,1,2,2]
Output: 2
*/
public class maxOccuredElement {
    public int majorityElement(int[] nums) {
        int halfArray = nums.Length/2;
        int count = 0;
        for(int i = 0; i < nums.Length; i++) {
            count = 0;
            for(int j = 0; j < nums.Length; j++) {
                if(nums[j] == nums[i]) {
                    count++;
                }
            }
            if(count > halfArray) {
                return nums[i];
            }
        }  
        return -1;
    }
}
