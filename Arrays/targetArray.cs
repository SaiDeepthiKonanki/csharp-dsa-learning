/*
Create Target Array in the Given Order
Example 1:
Input: nums = [0,1,2,3,4], index = [0,1,2,2,1]
Output: [0,4,1,3,2]
Explanation:
nums       index     target
0            0        [0]
1            1        [0,1]
2            2        [0,1,2]
3            2        [0,1,3,2]
4            1        [0,4,1,3,2]

Example 2:
Input: nums = [1,2,3,4,0], index = [0,1,2,3,0]
Output: [0,1,2,3,4]
Explanation:
nums       index     target
1            0        [1]
2            1        [1,2]
3            2        [1,2,3]
4            3        [1,2,3,4]
0            0        [0,1,2,3,4]
*/
public class targetArray {
    public int[] createTargetArray(int[] nums, int[] index) {
        int [] result = new int[index.Length];
        if(index.Length == nums.Length) {
            for(int i = 0; i < index.Length; i++) {
                for (int j = i; j > index[i]; j--) {
                    result[j] = result[j - 1];
                }
                result[index[i]] = nums[i];
            }
        } 
        return result;       
    }
}
