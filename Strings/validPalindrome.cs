/*
Valid Palindrome
Example 1:
Input: s = "A man, a plan, a canal: Panama"
Output: true
Explanation: "amanaplanacanalpanama" is a palindrome.

Example 2:
Input: s = "race a car"
Output: false
Explanation: "raceacar" is not a palindrome.

Example 3:
Input: s = " "
Output: true
*/
public class validPalindrome {
    public bool isPalindrome(string s) {
        string result = "";
        for(int i = 0; i < s.Length; i++) { 
            char c = s[i];
            if(char.IsLetterOrDigit(c)) {
                result += char.ToLower(c);
            }
        }
        int left = 0;
        int right = result.Length-1;
        while(left < right) {
            if(result[left] != result[right]) {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
