using DataStructures;

var s = new Solution();
Assert(s.TitleToNumber("A") == 1);
Assert(s.TitleToNumber("AB") == 28);
Assert(s.TitleToNumber("ZY") == 701);
Console.WriteLine("All test cases pass!");

static void Assert(bool condition)
{
    if (!condition) throw new Exception("Assert failed");
}

/*

Problem:
171. Excel Sheet Column Number

Description:
Given a string columnTitle that represents the column title as appear in an Excel sheet, return its corresponding column number.

For example:

A -> 1
B -> 2
C -> 3
...
Z -> 26
AA -> 27
AB -> 28 
...

 

Example 1:

Input: columnTitle = "A"
Output: 1

Example 2:

Input: columnTitle = "AB"
Output: 28

Example 3:

Input: columnTitle = "ZY"
Output: 701

 

Constraints:

    1 <= columnTitle.length <= 7
    columnTitle consists only of uppercase English letters.
    columnTitle is in the range ["A", "FXSHRXW"].



Approach 1:
    The column title is a base-26 number that we need to convert to decimal.
    Starting with the last letter (ones place), take each letter, convert it
    to its decimal value, and multiply it by 10 to the i, where i is the current
    "tens place" of the letter.
    (e.g. ones place: i=0, tens place: i=1, hundreds place: i=2, etc)
    The sum total gives us the column number.
*/
public class Solution
{
    public int TitleToNumber(string columnTitle)
    {
        int value = 0;
        int exponent = 0;

        for (int i = columnTitle.Length - 1; i >= 0; i--)
        {
            int digit = (columnTitle[i] - 'A') + 1;
            value += digit * (int)Math.Pow(26, exponent);
            exponent++;
        }

        return value;
    }
}