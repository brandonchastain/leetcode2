// See https://aka.ms/new-console-template for more information
var s = new Solution();
Assert(s.LongestPalindrome("babad") == "bab");
Assert(s.LongestPalindrome("cbbd") == "bb");
Assert(s.LongestPalindrome("helloworld") == "owo");
Assert(s.LongestPalindrome("abcdefg") == "a");
Console.WriteLine("Success!");

static void Assert(bool condition)
{
    if (!condition) throw new Exception("Assert failed");
}

/*
5. Longest Palindromic Substring

Given a string s, return the longest palindromic substring in s.

Example 1:
    Input: s = "babad"
    Output: "bab"
    Explanation: "aba" is also a valid answer.

Example 2:
    Input: s = "cbbd"
    Output: "bb"

Constraints:
    1 <= s.length <= 1000
    s consist of only digits and English letters.

Approach 1:
    For i = n to 2, check each substring of length i.
    The first palindrome encountered must be the longest one.
    Time: O(n^3) because we check up to n/2 substrings for
          being a palindrome, n times.
          Checking a substring for a palindrome O(n).
*/
public class Solution {
    public string LongestPalindrome(string s) {
        if (s == string.Empty) return s;

        for (int length = s.Length; length > 1; length--)
        {
            for (int start = 0; start + length <= s.Length; start++)
            {
                if (IsPalindrome(s, start, length))
                {
                    return s.Substring(start, length);
                }
            }
        }

        return s[0].ToString();
    }

    private bool IsPalindrome(string s, int start, int length)
    {
        int l = start;
        int r = start + length - 1;

        while (l < r)
        {
            if (s[l] != s[r])
            {
                return false;
            }

            l++;
            r--;
        }

        return true;
    }


}