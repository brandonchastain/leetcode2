using DataStructures;

var s = new Solution();
AssertEqual(s.IsHappy(5), false);
AssertEqual(s.IsHappy(19), true);
AssertEqual(s.IsHappy(2), false);
Console.WriteLine("All test cases pass!");

static void AssertEqual(object a, object b)
{
    if (!a.Equals(b)) throw new Exception($"Assert failed. Expected {a} but found {b}.");
}

/*

Problem:
202. Happy Number
Description:
Write an algorithm to determine if a number n is happy.

A happy number is a number defined by the following process:

    Starting with any positive integer, replace the number by the sum of the squares of its digits.
    Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
    Those numbers for which this process ends in 1 are happy.

Return true if n is a happy number, and false if not.

Example 1:

Input: n = 19
Output: true
Explanation:
12 + 92 = 82
82 + 22 = 68
62 + 82 = 100
12 + 02 + 02 = 1

Example 2:

Input: n = 2
Output: false

 

Constraints:

    1 <= n <= 231 - 1


Approach 1:
    Maintain a hashset of all the sums. If a sum has been
    seen before, we know we have a cycle and number is not happy.
    If sum ever reaches 1, the number is happy.
    Time: O(logn * iterations)
*/
public class Solution
{
    public bool IsHappy(int n)
    {
        var seenSums = new HashSet<int>();
        int sum = n;

        while (sum > 1)
        {
            sum = SumSquaredDigits(sum);

            if (seenSums.Contains(sum))
            {
                // cycle detected
                return false;
            }

            seenSums.Add(sum);
        }

        return true;
    }

    private int SumSquaredDigits(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            int digit = n % 10;
            sum += (digit * digit);
            n = n / 10;
        }
        return sum;
    }
}