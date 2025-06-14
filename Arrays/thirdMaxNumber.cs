/*
Third Maximum Number
Example 1:
Input: nums = [3,2,1]
Output: 1
Explanation:
The first distinct maximum is 3.
The second distinct maximum is 2.
The third distinct maximum is 1.

Example 2:
Input: nums = [1,2]
Output: 2
Explanation:
The first distinct maximum is 2.
The second distinct maximum is 1.
The third distinct maximum does not exist, so the maximum (2) is returned instead.

Example 3:
Input: nums = [2,2,3,1]
Output: 1
Explanation:
The first distinct maximum is 3.
The second distinct maximum is 2 (both 2's are counted together since they have the same value).
The third distinct maximum is 1.
*/
public class thirdMaxNumber {
    public int thirdMax(int[] nums) {
        Array.Sort(nums);
        Array.Reverse(nums);
        int[] newNums = new int[nums.Length];
        int uniqueIndex = 0;
        for (int i = 0; i < nums.Length; i++) {
            bool isDuplicate = false;
            for (int j = 0; j < uniqueIndex; j++) {
                if (newNums[j] == nums[i]) {
                    isDuplicate = true;
                    break;
                }
            }
            if (!isDuplicate) {
                newNums[uniqueIndex] = nums[i];
                uniqueIndex++;
            }
        }
        if (uniqueIndex < 3) {
            return newNums[0];
        } else {
            return newNums[2];
        }
    }
}
