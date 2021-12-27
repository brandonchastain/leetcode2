using DataStructures;

var s = new Solution();
Assert(s.IsPalindrome("A man, a plan, a canal: Panama") == true);
Assert(s.IsPalindrome("race a car") == false);
Assert(s.IsPalindrome("") == true);
Console.WriteLine("All test cases pass!");

static void Assert(bool condition)
{
    if (!condition) throw new Exception("Assert failed");
}

/*

Problem:
125. Valid Palindrome

Description:
A phrase is a palindrome if, after converting all uppercase letters
into lowercase letters and removing all non-alphanumeric characters,
it reads the same forward and backward. Alphanumeric characters
include letters and numbers.

Given a string s, return true if it is a palindrome, or false otherwise.

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
Explanation: s is an empty string "" after removing non-alphanumeric characters.
Since an empty string reads the same forward and backward, it is a palindrome.

Constraints:

    1 <= s.length <= 2 * 105
    s consists only of printable ASCII characters.

Approach 1:

*/
public class Solution
{
    public bool IsPalindrome(string s)
    {
        if (s == null) return true;

        string alphanum = new String(s
            .ToLowerInvariant()
            .Where(c => Char.IsNumber(c) || Char.IsLetter(c))
            .ToArray());
        
        int l = 0;
        int r = alphanum.Length - 1;

        while (l < r)
        {
            if (alphanum[l] != alphanum[r])
            {
                return false;
            }
            l++;
            r--;
        }

        return true;
    }
}