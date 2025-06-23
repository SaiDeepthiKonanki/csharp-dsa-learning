/*
Detect Capital
Example 1:
Input: word = "USA"
Output: true

Example 2:
Input: word = "FlaG"
Output: false
*/
public class detectCapital {
  public bool isCaptial(string word) {
    return word == word.ToUpper() || word == word.ToLower() || (char.IsUpper(word[0]) && word.Substring(1) == word.Substring(1).ToLower());
  }
}
