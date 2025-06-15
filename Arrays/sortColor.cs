/*
Sort Colors
Donot use Sort Function
Example 1:
Input: nums = [2,0,2,1,1,0]
Output: [0,0,1,1,2,2]

Example 2:
Input: nums = [2,0,1]
Output: [0,1,2]
*/
public class sortColor {
    public void sortColors(int[] nums) {
        for(int i = 0; i < nums.Length; i++) {
            int temp = 0;
            for(int j = 0; j < nums.Length; j++) {
                if(nums[i] < nums[j]) {
                    temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
        }
        
    }
}
