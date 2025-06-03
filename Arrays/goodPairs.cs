/*
Number of Good Pairs
Example 1:
Input: nums = [1,2,3,1,1,3]
Output: 4
Explanation: There are 4 good pairs (0,3), (0,4), (3,4), (2,5) 0-indexed.
*/
public class goodPairs {
    public int noGoodPairs(int[] nums) {
        int count = 0;
        for(int i = 0; i < nums.Length; i++) {
            for(int j = i+1; j < nums.Length; j++) { 
                if(nums[i] == nums[j]) {
                    count++;
                }
            }
        }
        return count;   
    }
}
