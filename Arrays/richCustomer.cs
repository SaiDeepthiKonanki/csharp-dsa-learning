/*
Richest Customer Wealth
Example 1:
Input: accounts = [[1,2,3],[3,2,1]]
Output: 6
Explanation:
1st customer has wealth = 1 + 2 + 3 = 6
2nd customer has wealth = 3 + 2 + 1 = 6
Both customers are considered the richest with a wealth of 6 each, so return 6.

Example 2:
Input: accounts = [[1,5],[7,3],[3,5]]
Output: 10
Explanation: 
1st customer has wealth = 6
2nd customer has wealth = 10 
3rd customer has wealth = 8
The 2nd customer is the richest with a wealth of 10.

Example 3:
Input: accounts = [[2,8,7],[7,1,3],[1,9,5]]
Output: 17 
*/
public class richCustomer {
    public int maxWealth(int[][] accounts) {
      int [] result = new int[accounts.Length];
      for(int i = 0; i < accounts.Length; i++) {
        result[i] = accounts[i].Sum();
      }
      return result.Max();
    }
}

//Optimised answer: 
public int richCustomer(int[][] accounts) {
    accounts.Max(customer => customer.Sum());
}

