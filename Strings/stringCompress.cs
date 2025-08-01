/*
String Compress
Example 1:
Input: chars = ["a","a","b","b","c","c","c"]
Output: Return 6, and the first 6 characters of the input array should be: ["a","2","b","2","c","3"]
Explanation: The groups are "aa", "bb", and "ccc". This compresses to "a2b2c3".

Example 2:
Input: chars = ["a"]
Output: Return 1, and the first character of the input array should be: ["a"]
Explanation: The only group is "a", which remains uncompressed since it's a single character.

Example 3:
Input: chars = ["a","b","b","b","b","b","b","b","b","b","b","b","b"]
Output: Return 4, and the first 4 characters of the input array should be: ["a","b","1","2"].
Explanation: The groups are "a" and "bbbbbbbbbbbb". This compresses to "ab12".
*/
public class stringCompress {
    public int compress(char[] chars) {
        int read = 0;
        int write = 0;
        while(read < chars.Length) {
            char currentChar = chars[read];
            int count = 0;
            while(read < chars.Length && chars[read] == currentChar) {
                count++;
                read++;
            }
            chars[write++] = currentChar;
            if(count > 1) {
                foreach(char digit in count.ToString())
                    chars[write++] = digit;
            }
        }
        return write; 
    }
}
